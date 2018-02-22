using System;
using DeleteTransactionInDB.Model;
using System.Data.Linq;
using System.Linq;
using System.Windows;
using System.Threading.Tasks;

namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для DeleteTransaction.xaml
    /// </summary>
    public partial class DeleteTransaction : Window
    {
        public static string DbName()
        {
            string pcName = Environment.MachineName.ToLower();
            string[] zipCode = pcName.Split('-');

            return "DB" + zipCode[1];
        }

        static string _connectionString = @"Data Source=localhost;Initial Catalog=" + DbName() + ";Integrated Security = SSPI";
        //static string _connectionString = @"Data Source=r54-633009-n;Initial Catalog=DB633009;User Id=sa;password=QweAsd123";
        DataContext _dataContext = new DataContext(_connectionString);

        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private async void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (numberTbx.Text != string.Empty)
            {
                Progressbar.Visibility = Visibility.Visible;
                Progressbar.IsIndeterminate = true;
                SearchBtn.Opacity = 0.2;
                await Serach();
            }
            else
            {
                MessageBox.Show("Не введен номер зависшей транзакции");
            }
            
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var result = _dataContext.GetTable<Retailtransactiontable>()
                .ToList()
                .Where(r => r.Receiptid == numberTbx.Text);

            if (result != null)
            {
                _dataContext.GetTable<Retailtransactiontable>().DeleteAllOnSubmit(result);
                _dataContext.SubmitChanges();
                ResultLst.Items.Clear();
                MessageBox.Show("Транзакция удалена!\n Перезайдите в сверку транзакций.");
            }
            else
            {
                MessageBox.Show("Транзакция не удалена");
            }
        }

        public async Task Serach()
        {
            try
            {
                var result = await Task.Run(() => _dataContext.GetTable<Retailtransactiontable>()
                            .ToList()
                            .Where(r => r.Receiptid == numberTbx.Text));   //"Прод092765"

                foreach (var item in result)
                {
                    ResultLst.Items.Add(new Retailtransactiontable
                    {
                        //Номер транзакции
                        Receiptid = item.Receiptid,
                        //Номер терминала
                        Terminal = item.Terminal,
                        //Дата создания
                        Createddate = item.Createddate,
                        //Сумма платежа
                        Paymentamount = item.Paymentamount
                    });
                }
                Progressbar.IsIndeterminate = false;
                Progressbar.Visibility = Visibility.Hidden;
                SearchBtn.Opacity = 1;
                DeleteBtn.Visibility = Visibility.Visible;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
            
        }
    }

    
}
