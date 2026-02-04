using System;
using System.Windows;

namespace Messenger
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string userLogin;
        public bool isGuest;

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
