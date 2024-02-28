using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(txtLength.Text);
            int wid = Convert.ToInt32(txtWidth.Text);

            int area = len * wid;
            txtArea.Text = area.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(txtLength.Text);
            int wid = Convert.ToInt32(txtWidth.Text);

            int per = (len + wid) * 2;
            txtArea.Text = per.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolume_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(txtLength.Text);
            int wid = Convert.ToInt32(txtWidth.Text);
            int hght = Convert.ToInt32(txtHeight.Text);

            int vol = len * wid * hght;

            txtArea.Text = vol.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int len = Convert.ToInt32(txtLength.Text);
            int wid = Convert.ToInt32(txtWidth.Text);
            int hght = Convert.ToInt32(txtHeight.Text);

            int sarea = 
        }
    }
}
