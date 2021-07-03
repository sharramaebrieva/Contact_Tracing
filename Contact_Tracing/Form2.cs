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
        string Answer1 = "";
        string Answer2 = "";
        string Answer3 = "";
        string Answer4 = "";
        string Answer5 = "";

        string Result1 = "";
        string Result2 = "";
        string Result3 = "";
        string Result4 = "";
        string Result5 = "";

        string Summary = "";

        string q1_1 = "";
        string q1_2 = "";
        string q1_3 = "";
        string q1_4 = "";
        string q1_5 = "";
        string q1_6 = "";
        string q1_7 = "";
        string q1_8 = "";
        string q1_9 = "";

        string SummarySymptoms = "";

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












        private void Button_Save2_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                q1_1 = checkBox1.Text;
            }

            if (checkBox2.Checked)
            {
                q1_2 = checkBox2.Text;
            }

            if (checkBox3.Checked)
            {
                q1_3 = checkBox3.Text;
            }

            if (checkBox4.Checked)
            {
                q1_4 = checkBox4.Text;
            }

            if (checkBox5.Checked)
            {
                q1_5 = checkBox5.Text;
            }

            if (checkBox6.Checked)
            {
                q1_6 = checkBox6.Text;
            }

            if (checkBox7.Checked)
            {
                q1_7 = checkBox7.Text;
            }

            if (checkBox8.Checked)
            {
                q1_8 = checkBox8.Text;
            }

            if (checkBox9.Checked)
            {
                q1_9 = checkBox9.Text;
            }

            Summary = Result1 + "\n\n" + Result2 + "\n\n" + Result3 + "\n\n" + Result4 + "\n\n" + Result5;
            SummarySymptoms = q1_1 + "\n" + q1_2 + "\n" + q1_3 + "\n" + q1_4 + "\n" + q1_5 + "\n" + q1_6 + "\n" +
                q1_7 + "\n" + q1_8 + "\n" + q1_9;

            if (Answer1 == "" || Answer2 == "" || Answer3 == "" || Answer4 == "" || Answer5 == "")
            {
                MessageBox.Show("Please answer all required questions!");
            }
            else if (Answer1 == "No" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "No")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
            }
            else if (Answer1 == "No" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "Yes" &&
                TextBox_SpecifyCity.Text == "")
            {
                MessageBox.Show("Please specify the city / municipality you traveled to outside your current" +
                    "residency!");
            }
            else if (Answer1 == "Yes" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "No"
                && SummarySymptoms == "")
            {
                MessageBox.Show("Please specify the symptoms you have experienced by clicking the checkboxes.");
            }
            else if (Answer1 == "Yes" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "Yes"
                && SummarySymptoms == "" && TextBox_SpecifyCity.Text == "")
            {
                MessageBox.Show("Please specify the symptoms you have experienced by clicking the checkboxes." +
                    "\n\nPlease specify the city / municipality you traveled to outside your current" +
                    "residency!");
            }
            else if (Answer1 == "Yes" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "Yes"
                && SummarySymptoms != "" && TextBox_SpecifyCity.Text != "")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
            }
            else if (Answer1 == "No" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "Yes"
                && TextBox_SpecifyCity.Text != "")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
            }
            else if (Answer1 == "Yes" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "Yes"
                && SummarySymptoms != "" && TextBox_SpecifyCity.Text != "")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
            }
        }
        private void RadioButton_1Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer1 = "Yes";
            GroupBox_Symptoms.Visible = true;
            Result1 = "Experienced or did have any of the symptoms for the past 14 days:\n" + SummarySymptoms;
        }

        private void RadioButton_1No_CheckedChanged(object sender, EventArgs e)
        {
            Answer1 = "No";
            GroupBox_Symptoms.Visible = false;
            SummarySymptoms = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            Result1 = "Did not experience or did not have any of the symptoms for the past 14 days.";
        }

        private void RadioButton_2Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer2 = "Yes";
            Result2 = "Experienced face-to-face contact with a probable or confirmed COVID-19 case within 1 " +
                "meter and for more than 15 minutes for the past 14 days.";
        }

        private void RadioButton_2No_CheckedChanged(object sender, EventArgs e)
        {
            Answer2 = "No";
            Result2 = "Did not have any face-to-face contact with a probable or confirmed COVID-19 case within 1 " +
                "meter and for more than 15 minutes for the past 14 days.";
        }


        private void RadioButton_3Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer3 = "Yes";
            Result3 = "Provided direct care for a patient with probable or confirmed COVID - 19 case " +
                "without using proper Personal Protective Equipment(PPE) for the past 14 days.";
        }

        private void RadioButton_3No_CheckedChanged(object sender, EventArgs e)
        {
            Answer3 = "No";
            Result3 = "Did not provide direct care for a patient with probable or confirmed COVID - 19 case " +
                "without using proper Personal Protective Equipment(PPE) for the past 14 days.";
        }

        private void RadioButton_4Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer4 = "Yes";
            Result4 = "Traveled outside the Philippines in the last 14 days.";
        }

        private void RadioButton_4No_CheckedChanged(object sender, EventArgs e)
        {
            Answer4 = "No";
            Result4 = "Did not travel outside the Philippines in the last 14 days.";
        }

        private void RadioButton_5Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer5 = "Yes";
            Result5 = "Traveled to " + TextBox_SpecifyCity.Text.ToString() + ", which is outside the current city / " +
                "municipality of residence";
            TextBox_SpecifyCity.ReadOnly = false;
        }

        private void RadioButton_5No_CheckedChanged(object sender, EventArgs e)
        {
            Answer5 = "No";
            Result5 = "Did not travel outside the current city / municipality of residence";
            TextBox_SpecifyCity.Text = "";
            TextBox_SpecifyCity.ReadOnly = true;
        }







        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            q1_2 = checkBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            q1_3 = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            q1_4 = checkBox4.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            q1_5 = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            q1_6 = checkBox6.Text;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            q1_7 = checkBox7.Text;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            q1_8 = checkBox8.Text;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            q1_9 = checkBox9.Text;
        }

        
    }
}
