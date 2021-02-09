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
    public partial class frmExercise_3 : Form
    {
        public frmExercise_3()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExercise_3 frmExercise_3 = new frmExercise_3();
            frmExercise_3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int X;
            X = 0;
            do
            {
                X = X + 1;
                lstLoop.Items.Add(X);
            }
            while (X < 200);
        }

        private void btnLoop2_Click(object sender, EventArgs e)
        {
            for (int X = 0; X < 16; X++)
            {
                lstLoop.Items.Add(X);
            }

        }

        private void btnLoop3_Click(object sender, EventArgs e)
        {
            for (int X = -0; X < 16; X++)
            {
                lstLoop.Items.Add(X);
            }
        }

        private void btnLoop4_Click(object sender, EventArgs e)
        {
            int i = 0;
            do
            {

                lstLoop.Items.Add(i.ToString());
                i++;
            }
            while (i < 10);
        
        
    }

        private void btnClear_Click(object sender, EventArgs e)
        {
           
        }
    }
}
