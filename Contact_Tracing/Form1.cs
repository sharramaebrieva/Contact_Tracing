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
            
        }


        private void ButtonClick_Save(object sender, EventArgs e)
        {
            string Name = TextBox_Name.Text.ToString();
            string Age = TextBox_Age.Text.ToString();
            string Address = TextBox_Address.Text.ToString();
            string Birthdate = TextBox_Birthdate.Text.ToString();
            string Male = RadioButton_Male.Text.ToString();
            string Female = RadioButton_Female.Text.ToString();

            MessageBox.Show("Please check all your information!" + "\n\nName: " + Name
                + "\nAge: " + Age + "\nCurrent Address: " + Address + "\nBirthdate: " + Birthdate
                + "\nGender: " + Male + Female);
        }
    }
}
