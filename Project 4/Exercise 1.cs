using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_4
{
    public partial class frmExercise_1 : Form
    {
        public frmExercise_1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExercise_1 frmExercise_1 = new frmExercise_1();
            frmExercise_1.Show();
            this.Close();

        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            string strCountries = "";
            string strGroup = "";
            strCountries = cboCountry.Text;
            strGroup = txtOutput.Text;

            if (cboCountry.Text == "Holland")
            {
                txtOutput.Text = "A";
            }
            else if (cboCountry.Text == "Switzerland")

            {
                txtOutput.Text = "A";

            }
            else if (cboCountry.Text == "Italy")

            {
                txtOutput.Text = "A";

            }

            if (cboCountry.Text == "South Africa")
            {
                txtOutput.Text = "B";
            }
            else if (cboCountry.Text == "Brazile")

            {
                txtOutput.Text = "B";

            }
            else if (cboCountry.Text == "Sweden")

            {
               txtOutput.Text = "B";

            }

            if (cboCountry.Text == "Germany")
            {
                txtOutput.Text = "C";
            }
            else if (cboCountry.Text == "England")

            {
                txtOutput.Text = "C";

            }
            else if (cboCountry.Text == "Argentina")

            {
                txtOutput.Text = "C";

            }

            if (cboCountry.Text == "Scotland")
            {
                txtOutput.Text = "D";
            }
            else if (cboCountry.Text == "USA")

            {
                txtOutput.Text = "D";

            }
            else if (cboCountry.Text == "France")

            {
                txtOutput.Text = "D";

            }

        }
    }
}
