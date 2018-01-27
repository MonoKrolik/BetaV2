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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            p1 = true;
            p1lose = 0;
            p1win = 0;
            p2win = 0;
            p2lose = 0;
            label12.Text = "Win: "+p1win;
            label13.Text = "Lose: "+p1lose;
            label14.Text = "Draw: "+p1noLW;
            label15.Text = "Win: "+p2win;
            label16.Text = "Lose: "+p2lose;
            label17.Text = "Draw: "+p2noLW;
            hod();

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

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox10.Visible = false;
            pictureBox11.Visible = false;
            pictureBox12.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;

            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;

            persp1 = Convert.ToInt32(File.ReadAllText(putp1,Encoding.Default));
            persp2 = Convert.ToInt32(File.ReadAllText(putp2,Encoding.Default));

            labels[0] = label1;
            labels[1] = label2;
            labels[2] = label3;
            labels[3] = label4;
            labels[4] = label5;
            labels[5] = label6;
            labels[6] = label7;
            labels[7] = label8;
            labels[8] = label9;

            personag();
        }

        //metodi
        #region
        public void hod()
        {
            if (p1 == true)
            {
                label18.BackColor = Color.Red;
                label18.ForeColor = Color.White;
                label18.Text = "Ходит Player 1";

            }
            else if (p2 == true)
            {
                label18.BackColor = Color.Blue;
                label18.ForeColor = Color.White;
                label18.Text = "Ходит Player 2";
            }
        }

        public void restart()
        {
            

            labels[0] = label1;


            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            p1 = true;
            p2 = false;
            per = false;
            hod();
            timer1.Start();
        }

        public void personag()
        {
             
            if (persp1 == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 2)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 3)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 4)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 5)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 6)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 7)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
            }
            if (persp1 == 8)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
            }
            if (persp1 == 9)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
            }
            if (persp2 == 10)
            {
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 11)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 12)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 13)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 14)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 15)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = true;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 16)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
                pictureBox18.Visible = false;
            }
            if (persp2 == 17)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = true;
                pictureBox18.Visible = false;
            }
            if (persp2 == 18)
            {
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                pictureBox15.Visible = false;
                pictureBox16.Visible = false;
                pictureBox17.Visible = false;
                pictureBox18.Visible = true;
            }
        }
        #endregion

        //peremen
        #region
        bool per = false;
        bool p1 = false;
        bool p2 = false;
        int p1win = 0;
        int p1lose = 0;
        int p1noLW = 0;
        int p2win = 0;
        int p2lose = 0;
        int p2noLW = 0;
        string putp1  = ("T/Player1.txt");
        string putp2 = ("T/Player2.txt");
        int persp1 = 0;
        int persp2 = 0;
        Label[] labels = new Label[9];
        #endregion

        //x and o
        #region

        private void commonLabel_Click(object sender, EventArgs e)
        {
            Label currentLabel = sender as Label;
            if(p1 == true && currentLabel.Text != "O")
            {
                currentLabel.Text = "X";
                p2 = true;
                p1 = false;
            }
            else if (p2 == true && currentLabel.Text != "X")
            {
                currentLabel.Text = "O";
                p1 = true;
                p2 = false;
            }
            hod();
        }
        #endregion

        //restart
        private void button1_Click(object sender, EventArgs e)
        {
            restart();
        }

        //win and lose and Draw
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Text == "X" && label2.Text == "X" && label3.Text == "X" || label1.Text == "X" && label5.Text == "X" && label9.Text == "X" || label1.Text == "X" && label4.Text == "X" && label7.Text == "X" || label2.Text == "X" && label5.Text == "X" && label8.Text == "X" || label3.Text == "X" && label5.Text == "X" && label7.Text == "X" || label3.Text == "X" && label6.Text == "X" && label9.Text == "X" || label4.Text == "X" && label5.Text == "X" && label6.Text == "X" || label7.Text == "X" && label8.Text == "X" && label9.Text == "X")
            {
                timer1.Stop();
                MessageBox.Show("Победил 1 игрок");
                p1win = p1win + 1;
                p2lose = p2lose + 1;
                label12.Text = "Win: "+p1win;
                label16.Text = "Lose: "+p2lose;
                restart();
            }
            if (label1.Text == "O" && label2.Text == "O" && label3.Text == "O" || label1.Text == "O" && label5.Text == "O" && label9.Text == "O" || label1.Text == "O" && label4.Text == "O" && label7.Text == "O" || label2.Text == "O" && label5.Text == "O" && label8.Text == "O" || label3.Text == "O" && label5.Text == "O" && label7.Text == "O" || label3.Text == "O" && label6.Text == "O" && label9.Text == "O" || label4.Text == "O" && label5.Text == "O" && label6.Text == "O" || label7.Text == "O" && label8.Text == "O" && label9.Text == "O")
            {
                timer1.Stop();
                MessageBox.Show("Победил 2 игрок");
                p2win = p2win + 1;
                p1lose = p1lose + 1;
                label15.Text = "Win: "+p2win;
                label13.Text = "Lose: "+p1lose;
                restart();
            }
            else if (label1.Text != "" && label2.Text != "" && label3.Text != "" && label4.Text != "" && label5.Text != "" && label6.Text != "" && label7.Text != "" && label8.Text != "" && label9.Text != "")
            {
                timer1.Stop();
                MessageBox.Show("Ничья");
                p1noLW = p1noLW + 1;
                p2noLW = p2noLW + 1;
                label14.Text = "Draw: "+p1noLW;
                label17.Text = "Draw: "+p1noLW;
                restart();
            }
        }

        //exit
        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        //personaji
        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            Close();
        }
    }
}