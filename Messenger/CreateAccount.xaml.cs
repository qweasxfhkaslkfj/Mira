using System;
using System.Windows;
using System.Windows.Input;

namespace Messenger
{
    /// <summary>
    /// Логика взаимодействия для CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Window
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        // Нажатие на кнопку назад
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationChoiceWindow registrationChoiceWindow = new RegistrationChoiceWindow();
            registrationChoiceWindow.Show();

            this.Close();
        }
        // Нажатие на кнопку СОЗДАТЬ
        private void CreateAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Нажатие на кнопку создания аккаунта");
        }
        // Нажатие клавиш в поле ввода
        private void FullNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                tagTextBox.Focus();
                e.Handled = true;
            }
        }
        private void TagTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (passwordTextBox.Visibility == Visibility.Visible)
                {
                    passwordTextBox.Focus();
                    e.Handled = true;
                }
                else
                {
                    passwordVisibleTextBox.Focus();
                    e.Handled = true;
                }
            }
        }
        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                confirmPasswordTextBox.Focus();
                e.Handled = true;
            }
        }
        private void ConfirmPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                groupTextBox.Focus();
                e.Handled = true;
            }
        }
        private void PasswordVisibleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                confirmPasswordVisibleTextBox.Focus();
                e.Handled = true;
            }
        }

        private void ConfirmPasswordVisibleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                groupTextBox.Focus();
                e.Handled = true;
            }
        }
        private void GroupTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                CreateAccountBtn_Click(sender, e);
                e.Handled = true;
            }
        }

        // Показ пароля
        private void ShowPasswordCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            // Копируем пароль из PasswordBox в TextBox
            passwordVisibleTextBox.Text = passwordTextBox.Password;
            confirmPasswordVisibleTextBox.Text = confirmPasswordTextBox.Password;

            // Переключаем видимость
            passwordTextBox.Visibility = Visibility.Collapsed;
            passwordVisibleTextBox.Visibility = Visibility.Visible;
            confirmPasswordTextBox.Visibility = Visibility.Collapsed;
            confirmPasswordVisibleTextBox.Visibility = Visibility.Visible;
        }

        // Скрытие пароля
        private void ShowPasswordCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            // Копируем пароль из TextBox обратно в PasswordBox
            passwordTextBox.Password = passwordVisibleTextBox.Text;
            confirmPasswordTextBox.Password = confirmPasswordVisibleTextBox.Text;

            // Переключаем видимость
            passwordVisibleTextBox.Visibility = Visibility.Collapsed;
            passwordTextBox.Visibility = Visibility.Visible;
            confirmPasswordVisibleTextBox.Visibility = Visibility.Collapsed;
            confirmPasswordTextBox.Visibility = Visibility.Visible;
        }
    }
}
