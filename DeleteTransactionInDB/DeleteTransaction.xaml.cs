using DeleteTransactionInDB.Model;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Windows;

namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для DeleteTransaction.xaml
    /// </summary>
    public partial class DeleteTransaction : Window
    {
        static string connectionString = @"Data Source=R54-633203-N; Initial Catalog=DB633203; user id=sa;password=Admin123";

        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private void searchBtn_Click(object sender, RoutedEventArgs e)
        {
            DataContext dataContext = new DataContext(connectionString);
            Retailtransactiontable retailtransactiontable = new Retailtransactiontable();

            string tbxResult = numberTbx.Text;

            if (tbxResult != string.Empty)
            {
                var result = dataContext.GetTable<Retailtransactiontable>()
                .ToList()
                .Where(r => r.RECEIPTID == tbxResult); //"Прод092765"

                foreach (var item in result)
                {
                    resultLst.Items.Add(new Retailtransactiontable
                    {
                        //Номер транзакции
                        TRANSACTIONID = item.TRANSACTIONID,
                        //Номер терминала
                        TERMINAL = item.TERMINAL,
                        //Дата создания
                        CREATEDDATE = item.CREATEDDATE,
                        //Сумма платежа
                        PAYMENTAMOUNT = item.PAYMENTAMOUNT
                    });
                }
            }
            else
            {
                MessageBox.Show("Не введен номер зависшей транзакции");
            }
            
        }
    }
}
