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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "請按我一下")
                button1.Text = "我已經被按過了";
            else if (button1.Text == "我已經被按過了")
                button1.Text = "請按我一下";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String count = label1.Text;
            int sum = Int32.Parse(count) + 1;
            label1.Text = sum.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String count = label1.Text;
            int sum = Int32.Parse(count) - 1;
            label1.Text = sum.ToString();
        }
    }
}
