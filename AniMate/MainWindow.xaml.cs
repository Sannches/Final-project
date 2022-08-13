using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace AniMate {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            TB1.Visibility = Visibility.Collapsed;  //делает элементы управления невидимыми
            LabPass.Visibility = Visibility.Collapsed;
            TbPass.Visibility = Visibility.Collapsed;
            bPassOK.Visibility = Visibility.Collapsed;
            LabPass1.Visibility = Visibility.Collapsed;
            TB2.Visibility = Visibility.Collapsed;
            Rec1.Visibility = Visibility.Collapsed;
            Lab3.Visibility = Visibility.Collapsed;
        }

        DoubleAnimation dAnimation = new DoubleAnimation();
        Random rand = new Random();
        double currSize;
        public string sFIO1 = "Круталевич А.И.", sFIO2 = "Закурдаев Д.С.";
        public string sPass1 = "123456", sPass2 = "654321";
        public string sFIO = "", sPass = "";

        private void bLoginOK_Click(object sender, RoutedEventArgs e) //*****************************************
        {
            if (TbNom.Text != sFIO1 && TbNom.Text != sFIO2) //проверка авторизованных операторов
            {
                TB1.Visibility = Visibility.Visible;    //делаем видимым
                dAnimation.From = currSize = TB1.Width;
                dAnimation.To = currSize + 280;
                dAnimation.Duration = TimeSpan.FromSeconds(2);

                dAnimation.AutoReverse = true;
                dAnimation.FillBehavior = FillBehavior.Stop;

                dAnimation.Completed += (object sender1, EventArgs e1) => 
                {
                    TB1.Text = "Авторизированы: Круталевич А.И., Закурдаев Д.С.";
                    TB1.Visibility = Visibility.Collapsed;
                    bLoginOK.Content = "...";
                    LabPass.Visibility = Visibility.Collapsed;
                    TbPass.Visibility = Visibility.Collapsed;
                    bPassOK.Visibility = Visibility.Collapsed;
                    LabPass1.Visibility = Visibility.Collapsed;
                };
                TB1.BeginAnimation(Button.WidthProperty, dAnimation);
                return;
            }

            sFIO = TbNom.Text;
            if (sFIO == sFIO1) sPass = sPass1;
            else sPass = sPass2;

            dAnimation.From = currSize = bLoginOK.Width;
            dAnimation.To = currSize + 20;
            dAnimation.Duration = TimeSpan.FromSeconds(0.2);

            dAnimation.AutoReverse = true;
            dAnimation.FillBehavior = FillBehavior.Stop;

            dAnimation.Completed += (object sender1, EventArgs e1) =>
            {
                bLoginOK.Content = "OK";
                LabPass.Visibility = Visibility.Visible;
                TbPass.Visibility = Visibility.Visible;
                bPassOK.Visibility = Visibility.Visible;
                LabPass1.Visibility = Visibility.Visible;
                TbNom.IsEnabled = false;
            };
            bLoginOK.BeginAnimation(Button.WidthProperty, dAnimation);
        }

        void ProvPass() 
        {
            TB1.Text = "Не правильно введен пароль...";
            TB1.Visibility = Visibility.Visible;
            dAnimation.From = currSize = TB1.Width;
            dAnimation.To = currSize + 200;
            dAnimation.Duration = TimeSpan.FromSeconds(1);

            dAnimation.AutoReverse = true;
            dAnimation.FillBehavior = FillBehavior.Stop;

            dAnimation.Completed += (object sender1, EventArgs e1) =>
            {
                TB1.Visibility = Visibility.Collapsed;
            };
            TB1.BeginAnimation(Button.WidthProperty, dAnimation);
        }

        private void bPassOK_Click(object sender, RoutedEventArgs e) //*****************************************
        {

            if (TbPass.Text != sPass)   //проверка пароля
            {
                ProvPass();
                return;
            };

            TB2.Visibility = Visibility.Visible;
            Rec1.Visibility = Visibility.Visible;
            Lab3.Visibility = Visibility.Visible;
            dAnimation.From = currSize = TB2.Width;
            dAnimation.To = currSize + 316;
            dAnimation.Duration = TimeSpan.FromSeconds(1);

            dAnimation.AutoReverse = false;
            dAnimation.FillBehavior = FillBehavior.Stop;

            dAnimation.Completed += (object sender1, EventArgs e1) =>
            {
                Lab3.Content = "Авторизация успешно пройдена!";
                Lab3.FontStyle = FontStyles.Italic;
                Lab3.FontSize = 14;
                Lab3.FontWeight = FontWeights.Bold;
                Lab3.Foreground = Brushes.Red;
                TB2.Visibility = Visibility.Collapsed;
                Rec1.Visibility = Visibility.Collapsed;
                Close();

                Form1 newForm = new Form1(sFIO);
                newForm.ShowDialog();
            };
            TB2.BeginAnimation(Button.WidthProperty, dAnimation);
        }

        private void dAnimation_Completed(object sender1, EventArgs e1)
        {
            bLoginOK.Content = "OK";
        }
    }
}
