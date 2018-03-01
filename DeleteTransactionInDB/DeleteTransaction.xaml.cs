using System;
using DeleteTransactionInDB.Model;
using System.Data.Linq;
using System.Linq;
using System.Windows;
using System.Threading.Tasks;
using log4net;

namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для DeleteTransaction.xaml
    /// </summary>
    public partial class DeleteTransaction : Window
    {
        private static readonly ILog Log = LogManager.GetLogger
            (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static string DbName()
        {
            string pcName = Environment.MachineName.ToLower();
            string[] zipCode = pcName.Split('-');

            return "DB" + zipCode[1];
        }

        private static readonly string ConnectionString = @"Data Source=localhost;Initial Catalog=" + DbName() + ";Integrated Security = SSPI;Trusted_Connection=true;";

        readonly DataContext _dataContext = new DataContext(ConnectionString);

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

            _dataContext.GetTable<Retailtransactiontable>().DeleteAllOnSubmit(result);
            _dataContext.SubmitChanges();
            Log.Info($"Удалена транзакция: {numberTbx.Text}");
            ResultLst.Items.Clear();
            numberTbx.Text = string.Empty;
            MessageBox.Show("Транзакция удалена!\n Перезайдите в сверку транзакций.");
        }

        private async Task Serach()
        {
            try
            {
                var result = await Task.Run(() => _dataContext.GetTable<Retailtransactiontable>()
                    .ToList()
                    .Where(r => r.Receiptid == numberTbx.Text));
                Log.Info("Найдена транзакция:");

                foreach (var item in result)
                {
                    Log.Info($"Номер транзакции: {item.Receiptid}, Номер терминала: {item.Terminal}, Дата создания: {item.Createddate}, Сумма: {item.Paymentamount}");
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

        private int _i;

        private void numberTbx_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            _i++;
            if (_i == 1)
            {
                numberTbx.Text = numberTbx.Text[0].ToString().ToUpper();
            }
            else
            {
                numberTbx.SelectionStart = numberTbx.Text.Length;
            }
        }
    }
}
