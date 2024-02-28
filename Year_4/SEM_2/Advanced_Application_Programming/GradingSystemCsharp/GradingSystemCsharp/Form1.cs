using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradingSystemCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int math = Convert.ToInt32(txtMath.Text);
            int phyc = Convert.ToInt32(txtPhyc.Text);
            int chem = Convert.ToInt32(txtChem.Text);
            int bio = Convert.ToInt32(txtBio.Text);
            int geo = Convert.ToInt32(txtGeo.Text);

            int tot = math + phyc + chem + bio + geo;
            double ave = tot / 5;

            if (ave >= 70)
            {
                txtGrade.Text = "A";
            }
            else if (ave >= 60)
            {
                txtGrade.Text = "B";
            }
            else if (ave >= 50)
            {
                txtGrade.Text = "C";
            }
            else if (ave >= 40)
            {
                txtGrade.Text = "D";
            }
            else
            {
                txtGrade.Text = "FAIL";
            }

            txtAve.Text = ave.ToString();
            txtTotal.Text = tot.ToString();

            
        } 
                     
    }
}
