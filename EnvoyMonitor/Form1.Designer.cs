namespace EnvoyMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPeakConsumed = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPeakProduced = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConsumed = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNetConsumed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProduced = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bExportLogToFile = new System.Windows.Forms.Button();
            this.bSaveComment = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLogComment = new System.Windows.Forms.TextBox();
            this.bLogAction = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtPeakConsumed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtPeakProduced);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtConsumed);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNetConsumed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProduced);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(633, 338);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Power Monitor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(338, 225);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sampling Interval";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 second",
            "5 seconds",
            "30 seconds",
            "1 minute",
            "5 minutes",
            "10 minutes"});
            this.comboBox1.Location = new System.Drawing.Point(342, 249);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(148, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtPeakConsumed
            // 
            this.txtPeakConsumed.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakConsumed.Location = new System.Drawing.Point(340, 143);
            this.txtPeakConsumed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeakConsumed.Name = "txtPeakConsumed";
            this.txtPeakConsumed.ReadOnly = true;
            this.txtPeakConsumed.Size = new System.Drawing.Size(148, 44);
            this.txtPeakConsumed.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Peak Consumed (W)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(338, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Peak Produced (W)";
            // 
            // txtPeakProduced
            // 
            this.txtPeakProduced.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeakProduced.Location = new System.Drawing.Point(342, 57);
            this.txtPeakProduced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPeakProduced.Name = "txtPeakProduced";
            this.txtPeakProduced.ReadOnly = true;
            this.txtPeakProduced.Size = new System.Drawing.Size(148, 44);
            this.txtPeakProduced.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Net Consumed (W)";
            // 
            // txtConsumed
            // 
            this.txtConsumed.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsumed.Location = new System.Drawing.Point(120, 143);
            this.txtConsumed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtConsumed.Name = "txtConsumed";
            this.txtConsumed.ReadOnly = true;
            this.txtConsumed.Size = new System.Drawing.Size(148, 44);
            this.txtConsumed.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Consumed (W)";
            // 
            // txtNetConsumed
            // 
            this.txtNetConsumed.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetConsumed.Location = new System.Drawing.Point(120, 235);
            this.txtNetConsumed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNetConsumed.Name = "txtNetConsumed";
            this.txtNetConsumed.ReadOnly = true;
            this.txtNetConsumed.Size = new System.Drawing.Size(148, 44);
            this.txtNetConsumed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Produced (W)";
            // 
            // txtProduced
            // 
            this.txtProduced.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProduced.Location = new System.Drawing.Point(120, 57);
            this.txtProduced.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProduced.Name = "txtProduced";
            this.txtProduced.ReadOnly = true;
            this.txtProduced.Size = new System.Drawing.Size(148, 44);
            this.txtProduced.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bExportLogToFile);
            this.groupBox2.Controls.Add(this.bSaveComment);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtLogComment);
            this.groupBox2.Controls.Add(this.bLogAction);
            this.groupBox2.Location = new System.Drawing.Point(18, 366);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(633, 338);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Logging";
            // 
            // bExportLogToFile
            // 
            this.bExportLogToFile.Location = new System.Drawing.Point(180, 223);
            this.bExportLogToFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bExportLogToFile.Name = "bExportLogToFile";
            this.bExportLogToFile.Size = new System.Drawing.Size(244, 35);
            this.bExportLogToFile.TabIndex = 10;
            this.bExportLogToFile.Text = "Export Log to File";
            this.bExportLogToFile.UseVisualStyleBackColor = true;
            this.bExportLogToFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // bSaveComment
            // 
            this.bSaveComment.Location = new System.Drawing.Point(512, 135);
            this.bSaveComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSaveComment.Name = "bSaveComment";
            this.bSaveComment.Size = new System.Drawing.Size(112, 35);
            this.bSaveComment.TabIndex = 13;
            this.bSaveComment.Text = "Insert";
            this.bSaveComment.UseVisualStyleBackColor = true;
            this.bSaveComment.Click += new System.EventHandler(this.bSaveComment_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 114);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Log Comment";
            // 
            // txtLogComment
            // 
            this.txtLogComment.Location = new System.Drawing.Point(22, 138);
            this.txtLogComment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLogComment.Name = "txtLogComment";
            this.txtLogComment.Size = new System.Drawing.Size(486, 26);
            this.txtLogComment.TabIndex = 11;
            // 
            // bLogAction
            // 
            this.bLogAction.Location = new System.Drawing.Point(180, 52);
            this.bLogAction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bLogAction.Name = "bLogAction";
            this.bLogAction.Size = new System.Drawing.Size(244, 35);
            this.bLogAction.TabIndex = 2;
            this.bLogAction.Text = "Start Logging";
            this.bLogAction.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bLogAction.UseVisualStyleBackColor = true;
            this.bLogAction.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 740);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Envoy Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProduced;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtConsumed;
        private System.Windows.Forms.Button bLogAction;
        private System.Windows.Forms.TextBox txtNetConsumed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPeakConsumed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPeakProduced;
        private System.Windows.Forms.Button bSaveComment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLogComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bExportLogToFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

