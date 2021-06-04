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

        private void TextBoxName_TextChanged(object sender, EventArgs e)
        {
            Name = TextBox_Name.Text.ToString();
        }


        
        string Gender;

        private void ButtonClick_Save(object sender, EventArgs e)
        {
            string Age = TextBox_Age.Text.ToString();
            string Address = TextBox_Address.Text.ToString();
            string Birthdate = TextBox_Birthdate.Text.ToString();

            MessageBox.Show("Please check all your information!" + "\n\nName: " + Name
                + "\nAge: " + Age + "\nCurrent Address: " + Address + "\nBirthdate: " + Birthdate
                + "\nGender: " + Gender);
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
