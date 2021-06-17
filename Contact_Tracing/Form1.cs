using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string Name = TextBox_LastName.Text + ", " + TextBox_FirstName.Text + ", " + TextBox_MiddleName.Text;
            string Age = TextBox_Age.Text;
            string Birthdate = TextBox_Birthdate.Text;
            string ContactNumber = TextBox_ContactNumber.Text;
            string Address = TextBox_Street.Text + ", " + TextBox_Brgy.Text + ", " + TextBox_Municipality.Text + ", "
                + TextBox_City.Text;

            string Summary = "Name: " + Name + "\nAge: " + Age + "\nBirthdate: " + Birthdate + "\nGender: " + Gender
                + "\nContact Number: " + ContactNumber + "\nCurrent Address: " + Address;
            
        }

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
        }


       
        string Gender;

        public void ButtonClick_Save(object sender, EventArgs e)
        {
            string Name = TextBox_LastName.Text + ", " + TextBox_FirstName.Text + ", " + TextBox_MiddleName.Text;
            string Age = TextBox_Age.Text;
            string Birthdate = TextBox_Birthdate.Text;
            string ContactNumber = TextBox_ContactNumber.Text;
            string Address = TextBox_Street.Text + ", " + TextBox_Brgy.Text + ", " + TextBox_Municipality.Text + ", "
                + TextBox_City.Text;

            string Summary = "Name: " + Name + "\nAge: " + Age + "\nBirthdate: " + Birthdate + "\nGender: " + Gender
                + "\nContact Number: " + ContactNumber + "\nCurrent Address: " + Address;

            MessageBox.Show("Please check all your information!\n\n" + Summary + "\n\nIf all the information are " +
                "correct, click OK then click Next. Thank You!");
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
        }
    }
}
