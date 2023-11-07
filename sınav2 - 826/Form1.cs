using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav2___826
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTaksit.Text = tbTaksit.Text = tbTaksit.Text;

        }

        private void tbTaksit_Scroll(object sender, EventArgs e)
        {
            lblTaksit.Text = tbTaksit.Value.ToString(); // yan taraftaki değer

            double toplam = Convert.ToDouble(txtBirim.Text);
            double taksit = toplam / tbTaksit.Value;
            lblAdet.Text = taksit.ToString();


        }
    }
}
