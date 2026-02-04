using System;
using System.Windows;
using System.Windows.Input;

namespace Messenger
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }

        // Вход
        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            if (loginTextBox.Text.Trim(' ').Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите логин");
            }
            else if (passwordTextBox.Password.Trim(' ').Length == 0 && passwordVisibleTextBox.Text.Trim(' ').Length == 0)
            {
                MessageBox.Show("Пожалуйста, введите пароль");
            }
            else
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                this.Close();
            }
        }

        // Вход как гость
        private void WithoutAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrationChoiceWindow registrationChoiceWindow = new RegistrationChoiceWindow();
            registrationChoiceWindow.Show();
            this.Close();
        }

        // Нажатие на кнопку показа/скрытия пароля
        private void showPasswordBtn_Click(object sender, RoutedEventArgs e)
        {
            if (passwordTextBox.Visibility == Visibility.Visible)
            {
                // Показ пароля
                passwordVisibleTextBox.Text = passwordTextBox.Password;
                passwordTextBox.Visibility = Visibility.Collapsed;
                passwordVisibleTextBox.Visibility = Visibility.Visible;
                passwordToggleText.Text = "🙈"; // Изменено на закрытый глаз
            }
            else
            {
                // Скрытие пароля
                passwordTextBox.Password = passwordVisibleTextBox.Text;
                passwordVisibleTextBox.Visibility = Visibility.Collapsed;
                passwordTextBox.Visibility = Visibility.Visible;
                passwordToggleText.Text = "👁"; // Открытый глаз
            }

            // Установка фокуса в активное поле
            if (passwordTextBox.Visibility == Visibility.Visible)
                passwordTextBox.Focus();
            else
                passwordVisibleTextBox.Focus();
        }

        // Нажатие клавиш в поле ввода
        private void LoginTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                passwordTextBox.Focus();
                e.Handled = true;
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginBtn_Click(sender, e);
                e.Handled = true;
            }
        }

        private void PasswordVisibleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginBtn_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}