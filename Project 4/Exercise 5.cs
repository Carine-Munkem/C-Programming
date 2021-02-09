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
    public partial class frmExercise_5 : Form
    {
        public frmExercise_5()
        {
            InitializeComponent();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmExercise_5 frmExercise_5 = new frmExercise_5();
            frmExercise_5.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int intValue1 = 0;
            int intValue2 = 0;
            int intValue3 = 0;
            int intOutput = 0;
            intValue1 = int.Parse(txtInput1.Text);
            intValue2 = int.Parse(txtInput2.Text);
            intValue3 = int.Parse(txtInput3.Text);
            intOutput = int.Parse(lblOutput.Text);
            
            // lblOutput = intValue1  + intValue2  + intValue3;
            lblOutput.Text = lblOutput.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput1.Text = "";
            txtInput2.Text = "";
            txtInput3.Text = "";
        }

        private void frmExercise_5_Load(object sender, EventArgs e)
        {

        }
    }
}
