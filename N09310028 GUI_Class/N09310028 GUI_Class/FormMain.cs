﻿using System;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text="我已經被按過了";
            Form form = new FormButton();
            form.Show(); 







                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form2();

            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new FormTimer();

            form.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form form = new FormGame();

            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form form = new FormCheckBox();

            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form form = new FormMenu();

            form.Show();
        }
    }
}
