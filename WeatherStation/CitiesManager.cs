using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation {
    public class CitiesManager {

        public List<CitiesInfo> FindNewCity(string city) {
            List<CitiesInfo> res = new List<CitiesInfo>();


            string conString = "Server=(LocalDB)\\MSSQLLocalDB;Database=WeatherStation;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            DataSet ds = new DataSet();

            SqlDataAdapter da = new SqlDataAdapter("select top 10 * from Cities where CityName like '" + city + "%'", conString);
            da.Fill(ds);

            con.Close();


            //DataTableCollection tbls = ds.Tables;
            //DataTable dt = tbls[0];
            //DataRowCollection rowCol = dt.Rows;
            //DataRow row = rowCol[0];
            //object ress = row[1];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) {
                DataRow row = ds.Tables[0].Rows[i];

                string cityName = Convert.ToString(row["CityName"]);
                string country =  Convert.ToString(row["Country"]);
                CitiesInfo cityExists = res.Find(item => item.CityName == cityName && item.Country == country);
                if (cityExists == null) {
                    CitiesInfo cityInfo = new CitiesInfo();
                    cityInfo.CityId = Convert.ToInt32(row[1]);
                    cityInfo.CityName = cityName;
                    cityInfo.Country = country;
                    res.Add(cityInfo);
                }
            }

            return res;
        }

        public void ImportCitiesToDb() {
            List<JsonData> cities = new List<JsonData>();

            using (var jtr = new JsonTextReader(new StreamReader(File.OpenRead(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "city.list.json"))))) {
                JsonSerializer jsonSerializer = new JsonSerializer();
                cities = jsonSerializer.Deserialize<List<JsonData>>(jtr);
            }

            string conString = "Server=(LocalDB)\\MSSQLLocalDB;Database=WeatherStation;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(conString);
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select top 0 * from Cities", conString);
            da.Fill(ds);

            cities.ForEach(cityObj => {
                var row = ds.Tables[0].NewRow();
                row[1] = cityObj.id;
                row[2] = cityObj.name;
                row[3] = cityObj.country;
                ds.Tables[0].Rows.Add(row);
            });

            var cmdBuilder = new SqlCommandBuilder(da);
            var insCmd = cmdBuilder.GetInsertCommand();
            da.InsertCommand = insCmd;

            da.Update(ds);

            con.Close();
        }

        class JsonData {
            public int id { get; set; }
            public string name { get; set; }
            public string country { get; set; }
        }
    }
}
