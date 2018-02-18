using DeleteTransactionInDB.Model;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для DeleteTransaction.xaml
    /// </summary>
    public partial class DeleteTransaction : Window
    {
        static string _connectionString = @"Data Source=R54-633203-N; Initial Catalog=DB633203; user id=sa;password=Admin123";
        DataContext _dataContext = new DataContext(_connectionString);

        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (numberTbx.Text != string.Empty)
            {
                var result = _dataContext.GetTable<Retailtransactiontable>()
                .ToList()
                .Where(r => r.Receiptid == numberTbx.Text); //"Прод092765"

                    foreach (var item in result)
                    {
                        resultLst.Items.Add(new Retailtransactiontable
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
                deleteBtn.Visibility = Visibility.Visible;
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
                resultLst.Items.Clear();
                MessageBox.Show("Транзакция удалена!\n Перезайдите в сверку транзакций.");
            }
            else
            {
                MessageBox.Show("Транзакция не удалена");
            }
        }
    }
}
