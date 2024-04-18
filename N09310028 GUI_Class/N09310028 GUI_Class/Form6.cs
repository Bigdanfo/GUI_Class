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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("嗨");
            string tmp = TextBox_input.Text;
            int c = int32.parse(tmp);
        }

        private void button1_Click(object sender, EventArgs e)
        {//華氏 = (攝氏)* (9 / 5) + 32
            double result = c * 1.8+32;
            Console.WriteLine(result);
            Console.ReadLine();
            labe2_result.Text = result.ToString();
        }
    }
}
