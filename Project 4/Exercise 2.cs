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
    public partial class frmExercise_2 : Form
    {
        public frmExercise_2()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmExercise_2 frmExercise_2 = new frmExercise_2();
            frmExercise_2.Show();
            this.Close();

        }

        private void btnType_Click(object sender, EventArgs e)
        {
            string strContinent = "";
            string strAgeGroup = "";
            string strGender = "";
            string strSpectatorType = "";
            strContinent = cboContinent.Text;
            strAgeGroup = cboAgeGroup.Text;
            strGender = cboGender.Text;
            strSpectatorType = SpectatorOutput.Text;

            if (cboContinent.Text == "Africa")
            {
                if (cboAgeGroup.Text == "Child")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "A";
                    }
                }
            }
                    else if (cboGender.Text == "Male")
                    {
                        SpectatorOutput.Text = "B";
                    }

            if (cboContinent.Text == "Africa")
            {
                if (cboAgeGroup.Text == "Adult")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = " C";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "D";
            }

            if (cboContinent.Text == "Africa")
            {
                if (cboAgeGroup.Text == "Pensioner")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "E";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "F";
            }


            if (cboContinent.Text == "America")
            {
                if (cboAgeGroup.Text == "Child")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "G";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "H";
            }

            if (cboContinent.Text == "America")
            {
                if (cboAgeGroup.Text == "Adult")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "I";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "J";
            }

            if (cboContinent.Text == "America")
            {
                if (cboAgeGroup.Text == "Pensioner")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "K";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "L";
            }


            if (cboContinent.Text == "Europe")
            {
                if (cboAgeGroup.Text == "Child")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "M";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "N";
            }

            if (cboContinent.Text == "Europe")
            {
                if (cboAgeGroup.Text == "Adult")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "O";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "P";
            }

            if (cboContinent.Text == "Europe")
            {
                if (cboAgeGroup.Text == "Pensioner")
                {
                    if (cboGender.Text == "Female")
                    {
                        SpectatorOutput.Text = "Q";
                    }
                }
            }
            else if (cboGender.Text == "Male")
            {
                SpectatorOutput.Text = "R";
            }
        }
            }
        
        
    }

