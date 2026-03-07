using System.Windows;

namespace AssetManagementSystem
{
    public partial class LoginPage : Window
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Функция входа пока в разработке");
        }

        private void OpenRegistration(object sender, RoutedEventArgs e)
        {
            RegistrationPage reg = new RegistrationPage();
            reg.Show();
            this.Close();
        }
    }
}