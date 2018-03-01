using DeleteTransactionInDB.Model;
using System;
using System.Data.Linq;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using log4net;


namespace DeleteTransactionInDB
{
    /// <summary>
    /// Логика взаимодействия для DeleteTransactionWithoutNuber.xaml
    /// </summary>
    public partial class DeleteTransactionWithoutNuber : Window
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

        private readonly DataContext _dataContext = new DataContext(ConnectionString);

        public DeleteTransactionWithoutNuber()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
       {



            //var result = _dataContext.GetTable<GmTransaction>()
            //    .ToList()
            //    .Join(_dataContext.GetTable<RetailTransactionSalesTrans>(),
            //    t => t.NotSavedRetailTransactionId,
            //    r => r.Receiptid,
            //    (t, r) => new
            //    {

            //    });

        }
    }
}
