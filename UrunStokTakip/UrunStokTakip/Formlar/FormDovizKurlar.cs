using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrunStokTakip.Formlar
{
    public partial class FormDovizKurlar : Form
    {
        public FormDovizKurlar()
        {
            InitializeComponent();
        }

        // Döviz kurlarını çekmek için TCMB resmi sitesine webbrowser üzerinden erişilmesi
        private void FormDovizKurlar_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.tcmb.gov.tr/wps/wcm/connect/tr/tcmb+tr/main+page+site+area/bugun");
        }
    }
}
