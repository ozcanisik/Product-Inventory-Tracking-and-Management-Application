using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zen.Barcode;

namespace UrunStokTakip.Formlar
{
    public partial class FormBarkod : Form
    {
        public FormBarkod()
        {
            InitializeComponent();
        }

        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            Code128BarcodeDraw barcode = BarcodeDrawFactory.Code128WithChecksum;
            pictureEdit3.Image = barcode.Draw(textKod.Text,35);
        }
    }
}
