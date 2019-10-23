using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Zmiana_waluty_V1._0
{
    public class CurrencyRadioButtonToolkit 
    {
        public RadioButton rb_pln_f { get; set; }
        public RadioButton rb_eur_f { get; set; }
        public RadioButton rb_usd_f { get; set; }
        public RadioButton rb_gbp_f { get; set; }

        public string JakaWaluta()
        {
            if (rb_pln_f.Checked) return "PLN";
            if (rb_eur_f.Checked) return "EUR";
            if (rb_usd_f.Checked) return "USD";
            if (rb_gbp_f.Checked) return "GBP";

            return "";
        }
        public void SprawdzRadiobuttony()
        {
           // ZamienButton.Text = "dasdad";
            

        }
    }
}
