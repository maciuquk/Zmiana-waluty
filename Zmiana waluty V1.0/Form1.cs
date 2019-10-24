using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zmiana_waluty_V1._0
{
    public partial class ZmianaWaluty : Form

    {
        decimal kursEur = 0;
        decimal kursDol = 0;
        decimal kursGbp = 0;
        decimal kursRub = 0;
        int zaokraglenie = 4;



        CurrencyRadioButtonToolkit radiobuttonToolsFrom = null;
        CurrencyRadioButtonToolkit radiobuttonToolsTo = null;
        KursyWalut kursyWalut = new KursyWalut();
        public ZmianaWaluty()
        {
            InitializeComponent();
            radiobuttonToolsFrom = new CurrencyRadioButtonToolkit()
            {
                rb_eur_f = radioButtonZeuro,
                rb_gbp_f = radioButtonZgbp,
                rb_usd_f = radioButtonZdolar,
                rb_rub_f = radioButtonZrub
            };
            radiobuttonToolsTo = new CurrencyRadioButtonToolkit()
            {

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

        }

        private void ZamienButton_Click(object sender, EventArgs e)
        {
            //this.Text = radiobuttonToolsFrom.JakaWaluta();
            if (kursEur == 0)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Najpierw zaktualizuj kursy!");
            }

            else
            {
                string symbolWaluty = "";
                if (radioButtonZeuro.Checked) symbolWaluty = "€";
                if (radioButtonZdolar.Checked) symbolWaluty = "$";
                if (radioButtonZgbp.Checked) symbolWaluty = "GBP";
                if (radioButtonZrub.Checked) symbolWaluty = "RUB";

                label7.Text = ZamienBox.Text + symbolWaluty + " = ";
                label3.Text = ZamienBox.Text + "zł = ";
                ZamienWaluty();
            }

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

        private void button2_Click(object sender, EventArgs e)
        {
            //aktualizacja wszystkich kursów


            kursEur = kursyWalut.SciagnijAktualneKursy("EUR");
            kursDol = kursyWalut.SciagnijAktualneKursy("USD");
            kursGbp = kursyWalut.SciagnijAktualneKursy("GBP");
            kursRub = kursyWalut.SciagnijAktualneKursy("RUB");
            //kursyWalutTrescLabel.Text = "Kurs €: " + kursEur + " zł \nKurs $: " + kursDol +" zł \nKurs GBP: " + kursGbp + " zł \nKurs RUB: " + kursRub +" zł \n";
            WyswietlKurstWalut();
            string hhh = kursyWalut.SciagnijAktualnaDate("EUR");
            dataKursowLabel.Text = hhh;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // dataKursowLabel.Text = dataKursuPicker.
            dataKursuPicker.MinDate = new DateTime(2019, 6, 20); //trzeba zrobić ograniczenie do maksymalnie 93 dni przed, bo wywali błąd

            // dodać obsługę błędu który się pojawia, jak nie ma tabeli na adany dzień
            string data = dataKursuPicker.Value.ToString("yyyy-MM-dd");
            dataKursowLabel.Text = data;
            kursEur = kursyWalut.SciagnijAktualneKursyWgDaty("EUR", data);
            kursDol = kursyWalut.SciagnijAktualneKursyWgDaty("USD", data);
            kursGbp = kursyWalut.SciagnijAktualneKursyWgDaty("GBP", data);
            kursRub = kursyWalut.SciagnijAktualneKursyWgDaty("RUB", data);
            WyswietlKurstWalut();

        }

        private void WyswietlKurstWalut()
        {
            kursyWalutTrescLabel.Text = "Kurs €: " + kursEur + " zł \nKurs $: " + kursDol + " zł \nKurs GBP: " + kursGbp + " zł \nKurs RUB: " + kursRub + " zł \n";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButtonZdolar_Click(object sender, EventArgs e)
        {
            //if (radioButtonZdolar.Checked)
            //    label3.Text = "$/zł";
            //    label7.Text = "zł/$";
        }

        private void radioButtonZeuro_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonZeuro.Checked)
            //    label3.Text = "€/zł";
            //    label7.Text = "zł/€";
        }

        private void radioButtonZgbp_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonZgbp.Checked)
            //    label3.Text = "GBP/zł";
            //label7.Text = "zł/GBP";
        }

        private void radioButtonZrub_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButtonZrub.Checked)
            //    label3.Text = "RUB/zł";
            //label7.Text = "zł/RUB";
        }

        private void ZamienWaluty()
        {
            decimal przelicznik = 0;
            string symbol = "";
            if (radioButtonZeuro.Checked)
            {
                przelicznik = kursEur;
                symbol = "€";
            }
            if (radioButtonZdolar.Checked)
            {
                przelicznik = kursDol;
                symbol = "$";
            }
            if (radioButtonZgbp.Checked)
            {
                przelicznik = kursGbp;
                symbol = "GBP";
            }

            if (radioButtonZrub.Checked)
            {

                przelicznik = kursRub;
                symbol = "RUB";
            }



            decimal wpisanaWartosc = Convert.ToDecimal(ZamienBox.Text); // obsługę błędu wpisać i enterem dodawanie

            label2.Text = (Decimal.Round((wpisanaWartosc / przelicznik), zaokraglenie)).ToString() + " " + symbol;
            label4.Text = (Decimal.Round((wpisanaWartosc * przelicznik), zaokraglenie)).ToString() + " zł";




        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (zaokraglenie < 10)
            {
                zaokraglenie++;

                if (zaokraglenie == 1)

                    label9.Text = zaokraglenie + " miejsca";
                else 
                    label9.Text = zaokraglenie + " miejsc";
            }

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (zaokraglenie > 0)
            {
                zaokraglenie--;
                if (zaokraglenie == 1)
                    label9.Text = zaokraglenie + " miejsca";
                else
                    label9.Text = zaokraglenie + " miejsc";
            }
        }
    }
}
