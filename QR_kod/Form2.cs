using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;

namespace QR_kod
{
    public partial class Form2 : Form
    {
        QRCodeEncoder code = new QRCodeEncoder();
        Image resim;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            resim = code.Encode(textBox1.Text);
            pictureBox1.Image = resim;
        }
    }
}
