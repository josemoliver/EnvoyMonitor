using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using System.Data.SQLite;

namespace EnvoyMonitor
{
    public partial class Form1 : Form
    {
        SQLiteConnection m_dbConnection;

        List<EnvoyReading> PowerReadings = new List<EnvoyReading>();

        //"Get EnvoyProductionURL, usually http://envoy.local/production.json
        string EnvoyProductionURL = System.Configuration.ConfigurationManager.AppSettings["EnvoyProductionURL"].ToString().Trim();

        double PowerProduced;
        double PowerConsumed;
        double PowerNet;
        double PowerConsumedLifetime;
        double PowerProducedLifetime;
        double PeakPowerProduced    =   0;
        double PeakPowerConsumed    =   0;
        int SamplingInterval        = 1000; //default sampling interval 1000ms (1 second)

        string Comment = null;

        bool LoggingMode = false;
        int ActiveLogID=-1;

        int ReadingTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {         
            timer1.Interval = (SamplingInterval);
            comboBox1.SelectedIndex = 0;
            timer1.Tick += new EventHandler(UpdateTelemetry);
            timer1.Start();
        }

        public void UpdateTelemetry(object sender, EventArgs e)
        {
       
            EnvoyReading Reading;

            var webrequest = (HttpWebRequest)System.Net.WebRequest.Create(EnvoyProductionURL);
            string responsetext = "";

                    using (var response = webrequest.GetResponse())
                    using (var reader = new StreamReader(response.GetResponseStream()))
                    {
                        var result = reader.ReadToEnd();
                        responsetext = Convert.ToString(result);
                    }
                           
            Reading = JsonConvert.DeserializeObject<EnvoyReading>(responsetext);

            ReadingTime = Reading.consumption[0].readingTime;
            PowerProduced = Reading.production[1].wNow;
            PowerConsumed = Reading.consumption[0].wNow;
            PowerNet = Reading.consumption[1].wNow;
            PowerProducedLifetime = Reading.production[1].whLifetime;
            PowerConsumedLifetime = Reading.consumption[0].whLifetime;

            txtPeakProduced.ForeColor = System.Drawing.Color.FromName("WindowText");
            txtPeakConsumed.ForeColor = System.Drawing.Color.FromName("WindowText");

            if (PowerProduced>PeakPowerProduced)
            {
                PeakPowerProduced = PowerProduced;
                txtPeakProduced.Text = PeakPowerProduced.ToString();
                txtPeakProduced.ForeColor = System.Drawing.Color.FromName("Blue");
            }

            if (PowerConsumed > PeakPowerConsumed)
            {
                PeakPowerConsumed = PowerConsumed;
                txtPeakConsumed.Text = PeakPowerConsumed.ToString();
                txtPeakConsumed.ForeColor = System.Drawing.Color.FromName("Blue");
            }

            txtProduced.Text = PowerProduced.ToString();
            txtConsumed.Text = PowerConsumed.ToString();
            txtNetConsumed.Text = PowerNet.ToString();

            //If logging is enabled, save reading to SQLite db
            if (LoggingMode == true)
            {
                m_dbConnection = new SQLiteConnection("Data Source=EnvoyMonitor.sqlite;Version=3;");
                m_dbConnection.Open();

                try
                {
                    string sqlInsertReading = "insert into Readings values (" + ReadingTime + "," + PowerProduced + "," + PowerConsumed + "," + PowerNet + "," + PowerProducedLifetime + "," + PowerConsumedLifetime + ",'"+Comment+"')";
                    SQLiteCommand commandInsertReading = new SQLiteCommand(sqlInsertReading, m_dbConnection);
                    commandInsertReading.ExecuteNonQuery();

                    if (Comment!=null)
                    {
                        txtLogComment.Text = "";
                        txtLogComment.Enabled = true;
                        bSaveComment.Enabled = true;
                    }

                    Comment = null;

                }
                catch
                {

                }
            }
        }

        public static string UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();

            return dtDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public class Production
        {
            public string type { get; set; }
            public int activeCount { get; set; }
            public int readingTime { get; set; }
            public double wNow { get; set; }
            public double whLifetime { get; set; }
            public string measurementType { get; set; }
            public double? varhLeadLifetime { get; set; }
            public double? varhLagLifetime { get; set; }
            public double? vahLifetime { get; set; }
            public double? rmsCurrent { get; set; }
            public double? rmsVoltage { get; set; }
            public double? reactPwr { get; set; }
            public double? apprntPwr { get; set; }
            public double? pwrFactor { get; set; }
            public double? whToday { get; set; }
            public double? whLastSevenDays { get; set; }
            public double? vahToday { get; set; }
            public double? varhLeadToday { get; set; }
            public double? varhLagToday { get; set; }
        }

        public class Consumption
        {
            public string type { get; set; }
            public int activeCount { get; set; }
            public string measurementType { get; set; }
            public int readingTime { get; set; }
            public double wNow { get; set; }
            public double whLifetime { get; set; }
            public double varhLeadLifetime { get; set; }
            public double varhLagLifetime { get; set; }
            public double vahLifetime { get; set; }
            public double rmsCurrent { get; set; }
            public double rmsVoltage { get; set; }
            public double reactPwr { get; set; }
            public double apprntPwr { get; set; }
            public double pwrFactor { get; set; }
            public double whToday { get; set; }
            public double whLastSevenDays { get; set; }
            public double vahToday { get; set; }
            public double varhLeadToday { get; set; }
            public double varhLagToday { get; set; }
        }

        public class Storage
        {
            public string type { get; set; }
            public int activeCount { get; set; }
            public int readingTime { get; set; }
            public int wNow { get; set; }
            public int whNow { get; set; }
            public string state { get; set; }
        }

        public class EnvoyReading
        {
            public List<Production> production { get; set; }
            public List<Consumption> consumption { get; set; }
            public List<Storage> storage { get; set; }
        }

        // Loggin toggle
        private void button1_Click(object sender, EventArgs e)
        {
            m_dbConnection = new SQLiteConnection("Data Source=EnvoyMonitor.sqlite;Version=3;");
            m_dbConnection.Open();

            if (LoggingMode==false)
            {
                string sqlInsertLogging = "insert into Logs (StartTime) values (" + ReadingTime + ")";
                SQLiteCommand commandInsertLogging = new SQLiteCommand(sqlInsertLogging, m_dbConnection);
                commandInsertLogging.ExecuteNonQuery();

                string sqlGetLastInsertID = @"select MAX(LogID) FROM Logs";
                SQLiteCommand commandGetLatestLogID = new SQLiteCommand(sqlGetLastInsertID, m_dbConnection);
                ActiveLogID = int.Parse(commandGetLatestLogID.ExecuteScalar().ToString());
                LoggingMode = true;
                bExportLogToFile.Enabled = false;
                bLogAction.Text = "Stop Logging";

            }
            else
            {
                bLogAction.Text = "Start Logging";
                LoggingMode = false;
                string sqlEndLogging = "update Logs set EndTime=" + ReadingTime +" where LogID="+ ActiveLogID;
                SQLiteCommand commandEndLogging = new SQLiteCommand(sqlEndLogging, m_dbConnection);
                commandEndLogging.ExecuteNonQuery();
                bExportLogToFile.Enabled = true;
            }
        }

        private void bSaveComment_Click(object sender, EventArgs e)
        {
            Comment = txtLogComment.Text.Trim();
            txtLogComment.Enabled = false;
            bSaveComment.Enabled = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (comboBox1.SelectedIndex==0)
            {
                SamplingInterval=1000;
            }
            if (comboBox1.SelectedIndex==1)
            {
                SamplingInterval = 5000;
            }
            if (comboBox1.SelectedText == "1 minute")
            {
                SamplingInterval = 60000;
            }

            timer1.Interval = (SamplingInterval);

        }

        //Export log to file
        private void button2_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            string filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.Filter = filter;
            saveFileDialog1.FilterIndex = 0;
            saveFileDialog1.RestoreDirectory = true;
           
                //Fetch latest log entry
                string sqlGetLog = @"SELECT * FROM Logs ORDER BY LogID DESC";
                SQLiteCommand commandGetLogRange = new SQLiteCommand(sqlGetLog, m_dbConnection);
                SQLiteDataReader readerLog = commandGetLogRange.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(readerLog);

                int LastLogStartTime = int.Parse(dt.Rows[0]["StartTime"].ToString());
                int LastLogEndTime = int.Parse(dt.Rows[0]["EndTime"].ToString());
                double UnixTime;

                string sqlReadingsLog = @"SELECT * FROM Readings WHERE ReadingTime>=" + LastLogStartTime + " AND ReadingTime<=" + LastLogEndTime;
                SQLiteCommand commandGetReadingsLog = new SQLiteCommand(sqlReadingsLog, m_dbConnection);
                SQLiteDataReader readerReadings = commandGetReadingsLog.ExecuteReader();

                string FileContents = "ReadingDateTime,PowerProduced,PowerConsumed,PowerNetConsumed,PowerProducedLifetime,PowerConsumedLifetime,Comment\n";

                while (readerReadings.Read())
                {
                    UnixTime = double.Parse(readerReadings[0].ToString());
                    FileContents = FileContents + "\"" + UnixTimeStampToDateTime(UnixTime).Trim() + "\"," + readerReadings[1] + "," + readerReadings[2] + "," + readerReadings[3] + "," + readerReadings[4] + "," + readerReadings[5] + ",\"" + readerReadings[6] + "\"\n";
                }

            StreamWriter writer = null;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filter = saveFileDialog1.FileName;
                writer = new StreamWriter(filter);
                writer.Write(FileContents);
                writer.Close();
            }

        }

    }
}
