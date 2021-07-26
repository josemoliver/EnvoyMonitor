# EnvoyMonitor
Simple Windows power monitor tool for reading data from a home's Enphase Envoy.

- Monitor in near real-time your home's PV system power readings such as Power Produced, Consumed, and Net Consumed.
- Save readings to SQLdb and Export them to an CSV file which can be opened in apps such as Excel.
- Make comments as readings are made to make power consumption analysis later. Example ("Living room AC turned off", "Hair dryer turned on"...)

![Alt text](/EnvoyMonitor_screenshot1.png?raw=true "EnvoyMonitor Screenshot")

Prior to building solution or running the app make sure you complete the following steps.
1. Create the SQLite Database by executing the included EnvoyMonitor.sqlite.sql script. Recommend using a SQLite UI client such as SQLite Browser https://sqlitebrowser.org/
2. Set EnvoyProductionURL key in the app config file to your local Envoy Gate path, usually http://envoy.local/production.json

Notes:
- Envoy Communications Gateway is a registered trademark of Enphase (https://enphase.com/).
- This a "quick and dirty" utility I created for monitoring my home's power consumption.
- THE ENVOYMONITOR CODE IS PROVIDED “AS IS” AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL CODE CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, DAMAGE TO PV EQUIPMENT; PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) SUSTAINED BY YOU OR A THIRD PARTY, HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT ARISING IN ANY WAY OUT OF THE USE OF THE ENVOYMONITOR CODE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
