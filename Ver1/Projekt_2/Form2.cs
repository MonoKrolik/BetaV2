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
    public partial class Form2 : Form
    {
        public Form2()
       
        {
            InitializeComponent();
            //первоначальные характеристики компонентов
            #region
            timer1.Stop();
            //misheni
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox7.BackColor = Color.Transparent;
            pictureBox8.BackColor = Color.Transparent;
            pictureBox9.BackColor = Color.Transparent;
            pictureBox10.BackColor = Color.Transparent;
            pictureBox11.BackColor = Color.Transparent;
            pictureBox12.BackColor = Color.Transparent;
            pictureBox13.BackColor = Color.Transparent;
            pictureBox14.BackColor = Color.Transparent;
            //nevinnie
            pictureBox15.BackColor = Color.Transparent;
            pictureBox16.BackColor = Color.Transparent;
            pictureBox17.BackColor = Color.Transparent;
            pictureBox18.BackColor = Color.Transparent;

            label1.BackColor = Color.Transparent;

            picktureFalse();

            button2.Enabled = false;

            label();

            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;
            label13.BackColor = Color.Transparent;
            label14.BackColor = Color.Transparent;
            label15.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label17.BackColor = Color.Transparent;
            label18.BackColor = Color.Transparent;
            label19.BackColor = Color.Transparent;
            label20.BackColor = Color.Transparent;
            label21.BackColor = Color.Transparent;
            #endregion
            MessageBox.Show("Вы только что ставший войн. Ваше племя Орла голодает и вас отправляют на охоту на бизонов что бы добыть мяса.");
        }

        int time = 2400;
        int round = 1;
        int n = 0;
        int Nom = 0;
        int f = 0;
        int val = 100;
        int niv = 0;

        //методи
        #region
        public void label()
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label21.Visible = false;
        }

        public void picktureFalse()
        {
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
        }

        public void restart()
        {
            MessageBox.Show("Тебя изгнали или загрызли. Начни все сначало. )");
            label();
            picktureFalse();
            timer1.Stop();
            time = 2400;
            round = 1;
            n = 0;
            Nom = 0;
            f = 0;
            val = 100;
            niv = 0;
            button1.Enabled = true;
            button2.Enabled = false;
            progressBar1.Value = 0;
            label3.Text = "Раунд: " + round;
        }

        public void bonusOTround()
        {
            if (round == 2)
            {
                f = f + 3;
            }
            if (round == 3)
            {
                f = f + 5;
            }
            if (round == 4)
            {
                f = f + 10;
            }
        }
        #endregion

        //прогресс
        #region
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            label10.Visible = true;
            f = f + 7;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox5.Visible = false;

            bonusOTround();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label7.Visible = true;
            f = f - 10;
            n = n - 5;

            pictureBox2.Visible = false;


            bonusOTround();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            label15.Visible = true;
            f = f + 2;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox3.Visible = false;

            bonusOTround();
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            label8.Visible = true;
            f = f - 10;
            n = n - 5;

            pictureBox4.Visible = false;

            bonusOTround();
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            label11.Visible = true;
            f = f + 5;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox8.Visible = false;

            bonusOTround();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            label20.Visible = true;
            f = f - 10;
            n = n - 5;

            pictureBox6.Visible = false;

            bonusOTround();
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            label18.Visible = true;
            f = f + 2;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox7.Visible = false;

            bonusOTround();
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            label17.Visible = true;
            f = f + 4;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox9.Visible = false;

            bonusOTround();
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            label9.Visible = true;
            f = f + 5;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox10.Visible = false;

            bonusOTround();
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            label19.Visible = true;
            f = f + 5;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox11.Visible = false;

            bonusOTround();
        }
        private void pictureBox12_Click(object sender, EventArgs e)
        {
            label5.Visible = true;
            f = f + 20;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox12.Visible = false;

            bonusOTround();
        }
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            f = f + 20;
            n = n + 5;
            progressBar1.Value = n;

            pictureBox13.Visible = false;

            bonusOTround();
        }
        private void pictureBox18_Click(object sender, EventArgs e)
        {
            label6.Visible = true;
            restart();
        }
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            label14.Visible = true;
            restart();
        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            label12.Visible = true;
            restart();
        }
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            label16.Visible = true;
            n = n + 15;
            progressBar1.Value = n;

            pictureBox17.Visible = false;
        }
        private void pictureBox14_Click(object sender, EventArgs e)
        {
            label13.Visible = true;
            n = n - 20;

            pictureBox14.Visible = false;
        }
        private void Form2_Click(object sender, EventArgs e)
        {
            label21.Visible = true;
            f = f - 5;
        }
        #endregion

        //мишени
        private void timer1_Tick(object sender, EventArgs e)
        {

            Random r = new Random();
            Nom = r.Next(0, 15);
            niv = r.Next(-1, 4);
            if (Nom == 1 || niv == 1)
            {
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox16.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 2)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 3 || niv == 3)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 4)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 5 || niv == 3)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox18.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 6)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 7 || niv == 2)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 8)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 9)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 10)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = true;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 11 || niv == 0)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = true;
                pictureBox13.Visible = false;
                pictureBox15.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 12)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 13)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                pictureBox17.Visible = false;
                label();
            }
            if (Nom == 14)
            {
                pictureBox3.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;
                pictureBox17.Visible = true;
                label();
            }
            label();
        }

        //chet
        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = "Cчет: " + f;
            label1.Text = "Прогресс: " + n + "/" + "400";
            if (progressBar1.Value == val && val != 400)
            {
                label();
                timer2.Stop();
                timer1.Stop();
                button2.Enabled = true;
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
                MessageBox.Show("Конец Раунда");
            }
            if (progressBar1.Value == 400)
            {
                label();
                timer2.Stop();
                timer1.Stop();
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
                MessageBox.Show("Конец игры ты молодец " + " Твой Счет: " + f);
                button1.Enabled = true;
                progressBar1.Value = 0;
                time = 2400;
                round = 1;
                n = 0;
                Nom = 0;
                f = 0;
                val = 100;
                niv = 0;

            }

        }

        //start
        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "Раунд: " + round;
            timer1.Start();
            button1.Enabled = false;
        }

        // round 
        private void button2_Click(object sender, EventArgs e)
        {
            val = val + 100;
            time = time - 600;
            if (time >= 600)
            {
                timer2.Start();
                round = round + 1;
                timer1.Interval = time;
            }
            label3.Text = "Раунд: " + round;
            timer1.Start();
            button2.Enabled = false;
            pictureBox15.Visible = false;
            pictureBox16.Visible = false;
            pictureBox17.Visible = false;
            pictureBox18.Visible = false;
            pictureBox14.Visible = false;
            pictureBox2.Visible = false;
            pictureBox4.Visible = false;
            pictureBox6.Visible = false;
        }

        //exit
        private void button3_Click(object sender, EventArgs e)
        {
            string put1 = ("T/Результаты за тир.txt");
            string res = "Счет за игру " + f.ToString() + Environment.NewLine + "Раунд " + round.ToString();
            File.AppendAllText(put1, res);
            Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            Close();
        }

        //Правила
        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Игра состоит из 4 раундов. После определённого прогресса животные будут появляться и исчезать быстре. Можно стрелять только по бизонам. При выстреле в льва он нападет на вас и заргызет. При убийстве соплеменника вас изгонят. При убийстве вашего партнера (сидящий рядом орел ) ваш прогресс уменьшится. При убийстве пришельца из будушего ваш прогресс увеличится. При промохе у вас отнимятся очки. При убийстве священного животного у вас отнимят немного очков и прогресса. Удачной игры.");
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

