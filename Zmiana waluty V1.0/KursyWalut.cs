using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmiana_waluty_V1._0
{
    public class KursyWalut
    {
        public decimal SciagnijAktualneKursy(string waluta)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string requestUri = "http://api.nbp.pl/api/exchangerates/rates/a/" + waluta + "/?format=json";
            string wynikjson = client.GetStringAsync(requestUri).Result;
            dynamic obiektJson = (dynamic)JsonConvert.DeserializeObject<object>(wynikjson);
            decimal kurs = obiektJson.rates[0].mid;

            return kurs;

        }
        
        public string SciagnijAktualnaDate(string waluta)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            string requestUri = "http://api.nbp.pl/api/exchangerates/rates/a/" + waluta + "/?format=json";
            string wynikjson = client.GetStringAsync(requestUri).Result;
            dynamic obiektJson = (dynamic)JsonConvert.DeserializeObject<object>(wynikjson);
            //string kurs = obiektJson.rates[0].mid;
            string data = obiektJson.rates[0].effectiveDate;
            return data;
        }

        public decimal SciagnijAktualneKursyWgDaty(string waluta, string data)
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Accept
              .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            string requestUri = "http://api.nbp.pl/api/exchangerates/rates/a/" + waluta + "/" + data +"/?format=json";
            string wynikjson = client.GetStringAsync(requestUri).Result;
            dynamic obiektJson = (dynamic)JsonConvert.DeserializeObject<object>(wynikjson);
            decimal kurs = obiektJson.rates[0].mid;

            return kurs;

        }
    }
}
