using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projekt_2
{
    public partial class Form8 : Form
    {
        string put = ("T/Glava3.txt");
        string[] text = new string[5];
        string staf = "";
        string slova = "";
        string[] stafs = new string[1];

        public Form8()
        {
            InitializeComponent();
            slova = File.ReadAllText(put, Encoding.Default);
            text = slova.Split('=');
            stafs = staf.Split('=');
            pictureBox1.Visible = false;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            label2.Visible = false;
            label4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            label2.Text = "Генри";
            label4.Text = "";
            label3.Visible = false;
            label5.Visible = false;
            BackColor = Color.Black;
        }

        int n = 0;

        private void label3_Click(object sender, EventArgs e)
        {
            n++;
            if (n == 1)
            {
                n = 0;
                BackgroundImage = System.Drawing.Image.FromFile("I/round2.1.jpg");
                label3.Text = text[n];
                n = 1;
            }
            else if (n == 1 || n == 2 || n == 7 || n == 4 || n == 10)
            {
                label2.Visible = true;
                pictureBox4.Visible = true;
                label3.Text = text[n];
            }
            if (n == 3 || n == 6 || n == 9)
            {
                label2.Visible = false;
                pictureBox4.Visible = false;
                label3.Text = text[n];
            }
            if (n==4)
            {
                pictureBox1.Visible = true;
                label3.Text = text[n];
            }
            if (n == 5)
            {
                Form9 f9 = new Form9();
                f9.ShowDialog();
                label3.Text = text[n];
                pictureBox1.Visible = false;
            }
            if (n == 8)
            {
                label3.Text = text[n];
            }
            if (n == 11)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label5.Visible = true;
            button1.Visible = false;
            label3.Text = "Глава 3. Путь";
        }
    }
}
 //Form9 f9 = new Form9();
            //f9.ShowDialog();