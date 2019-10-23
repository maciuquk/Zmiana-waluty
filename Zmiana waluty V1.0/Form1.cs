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
    public partial class ZmianaWaluty : Form
    {
        //RadioButtony radiobuttony = new RadioButtony();
        CurrencyRadioButtonToolkit radiobuttonToolsFrom = null;
        CurrencyRadioButtonToolkit radiobuttonToolsTo = null;
        public ZmianaWaluty()
        {
            InitializeComponent();
            radiobuttonToolsFrom = new CurrencyRadioButtonToolkit()
            {
                rb_pln_f = radioButtonZzl,
                rb_eur_f = radioButtonZeuro,
                rb_gbp_f = radioButtonZgbp,
                rb_usd_f = radioButtonZdolar
            };
            radiobuttonToolsTo = new CurrencyRadioButtonToolkit()
            {
                rb_pln_f = radioButtonNazl,
                rb_eur_f = radioButtonNaeuro,
                rb_gbp_f = radioButtonNagbp,
                rb_usd_f = radioButtonNadolar
            };

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ZmianaWaluty_Load(object sender, EventArgs e)
        {


        }

        private void radioButtonZzl_Click(object sender, EventArgs e)
        {
            ZamienButton.Text = "dasdad";

        }

        private void ZamienButton_Click(object sender, EventArgs e)
        {
            this.Text = radiobuttonToolsFrom.JakaWaluta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal kurs = new Decimal();
            if (PobierzKurs(radiobuttonToolsFrom.JakaWaluta(), ref kurs))
            {
                Text = "Kurs " + radiobuttonToolsFrom.JakaWaluta() + ": " + kurs;
            }
            else
                Text = "Błąd przy pobieraniu kursu";

        }

        private bool PobierzKurs(string waluta, ref Decimal kurs)
        {
            if (waluta == "")
            {
                System.Windows.Forms.MessageBox.Show("Wybierz walutę");
                return false;
            }
            try
            {
                HttpClient client = new HttpClient();
                client.DefaultRequestHeaders.Accept
                  .Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string requestUri = "http://api.nbp.pl/api/exchangerates/rates/a/" + waluta + "/?format=json";
                string wynikjson = client.GetStringAsync(requestUri).Result;
                dynamic obiektJson = (dynamic)JsonConvert.DeserializeObject<object>(wynikjson);
                kurs = obiektJson.rates[0].mid;
                return true;
            }
            catch (Exception exception)
            {
                System.Windows.Forms.MessageBox.Show($"W trakcie pobierania kursu wystąpił błąd: {exception.Message}");
            }
            return false;
        }
    }
}
