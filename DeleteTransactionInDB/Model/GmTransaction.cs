using System;
using System.Data.Linq.Mapping;

namespace DeleteTransactionInDB.Model
{
    [Table(Name = "GM_Transaction")]
    public class GmTransaction
    {
        [Column(IsPrimaryKey = true)]
        public string TransactionId { get; set; }

        [Column]
        public string RetailTransactionId { get; set; }

        [Column]
        public DateTime  TransactionDate { get; set; }

        [Column]
        public int  TransactionType { get; set; }

        [Column]
        public string EmplID { get; set; }

        [Column]
        public decimal NetAmount { get; set; }

        [Column(IsPrimaryKey = true)]
        public string STOREID { get; set; }

        [Column(IsPrimaryKey = true)]
        public string TERMINALID { get; set; }

        [Column(IsPrimaryKey = true)]
        public string DataAreaId { get; set; }

        [Column]
        public decimal GrossAmount { get; set; }

        [Column]
        public decimal TaxAmount { get; set; }

        [Column]
        public decimal Payment { get; set; }

        [Column]
        public int Complited { get; set; }

        [Column]
        public string NotSavedRetailTransactionId { get; set; }
    }
}
