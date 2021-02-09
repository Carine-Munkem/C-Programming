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
    public partial class frmExercise_6 : Form
    {
        public frmExercise_6()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExercise_5 frmExercise_5 = new frmExercise_5();
            frmExercise_5.Show();
            this.Hide();
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            int intValue1;
            int intValue2;
            int intValue3;
            int intValue4;
            int intValue5;
            int intValue6;

            Random MyRand = new Random();
            intValue1 = MyRand.Next(1, 50);
            intValue2 = MyRand.Next(1, 50);
            intValue3 = MyRand.Next(1, 50);
            intValue4 = MyRand.Next(1, 50);
            intValue5 = MyRand.Next(1, 50);
            intValue6 = MyRand.Next(1, 50);

            txtValue1.Text = intValue1.ToString();
            txtValue2.Text = intValue2.ToString();
            txtValue3.Text = intValue3.ToString();
            txtValue4.Text = intValue4.ToString();
            txtValue5.Text = intValue5.ToString();
            txtValue6.Text = intValue6.ToString();
        }
    }
}
