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

namespace Projekt_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
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

            label2.Visible = false;
            label4.Visible = false;
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
            label2.Text = "Генри";
            label4.Text = "Мия";
            BackColor = Color.Black;
            button1.Enabled = false;
            
        }

        SoundPlayer fon1 = new SoundPlayer("M/Fon.wav");
        SoundPlayer fon2 = new SoundPlayer("M/fonnap.wav");
        SoundPlayer dragon = new SoundPlayer("M/dragon.wav");
        SoundPlayer paden = new SoundPlayer("M/paden.wav");
        SoundPlayer udar = new SoundPlayer("M/udar.wav");
        int shag = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {
            shag++;
            if (shag == 1)
            {
                label2.BackColor = Color.White;
                label4.BackColor = Color.White;
                BackgroundImage = System.Drawing.Image.FromFile("I/start.jpg");
                label3.Visible = true;
                label3.Text = "Неизвестный: Меня зовут Генри, на данный момент мне 57лет. Я герой спасший принцессу из лап стража пустыни. И сейчас детишки я поведаю вам эту историю которая началась 40 лет назад.";
            }
            if (shag == 2)
            {
                label3.Text = "Генри: Тогда мне было всего 17 лет, я  ждал принцессу Мию на опушке леса что бы сделать ей предложение. Тогда то все и началось!";
            }
            if (shag == 3)
            {
                label2.Text = "Генри";
                label2.Visible = true;
                pictureBox2.Visible = true;
                pictureBox1.Visible = true;
                label3.Text = ("Генри: Решено! Здесь я признаюсь ей. Я долго к этому готовился. Надеюсь она согласится.");
            }
            if (shag == 4)
            {
                label4.Visible = true;
                pictureBox3.Visible = true;
                pictureBox4.Visible = true;
                label3.Text = "Мия: Генри!\nГенри: Мия!\n(Смеются от счастья) ";
            }
            if (shag == 5)
            {
                label3.Text = "Мия: Я так счаслива тебя видеть!\nГенри: Ты все так же прекрасна.";
            }
            if (shag == 6)
            {
                label3.Text = "Генри: Хочет ли моя принцесса куда нибудь пойти?\nМия: Я бы хотела увидеть то место, о котором ты постоянно упоменаешь.";
            }
            if (shag == 7)
            {
                label3.Text = "Генри: Перед тем как мы туда пойдем, ааа , я бы хотел тебе коечто сказать.\nМия: Что же это? Это очень важно?";
            }
            if (shag == 8)
            {
                label3.Text = "Генри: Это очень важно для меня, надеюсь что это будет важным и для тебя.\nМия: Говори же тогда быстрее.";
            }
            if (shag == 9)
            {
                label3.Text = "Генри: Мия. Мы знакомы с тобой всего год, но этот год был самым счасливым в моей жизни и надеюсь что и для тебя то же.";
            }
            if (shag == 10)
            {
                label3.Text = "Генри: Хоть я и не богат и моя семья не настолько благородна как твоя, но я все же хочу спросить тебя. (встает на одно колено и достает из своего кармана коробочку)";
            }
            if (shag == 11)
            {
                label3.Text = "Генри: Выйдиешь ли ты за меня Мия?(Оба краснеют)\nМия: Генри? К-к-конечно! Я-я-я так счаслива Генри!";
            }
            if (shag == 12)
            {
                dragon.Play();
                label3.Text = "Генри: Что это было!?";
            }
            if (shag == 13)
            {
                fon2.Play();
                label3.Text = "Мия: (встревоженно говорит) Генри что это? Мне страшно. Генри вон там! Смотри! Это дракон!";
            }
            if (shag == 14)
            {
                label3.Text = "Генри: Мия бежим быстрее к блокпосту!";
                pictureBox1.Image = System.Drawing.Image.FromFile("I/glavperzad.png");
                pictureBox4.Image = System.Drawing.Image.FromFile("I/glavper.png");
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label2.Visible = false;
                label4.Visible = false;
            }
            if (shag == 15)
            {
                paden.Play();
            }
            if (shag == 16)
            {
                fon2.Play();
                pictureBox5.Visible = true;
                pictureBox1.Image = System.Drawing.Image.FromFile("I/glavperfront.png");
                pictureBox4.Image = System.Drawing.Image.FromFile("I/glavfront.png");
                pictureBox3.Visible = true;
                pictureBox2.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
                label3.Text = "Генри: Мия встань за меня!\nМия: Но!\nГенри: Быстрее!!";
            }
            if (shag == 17)
            {
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                pictureBox6.Visible = false;
                pictureBox4.Visible = false;
                pictureBox1.Visible = false;


            }
            if (shag == 18)
            {
                label4.Text = "Дракон";
                label2.Text = "Мия";
                pictureBox2.Image = System.Drawing.Image.FromFile("I/glavhad.png");
                pictureBox3.Image = System.Drawing.Image.FromFile("I/dragonhad.png");
                label3.Text = "Дракон: Я пришел забрать тебя дитя.\nМия: Но зачем я тебе?\nДракон: Тебе необязательно этого знать! (Влезает Генри)";


            }
            if (shag == 19)
            {
                dragon.Play();

            }
            if (shag == 20)
            {
                fon2.Play();
                label4.Text = "Генри";
                label2.Text = "Дракон";
                pictureBox2.Image = System.Drawing.Image.FromFile("I/dragonhad.png");
                pictureBox3.Image = System.Drawing.Image.FromFile("I/glavperhad.png");
                label3.Text = "Дракон: Не меншайся мне жалкий человек!";

            }
            if (shag == 21)
            {
                udar.Play();
                label3.Text = "Генри: Агхт! (Генри отлетает на пол метра)\nДракон: Мы уходим!";
                pictureBox7.Visible = false;
            }
            if (shag == 22)
            {
                fon2.PlayLooping();
                pictureBox8.Visible = false;
                pictureBox6.Visible = true;
            }
            if (shag == 23)
            {
                pictureBox6.Visible = false;
                pictureBox2.Image = System.Drawing.Image.FromFile("I/glavhad.png");
                label2.Text = "Мия";
                pictureBox5.Visible = false;
                label3.Text = "(Дракон схватил Мию и начал взлетать) Мия: Генри! НЕЕЕЕЕТ!!! Генрии!\nГенри: (сплевывая кровь) Мия! Я спасу тебя! Агхт (Генри теряет сознание)";
            }
            if (shag == 24)
            {
                label2.Visible = false;
                label4.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                label3.Text = "Деревенский увидел дракона и побежал быстрее в деревню. Спустя 3 часа деревенские пришли на место этого проиществия. Подняли почти живого Генри и унесли его в деревню.";
            }
            if (shag == 25)
            {
                label2.Text = "Деревенский1";
                label4.Text = "Деревенский2";
                label3.Text = "Деревенский1: Несите осторожней! Он ранен.\nДеревенский2: Глава это и вправдо был дракон!? Неужели? Они разве не выдумка!?";
                label2.Visible = true;
                label4.Visible = true;
            }
            if (shag == 26)
            {
                label2.Text = "Деревенский3";
                label3.Text = "Деревенский3: Я же говорил что они существуют!";
            }
            if (shag == 27)
            {
                label2.Text = "Деревенский1";
                label4.Visible = false;
                label3.Text = "Деревенский1: А ну молчать! И несите осторожней. (Прошло 8 часов)";
            }
            if (shag == 28)
            {
                fon1.PlayLooping();
                BackgroundImage = System.Drawing.Image.FromFile("I/spalnya-4.jpg");
                label4.Visible = true;
                label4.Text = "Генри";
                label2.Text = "Деревенский2";
                pictureBox2.Image = System.Drawing.Image.FromFile("I/vtorpers.png");
                pictureBox3.Image = System.Drawing.Image.FromFile("I/glavperhad.png");
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;
                pictureBox10.Visible = true;
                pictureBox9.Visible = true;
                label3.Text = "Генри: Мия! А!? Где это!\nДеревенский2: Ты в деревни дзиха. Мы нашли тебя у опушки раненого после того как улетел тот черный дракон. Расскажи что там случилось.";
            }
            if (shag == 29)
            {
                label3.Text = "Генри: Да конечно. (Спустя несколько минут рассказа Генри, герои перешли в гостевую комнату.)";
            }
            if (shag == 30)
            {
                BackgroundImage = System.Drawing.Image.FromFile("I/19296.jpg");
                label3.Text = "Деревенский2: Как так!? Принцесса похищена! Божее. Король Будет в ярости. Ты должен спасти ее и как можно быстрее.\nГенри: Я спасу ее!";
            }
            if (shag == 31)
            {
                label3.Text = "Генри: Как тебя зовут?\nДеревенский2: Ой извени я не представился. Меня зовут Питер.\nГенри: Питер кто видел куда улетал дракон?";
            }
            if (shag == 32)
            {
                label2.Text = "Питер";
                label3.Text = "Питер: Это как раз был я. Он улетел в сторону пустыни. Тебе придется пройти через лес и там найти пещеру которая идет сквозь гору. Так ты попадешь в пустыню.";
            }
            if (shag == 33)
            {
                label3.Text = "Генри: Большое спасибо!\nПитер подожди тебе еще рано идти у тебя сломано ребро, да и раны могут открыться.\nГенри: Нет времени на это. Я отправляюсь!\nПитер: Удачи!";
            }
            if (shag == 34)
            {
                label3.Text = "Генри попросил деревенских дать ему лошать что бы добраться до дома и собрать все самое необходимое для возвращения принцессы Мии\nГлава 1. Прогол Закончена.\n Нажмите на -> для того что бы перейти в главное меню";
            }
            if (shag == 34)
            {
                fon1.Stop();
                Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fon1.PlayLooping();
            label3.Text = "Глава 1. Пролог";
            label3.Visible = true;
            button1.Enabled = true;
        }
    }
}
