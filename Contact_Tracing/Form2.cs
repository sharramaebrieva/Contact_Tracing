using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
        string City = "";

        string Summary = "";
        string SummarySymptoms = "";
        StreamWriter Records;

        public Form2()
        {
            InitializeComponent();
        }

        private void Question1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button_Save2_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            { SummarySymptoms = checkBox1.Text; }
            if(checkBox2.Checked)
            { SummarySymptoms += checkBox2.Text; }
            if (checkBox3.Checked)
            { SummarySymptoms += checkBox3.Text; }
            if (checkBox4.Checked)
            { SummarySymptoms += checkBox4.Text; }
            if (checkBox5.Checked)
            { SummarySymptoms += checkBox5.Text; }
            if (checkBox6.Checked)
            { SummarySymptoms += checkBox6.Text; }
            if (checkBox7.Checked)
            { SummarySymptoms += checkBox7.Text; }
            if (checkBox8.Checked)
            { SummarySymptoms += checkBox8.Text; }
            if (checkBox9.Checked)
            { SummarySymptoms += checkBox9.Text; }

            City = TextBox_SpecifyCity.Text;

            Summary = Result1 + "\n\n" + Result2 + "\n\n" + Result3 + "\n\n" + Result4 + "\n\n" + Result5;


            if (Answer1 == "" || Answer2 == "" || Answer3 == "" || Answer4 == "" || Answer5 == "")
            {
                MessageBox.Show("Please answer all required questions!");
            }
            else if (Answer1 == "No" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "No")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
                Button_Submit.Enabled = true;
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
                Button_Submit.Enabled = true;
            }
            else if (Answer1 == "No" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "Yes"
                && TextBox_SpecifyCity.Text != "")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
                Button_Submit.Enabled = true;
            }
            else if (Answer1 == "Yes" && Answer2 != "" && Answer3 != "" && Answer4 != "" && Answer5 == "No"
                && SummarySymptoms != "")
            {
                MessageBox.Show("Kindly check all your answers and information\n\n" + Summary + "\n\n" + "Click" +
                    "OK, then Submit.");
                Button_Submit.Enabled = true;
            }
        }
        private void RadioButton_1Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer1 = "Yes";

            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
            checkBox6.Enabled = true;
            checkBox7.Enabled = true;
            checkBox8.Enabled = true;
            checkBox9.Enabled = true;

            Result1 = "Experienced or did have any of the symptoms for the past 14 days:" + SummarySymptoms;
        }

        private void RadioButton_1No_CheckedChanged(object sender, EventArgs e)
        {
            Answer1 = "No";
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            checkBox6.Enabled = false;
            checkBox7.Enabled = false;
            checkBox8.Enabled = false;
            checkBox9.Enabled = false;

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
            TextBox_SpecifyCity.ReadOnly = false;
            Result5 = "Traveled to " + City + ", which is outside the current city / " +
                "municipality of residence.";
        }

        private void RadioButton_5No_CheckedChanged(object sender, EventArgs e)
        {
            Answer5 = "No";
            Result5 = "Did not travel outside the current city / municipality of residence.";
            TextBox_SpecifyCity.Text = "";
            TextBox_SpecifyCity.ReadOnly = true;
        }

        private void ButtonClick_Submit(object sender, EventArgs e)
        {
            string Reference = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890abcdefghijklmnopqrstuvwxyz";
            var Length = new char[10];
            Random ReferenceNumber = new Random();
            
            for (int i = 0; i < Length.Length; i++)
            {
                Length[i] = Reference[ReferenceNumber.Next(Reference.Length)];
            }
            string NewReferenceNumber = new String(Length);
            MessageBox.Show("Please take note of your Reference Number!\n\n" + NewReferenceNumber);

            Records = File.AppendText(@"C:\Users\LENOVO\Desktop\Contact-Tracing-Info.txt");
            Records.WriteLine(Summary + "\n");
            Records.WriteLine("Reference Number: " + NewReferenceNumber);
            Records.Close();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}
