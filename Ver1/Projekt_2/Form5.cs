using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Projekt_2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            b = 100;
            b1 = b;
            progressBar1.Value = b;
            progressBar2.Value = hp;
            progressBar2.Visible = false;
            timer1.Stop();
            timer2.Stop();
            label1.Text = b + "/" + b;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            label2.BackColor = Color.White;
            label4.BackColor = Color.White;
            label1.BackColor = Color.White;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            progressBar1.Visible = false;
            label1.Visible = false;
            label2.Text = "Генри";
            label4.Text = "Неизвестный";
            label2.Visible = false;
            label4.Visible = false;
            label3.Visible = false;
            label5.Visible = false;
            slova = File.ReadAllText(put,Encoding.Default);
            text = slova.Split('=');
            label3.Text = text[0];
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            timer3.Stop();
        }

        string put = ("T/Glava2.txt");
        string[] text = new string[5];
        string slova = "";
        int b = 100;
        int b1 = 100;
        int nom = 0;
        int dam = 20;
        int damage = 0;
        int n = 0;
        int hp = 350;
        int var = 0;
        int inter = 0;
        SoundPlayer sf = new SoundPlayer("M/sword1.wav");
        SoundPlayer fon1 = new SoundPlayer("M/fon3.wav");
        SoundPlayer voi = new SoundPlayer("M/Voi.wav");
        SoundPlayer fon2 = new SoundPlayer("M/Night.wav");
        SoundPlayer rasvet = new SoundPlayer("M/rasvet.wav");
        SoundPlayer fon3 = new SoundPlayer("M/death.wav");
        SoundPlayer trev = new SoundPlayer("M/fonnap.wav");

        public void vragi()
        {
            nom++;
            //1 raund
            #region
            if (nom == 1 )
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("I/hoblin.png");
                b = 100;
                progressBar1.Value = b;
            }
            if (nom == 2)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("I/volk.png");
                dam = 25;
                b = 250; b1 = b;
                progressBar1.Value = b;
            }
            if (nom == 3)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("I/ent.png");
                dam = 30;
                b = 300; b1 = b;
                progressBar1.Value = b;
            }
            if (nom == 4)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile("I/elif.png");
                dam = 40;
                b = 800; b1 = b;
                progressBar1.Value = b;
            }
            #endregion

           
        }

        //Дамаг главного персонажа
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            sf.Play();
            b = b - dam;
            label1.Text = b + "/" + b1;
        }

        //Система подсчета урона и замена врага.
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (b >= 0)
            {
                progressBar1.Value = b;
                label1.Text = b + "/" + b1;
            }
            if (b <= 0)
            {
                label1.Text = b + "/" + b1;
                pictureBox1.Visible = false;
                label1.Visible = false;
                progressBar1.Visible = false;
                label2.Visible = true;
                pictureBox4.Visible = true;
                label3.Visible = true;
                label5.Visible = true;
                timer2.Stop();
                progressBar2.Visible = false;
                try
                {
                    label3.Text = text[n];
                }
                catch (Exception)
                {
                    throw;
                }
                progressBar1.Value = b1;
                timer1.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label5.Visible = true;
            button1.Visible = false;
            label3.Text = "Глава 2. Начало пути";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            n++;
            if (n == 1)
            {
                fon1.PlayLooping();
                label2.Visible = true;
                BackgroundImage = System.Drawing.Image.FromFile("I/round1.jpg");
                pictureBox4.Visible = true;
                label3.Text = text[n-1]+Environment.NewLine + text[n];
            }
            if (n == 2)
            {
                pictureBox3.Visible = true;
                label4.Visible = true;
                label3.Text = text[n];
            }
            if (n == 3)
            {
                label4.Text = "Гоблин";
                label3.Text = text[n];
            }
            if (n == 4)
            {
                label3.Text = text[n];
            }
            if (n == 5)
            {
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
                label1.Visible = true;
                progressBar1.Visible = true;
                timer1.Start();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
                progressBar2.Visible = true;
                timer2.Start();
                vragi();
            }
            if (n == 6)
            {
                fon1.PlayLooping();
                label3.Text = text[n];
            }
            if (n == 7)
            {
                
               label3.Text = text[n];
            }
            if (n == 8)
            {
                pictureBox4.Visible = false;
                label2.Visible = false;
                
                label3.Text = text[n];
            }
            if (n == 9)
            {
                pictureBox4.Visible = true;
                label2.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
                pictureBox3.Image = System.Drawing.Image.FromFile("I/volkhad.png");
                label4.Text = "Неизвестный";
                label3.Text = text[n];
                voi.Play();
            }
            if (n == 10)
            {
                fon1.PlayLooping();
                label3.Text = text[n];
            }
            if (n == 11)
            {
                progressBar1.Maximum = 250;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
                label1.Visible = true;
                progressBar1.Visible = true;
                timer1.Start();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                timer2.Start();
                button1.Visible = false;
                progressBar2.Visible = true;
                vragi();
            }
            if (n == 12)
            {
                fon1.PlayLooping();
                label3.Text = text[n];
            }
            if (n == 13)
            {
                BackgroundImage = System.Drawing.Image.FromFile("I/dark_forest_006-1024x576.jpg");
                fon2.PlayLooping();
                label3.Text = text[n];
            }
            if (n == 14 || n == 15 || n == 17)
            {
                label3.Text = text[n];
            }
            if (n == 16)
            {
                BackgroundImage = System.Drawing.Image.FromFile("I/round1.jpg");
                rasvet.Play();
                label3.Text = text[n];
            }
            if (n == 18)
            {
                trev.PlayLooping();
                label3.Text = text[n];
            }
            if (n == 19)
            {
                progressBar1.Maximum = 300;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
                label1.Visible = true;
                progressBar1.Visible = true;
                progressBar2.Visible = true;
                timer1.Start();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                timer2.Start();
                button1.Visible = false;
                vragi();
            }
            if (n == 20)
            {
                fon1.PlayLooping();
                label3.Text = text[n];
            }
            if (n == 21)
            {
                BackgroundImage = System.Drawing.Image.FromFile("I/round2.jpg");
                label3.Text = text[n];
            }
            if (n == 22)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                label3.Text = text[n];
            }
            if (n == 23)
            {
                label3.Text = text[n];
                pictureBox3.Visible = true;
                pictureBox3.Image = System.Drawing.Image.FromFile("I/nimfa.png");
                label4.Visible = true;
                label4.Text = "Нимфа";
            }
            if (n >=24 && n<=29)
            {
                label3.Text = text[n];
            }
            if (n == 30)
            {
                label3.Text = text[n];
                timer3.Start();
            }
            if (n == 31 && var == 1)
            {
                progressBar1.Maximum = 800;
                pictureBox4.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                label1.Visible = true;
                progressBar1.Visible = true;
                progressBar2.Visible = true;
                timer1.Start();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                button1.Visible = false;
                timer2.Start();
                vragi();
            }
            if (n == 32 && var == 1)
            {
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
                label3.Text = text[n];
            }
            if ((n == 33 || n == 34) && var == 1)
            {
                label3.Text = text[n];
            }
            if (n == 35 && var == 1)
            {
                pictureBox3.Visible = false;
                label4.Visible = false;
                label3.Text = text[n];
            }
            if (n == 36 && var == 1)
            {
                pictureBox6.Visible = false;
                label3.Text = text[n];
            }
            if (n == 37 && var == 1)
            {
                pictureBox5.Visible = false;
                label2.Visible = false;
                pictureBox4.Visible = false;

                label3.Text = text[n];
                button5.Visible = true;
            }
            if (n == 31 && var == 2)
            {
                n = 38;
                label3.Text = text[n];
            }
            if (n == 39 && var ==2)
            {
                pictureBox4.Visible = false;
                label2.Visible = false;
                label3.Text = text[n];
            }
            if (n == 40 && var == 2)
            {
                pictureBox2.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox3.Visible = false;
                label4.Visible = false;
                label3.Text = text[n];
            }
            if (n == 41 && var == 2)
            {
                BackgroundImage = System.Drawing.Image.FromFile("I/roundfinal.jpg");
                label3.Text = text[n];
                fon3.PlayLooping();
            }
            if (n==42 && var == 2)
            {
                label3.Text = text[n];
                button4.Visible = true;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            hp = hp - 10;
            if (var == 0)
            {
                damage = damage + 10;
            }
            if (hp>=0)
            {
                progressBar2.Value = hp;
            }
            else if (hp <= 0)
            {
                timer2.Stop();
                var = 3;
                label3.Visible = true;
                label5.Visible = true;
                pictureBox5.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = false;
                progressBar1.Visible = false;
                progressBar2.Visible = false;
                label1.Visible = false;
                label3.Text = text[42];
                button4.Visible = true;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            inter++;
            if (inter == 4)
            {
                pictureBox6.Visible = false;
                pictureBox5.Visible = false;
                button2.Visible = true;
                button3.Visible = true;
                timer3.Stop();
                inter = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var = 1;
            button2.Visible = false;
            n = 30;
            button3.Visible = false;
            pictureBox6.Visible = true;
            pictureBox5.Visible = true;
            label3_Click(new object(), new EventArgs());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var = 2;
            button2.Visible = false;
            button3.Visible = false;
            pictureBox6.Visible = true;
            pictureBox5.Visible = true;
            n = 30;
            label3_Click(new object(), new EventArgs());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b = b1;
            hp = 300-damage;
            progressBar2.Value = hp;
            n = 29;
            label3_Click(new object(), new EventArgs());
            button4.Visible = false;
            var = 0;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            label4.Visible = true;
            label2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fon1.Stop();
            fon2.Stop();
            fon3.Stop();
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }
    }
}