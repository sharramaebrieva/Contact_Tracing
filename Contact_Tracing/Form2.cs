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
            if (Answer1 == "" || Answer2 == "" || Answer3 == "" || Answer4 == "" || Answer5 == "")
            {
                MessageBox.Show("Please answer all required questions!");
            }
            
        }

        private void RadioButton_1Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer1 = "Yes";
            GroupBox_Symptoms.Visible = true;
        }

        private void RadioButton_1No_CheckedChanged(object sender, EventArgs e)
        {
            Answer1 = "No";
        }

        private void RadioButton_2Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer2 = "Yes";
        }

        private void RadioButton_2No_CheckedChanged(object sender, EventArgs e)
        {
            Answer2 = "No";
        }


        private void RadioButton_3Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer3 = "Yes";
        }

        private void RadioButton_3No_CheckedChanged(object sender, EventArgs e)
        {
            Answer3 = "No";
        }

        private void RadioButton_4Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer4 = "Yes";
        }

        private void RadioButton_4No_CheckedChanged(object sender, EventArgs e)
        {
            Answer4 = "No";
        }

        private void RadioButton_5Yes_CheckedChanged(object sender, EventArgs e)
        {
            Answer5 = "Yes";
            TextBox_SpecifyCity.ReadOnly = false;
        }

        private void RadioButton_5No_CheckedChanged(object sender, EventArgs e)
        {
            Answer5 = "No";
            TextBox_SpecifyCity.Text = "";
            TextBox_SpecifyCity.ReadOnly = true;
        }
    }
}
