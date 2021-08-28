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
    public partial class Wages : Form
    {
        public Wages(string username, string ID)
        {
            InitializeComponent();
            Name_Show_Label.Text = username;
            Pass_Label.Text = ID;
            Name_Res_Label.Text = username + "'s Weekly Wage :";
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Title_label_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            error.Text = "";  
            double totHours = 0;
            totHours += Convert.ToInt32(sunHours.Value)+ Convert.ToInt32(monHours.Value);
            totHours += Convert.ToInt32(tuesHours.Value) + Convert.ToInt32(wedHours.Value);
            totHours += Convert.ToInt32(thursHours.Value) ;
         
           
            double totMin = 0;
            totMin+= Convert.ToInt32(sunMin.Value) + Convert.ToInt32(monMin.Value);
            totMin += Convert.ToInt32(tuesMin.Value) + Convert.ToInt32(wedMin.Value);
            totMin += Convert.ToInt32(thursMin.Value);
  
            totMin = totMin / 60;
            double totWork = totHours + totMin;
            double work = totWork, extra = 0;
            if(totWork>40)
            {
                extra = totWork - 40;
                work = totWork - extra;
            }
           
            if (comboBox1.Text == "Grade-1")
                totWork = (extra * 4000) + (work * 2000);
            else if (comboBox1.Text == "Grade-2")
                totWork = (extra * 3000) + (work * 1500);
            else if (comboBox1.Text == "Grade-3")
                totWork = (extra * 2000) + (work * 1000);
            else if (comboBox1.Text == "Grade-4")
                totWork = (extra * 1000) + (work * 500);
            else
                extra = -1;
            
            if (extra == -1)
                error.Text = "Select your grade";
            else
            {
               Final_ResLevel.Text = Name_Res_Label.Text + " "+ totWork.ToString("0.00"); 
            }
               
           
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            sunHours.Value = 0;
            monHours.Value = 0;
            tuesHours.Value = 0;
            wedHours.Value = 0;
            thursHours.Value = 0;
            sunMin.Value = 0;
            monMin.Value = 0;
            tuesMin.Value = 0;
            wedMin.Value = 0;
            thursMin.Value = 0;
            error.Text = "";
            Final_ResLevel.Text = "";
            comboBox1.Text = "";
        }
    }
}
