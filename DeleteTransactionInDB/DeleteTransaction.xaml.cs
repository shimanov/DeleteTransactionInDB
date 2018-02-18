using System;
using DeleteTransactionInDB.Model;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

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

        static string _connectionString = @"Data Source=localhost; Initial Catalog=" + DbName() + "; user id=sa;password=Admin123";
        DataContext _dataContext = new DataContext(_connectionString);

        public DeleteTransaction()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            if (numberTbx.Text != string.Empty)
            {
                Regex regex = new Regex("^[а-яА-ЯёЁ0-9]+$ ", RegexOptions.IgnoreCase);
                Match match = regex.Match(numberTbx.Text);
                if (match.Success)
                {
                    var result = _dataContext.GetTable<Retailtransactiontable>()
                        .ToList()
                        .Where(r => r.Receiptid == numberTbx.Text); //"Прод092765"

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
                    DeleteBtn.Visibility = Visibility.Visible;
                }
                else
                {
                    MessageBox.Show("!!!!");
                }
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
    }
}
