using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeatherStationApi;
using WeatherStationApi.Model;

namespace WeatherStation {
    public partial class WeatherForecastlbl : Form {
        string degreesString = "";
        string speedString = "";

        public WeatherForecastlbl() {
            InitializeComponent();
            ctrlYourCityName.Text = "8133876";
            City city = new City();
            string cityName = city.Name;

            loWeatherInCity.Text = "Weather In Your City";
        }

        public void ctrlSearch_Click(object sender, EventArgs e) {
            WeatherStationClient weather = new WeatherStationClient();

            string search = ctrlYourCityName.Text;
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("lang", "en");
            dic.Add("units", "metric");
            dic.Add("mode", "json");
            dic.Add("q", search);

            WeatherResponse res = weather.GetWeather(dic);
            ForecastResponse Forecast = weather.GetForecast(dic);

            loWeatherInCity.Text = "Weather in: " + Forecast.City.Name + ", " + Forecast.City.Country;

            SetUIValues(res);
            SetNext24Hours(Forecast);
            DegreesSetup(res);
            WindSpeedSetup(res);
            PictureSetup(res, weather);
            NextFiveDays(Forecast.Analysis);
            //SunriseSetup(res.SysInfo.Sunrise);
            //SunsetSetup(res.SysInfo.Sunset);
            ctrlSunrise.Text = DateSetup(res.SysInfo.Sunrise);
            ctrlSunset.Text = DateSetup(res.SysInfo.Sunset);
        }

        public void NextFiveDays(List<ForecastAnalysis> fore) {
            List<string> forecastDays = new List<string>();

            for (int i = 0; i < fore.Count; i++) {
                ForecastAnalysis element = fore[i];

                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(element.Date).ToLocalTime();

                string forecastDay = Convert.ToString(dtDateTime.DayOfWeek);

                if (forecastDays.Contains(forecastDay) == false) {
                    forecastDays.Add(forecastDay);
                }
            }

            loDay1.Text = forecastDays[0];
            loDay2.Text = forecastDays[1];
            loDay3.Text = forecastDays[2];
            loDay4.Text = forecastDays[3];
            loDay5.Text = forecastDays[4];

            NextFiveAvgTemps(fore, forecastDays);
        }

        public void NextFiveAvgTemps(List<ForecastAnalysis> fore, List<string> forecastDays) {
            List<double> day1Temps = new List<double>();
            List<double> day2Temps = new List<double>();
            List<double> day3Temps = new List<double>();
            List<double> day4Temps = new List<double>();
            List<double> day5Temps = new List<double>();

            for (int i = 0; i < fore.Count; i++) {
                ForecastAnalysis element = fore[i];

                DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
                dtDateTime = dtDateTime.AddSeconds(element.Date).ToLocalTime();

                string forecastDay = Convert.ToString(dtDateTime.DayOfWeek);

                double temperature = element.MainInfo.Temperature;

                if (forecastDay == forecastDays[0]) {
                    day1Temps.Add(temperature);
                }
                else if (forecastDay == forecastDays[1]) {
                    day2Temps.Add(temperature);
                }
                else if (forecastDay == forecastDays[2]) {
                    day3Temps.Add(temperature);
                }
                else if (forecastDay == forecastDays[3]) {
                    day4Temps.Add(temperature);
                }
                else if (forecastDay == forecastDays[4]) {
                    day5Temps.Add(temperature);
                }


            }
            double sum = 0;

            for (int i = 0; i < day1Temps.Count; i++) {
                sum = sum + day1Temps[i];
            }
            double avgTemp1 = sum / day1Temps.Count;
            loAvgDay1.Text = Convert.ToString(avgTemp1);
            sum = 0;


            for (int i = 0; i < day2Temps.Count; i++) {
                sum = sum + day2Temps[i];
            }
            double avgTemp2 = sum / day2Temps.Count;
            loAvgDay2.Text = Convert.ToString(avgTemp2);
            sum = 0;

            for (int i = 0; i < day3Temps.Count; i++) {
                sum = sum + day3Temps[i];
            }
            double avgTemp3 = sum / day3Temps.Count;
            loAvgDay3.Text = Convert.ToString(avgTemp3);
            sum = 0;

            for (int i = 0; i < day4Temps.Count; i++) {
                sum = sum + day4Temps[i];
            }
            double avgTemp4 = sum / day4Temps.Count;
            loAvgDay4.Text = Convert.ToString(avgTemp4);
            sum = 0;

            for (int i = 0; i < day5Temps.Count; i++) {
                sum = sum + day5Temps[i];
            }
            double avgTemp5 = sum / day5Temps.Count;
            loAvgDay5.Text = Convert.ToString(avgTemp5);
            sum = 0;
        }

        public void SetUIValues(WeatherResponse res) {
            ctrlTemperature.Text = Convert.ToString(res.MainInfo.Temperature);
            ctrlWind.Text = Convert.ToString(res.Wind.Degrees) + (", ") + (res.Wind.Speed);
            ctrlCloudiness.Text = Convert.ToString(res.Clouds.All) + "%";
            ctrlPressure.Text = Convert.ToString(res.MainInfo.Pressure) + " hPa";
            ctrlHumidity.Text = Convert.ToString(res.MainInfo.Humidity) + "%";
            ctrlSunrise.Text = Convert.ToString(res.SysInfo.Sunrise);
            ctrlSunset.Text = Convert.ToString(res.SysInfo.Sunset);
            ctrlGeoCoords.Text = Convert.ToString(res.Coordinates.Latitude) + " , " + Convert.ToString(res.Coordinates.Longitude);
        }

        public void DegreesSetup(WeatherResponse res) {
            if ((res.Wind.Degrees >= 0 && res.Wind.Degrees < 22.5) || (res.Wind.Degrees >= 337.5 && res.Wind.Degrees <= 360)) {
                degreesString = "North";
            }
            else if (res.Wind.Degrees >= 22.5 && res.Wind.Degrees < 45) {
                degreesString = "North-Northeast";
            }
            else if (res.Wind.Degrees >= 45 && res.Wind.Degrees < 67.5) {
                degreesString = "Northeast";
            }
            else if (res.Wind.Degrees >= 67.5 && res.Wind.Degrees < 90) {
                degreesString = "East";
            }
            else if (res.Wind.Degrees >= 90 && res.Wind.Degrees < 112.5) {
                degreesString = "East-Southeast";
            }
            else if (res.Wind.Degrees >= 112.5 && res.Wind.Degrees < 135) {
                degreesString = "Southeast";
            }
            else if (res.Wind.Degrees >= 135 && res.Wind.Degrees < 157.5) {
                degreesString = "South-Southeast";
            }
            else if (res.Wind.Degrees >= 157.5 && res.Wind.Degrees < 180) {
                degreesString = "South";
            }
            else if (res.Wind.Degrees >= 180 && res.Wind.Degrees < 202.5) {
                degreesString = "South-Southwest";
            }
            else if (res.Wind.Degrees >= 202.5 && res.Wind.Degrees < 225) {
                degreesString = "Southwest";
            }
            else if (res.Wind.Degrees >= 225 && res.Wind.Degrees < 247.5) {
                degreesString = "West-Southwest";
            }
            else if (res.Wind.Degrees >= 247.5 && res.Wind.Degrees < 270) {
                degreesString = "West";
            }
            else if (res.Wind.Degrees >= 270 && res.Wind.Degrees < 292.5) {
                degreesString = "West-Northwest";
            }
            else if (res.Wind.Degrees >= 292.5 && res.Wind.Degrees < 315) {
                degreesString = "Northwest";
            }
            else if (res.Wind.Degrees >= 315 && res.Wind.Degrees < 337.5) {
                degreesString = "North-Northwest";
            }
            else {
                degreesString = "Unknown wind direction";
            }

            ctrlWind.Text = Convert.ToString(res.Wind.Degrees) + "° " + degreesString + ", " + speedString;
        }

        public void WindSpeedSetup(WeatherResponse res) {

            if (res.Wind.Speed >= 0 && res.Wind.Speed <= 0.2) {
                speedString = "Calm";
            }
            if (res.Wind.Speed >= 0.3 && res.Wind.Speed <= 1.5) {
                speedString = "	Light Air";
            }
            if (res.Wind.Speed >= 1.6 && res.Wind.Speed <= 3.3) {
                speedString = "	Light Breeze";
            }
            if (res.Wind.Speed >= 3.4 && res.Wind.Speed <= 5.4) {
                speedString = "Gentle Breeze";
            }
            if (res.Wind.Speed >= 5.5 && res.Wind.Speed <= 7.9) {
                speedString = "Moderate Breeze";
            }
            if (res.Wind.Speed >= 8.0 && res.Wind.Speed <= 10.7) {
                speedString = "Fresh Breeze";
            }
            if (res.Wind.Speed >= 10.8 && res.Wind.Speed <= 13.8) {
                speedString = "Strong Breeze";
            }
            if (res.Wind.Speed >= 13.9 && res.Wind.Speed <= 17.1) {
                speedString = "Near Gale";
            }
            if (res.Wind.Speed >= 17.2 && res.Wind.Speed <= 20.7) {
                speedString = "Gale";
            }
            if (res.Wind.Speed >= 20.8 && res.Wind.Speed <= 24.4) {
                speedString = "Severe Gale";
            }
            if (res.Wind.Speed >= 24.5 && res.Wind.Speed <= 28.4) {
                speedString = "Strong storm";
            }
            if (res.Wind.Speed >= 28.5 && res.Wind.Speed <= 32.6) {
                speedString = "Violent Storm";
            }
            if (res.Wind.Speed >= 32.7) {
                speedString = "Hurricane";
            }
            ctrlWind.Text = Convert.ToString(res.Wind.Degrees) + "° " + degreesString + ", " + speedString;


        }

        public void SetNext24Hours(ForecastResponse Forecast) {
            ctrlForecast1.Text = ParseAnalysisObject(Forecast.Analysis[0]);
            ctrlForecast2.Text = ParseAnalysisObject(Forecast.Analysis[1]);
            ctrlForecast3.Text = ParseAnalysisObject(Forecast.Analysis[2]);
            ctrlForecast4.Text = ParseAnalysisObject(Forecast.Analysis[3]);
            ctrlForecast5.Text = ParseAnalysisObject(Forecast.Analysis[4]);
            ctrlForecast6.Text = ParseAnalysisObject(Forecast.Analysis[5]);
            ctrlForecast7.Text = ParseAnalysisObject(Forecast.Analysis[6]);
            ctrlForecast8.Text = ParseAnalysisObject(Forecast.Analysis[7]);
        }

        public string ParseAnalysisObject(ForecastAnalysis analysisObj) {
            return analysisObj.DateText.Substring(11, 5) +
                "\n" + Convert.ToString(analysisObj.MainInfo.Temperature) + " C" +
                 "\n" + Convert.ToString(analysisObj.Wind.Speed) + " m/s" +
                 "\n" + Convert.ToString(analysisObj.MainInfo.Pressure) + " hPa";
        }

        public void PictureSetup(WeatherResponse res, WeatherStationClient weather) {
            string iconId = res.Weather[0].Icon;
            string filePath = AppDomain.CurrentDomain.BaseDirectory + "\\" + iconId + ".png";
            bool fileExists = File.Exists(filePath);

            string imagePath = "";
            if (fileExists == true) {
                imagePath = filePath;
            }
            else {
                imagePath = weather.GetIcon(iconId);
            }
            ctrlWeathedData.Image = Image.FromFile(imagePath);
        }

        public string DateSetup(int unixSecs) {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixSecs).ToLocalTime();
            return Convert.ToString(dtDateTime.TimeOfDay);
        }

        private void ctrlFindCity_Click(object sender, EventArgs e) {
            CitiesManager citiesManager = new CitiesManager();
            List<CitiesInfo> citiesResults = citiesManager.FindNewCity(ctrlYourCityName.Text);
            ctrlYourCityName.Items.Clear();
           
            for (int i = 0; i < citiesResults.Count; i++) {
                ctrlYourCityName.Items.Add(citiesResults[i].CityName + ", " + citiesResults[i].Country);
            }

            ctrlYourCityName.DroppedDown = true;
        }
    }
}