using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N09310028_GUI_Class
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("text box 被改變了");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox3.Text);
            int b = Int32.Parse(textBox4.Text);
            label4.Text = (a + b).ToString();
                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox5.Text);
            int b = Int32.Parse(textBox6.Text);
            label7.Text = (a - b).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox8.Text);
            int b = Int32.Parse(textBox7.Text);
            label8.Text = (a * b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox10.Text);
            int b = Int32.Parse(textBox9.Text);
            if (b>0)
            {
                label11.Text=(a / b).ToString();
            }
            else
            {
                label11.Text ="錯誤:分母不能為零";
            }
            
        }
    }
}
