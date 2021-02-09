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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmExercise_1 frmExercise_1 = new frmExercise_1();
            frmExercise_1.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmExercise_2 frmExercise_2 = new frmExercise_2();
            frmExercise_2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmExercise_3 frmExercise_3 = new frmExercise_3();
            frmExercise_3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmExercise_4 frmExercise_4 = new frmExercise_4();
            frmExercise_4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmExercise_5 frmExercise_5 = new frmExercise_5();
            frmExercise_5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmExercise_6 frmExercise_6 = new frmExercise_6();
            frmExercise_6.Show();
            this.Hide();
        }
    }
}
