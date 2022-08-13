using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;    //для работы с базой данных
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;    //для работы с базой данных
using System.Configuration; //для для работы с файлом конфигурации App.config

namespace AniMate
{
    public partial class Form2 : Form
    {
        public bool Yes = false;
        public int X1_x, X1_y;
        public int X2_x, X2_y;
        public int X3_x, X3_y;
        public int X4_x, X4_y;
        public int NP;
        private int num_add;    //номер для новой добавляемой программы
        private int fill_prog = 0;  //0-запрет, 1-разрешение для события dgvDataBase_CurrentCellChanged (изменение текущей ячейки)
        private SqlConnection sqlConnection = null; //переменная для подключения к БД

        public Form2(int X1, int Y1, int X2, int Y2, int X3, int Y3, int X4, int Y4)   //конструктор Form2 с параметрами координат
        {
            InitializeComponent();
            X1_x = X1; X1_y = Y1;
            X2_x = X2; X2_y = Y2;
            X3_x = X3; X3_y = Y3;
            X4_x = X4; X4_y = Y4;
            tbX1.Text = Convert.ToString(X1);   //принятые координаты точек сварки
            tbY1.Text = Convert.ToString(Y1);
            tbX2.Text = Convert.ToString(X2);
            tbY2.Text = Convert.ToString(Y2);
            tbX3.Text = Convert.ToString(X3);
            tbY3.Text = Convert.ToString(Y3);
            tbX4.Text = Convert.ToString(X4);
            tbY4.Text = Convert.ToString(Y4);
        }

        private void bAdd_Click(object sender, EventArgs e)  //событие по кнопке ДОБАВИТЬ новую программу в БД
        {
            //подтверждение на удаление
            DialogResult dialogResult = MessageBox.Show($"Добавить программу №{num_add.ToString()}?", "Добавление строки в БД", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { }
            else if (dialogResult == DialogResult.No) { return; } //если "нет", то выход из функции

            fill_prog = 0;  //запрет для события dgvDataBase_CurrentCellChanged

            SqlCommand command = new SqlCommand(    //запрос на добавление
                $"INSERT INTO [ProgRTK] (Prog,X1,X2,X3,X4,Y1,Y2,Y3,Y4) values (" +
                    $"{num_add}, " +
                    $"{Convert.ToInt32(tbX1.Text)}, " +
                    $"{Convert.ToInt32(tbX2.Text)}, " +
                    $"{Convert.ToInt32(tbX3.Text)}, " +
                    $"{Convert.ToInt32(tbX4.Text)}, " +
                    $"{Convert.ToInt32(tbY1.Text)}, " +
                    $"{Convert.ToInt32(tbY2.Text)}, " +
                    $"{Convert.ToInt32(tbY3.Text)}, " +
                    $"{Convert.ToInt32(tbY4.Text)} " +
                    $")",
                sqlConnection);

            if (command.ExecuteNonQuery() == 1) //выполняем запрос
            {
                //заполняем строку статуса
                label12.Text = $"Статус: Строка с новыми данными успешно добавлена в БД (Программа №{num_add.ToString()} )...";
            }
            RefreshBase();  //функция обновления данных в окне dgvDataBase
            fill_prog = 1;  //разрешение для события dgvDataBase_CurrentCellChanged
            Fill_Koordinate();  //функция для заполнения координат значениями из текущей строки базы данных в dgvDataBase
        }

        private void RefreshBaseTok()  //обновление данных в окне dgvADB
        {
            NP = Convert.ToInt32(dgvDataBase.CurrentRow.Cells["Id"].Value.ToString());    //номер программы по Id из текущей строки dgvDataBase

            SqlDataAdapter dataAdapter2 = new SqlDataAdapter(    //запрос на вывод нужных полей с сортировкой по номеру программы
                "Select Sila,ProgramNom,Id,Prim FROM Tok WHERE ProgramNom = " + Convert.ToString(NP),
                sqlConnection);
            DataSet dataSet2 = new DataSet();
            dataAdapter2.Fill(dataSet2);
            dgvADB.DataSource = dataSet2.Tables[0];

            dgvADB.Columns["ProgramNom"].HeaderText = "id программы координат";    //заголовок колонки
            dgvADB.Columns["ProgramNom"].Width = 170;    //ширина колонки
            dgvADB.Columns["ProgramNom"].ReadOnly = true;    //только чтение
            dgvADB.Columns["Prim"].ReadOnly = true;    //только чтение
            dgvADB.Columns["ProgramNom"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvADB.Columns["Sila"].HeaderText = "Сила тока";    //заголовок колонки
            dgvADB.Columns["Sila"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //выравнивание заголовков таблицы по центру
            DataGridViewCellStyle style = dgvADB.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void RefreshBase()  //обновление данных в окне dgvDataBase
        {
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter(   //запрос на поиск максимального номера программы
                "SELECT MAX(Prog) as Prog FROM [ProgRTK]",
                sqlConnection);
            DataSet dataSet1 = new DataSet();
            dataAdapter1.Fill(dataSet1);
            dgvDataBase.DataSource = dataSet1.Tables[0];
            num_add = Convert.ToInt32(dgvDataBase.CurrentRow.Cells[0].Value) + 1; //номер для новой добавляемой программы

            SqlDataAdapter dataAdapter = new SqlDataAdapter(    //запрос на вывод нужных полей с сортировкой по номеру программы
                "Select Prog,X1,X2,X3,X4,Y1,Y2,Y3,Y4,Id FROM ProgRTK ORDER BY Prog",
                sqlConnection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dgvDataBase.DataSource = dataSet.Tables[0];


            dgvDataBase.Columns[0].HeaderText = "№ программы";    //заголовок первой колонки
            dgvDataBase.Columns[0].Width = 70;    //ширина первой колонки
            dgvDataBase.Columns[1].Width = 40;
            dgvDataBase.Columns[2].Width = 40;
            dgvDataBase.Columns[3].Width = 40;
            dgvDataBase.Columns[4].Width = 40;
            dgvDataBase.Columns[5].Width = 40;
            dgvDataBase.Columns[6].Width = 40;
            dgvDataBase.Columns[7].Width = 40;
            dgvDataBase.Columns[8].Width = 40;
            dgvDataBase.Columns[9].Width = 30;
            //выравнивание значений в колонке по центру
            dgvDataBase.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvDataBase.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //выравнивание заголовков таблицы по центру
            DataGridViewCellStyle style = dgvDataBase.ColumnHeadersDefaultCellStyle;
            style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void bDel_Click(object sender, EventArgs e)  //событие по кнопке УДАЛИТЬ
        {
            //подтверждение на удаление
            DialogResult dialogResult = MessageBox.Show($"Удалить программу №{dgvDataBase.CurrentRow.Cells[0].Value.ToString()}?", "Удаление строки БД", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) {}
            else if (dialogResult == DialogResult.No) {return;} //если "нет", то выход из функции

            tbNomProg.Text = dgvDataBase.CurrentRow.Cells[0].Value.ToString();    //заполняем номер программы в окне
            fill_prog = 0;  //запрет для события dgvDataBase_CurrentCellChanged

            SqlCommand command = new SqlCommand(    //запрос на удаление
                $"DELETE FROM [ProgRTK] " +
                $"WHERE Prog = {Convert.ToInt32(tbNomProg.Text)}",sqlConnection);

            if (command.ExecuteNonQuery() == 1) //выполняем запрос
            {
                label12.Text = "Статус: Строка БД удалена...";  //заполняем строку статуса
            }
            RefreshBase();  //функция обновления данных в окне dgvDataBase
            fill_prog = 1;  //разрешение для события dgvDataBase_CurrentCellChanged
            Fill_Koordinate();  //функция для заполнения координат значениями из текущей строки базы данных в dgvDataBase
        }

        private void bChange_Click(object sender, EventArgs e)    //событие по кнопке ИЗМЕНИТЬ (обновить значения в текущей строке БД)
        {
            //подтверждение на изменение
            DialogResult dialogResult = MessageBox.Show($"Изменить программу №{dgvDataBase.CurrentRow.Cells[0].Value.ToString()}?", "Изменение строки БД", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { }
            else if (dialogResult == DialogResult.No) { return; } //если "нет", то выход из функции

            tbNomProg.Text = dgvDataBase.CurrentRow.Cells[0].Value.ToString();    //заполняем номер программы в окне
            fill_prog = 0;  //запрет для события dgvDataBase_CurrentCellChanged

            string sss =
                $"UPDATE [ProgRTK] " +
                $"SET X1 = {Convert.ToInt32(tbX1.Text)}, " +
                $"X2 = {Convert.ToInt32(tbX2.Text)}, " +
                $"X3 = {Convert.ToInt32(tbX3.Text)}, " +
                $"X4 = {Convert.ToInt32(tbX4.Text)}, " +
                $"Y1 = {Convert.ToInt32(tbY1.Text)}, " +
                $"Y2 = {Convert.ToInt32(tbY2.Text)}, " +
                $"Y3 = {Convert.ToInt32(tbY3.Text)}, " +
                $"Y4 = {Convert.ToInt32(tbY4.Text)}" +
                $" WHERE Prog = {dgvDataBase.CurrentRow.Cells[0].Value.ToString()}";

            SqlCommand command = new SqlCommand(    //запрос на изменение значений координат
                sss, sqlConnection);

            if (command.ExecuteNonQuery() == 1) //выполняем запрос
            {
                //заполняем строку статуса
                label12.Text = $"Статус: Строка БД изменена (Программа №{dgvDataBase.CurrentRow.Cells[0].Value.ToString()})...";
            }

            string sss2 =
                $"UPDATE [Tok] " +
                $"SET Sila = {Convert.ToInt32(dgvADB.CurrentRow.Cells["Sila"].Value.ToString())} " +
                $"WHERE ProgramNom = {dgvADB.CurrentRow.Cells["ProgramNom"].Value.ToString()}";

            SqlCommand command2 = new SqlCommand(    //запрос на изменение значений координат
                sss2, sqlConnection);

            if (command2.ExecuteNonQuery() == 1) //выполняем запрос
            {
                //заполняем строку статуса
                label12.Text += " + (связанная база изменена) ...";
            }

            RefreshBase();  //функция обновления данных в окне dgvDataBase
            RefreshBaseTok();  //функция обновления данных в окне dgvADB
            fill_prog = 1;  //разрешение для события dgvDataBase_CurrentCellChanged
            Fill_Koordinate();  //функция для заполнения координат значениями из текущей строки базы данных в dgvDataBase

        }


        private void dgvDataBase_CurrentCellChanged_1(object sender, EventArgs e)
        {
            if (fill_prog == 1) //если есть разрешение, то заполняем координаты
            {
                Fill_Koordinate();
                RefreshBaseTok();
            }
        }

        private void Fill_Koordinate()  //функция заполнения координат значениеми из текущей строки БД в dgvDataBase
        {
            tbNomProg.Text = dgvDataBase.CurrentRow.Cells[0].Value.ToString();
            tbX1.Text = dgvDataBase.CurrentRow.Cells[1].Value.ToString();
            tbX2.Text = dgvDataBase.CurrentRow.Cells[2].Value.ToString();
            tbX3.Text = dgvDataBase.CurrentRow.Cells[3].Value.ToString();
            tbX4.Text = dgvDataBase.CurrentRow.Cells[4].Value.ToString();
            tbY1.Text = dgvDataBase.CurrentRow.Cells[5].Value.ToString();
            tbY2.Text = dgvDataBase.CurrentRow.Cells[6].Value.ToString();
            tbY3.Text = dgvDataBase.CurrentRow.Cells[7].Value.ToString();
            tbY4.Text = dgvDataBase.CurrentRow.Cells[8].Value.ToString();
        }

        private void Form2_Load(object sender, EventArgs e) //событие при загруке Form2 *******************************************
        {
            //создаем подклчение к базе данных по ключу и строке подключения (указана в файле конфигурации App.config)
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["RTK"].ConnectionString);
            sqlConnection.Open();   //открываем БД
            sqlConnection.State.ToString();

            if (sqlConnection.State == ConnectionState.Open)    //если статус подключения = 1 (успешно открыта)
            {
                label12.Text = "Статус: Подключение с БД установлено...";   //заполняем строку статуса
            }

            RefreshBase();  //выполняем функцию обновления данных в окне dgvDataBase
            RefreshBaseTok();  //выполняем функциюя обновления данных в окне dgvADB
            fill_prog = 1;  //разрешение для события dgvDataBase_CurrentCellChanged
            tbNomProg.Text = dgvDataBase.CurrentRow.Cells[0].Value.ToString();    //заполняем номер програмы из текущей строки БД  в окне dgvDataBase
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            X1_x = Convert.ToInt32(tbX1.Text);  //сохраняем новые координаты точек
            X1_y = Convert.ToInt32(tbY1.Text);
            X2_x = Convert.ToInt32(tbX2.Text);
            X2_y = Convert.ToInt32(tbY2.Text);
            X3_x = Convert.ToInt32(tbX3.Text);
            X3_y = Convert.ToInt32(tbY3.Text);
            X4_x = Convert.ToInt32(tbX4.Text);
            X4_y = Convert.ToInt32(tbY4.Text);

            //проверка координат по оси Х на выход за предельные значения
            if (((X1_x < 8) || (X1_x > 105)) || ((X2_x < 8) || (X2_x > 105)) ||
                ((X3_x < 8) || (X3_x > 105)) || ((X4_x < 8) || (X4_x > 105)))
            {
                MessageBox.Show("Координаты по оси Х выходят за границы сварочного стола... Введите корректные координаты.");
                Yes = false; //признак нажатия кнопки "Сохранить"
                return;
            }
            //проверка координат по оси Y на выход за предельные значения
            if (((X1_y < 22) || (X1_y > 50)) || ((X2_y < 22) & (X2_y > 50)) ||
                ((X3_y < 22) || (X3_y > 50)) || ((X4_y < 22) || (X4_y > 50)))
            {
                MessageBox.Show("Координаты по оси Y выходят за границы сварочного стола... Введите корректные координаты.");
                Yes = false; //признак нажатия кнопки "Сохранить"
                return;
            }

            Yes = true; //признак нажатия кнопки "Сохранить"
            this.Close();   //закрываем окно настроек
        }

        private void bSave_MouseHover(object sender, EventArgs e)   //событие при наведении курсора мышки на кнопку
        {
            toolTip1.SetToolTip(bSave, "Сохранение параметров и выход из формы");   //всплывающее окно
        }
    }
}
