using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace passa_faixa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double r, l, c;
            Double wcs, wci, wc;
            if ((txtC.Text==""|| txtC.Text == "0") || (txtR.Text == "" || txtR.Text == "0") || (txtL.Text == "" || txtL.Text == "0"))
            {
                MessageBox.Show("Complete os valores de entrada");
            }
            else
            {
                l = Convert.ToDouble(txtL.Text);
                c = Convert.ToDouble(txtC.Text);
                r = Convert.ToDouble(txtR.Text);

                wcs = (r * c + (Math.Sqrt(r * c * c + 4 * l * c))) / (2 * l * c);
                wci = (r * c  + (-1) * (Math.Sqrt(r * c * c + 4 * l * c))) / (2 * l * c);
                wc = 1000000 * (Math.Sqrt(1 / (c * l)));

                lblwcs.Text = wcs.ToString();
                lblwci.Text = wci.ToString(); ;
                lblwc.Text = wc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtL.Clear();
            txtC.Clear();
            txtR.Clear();

            lblwcs.Text = "";
            lblwci.Text = "";
            lblwc.Text = "";
        }
    }
}
