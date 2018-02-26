using System.IO;
using System.Windows;

namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void withNumber_Click(object sender, RoutedEventArgs e)
        {
            DeleteTransaction deleteTransaction = new DeleteTransaction();
            deleteTransaction.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (!Directory.Exists(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Почтовское говно"))
            {
                Directory.CreateDirectory(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Почтовское говно");
            }


        }
    }
}
