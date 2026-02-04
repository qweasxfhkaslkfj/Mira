using System;
using System.Windows;

namespace Messenger
{
    /// <summary>
    /// Логика взаимодействия для GuestEnter.xaml
    /// </summary>
    public partial class GuestEnter : Window
    {
        private Window parentWindow;

        public GuestEnter(Window parentWindow = null)
        {
            InitializeComponent();
            this.parentWindow = parentWindow;
        }

        private void GuestLoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (guestNameTextBox.Text.Trim(' ').Length == 0)
            {
                MessageBox.Show("Введите гостевое имя");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.userLogin = guestNameTextBox.Text + " (Гость)";
                mainWindow.isGuest = true;

                MessageBox.Show($"Выполнен гостевой вход с логином:\n {mainWindow.userLogin}");
                mainWindow.Show();

                if (this.parentWindow != null)
                {
                    this.parentWindow.Close();
                }

                this.Close();
            }
        }
    }
}
