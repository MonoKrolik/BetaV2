﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button7.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            Form10 f10 = new Form10();
            f10.ShowDialog();
            Close();
        }
    }
}
