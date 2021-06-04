using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void Question1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Question1_Click(object sender, EventArgs e)
        {
            Label_Question1.Text = "1. Are you experiencing or did you have any of the following in the" +
                "\nlast 14 days? If yes, kindly check all the applicable experiences.";
        }

        private void Question2_Click(object sender, EventArgs e)
        {
            Label_Question2.Text = "2.Have you had face - to - face contact with a probable or confirmed" +
                "\nCOVID - 19 case within 1 meter and for more than 15" +
                "\nminutes for the past 14 days?";
        }

        private void Question3_Click(object sender, EventArgs e)
        {
            Label_Question3.Text = "3.Have you provided direct care for a patient with probable or confirmed" +
                "\nCOVID - 19 case without using proper \"Personal Protective" +
                "\nEquipment (PPE)\" for the past 14 days?";
        }

        private void Question4_Click(object sender, EventArgs e)
        {
            Label_Question4.Text = "4.Have you traveled outside the Philippines in the last 14 days?";
        }

        private void Question5_Click(object sender, EventArgs e)
        {
            Label_Question5.Text = "5.Have you traveled outside the current city/ municipality where you reside?" +
                "\nIf yes, specify which city / municipality you went to.";
        }

        private void ButtonView_Click(object sender, EventArgs e)
        {
            Label_Question1.Text = "1. Are you experiencing or did you have any of the following in the" +
                "\nlast 14 days? If yes, kindly check all the applicable experiences.";
            Label_Question2.Text = "2.Have you had face - to - face contact with a probable or confirmed" +
                "\nCOVID - 19 case within 1 meter and for more than 15" +
                "\nminutes for the past 14 days?";
            Label_Question3.Text = "3.Have you provided direct care for a patient with probable or confirmed" +
                "\nCOVID - 19 case without using proper \"Personal Protective" +
                "\nEquipment (PPE)\" for the past 14 days?";
            Label_Question4.Text = "4.Have you traveled outside the Philippines in the last 14 days?";
            Label_Question5.Text = "5.Have you traveled outside the current city/ municipality where you reside?" +
                "\nIf yes, specify which city / municipality you went to.";
        }
    }
}
