using System;
using System.Windows;
using System.Collections.Generic;

namespace Messenger
{
    /// <summary>
    /// Логика взаимодействия для RegistrationChoiceWindow.xaml
    /// </summary>
    public partial class RegistrationChoiceWindow : Window
    {
        public RegistrationChoiceWindow()
        {
            InitializeComponent();
            RandomLabel();
        }

        // Создание аккаунта
        private void CreateAccountBtn_Click(object sender, RoutedEventArgs e)
        {
            CreateAccount create = new CreateAccount();
            create.Show();
            this.Close();
        }
        // Вход как гость
        private void LoginAsGuestBtn_Click(object sender, RoutedEventArgs e)
        {
            GuestEnter guestEnter = new GuestEnter(this);
            guestEnter.Show();
        }
        // Метод рандомного 
        private void RandomLabel()
        {
            Random rnd = new Random();
            random_ban_label.Text = labelsTexts[rnd.Next(1, 11)];
        }

        // Словарь
        private Dictionary<int, string> labelsTexts = new Dictionary<int, string>()
        {
            [1] = "Не услышать комплимент от попугая",
            [2] = "Не поймать падающую звезду сачком для бабочек",
            [3] = "Не найти глубокий смысл в инструкции к тостеру",
            [4] = "Не выиграть в армрестлинге у домашнего хомяка",
            [5] = "Не застать прекрасный Wi-Fi",
            [6] = "Не разгадать кроссворд на албанском языке",
            [7] = "Не договориться с будильником ещё о пяти минутах",
            [8] = "Не вспомнить, куда положил телефон минуту назад",
            [9] = "Не приготовить ужин из авакадо",
            [10] = "Не поймать ритм, под который капает кран",
        };

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrationWindow registrationWindow = new RegistrationWindow();
            registrationWindow.Show();

            this.Close();
        }
    }
}
