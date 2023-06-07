using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace UrunStokTakip.Formlar
{
    public partial class FormQRKod : Form
    {
        public FormQRKod()
        {
            InitializeComponent();
        }

        // QR Kod oluşturma işlemi
        private void buttonOlustur_Click(object sender, EventArgs e)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            pictureEdit3.Image = encoder.Encode(textSeriNo.Text);
        }
    }
}
