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
        string Name = "";
        string Age = "";
        string Birthdate = "";
        string Gender;
        string ContactNumber = "";
        string Address = "";
        string Summary = "";

        StreamWriter FileLocation;
        
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
        }


       
        

        public void ButtonClick_Save(object sender, EventArgs e)
        {
            Name = TextBox_LastName.Text + ", " + TextBox_FirstName.Text + ", " + TextBox_MiddleName.Text;
            Age = TextBox_Age.Text;
            Birthdate = TextBox_Birthdate.Text;
            ContactNumber = TextBox_ContactNumber.Text;
            Address = TextBox_Street.Text + ", " + TextBox_Brgy.Text + ", " + TextBox_Municipality.Text + ", "
                + TextBox_City.Text;

            Summary = "Name: " + Name + "\nAge: " + Age + "\nBirthdate: " + Birthdate + "\nGender: " + Gender
                + "\nContact Number: " + ContactNumber + "\nCurrent Address: " + Address;



            if (TextBox_LastName.Text == "" || TextBox_FirstName.Text == ""
                 || TextBox_Age.Text == "" || TextBox_Birthdate.Text == "" ||
                 TextBox_ContactNumber.Text == "" || TextBox_Brgy.Text == ""
                 || TextBox_Municipality.Text == "" && TextBox_City.Text == ""
                 || Gender == "")
            {
                MessageBox.Show("Incomplete Information! \n\nClick OK and fill out all necessary information!");
            }
            else if (TextBox_LastName.Text != "" && TextBox_FirstName.Text != ""
                 && TextBox_Age.Text != "" && TextBox_Birthdate.Text != "" &&
                 TextBox_ContactNumber.Text != "" && TextBox_Brgy.Text != ""
                 && TextBox_Municipality.Text != "" && TextBox_City.Text != ""
                 && Gender != "")
            {
                MessageBox.Show("Please check all your information!\n\n" + Summary + "\n\nIf all the information are "
                    + "correct, click OK then click Next. Thank You!");
                Button_Next.Enabled = true;
            }
        }

        private void RadioButton_Male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void RadioButton_Female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
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

            FileLocation = File.AppendText(@"C:\Users\LENOVO\Desktop\Contact-Tracing-Info.txt");
            FileLocation.WriteLine("CONTACT TRACING FOR COVID-19\nPersonal Information\n");
            FileLocation.WriteLine(Summary + "\n");
            FileLocation.Close();
        }

        private void PickBirthdate(object sender, EventArgs e)
        {
            TextBox_Birthdate.CustomFormat = "MMMM dd, yyyy";
        }
    }
}
