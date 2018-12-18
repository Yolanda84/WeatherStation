namespace WeatherStation
{
    partial class WeatherForecastlbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherForecastlbl));
            this.loYourCityName = new System.Windows.Forms.Label();
            this.loWeatherInCity = new System.Windows.Forms.Label();
            this.ctrlWeathedData = new System.Windows.Forms.PictureBox();
            this.ctrlTemperature = new System.Windows.Forms.RichTextBox();
            this.WindLbl = new System.Windows.Forms.Label();
            this.CloudinessLbl = new System.Windows.Forms.Label();
            this.PressureLbl = new System.Windows.Forms.Label();
            this.HumidityLbl = new System.Windows.Forms.Label();
            this.SunriseLbl = new System.Windows.Forms.Label();
            this.SunsetLbl = new System.Windows.Forms.Label();
            this.GeoCoordsLbl = new System.Windows.Forms.Label();
            this.ctrlWind = new System.Windows.Forms.TextBox();
            this.ctrlCloudiness = new System.Windows.Forms.TextBox();
            this.ctrlPressure = new System.Windows.Forms.TextBox();
            this.ctrlHumidity = new System.Windows.Forms.TextBox();
            this.ctrlSunrise = new System.Windows.Forms.TextBox();
            this.ctrlSunset = new System.Windows.Forms.TextBox();
            this.ctrlGeoCoords = new System.Windows.Forms.TextBox();
            this.dateTimePickerTemp = new System.Windows.Forms.DateTimePicker();
            this.dateLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDaily = new System.Windows.Forms.TabPage();
            this.loAvgDay5 = new System.Windows.Forms.Label();
            this.loDay5 = new System.Windows.Forms.Label();
            this.loAvgDay4 = new System.Windows.Forms.Label();
            this.loDay4 = new System.Windows.Forms.Label();
            this.loAvgDay3 = new System.Windows.Forms.Label();
            this.loDay3 = new System.Windows.Forms.Label();
            this.loAvgDay2 = new System.Windows.Forms.Label();
            this.loDay2 = new System.Windows.Forms.Label();
            this.loAvgDay1 = new System.Windows.Forms.Label();
            this.loDay1 = new System.Windows.Forms.Label();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.ctrlForecast5 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast6 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast7 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast8 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast4 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast3 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast2 = new System.Windows.Forms.RichTextBox();
            this.ctrlForecast1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ctrlYourCityName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlWeathedData)).BeginInit();
            this.tabDaily.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loYourCityName
            // 
            this.loYourCityName.AutoSize = true;
            this.loYourCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loYourCityName.Location = new System.Drawing.Point(21, 12);
            this.loYourCityName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.loYourCityName.Name = "loYourCityName";
            this.loYourCityName.Size = new System.Drawing.Size(116, 17);
            this.loYourCityName.TabIndex = 1;
            this.loYourCityName.Text = "Your city name";
            // 
            // loWeatherInCity
            // 
            this.loWeatherInCity.AutoSize = true;
            this.loWeatherInCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loWeatherInCity.Location = new System.Drawing.Point(21, 104);
            this.loWeatherInCity.Name = "loWeatherInCity";
            this.loWeatherInCity.Size = new System.Drawing.Size(158, 18);
            this.loWeatherInCity.TabIndex = 2;
            this.loWeatherInCity.Text = "Weather in your city";
            // 
            // ctrlWeathedData
            // 
            this.ctrlWeathedData.BackColor = System.Drawing.Color.Silver;
            this.ctrlWeathedData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctrlWeathedData.Image = ((System.Drawing.Image)(resources.GetObject("ctrlWeathedData.Image")));
            this.ctrlWeathedData.InitialImage = ((System.Drawing.Image)(resources.GetObject("ctrlWeathedData.InitialImage")));
            this.ctrlWeathedData.Location = new System.Drawing.Point(24, 125);
            this.ctrlWeathedData.Name = "ctrlWeathedData";
            this.ctrlWeathedData.Size = new System.Drawing.Size(110, 71);
            this.ctrlWeathedData.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ctrlWeathedData.TabIndex = 4;
            this.ctrlWeathedData.TabStop = false;
            // 
            // ctrlTemperature
            // 
            this.ctrlTemperature.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ctrlTemperature.Font = new System.Drawing.Font("Comic Sans MS", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctrlTemperature.Location = new System.Drawing.Point(140, 125);
            this.ctrlTemperature.Name = "ctrlTemperature";
            this.ctrlTemperature.Size = new System.Drawing.Size(76, 70);
            this.ctrlTemperature.TabIndex = 6;
            this.ctrlTemperature.Text = "23 C";
            // 
            // WindLbl
            // 
            this.WindLbl.AutoSize = true;
            this.WindLbl.Location = new System.Drawing.Point(18, 261);
            this.WindLbl.Name = "WindLbl";
            this.WindLbl.Size = new System.Drawing.Size(39, 15);
            this.WindLbl.TabIndex = 7;
            this.WindLbl.Text = "Wind";
            // 
            // CloudinessLbl
            // 
            this.CloudinessLbl.AutoSize = true;
            this.CloudinessLbl.Location = new System.Drawing.Point(18, 290);
            this.CloudinessLbl.Name = "CloudinessLbl";
            this.CloudinessLbl.Size = new System.Drawing.Size(78, 15);
            this.CloudinessLbl.TabIndex = 8;
            this.CloudinessLbl.Text = "Cloudiness";
            // 
            // PressureLbl
            // 
            this.PressureLbl.AutoSize = true;
            this.PressureLbl.Location = new System.Drawing.Point(18, 319);
            this.PressureLbl.Name = "PressureLbl";
            this.PressureLbl.Size = new System.Drawing.Size(64, 15);
            this.PressureLbl.TabIndex = 9;
            this.PressureLbl.Text = "Pressure";
            // 
            // HumidityLbl
            // 
            this.HumidityLbl.AutoSize = true;
            this.HumidityLbl.Location = new System.Drawing.Point(18, 348);
            this.HumidityLbl.Name = "HumidityLbl";
            this.HumidityLbl.Size = new System.Drawing.Size(63, 15);
            this.HumidityLbl.TabIndex = 10;
            this.HumidityLbl.Text = "Humidity";
            // 
            // SunriseLbl
            // 
            this.SunriseLbl.AutoSize = true;
            this.SunriseLbl.Location = new System.Drawing.Point(18, 377);
            this.SunriseLbl.Name = "SunriseLbl";
            this.SunriseLbl.Size = new System.Drawing.Size(56, 15);
            this.SunriseLbl.TabIndex = 11;
            this.SunriseLbl.Text = "Sunrise";
            // 
            // SunsetLbl
            // 
            this.SunsetLbl.AutoSize = true;
            this.SunsetLbl.Location = new System.Drawing.Point(18, 406);
            this.SunsetLbl.Name = "SunsetLbl";
            this.SunsetLbl.Size = new System.Drawing.Size(51, 15);
            this.SunsetLbl.TabIndex = 12;
            this.SunsetLbl.Text = "Sunset";
            // 
            // GeoCoordsLbl
            // 
            this.GeoCoordsLbl.AutoSize = true;
            this.GeoCoordsLbl.Location = new System.Drawing.Point(18, 435);
            this.GeoCoordsLbl.Name = "GeoCoordsLbl";
            this.GeoCoordsLbl.Size = new System.Drawing.Size(82, 15);
            this.GeoCoordsLbl.TabIndex = 13;
            this.GeoCoordsLbl.Text = "Geo Coords";
            // 
            // ctrlWind
            // 
            this.ctrlWind.Location = new System.Drawing.Point(106, 261);
            this.ctrlWind.Name = "ctrlWind";
            this.ctrlWind.Size = new System.Drawing.Size(256, 21);
            this.ctrlWind.TabIndex = 14;
            this.ctrlWind.Text = "Light breeze, 2.1 m/s, East ( 80 )";
            // 
            // ctrlCloudiness
            // 
            this.ctrlCloudiness.Location = new System.Drawing.Point(107, 292);
            this.ctrlCloudiness.Name = "ctrlCloudiness";
            this.ctrlCloudiness.Size = new System.Drawing.Size(255, 21);
            this.ctrlCloudiness.TabIndex = 15;
            this.ctrlCloudiness.Text = "Broken clouds";
            // 
            // ctrlPressure
            // 
            this.ctrlPressure.Location = new System.Drawing.Point(106, 319);
            this.ctrlPressure.Name = "ctrlPressure";
            this.ctrlPressure.Size = new System.Drawing.Size(256, 21);
            this.ctrlPressure.TabIndex = 16;
            this.ctrlPressure.Text = "1015 hpa";
            // 
            // ctrlHumidity
            // 
            this.ctrlHumidity.Location = new System.Drawing.Point(107, 352);
            this.ctrlHumidity.Name = "ctrlHumidity";
            this.ctrlHumidity.Size = new System.Drawing.Size(255, 21);
            this.ctrlHumidity.TabIndex = 17;
            this.ctrlHumidity.Text = "46 %";
            // 
            // ctrlSunrise
            // 
            this.ctrlSunrise.Location = new System.Drawing.Point(107, 379);
            this.ctrlSunrise.Name = "ctrlSunrise";
            this.ctrlSunrise.Size = new System.Drawing.Size(255, 21);
            this.ctrlSunrise.TabIndex = 18;
            this.ctrlSunrise.Text = "06:50";
            // 
            // ctrlSunset
            // 
            this.ctrlSunset.Location = new System.Drawing.Point(107, 406);
            this.ctrlSunset.Name = "ctrlSunset";
            this.ctrlSunset.Size = new System.Drawing.Size(255, 21);
            this.ctrlSunset.TabIndex = 19;
            this.ctrlSunset.Text = "23:19";
            // 
            // ctrlGeoCoords
            // 
            this.ctrlGeoCoords.Location = new System.Drawing.Point(106, 432);
            this.ctrlGeoCoords.Name = "ctrlGeoCoords";
            this.ctrlGeoCoords.Size = new System.Drawing.Size(256, 21);
            this.ctrlGeoCoords.TabIndex = 20;
            this.ctrlGeoCoords.Text = "51.51, -0.13";
            // 
            // dateTimePickerTemp
            // 
            this.dateTimePickerTemp.Location = new System.Drawing.Point(107, 234);
            this.dateTimePickerTemp.Name = "dateTimePickerTemp";
            this.dateTimePickerTemp.Size = new System.Drawing.Size(255, 21);
            this.dateTimePickerTemp.TabIndex = 21;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Location = new System.Drawing.Point(18, 232);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.Size = new System.Drawing.Size(37, 15);
            this.dateLbl.TabIndex = 22;
            this.dateLbl.Text = "Date";
            // 
            // label1
            // 
            this.label1.AccessibleName = "loWeatherForecast";
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Current weather and forecasts in your city";
            // 
            // tabDaily
            // 
            this.tabDaily.Controls.Add(this.loAvgDay5);
            this.tabDaily.Controls.Add(this.loDay5);
            this.tabDaily.Controls.Add(this.loAvgDay4);
            this.tabDaily.Controls.Add(this.loDay4);
            this.tabDaily.Controls.Add(this.loAvgDay3);
            this.tabDaily.Controls.Add(this.loDay3);
            this.tabDaily.Controls.Add(this.loAvgDay2);
            this.tabDaily.Controls.Add(this.loDay2);
            this.tabDaily.Controls.Add(this.loAvgDay1);
            this.tabDaily.Controls.Add(this.loDay1);
            this.tabDaily.Location = new System.Drawing.Point(4, 24);
            this.tabDaily.Name = "tabDaily";
            this.tabDaily.Padding = new System.Windows.Forms.Padding(3);
            this.tabDaily.Size = new System.Drawing.Size(641, 271);
            this.tabDaily.TabIndex = 1;
            this.tabDaily.Text = "Daily";
            this.tabDaily.UseVisualStyleBackColor = true;
            // 
            // loAvgDay5
            // 
            this.loAvgDay5.AutoSize = true;
            this.loAvgDay5.Location = new System.Drawing.Point(453, 83);
            this.loAvgDay5.Name = "loAvgDay5";
            this.loAvgDay5.Size = new System.Drawing.Size(81, 15);
            this.loAvgDay5.TabIndex = 9;
            this.loAvgDay5.Text = "Avg Temp 5";
            // 
            // loDay5
            // 
            this.loDay5.AutoSize = true;
            this.loDay5.Location = new System.Drawing.Point(453, 54);
            this.loDay5.Name = "loDay5";
            this.loDay5.Size = new System.Drawing.Size(43, 15);
            this.loDay5.TabIndex = 8;
            this.loDay5.Text = "Day 5";
            // 
            // loAvgDay4
            // 
            this.loAvgDay4.AutoSize = true;
            this.loAvgDay4.Location = new System.Drawing.Point(348, 83);
            this.loAvgDay4.Name = "loAvgDay4";
            this.loAvgDay4.Size = new System.Drawing.Size(81, 15);
            this.loAvgDay4.TabIndex = 7;
            this.loAvgDay4.Text = "Avg Temp 4";
            // 
            // loDay4
            // 
            this.loDay4.AutoSize = true;
            this.loDay4.Location = new System.Drawing.Point(348, 54);
            this.loDay4.Name = "loDay4";
            this.loDay4.Size = new System.Drawing.Size(43, 15);
            this.loDay4.TabIndex = 6;
            this.loDay4.Text = "Day 4";
            // 
            // loAvgDay3
            // 
            this.loAvgDay3.AutoSize = true;
            this.loAvgDay3.Location = new System.Drawing.Point(249, 83);
            this.loAvgDay3.Name = "loAvgDay3";
            this.loAvgDay3.Size = new System.Drawing.Size(81, 15);
            this.loAvgDay3.TabIndex = 5;
            this.loAvgDay3.Text = "Avg Temp 3";
            // 
            // loDay3
            // 
            this.loDay3.AutoSize = true;
            this.loDay3.Location = new System.Drawing.Point(249, 54);
            this.loDay3.Name = "loDay3";
            this.loDay3.Size = new System.Drawing.Size(43, 15);
            this.loDay3.TabIndex = 4;
            this.loDay3.Text = "Day 3";
            // 
            // loAvgDay2
            // 
            this.loAvgDay2.AutoSize = true;
            this.loAvgDay2.Location = new System.Drawing.Point(145, 83);
            this.loAvgDay2.Name = "loAvgDay2";
            this.loAvgDay2.Size = new System.Drawing.Size(85, 15);
            this.loAvgDay2.TabIndex = 3;
            this.loAvgDay2.Text = " Avg Temp 2";
            // 
            // loDay2
            // 
            this.loDay2.AutoSize = true;
            this.loDay2.Location = new System.Drawing.Point(145, 54);
            this.loDay2.Name = "loDay2";
            this.loDay2.Size = new System.Drawing.Size(43, 15);
            this.loDay2.TabIndex = 2;
            this.loDay2.Text = "Day 2";
            // 
            // loAvgDay1
            // 
            this.loAvgDay1.AutoSize = true;
            this.loAvgDay1.Location = new System.Drawing.Point(46, 83);
            this.loAvgDay1.Name = "loAvgDay1";
            this.loAvgDay1.Size = new System.Drawing.Size(81, 15);
            this.loAvgDay1.TabIndex = 1;
            this.loAvgDay1.Text = "Avg Temp 1";
            // 
            // loDay1
            // 
            this.loDay1.AutoSize = true;
            this.loDay1.Location = new System.Drawing.Point(46, 54);
            this.loDay1.Name = "loDay1";
            this.loDay1.Size = new System.Drawing.Size(43, 15);
            this.loDay1.TabIndex = 0;
            this.loDay1.Text = "Day 1";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.ctrlForecast5);
            this.tabMain.Controls.Add(this.ctrlForecast6);
            this.tabMain.Controls.Add(this.ctrlForecast7);
            this.tabMain.Controls.Add(this.ctrlForecast8);
            this.tabMain.Controls.Add(this.ctrlForecast4);
            this.tabMain.Controls.Add(this.ctrlForecast3);
            this.tabMain.Controls.Add(this.ctrlForecast2);
            this.tabMain.Controls.Add(this.ctrlForecast1);
            this.tabMain.Location = new System.Drawing.Point(4, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(442, 271);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // ctrlForecast5
            // 
            this.ctrlForecast5.Location = new System.Drawing.Point(3, 147);
            this.ctrlForecast5.Name = "ctrlForecast5";
            this.ctrlForecast5.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast5.TabIndex = 7;
            this.ctrlForecast5.Text = "";
            // 
            // ctrlForecast6
            // 
            this.ctrlForecast6.Location = new System.Drawing.Point(109, 147);
            this.ctrlForecast6.Name = "ctrlForecast6";
            this.ctrlForecast6.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast6.TabIndex = 6;
            this.ctrlForecast6.Text = "";
            // 
            // ctrlForecast7
            // 
            this.ctrlForecast7.Location = new System.Drawing.Point(215, 147);
            this.ctrlForecast7.Name = "ctrlForecast7";
            this.ctrlForecast7.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast7.TabIndex = 5;
            this.ctrlForecast7.Text = "";
            // 
            // ctrlForecast8
            // 
            this.ctrlForecast8.Location = new System.Drawing.Point(321, 147);
            this.ctrlForecast8.Name = "ctrlForecast8";
            this.ctrlForecast8.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast8.TabIndex = 4;
            this.ctrlForecast8.Text = "";
            // 
            // ctrlForecast4
            // 
            this.ctrlForecast4.Location = new System.Drawing.Point(321, 39);
            this.ctrlForecast4.Name = "ctrlForecast4";
            this.ctrlForecast4.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast4.TabIndex = 3;
            this.ctrlForecast4.Text = "";
            // 
            // ctrlForecast3
            // 
            this.ctrlForecast3.Location = new System.Drawing.Point(215, 39);
            this.ctrlForecast3.Name = "ctrlForecast3";
            this.ctrlForecast3.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast3.TabIndex = 2;
            this.ctrlForecast3.Text = "";
            // 
            // ctrlForecast2
            // 
            this.ctrlForecast2.Location = new System.Drawing.Point(109, 39);
            this.ctrlForecast2.Name = "ctrlForecast2";
            this.ctrlForecast2.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast2.TabIndex = 1;
            this.ctrlForecast2.Text = "";
            // 
            // ctrlForecast1
            // 
            this.ctrlForecast1.Location = new System.Drawing.Point(3, 39);
            this.ctrlForecast1.Name = "ctrlForecast1";
            this.ctrlForecast1.Size = new System.Drawing.Size(100, 96);
            this.ctrlForecast1.TabIndex = 0;
            this.ctrlForecast1.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMain);
            this.tabControl1.Controls.Add(this.tabDaily);
            this.tabControl1.Location = new System.Drawing.Point(378, 150);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 299);
            this.tabControl1.TabIndex = 25;
            // 
            // ctrlYourCityName
            // 
            this.ctrlYourCityName.FormattingEnabled = true;
            this.ctrlYourCityName.Items.AddRange(new object[] {
            "f",
            "g",
            "fg",
            "xd",
            "g",
            "dg",
            "d",
            "g",
            "dfgd"});
            this.ctrlYourCityName.Location = new System.Drawing.Point(21, 34);
            this.ctrlYourCityName.Name = "ctrlYourCityName";
            this.ctrlYourCityName.Size = new System.Drawing.Size(251, 23);
            this.ctrlYourCityName.TabIndex = 28;
            this.ctrlYourCityName.SelectedIndexChanged += new System.EventHandler(this.ctrlSearch_Click);
            // 
            // WeatherForecastlbl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(837, 459);
            this.Controls.Add(this.ctrlYourCityName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.dateTimePickerTemp);
            this.Controls.Add(this.ctrlGeoCoords);
            this.Controls.Add(this.ctrlSunset);
            this.Controls.Add(this.ctrlSunrise);
            this.Controls.Add(this.ctrlHumidity);
            this.Controls.Add(this.ctrlPressure);
            this.Controls.Add(this.ctrlCloudiness);
            this.Controls.Add(this.ctrlWind);
            this.Controls.Add(this.GeoCoordsLbl);
            this.Controls.Add(this.SunsetLbl);
            this.Controls.Add(this.SunriseLbl);
            this.Controls.Add(this.HumidityLbl);
            this.Controls.Add(this.PressureLbl);
            this.Controls.Add(this.CloudinessLbl);
            this.Controls.Add(this.WindLbl);
            this.Controls.Add(this.ctrlTemperature);
            this.Controls.Add(this.ctrlWeathedData);
            this.Controls.Add(this.loWeatherInCity);
            this.Controls.Add(this.loYourCityName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "WeatherForecastlbl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Forecast for you";
            ((System.ComponentModel.ISupportInitialize)(this.ctrlWeathedData)).EndInit();
            this.tabDaily.ResumeLayout(false);
            this.tabDaily.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label loYourCityName;
        private System.Windows.Forms.Label loWeatherInCity;
        private System.Windows.Forms.PictureBox ctrlWeathedData;
        private System.Windows.Forms.RichTextBox ctrlTemperature;
        private System.Windows.Forms.Label WindLbl;
        private System.Windows.Forms.Label CloudinessLbl;
        private System.Windows.Forms.Label PressureLbl;
        private System.Windows.Forms.Label HumidityLbl;
        private System.Windows.Forms.Label SunriseLbl;
        private System.Windows.Forms.Label SunsetLbl;
        private System.Windows.Forms.Label GeoCoordsLbl;
        private System.Windows.Forms.TextBox ctrlWind;
        private System.Windows.Forms.TextBox ctrlCloudiness;
        private System.Windows.Forms.TextBox ctrlPressure;
        private System.Windows.Forms.TextBox ctrlHumidity;
        private System.Windows.Forms.TextBox ctrlSunrise;
        private System.Windows.Forms.TextBox ctrlSunset;
        private System.Windows.Forms.TextBox ctrlGeoCoords;
        private System.Windows.Forms.DateTimePicker dateTimePickerTemp;
        private System.Windows.Forms.Label dateLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabDaily;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.RichTextBox ctrlForecast5;
        private System.Windows.Forms.RichTextBox ctrlForecast6;
        private System.Windows.Forms.RichTextBox ctrlForecast7;
        private System.Windows.Forms.RichTextBox ctrlForecast8;
        private System.Windows.Forms.RichTextBox ctrlForecast4;
        private System.Windows.Forms.RichTextBox ctrlForecast3;
        private System.Windows.Forms.RichTextBox ctrlForecast2;
        private System.Windows.Forms.RichTextBox ctrlForecast1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label loAvgDay5;
        private System.Windows.Forms.Label loDay5;
        private System.Windows.Forms.Label loAvgDay4;
        private System.Windows.Forms.Label loDay4;
        private System.Windows.Forms.Label loAvgDay3;
        private System.Windows.Forms.Label loDay3;
        private System.Windows.Forms.Label loAvgDay2;
        private System.Windows.Forms.Label loDay2;
        private System.Windows.Forms.Label loAvgDay1;
        private System.Windows.Forms.Label loDay1;
        private System.Windows.Forms.ComboBox ctrlYourCityName;
    }
}

