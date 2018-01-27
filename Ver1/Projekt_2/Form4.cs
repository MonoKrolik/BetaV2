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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
        }

        string putp1 = ("T/Player1.txt");
        string putp2 = ("T/Player2.txt");

        public void perehod()
        {
            pictureBox1.Visible = false;pictureBox10.Visible = true;
            pictureBox2.Visible = false; pictureBox11.Visible = true;
            pictureBox3.Visible = false;pictureBox12.Visible = true;
            pictureBox4.Visible = false;pictureBox13.Visible = true;
            pictureBox5.Visible = false;pictureBox14.Visible = true;
            pictureBox6.Visible = false;pictureBox15.Visible = true;
            pictureBox7.Visible = false;pictureBox16.Visible = true;
            pictureBox8.Visible = false; pictureBox17.Visible = true;
            pictureBox9.Visible = false;pictureBox18.Visible = true;
            label1.Text = "Выберает Player 2";
        }

        public void game()
        {
            Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            Close();
        }

        //personage
        #region
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1,"1");
            perehod();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "2");
            perehod();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "3");
            perehod();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "4");
            perehod();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "5");
            perehod();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "6");
            perehod();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "7");
            perehod();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "8");
            perehod();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp1, "9");
            perehod();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "10");
            game();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "11");
            game();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "12");
            game();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "13");
            game();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "14");
            game();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "15");
            game();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "16");
            game();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "17");
            game();
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            File.WriteAllText(putp2, "18");
            game();
        }
        #endregion
    }
}
