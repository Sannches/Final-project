using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AniMate
{
    public partial class Form1 : Form
    {
        static Random rand = new Random();
        int Sek;
        bool bAvtoVise = false;
        public int X1, Y1, X2, Y2, X3, Y3, X4, Y4;  //координаты точек сварки

        private void bShowProg_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();  //новое окно
            newForm.ShowDialog();   //открываем окно настроек (параметров)

        }

        public Form1(string FIO)
        {
            InitializeComponent();
            LB1.Visible = false;    //делаем элемент невидимым
            LB2.Visible = false;
            LB3.Visible = false;
            LB4.Visible = false;
            pb1.Minimum = 0;
            pb1.Maximum = 100;
            LB_FIO.Text += FIO; //label с фамилией оператора АПЛС авторизированного при входе
        }

        static void genSleep(int Sek)
        {
            Thread.Sleep(Sek);  //Приостанавливает текущий поток на заданное время
        }

        void ShowPoint(int j)
        {
            if (bAvtoVise)
            {
                if (j == 1) LB1.Visible = true; LB1.Refresh();  //элемент делаем видимым и обновляем
                if (j == 2) LB2.Visible = true; LB2.Refresh();
                if (j == 3) LB3.Visible = true; LB3.Refresh();
                if (j == 4) LB4.Visible = true; LB4.Refresh();
            } else 
            {
                if (j == 1) LB4.Visible = false;
                if (j == 2) LB3.Visible = false;
                if (j == 3) LB2.Visible = false;
                if (j == 4) LB1.Visible = false;
                this.Refresh(); //обновляем окно формы
            }
        }

        private void bStart_Click(object sender, EventArgs e)  //старт
        {
            bStart.Visible = false;
            bAvtoVise = !bAvtoVise;

            if (bAvtoVise) pb1.Value = 0;   //прямая операция
            else pb1.Value = 100;   //реверсная операция

            for (int i = 1; i < 5; i++)
            {
                Sek = rand.Next(500, 1000); //случайные секунды
                genSleep(Sek);  //задержка выполнения
                ShowPoint(i);   //показать точку сварки
                if (bAvtoVise) pb1.Value += 25; //если прямая операция добавляем значение в прогрессбар
                else pb1.Value -= 25; //если реверсная операция вычитаем значение из прогрессбара

            }
            genSleep(Sek);  //задержка выполнения перед показом кнопки
            if (bAvtoVise) bStart.Text = "Реверс операции";
            else bStart.Text = "Старт операции";
            bStart.Visible = true;
        }   //*******************************************************************************************

        private void bSettings_Click(object sender, EventArgs e)
        {
            X1 = LB1.Location.X; Y1 = LB1.Location.Y;   //координаты точек сварки в переменные
            X2 = LB2.Location.X; Y2 = LB2.Location.Y;
            X3 = LB3.Location.X; Y3 = LB3.Location.Y;
            X4 = LB4.Location.X; Y4 = LB4.Location.Y;

            Form2 newForm = new Form2(X1, Y1, X2, Y2, X3, Y3, X4, Y4);  //новое окно
            newForm.ShowDialog();   //открываем окно настроек (параметров)

            if (newForm.Yes)    //если была нажата кнопка "Сохранить" в окне настроек
            {
                LB1.Location = new Point(newForm.X1_x, newForm.X1_y);   //новые координаты точек сварки
                LB2.Location = new Point(newForm.X2_x, newForm.X2_y);
                LB3.Location = new Point(newForm.X3_x, newForm.X3_y);
                LB4.Location = new Point(newForm.X4_x, newForm.X4_y);
            }
        }
    }
}