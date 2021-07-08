using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        string FullName = "";
        string Age = "";
        string Birthdate = "";
        string Gender;
        string ContactNumber = "";
        string Email = "";
        string Address = "";
        string Summary = "";

        StreamWriter Records;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void RadioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void TextBox_DateToday_ValueChanged(object sender, EventArgs e)
        {
            TextBox_DateToday.CustomFormat = "MMMM dd, yyyy";
        }

        private void PickBirthdate(object sender, EventArgs e)
        {
            TextBox_Birthdate.CustomFormat = "MMMM dd, yyyy";
        }

        private void TextBox_Age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char value = e.KeyChar;

            if (!Char.IsDigit(value) && value != (char)Keys.Back && value != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        private void TextBox_ContactNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char value = e.KeyChar;

            if (!Char.IsDigit(value) && value != (char)Keys.Back && value != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        public void ButtonClick_Save(object sender, EventArgs e)
        {
            FullName = TextBox_LastName.Text + ", " + TextBox_FirstName.Text + ", " + TextBox_MiddleName.Text;
            Age = TextBox_Age.Text;
            Birthdate = TextBox_Birthdate.Text;
            ContactNumber = TextBox_ContactNumber.Text;
            Email = TextBox_Email.Text;
            Address = TextBox_Street.Text + ", " + TextBox_Brgy.Text + ", " + TextBox_Municipality.Text + ", "
                + TextBox_City.Text;

            Summary = "Name: " + FullName + "\nAge: " + Age + "\nBirthdate: " + Birthdate + "\nGender: " + Gender
                + "\nContact Number: " + ContactNumber + "\nEmail Address: " + Email + "\nCurrent Address: " + Address;

            if (TextBox_LastName.Text == "" || TextBox_FirstName.Text == ""
                 || TextBox_Age.Text == "" || TextBox_Birthdate.Text == "" ||
                 TextBox_ContactNumber.Text == "" || TextBox_Email.Text == "" || TextBox_Brgy.Text == ""
                 || TextBox_Municipality.Text == "" && TextBox_City.Text == ""
                 || Gender == "")
            {
                MessageBox.Show("Incomplete Information! \n\nClick OK and fill out all necessary information!");
            }
            else if (TextBox_LastName.Text != "" && TextBox_FirstName.Text != ""
                 && TextBox_Age.Text != "" && TextBox_Birthdate.Text != "" &&
                 TextBox_ContactNumber.Text != "" && TextBox_Email.Text != "" && TextBox_Brgy.Text != ""
                 && TextBox_Municipality.Text != "" && TextBox_City.Text != ""
                 && Gender != "" && TextBox_ContactNumber.Text.Length == 11)
            {
                MessageBox.Show("Please check all your information!\n\n" + Summary + "\n\nIf all the information are "
                    + "correct, click OK then click Next. Thank You!");
                Button_Next.Enabled = true;
            }
            else if (TextBox_LastName.Text != "" && TextBox_FirstName.Text != ""
                 && TextBox_Age.Text != "" && TextBox_Birthdate.Text != "" &&
                 TextBox_ContactNumber.Text != "" && TextBox_Email.Text != "" && TextBox_Brgy.Text != ""
                 && TextBox_Municipality.Text != "" && TextBox_City.Text != ""
                 && Gender != "" && TextBox_ContactNumber.Text.Length != 11)
            {
                MessageBox.Show("Please enter your 11-digit Mobile Number!");
            }
        }

        private void ButtonClick_Next(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            if (f2 == null)
            {
                f2.Parent = this;
            }
            f2.Show();
            this.Hide();

            Records = File.AppendText(@"C:\Users\LENOVO\Desktop\Contact-Tracing-Info.txt");
            Records.WriteLine("CONTACT TRACING FOR COVID-19" + TextBox_DateToday.Text + "\nPersonal Information\n");
            Records.WriteLine(Summary + "\n");
            Records.Close();
        }
    }
}
