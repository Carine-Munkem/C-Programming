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
    public partial class frmExercise_4 : Form
    {
        public frmExercise_4()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExercise_4 frmExercise_4 = new frmExercise_4();
            frmExercise_4.Show();
            this.Close();
        }

        private void btnAbsolute_Click(object sender, EventArgs e)
        {
            int intInput;
            int intOutput;
            intInput = int.Parse(txtInput.Text);
            intInput = -52;
            intOutput = Math.Abs(intInput);
            txtOutput.Text = intOutput.ToString();
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double dblInput;
            double dblOutput;
            
            dblInput = int.Parse(txtInput.Text);
          

            dblInput = 400;
            dblOutput = Math.Sqrt(dblInput);
            txtOutput.Text = dblOutput.ToString();
            


        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string strInput;
            int intOutput;
            strInput = txtInput.Text.ToString();
            intOutput = txtInput.Text.Length;
            txtOutput.Text = intOutput.ToString();

        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string strInput;
            string strOutput;

            strInput = txtInput.Text;
            strOutput = txtOutput.Text;

            strOutput = strInput.Substring(0,3);
            txtOutput.Text = strOutput.ToString();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            txtOutput.Text = System.DateTime.Now.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }
    }
}
