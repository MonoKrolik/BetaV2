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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            timer2.Stop();
            pictureBoxs[1] = pictureBox1;
            pictureBoxs[2] = pictureBox2;
            pictureBoxs[5] = pictureBox6;
            pictureBoxs[6] = pictureBox7;
            pictureBoxs[7] = pictureBox8;
            pictureBoxs[8] = pictureBox9;
            pictureBoxs[9] = pictureBox10;
            pictureBoxs[10] = pictureBox11;
            pictureBoxs[11] = pictureBox12;
            pictureBoxs[12] = pictureBox13;
            pictureBoxs[13] = pictureBox14;
            pictureBoxs[16] = pictureBox17;
            pictureBoxs[17] = pictureBox18;
            pictureBoxs[18] = pictureBox19;
            pictureBoxs[19] = pictureBox20;
            pictureBoxs[20] = pictureBox21;
            pictureBoxs[24] = pictureBox25;
            buttons[1] = button1;
            buttons[2] = button2;
            buttons[5] = button5;
            buttons[6] = button6;
            buttons[8] = button8;
            buttons[9] = button9;
            buttons[10] = button10;
            buttons[11] = button11;
            buttons[12] = button12;
            buttons[13] = button13;
            buttons[16] = button16;
            buttons[17] = button17;
            buttons[19] = button19;
            buttons[18] = button18;
            buttons[20] = button20;
            buttons[24] = button24;
            restart();
        }

        int n = 1;
        int b = 1;
        bool p1 = true;
        bool nps = false;
        int hod = 0;
        int q = 1;

        public void restart()
        {
            n = 1;
            b = 1;
            p1 = true;
            nps = false;
            hod = 0;
            q = 1;
            buttonEFalse();
            n = 1;
            pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
            buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b + 4].Enabled = true;
            n = 10;
            pictureBox26.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
        }

        public void buttonEFalse()
        {
            foreach (var x in buttons)
            {
                try
                {
                    x.Enabled = false;
                }
                catch (Exception)
                { }

            }
            //buttons[1]
            //buttons[2].Enabled = false;
            //buttons[5].Enabled = false;
            //buttons[6].Enabled = false;
            //buttons[8].Enabled = false;
            //buttons[9].Enabled = false;
            //buttons[10].Enabled = false;
            //buttons[11].Enabled = false;
            //buttons[12].Enabled = false;
            //buttons[13].Enabled = false;
            //buttons[16].Enabled = false;
            //buttons[17].Enabled = false;
            //buttons[18].Enabled = false;
            //buttons[19].Enabled = false;
            //buttons[20].Enabled = false;
            //buttons[24].Enabled = false;
        }
        public void buttonVFalse()
        {
            foreach (var x in buttons)
            {
                try
                {
                    x.Visible = false;
                }
                catch (Exception)
                {

                }
                
            }
        }
        public void buttonETrue()
        {
            foreach (var x in buttons)
            {
                try
                {
                    x.Visible = true;
                }
                catch (Exception)
                {}
                
            }
        }
        public void Stop()
        {
            buttonETrue();
            timer2.Stop();
            zad = 0;
        }
        public void Staf()
        {
            Random r = new Random();
            int nStaf = r.Next(0,8);
            int nimfa = r.Next(0,5);
            string puth = "T/Staf.txt";
            switch (nStaf)
            {
                case 1:File.WriteAllText(puth,"Лечение=");break;
                case 2: File.WriteAllText(puth, "Усиление="); break;
                case 3: File.WriteAllText(puth, "Огня="); break;
                case 4: File.WriteAllText(puth, "Воздуха="); break;
                case 5: File.WriteAllText(puth, "Земля="); break;
                case 6: File.WriteAllText(puth, "Вода="); break;
                case 7: File.WriteAllText(puth, "Тиара="); break;
                default:
                    break;
            }
            switch (nimfa)
            {
                case 1: File.AppendAllText(puth, "Огня"); break;
                case 2: File.AppendAllText(puth, "Воздуха"); break;
                case 3: File.AppendAllText(puth, "Земля"); break;
                case 4: File.AppendAllText(puth, "Вода"); break;
                default:
                    break;
            }
        }

        public void NPS(int n)
        {
            buttonVFalse();
            hod++;
            if (nps == true && hod <= 12)
            {
                if (hod == 1)
                {
                    q = 6;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 2)
                {
                    q = 5;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }

                if (hod == 3)
                {
                    q = 9;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 4)
                {
                    q = 13;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 5)
                {
                    q = 17;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 6)
                {
                    q = 18;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 7)
                {
                    q = 19;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 8)
                {
                    q = 20;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 9)
                {
                    q = 16;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 10)
                {
                    q = 12;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 11)
                {
                    q = 11;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                }
                if (hod == 12)
                {
                    q = 10;
                    pictureBox26.Location = new Point(pictureBoxs[q].Location.X + pictureBoxs[q].Width / 4, pictureBoxs[q].Location.Y + pictureBoxs[q].Height / 4);
                    p1 = true;
                    nps = false;
                    hod = 0;
                }
            }
            if (q == n)
            {
                timer1.Stop();
                MessageBox.Show("PIDOR YOU ATE");
            }
        }

        PictureBox[] pictureBoxs = new PictureBox[25];
        Button[] buttons = new Button[25];

        //buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b - 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;

        private void button1_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 1; b = n;
                buttonEFalse();
            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b + 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
                zad = 0;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                nps = true;
                p1 = false;
                NPS(n);
                n = 2; b = n;
                timer2.Start(); buttonEFalse();
            }
            else if (zad == 3)
            {
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
                zad = 0;
                buttons[b - 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b].Enabled = true;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 5; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); n = 6; nps = true;
                p1 = false;
                NPS(n); b = n; buttonEFalse();


            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b - 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); n = 8; nps = true;
                p1 = false;
                NPS(n); b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
               File.WriteAllText("Byte.txt","");
                zad = 0;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 9; b = n; buttonEFalse();
            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
                zad = 0;
                Staf();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); n = 10; nps = true; b = n;
                p1 = false;
                NPS(n); buttonEFalse();



            }
            if (zad == 3)
            {
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0; buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b - 1].Enabled = true; buttons[b - 4].Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 11; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b - 1].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 12; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b - 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 13; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 16; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 17; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 18; b = n; buttonEFalse();



            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b - 1].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);


                zad = 0;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 19; b = n; buttonEFalse();

            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b + 1].Enabled = true; buttons[b - 1].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
                zad = 0;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 20; b = n; buttonEFalse();

            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b - 1].Enabled = true; buttons[b + 4].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
                zad = 0;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (p1 == true && zad != 3)
            {
                timer2.Start(); nps = true;
                p1 = false;
                NPS(n); n = 24; b = n; buttonEFalse();

            }
            if (zad == 3)
            {
                buttons[b].Enabled = true; buttons[b - 4].Enabled = true;
                pictureBox3.Location = new Point(pictureBoxs[n].Location.X + pictureBoxs[n].Width / 4, pictureBoxs[n].Location.Y + pictureBoxs[n].Height / 4);
                zad = 0;
                Hide();
                Close();
            }
        }

        int zad = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (q == n)
            {
                timer1.Stop();
                MessageBox.Show("PIDOR YOU ATE");
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            zad++;
            if (zad == 3 && b == 1)
            {
                button1_Click(new object(), new EventArgs());Stop();       
            }
            if (zad == 3 && b == 2)
            {
                button2_Click(new object(), new EventArgs());Stop();
            }
            if (zad == 3 && b == 5)
            {               
                button5_Click(new object(), new EventArgs());Stop();                
            }
            if (zad == 3 && b == 6)
            {
                button6_Click(new object(), new EventArgs());Stop();               
            }
            if (zad == 3 && b == 8)
            {
                
                button8_Click(new object(), new EventArgs());Stop();               
            }
            if (zad == 3 && b == 9)
            {
                button9_Click(new object(), new EventArgs());Stop();
            }
            if (zad == 3 && b == 10)
            {
                button10_Click(new object(), new EventArgs());Stop();
            }
            if (zad == 3 && b == 11)
            {
                button11_Click(new object(), new EventArgs());Stop();
            }
            if (zad == 3 && b == 12)
            {
                button12_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 13)
            {
                button13_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 16)
            {
                button16_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 17)
            {
                button17_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 18)
            {
                button18_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 19)
            {
                button19_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 20)
            {
                button20_Click(new object(), new EventArgs()); Stop();
            }
            if (zad == 3 && b == 24)
            {
                button24_Click(new object(), new EventArgs()); Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            restart();
        }
    }
}
