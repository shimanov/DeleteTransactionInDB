using System;
using System.Data.Linq.Mapping;

namespace DeleteTransactionInDB.Model
{
    [Table(Name = "RETAILTRANSACTIONTABLE")]
    public class Retailtransactiontable
    {
        [Column(IsPrimaryKey = true)]
        public string TRANSACTIONID { get; set; }

        [Column]
        public int Type { get; set; }

        [Column]
        public string RECEIPTID { get; set; }

        [Column(IsPrimaryKey = true)]
        public string STORE { get; set; }

        [Column(IsPrimaryKey = true)]
        public string TERMINAL { get; set; }

        [Column]
        public string STAFF { get; set; }

        [Column]
        public DateTime TRANSDATE { get; set; }

        [Column]
        public int TRANSTIME { get; set; }

        [Column]
        public string SHIFT { get; set; }

        [Column]
        public DateTime SHIFTDATE { get; set; }

        [Column]
        public int WRONGSHIFT { get; set; }

        [Column]
        public string INFOCODEDISCGROUP { get; set; }

        [Column]
        public string CUSTACCOUNT { get; set; }

        [Column]
        public int TRANSCODE { get; set; }

        [Column]
        public decimal SALESPAYMENTDIFFERENCE { get; set; }

        [Column]
        public decimal NETAMOUNT { get; set; }

        [Column]
        public decimal COSTAMOUNT { get; set; }

        [Column]
        public decimal GROSSAMOUNT { get; set; }

        [Column]
        public decimal PAYMENTAMOUNT { get; set; }

        [Column]
        public decimal DISCAMOUNT { get; set; }

        [Column]
        public decimal CUSTDISCAMOUNT { get; set; }

        [Column]
        public decimal TOTALDISCAMOUNT { get; set; }

        [Column]
        public decimal NUMBEROFITEMS { get; set; }

        [Column]
        public decimal AMOUNTTOACCOUNT { get; set; }

        [Column]
        public decimal ROUNDEDAMOUNT { get; set; }

        [Column]
        public int ENTRYSTATUS { get; set; }

        [Column]
        public int NUMBEROFINVOICES { get; set; }

        [Column]
        public decimal NUMBEROFITEMLINES { get; set; }

        [Column]
        public string STATEMENTCODE { get; set; }

        [Column]
        public string STATEMENTID { get; set; }

        [Column]
        public string REFUNDRECEIPTID { get; set; }

        [Column]
        public decimal INCOMEEXPENSEAMOUNT { get; set; }

        [Column]
        public int TOACCOUNT { get; set; }

        [Column]
        public int NUMBEROFPAYMENTLINES { get; set; }

        [Column]
        public int SALEISRETURNSALE { get; set; }

        [Column]
        public int COUNTER { get; set; }

        [Column]
        public int TIMEWHENTOTALPRESSED { get; set; }

        [Column]
        public int TIMEWHENTRANSCLOSED { get; set; }

        [Column]
        public string CURRENCY { get; set; }

        [Column]
        public int TRANSTABLEID { get; set; }

        [Column]
        public int OPENDRAWER { get; set; }

        [Column]
        public int REPLICATED { get; set; }

        [Column]
        public int REPLICATIONCOUNTER { get; set; }

        [Column]
        public int INCLUDEDINSTATISTICS { get; set; }

        [Column]
        public string RETRIEVEDFROMRECEIPTID { get; set; }

        [Column]
        public string CREATEDONPOSTERMINAL { get; set; }

        [Column]
        public int POSTASSHIPMENT { get; set; }

        [Column]
        public int ITEMSPOSTED { get; set; }

        [Column]
        public DateTime MODIFIEDDATE { get; set; }

        [Column]
        public int MODIFIEDTIME { get; set; }

        [Column]
        public string MODIFIEDBY { get; set; }

        [Column]
        public DateTime CREATEDDATE { get; set; }

        [Column]
        public int CREATEDTIME { get; set; }

        [Column]
        public string CREATEDBY { get; set; }

        [Column(IsPrimaryKey = true)]
        public string DATAAREAID { get; set; }

        [Column]
        public string DESCRIPTION { get; set; }

        [Column]
        public string CUSTPURCHASEORDER { get; set; }

        [Column]
        public string COMMENT { get; set; }

        [Column]
        public string INVOICECOMMENT { get; set; }

        [Column]
        public decimal SALESORDERAMOUNT { get; set; }

        [Column]
        public decimal SALESINVOICEAMOUNT { get; set; }

        [Column]
        public string RECEIPTEMAIL { get; set; }

        [Column]
        public decimal EXCHRATE { get; set; }

        [Column]
        public string BATCHTERMINALID { get; set; }

        [Column]
        public long BATCHID { get; set; }

        [Column]
        public string FISCALSERIALID { get; set; }

        [Column]
        public string FISCALDOCUMENTID { get; set; }

        [Column]
        public int CREATEDOFFLINE { get; set; }

        [Column]
        public string INVENTLOCATIONID { get; set; }

        [Column]
        public string INVENTSITEID { get; set; }

        [Column]
        public string DLVMODE { get; set; }

        [Column]
        public DateTime RECEIPTDATEREQUESTED { get; set; }

        [Column]
        public DateTime SHIPPINGDATEREQUESTED { get; set; }

        [Column]
        public string CHANNELREFERENCEID { get; set; }

        [Column]
        public long LOGISTICSPOSTALADDRESS { get; set; }

        [Column]
        public long CHANNEL { get; set; }

        [Column]
        public string SALESORDERID { get; set; }
    }
}
