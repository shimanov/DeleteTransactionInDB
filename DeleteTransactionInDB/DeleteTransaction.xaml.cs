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
        static string connectionString = @"Data Source=R54-633203-N; Initial Catalog=DB633203; user id=sa;password=Admin123";
        DataContext dataContext = new DataContext(connectionString);

        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (numberTbx.Text != string.Empty)
            {
                var result = dataContext.GetTable<Retailtransactiontable>()
                .ToList()
                .Where(r => r.RECEIPTID == numberTbx.Text); //"Прод092765"

                    foreach (var item in result)
                    {
                        resultLst.Items.Add(new Retailtransactiontable
                        {
                            //Номер транзакции
                            RECEIPTID = item.RECEIPTID,
                            //Номер терминала
                            TERMINAL = item.TERMINAL,
                            //Дата создания
                            CREATEDDATE = item.CREATEDDATE,
                            //Сумма платежа
                            PAYMENTAMOUNT = item.PAYMENTAMOUNT
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
            var result = dataContext.GetTable<Retailtransactiontable>()
                .ToList()
                .Where(r => r.RECEIPTID == numberTbx.Text);

            if (result != null)
            {
                dataContext.GetTable<Retailtransactiontable>().DeleteAllOnSubmit(result);
                dataContext.SubmitChanges();
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
