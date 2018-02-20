using DeleteTransactionInDB.Model;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для DeleteTransactionWithoutNuber.xaml
    /// </summary>
    public partial class DeleteTransactionWithoutNuber : Window
    {
        public static string DbName()
        {
            string pcName = Environment.MachineName.ToLower();
            string[] zipCode = pcName.Split('-');

            return "DB" + zipCode[1];
        }

        static string _connectionString = @"Data Source=r54-633009-n; Initial Catalog=DB633009; user id=sa;password=";
        DataContext _dataContext = new DataContext(_connectionString);

        public DeleteTransactionWithoutNuber()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var result = _dataContext.GetTable<GmTransaction>()
                .ToList()
                .Join(_dataContext.GetTable<RetailTransactionSalesTrans>(),
                t => t.NotSavedRetailTransactionId,
                r => r.Receiptid,
                (t, r) => new { });

        }
    }
}
