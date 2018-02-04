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
using System.Media;

namespace Projekt_2
{
    public partial class Form8 : Form
    {
        string put = ("T/Glava3.txt");
        string[] text = new string[5];
        string staf = "";
        string slova = "";
        
        public Form8()
        {
            InitializeComponent();
            slova = File.ReadAllText(put, Encoding.Default);
            text = slova.Split('=');
            fon1.PlayLooping();
            pictureBox1.Visible = false;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            pictureBox2.Visible = false;
            pictureBox5.Visible = false;
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
        int n1 = 0;
        SoundPlayer fon1 = new SoundPlayer("M/fon5mel.wav");
        SoundPlayer spider = new SoundPlayer("M/spider.wav");
        SoundPlayer nap = new SoundPlayer("M/fongl3.wav");
        SoundPlayer fire = new SoundPlayer("M/fireball.wav");
        SoundPlayer air = new SoundPlayer("M/air.wav");
        SoundPlayer water = new SoundPlayer("M/Water.wav");
        SoundPlayer stone = new SoundPlayer("M/Rock.wav");

        private void label3_Click(object sender, EventArgs e)
        {
            n++;
            if (n == 1 && n1 == 0)
            {
                n1 = 1;
                BackgroundImage = System.Drawing.Image.FromFile("I/round2.1.jpg");
               n = 0; label3.Text = text[n];
                
            }
            else if (n == 1)
            {
                label2.Visible = true;
                pictureBox4.Visible = true;
                label3.Text = text[n];
            }
            if (n == 42 || n == 2 || n == 3 || n == 7 || n == 8 || n == 9 || n == 11 || n == 14 || n == 15 || n == 16 || (n >= 18 && n <=23) || (n >= 27 && n <= 31)||(n >= 33 && n <= 40) || (n>=43 && n<=52) || (n>=63 && n<=66) || (n >= 57 && n <= 61))
            {
                label3.Text = text[n];
            }
            if (n == 3 || n == 8 || n == 12 || n == 15 || n == 17 || n == 22 || n == 41 || n == 65 || n == 61)
            {
                pictureBox4.Visible = false;
                label2.Visible = false;
            }
            if (n == 7 || n == 11 || n == 14 || n == 16 || n == 21 || n == 29 || n == 43)
            {
                pictureBox4.Visible = true;
                label2.Visible = true;
            }
            if (n== 4)
            {
                pictureBox4.Visible = true;
                label2.Visible = true;
                pictureBox1.Visible = true;
                label3.Text = text[n];nap.PlayLooping();
            }
            if (n == 5)
            {
                
                Form9 f9 = new Form9();
                f9.ShowDialog();
                label3.Text = text[n];
                pictureBox1.Visible = false;
                staf = File.ReadAllText("T/Nimfa.txt");
                fon1.PlayLooping();
            }
            if (n == 6)
            {            
                label3.Text = text[n];
                pictureBox4.Visible = false;
                label2.Visible = false;
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
            }
           
            if (n == 10)
            {
                spider.Play();
                //pictureBox3.Visible = true;
                //label4.Visible = true;
                label4.Text = "Неизвестный";
                label3.Text = text[n];
            }
            if (n == 12)
            {
                label3.Text = text[n];
                pictureBox1.Image = Image.FromFile("I/pauk.png");
                pictureBox1.Visible = true;
            }
            if (n == 13)
            {
                label3.Text = text[n];
                label4.Visible = false;
                if (staf == "Воздуха")
                {
                    air.Play();
                }
                if (staf == "Огня")
                {
                    fire.Play();
                }
                if (staf == "Земля")
                {
                    stone.Play();
                }
                if (staf == "Вода")
                {
                    water.Play();
                }
                pictureBox5.Visible = false;
                pictureBox1.Visible = false;
            }
            if (n == 14)
            {
                fon1.PlayLooping();
            }
            if (n == 15)
            {
                label3.Text = text[n];
                pictureBox2.Visible = false;
            }
            if (n == 17)
            {
                label3.Text = text[n];
                BackgroundImage = Image.FromFile("I/round3.jpg");
            }
            if (n == 24)
            {
                label3.Text = text[n];
                BackgroundImage = Image.FromFile("I/glava3.jpg");
            }
            if (n == 25)
            {
                label3.Text = text[n];
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("I/snake.png");
                pictureBox1.Location = new Point(531,161);
            }
            if (n == 26)
            {
                label3.Text = text[n];
                pictureBox1.Visible = true;
                pictureBox3.Visible = true;
                label4.Visible = true;
            }
            if (n == 32)
            {
                label3.Text = text[n];
                label4.Text = "Глашатый";
            }
            if (n == 41)
            {
                label3.Text = text[n];
                pictureBox1.Visible = false;
                label4.Visible = false;
                pictureBox3.Visible = false;
                BackgroundImage = Image.FromFile("I/round3.jpg");
            }
            if (n == 43)
            {
                BackgroundImage = Image.FromFile("I/glava3.2.jpg");
                nap.PlayLooping();
                pictureBox2.Visible = true;
                pictureBox5.Visible = true;
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile("I/chimera.png");
                pictureBox3.Image = Image.FromFile("I/chimeraHad.png");
                pictureBox3.Visible = true;
                label4.Visible = true;
                label4.Text = "Азул";
            }
            if (n == 53)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox2.Visible = false;
                label3.Text = text[n];
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button2.Text = "Уничтожу мир и стану его властелином";
                button3.Text = "Убью дракона";
                button4.Text = "Спасу Мию от лап дракона";
            }
            if (n == 54)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox2.Visible = false;
                label3.Text = text[n];
                button2.Visible = true;
                button3.Visible = true;
                button2.Text = "Да";
                button3.Text = "Нет";
            }
            if (n == 55)
            {
                pictureBox1.Visible = false;
                pictureBox5.Visible = false;
                pictureBox2.Visible = false;
                label3.Text = text[n];
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button2.Text = "Я непереживу этого поэтому я убью себя";
                button3.Text = "Я уничтожу все";
                button4.Text = "Мне придется вернуться домой";
            }
            if (otv == "311"&& n == 56)
            {
                pictureBox1.Visible = true;
                pictureBox5.Visible = true;
                pictureBox2.Visible = true;
                label3.Text = text[n];
            }
            if (otv != "311" && n == 56)
            {
                n = 62;
                label3.Text = text[n];
            }
            if (n == 60)
            {
                pictureBox3.Visible = false;
                label4.Visible = false;
            }
            if (otv == "311" && n == 62)
            {
                label3.Text = "Нажмите для перехода в главное меню";
            }
            if (n == 67)
            {
                label3.Text = "Нажмите для перехода в начало опроса";
                n = 52;
                pictureBox1.Visible = true;
                pictureBox5.Visible = true;
                label4.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label2.Visible = true;
                otv = "";
                label3_Click(new object(), new EventArgs());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label5.Visible = true;
            button1.Visible = false;
            label3.Text = "Глава 3. Путь";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var = 1;
            test();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var = 2;
            test();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var = 3;
            test();
        }
        public void test()
        {
            otv = otv + Convert.ToString(var);
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            label3_Click(new object(), new EventArgs());
        }
        int var = 0;
        string otv = "";
    }
}