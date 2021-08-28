using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentWageCalculator
{
    public partial class CheckBox : Form
    {
        public CheckBox()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_textBox_TextChanged(object sender, EventArgs e)
        {

        }
         

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name_textBox.Text == "Misty" && Pass_textBox.Text == "180104101")
            {
                string username = Name_textBox.Text;
                string ID = Pass_textBox.Text;
                this.Hide(); 
                Wages frm = new Wages(username,ID);
                frm.Show();  
            }
            else
            {
                Error_Label.Text = "Invalid Username or Password";
            }
        }

        private void Pass_textBox_TextChanged(object sender, EventArgs e)
        {
            Pass_textBox.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                Pass_textBox.UseSystemPasswordChar = true;
            }
            else
            {
                Pass_textBox.UseSystemPasswordChar = false;
            }
        }
    }
}
