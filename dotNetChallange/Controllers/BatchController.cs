using dotNetChallange.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Timers;
using System.Web;
using System.Web.Mvc;

namespace dotNetChallange.Controllers
{
    public class BatchController : Controller
    {
        public void Index()
        {
            //Fetch the JSON string from URL.
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            var jsonData = (new WebClient()).DownloadString("#jsonUrl");

            //Convert JSON into Model
            JSONModel.Rootobject records = JsonConvert.DeserializeObject<JSONModel.Rootobject>(jsonData); //  JSON.Net

            SaveDataToDb(records);
        }

        private void SaveDataToDb(JSONModel.Rootobject model)
        {
            System.Data.SqlClient.SqlConnection sqlConnection1 = new System.Data.SqlClient.SqlConnection("Server=localhost;Integrated Security=True");

            System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT MyTable (low_24, high_24, avg_24h, volume_24h) " +
                "VALUES ('" + model.data.ticker.low_24h + "', '"
                            + model.data.ticker.high_24h + "', '"
                            + model.data.ticker.avg_24h + "', '"
                            + model.data.ticker.volume_24h + "')";
            cmd.Connection = sqlConnection1;

            sqlConnection1.Open();
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }
    }
}
