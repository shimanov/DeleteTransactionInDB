using System;
using System.Data.Linq.Mapping;

namespace DeleteTransactionInDB.Model
{
    [Table(Name = "RETAILTRANSACTIONTABLE")]
    public class Retailtransactiontable
    {
        [Column(IsPrimaryKey = true, Name = "TRANSACTIONID")]
        public string Transactionid { get; set; }

        [Column(Name = "TYPE")]
        public int Type { get; set; }

        [Column(Name = "RECEIPTID")]
        public string Receiptid { get; set; }

        [Column(IsPrimaryKey = true, Name = "STORE")]
        public string Store { get; set; }

        [Column(IsPrimaryKey = true, Name = "TERMINAL")]
        public string Terminal { get; set; }

        [Column(Name = "STAFF")]
        public string Staff { get; set; }

        [Column(Name = "TRANSDATE")]
        public DateTime Transdate { get; set; }

        [Column(Name = "TRANSTIME")]
        public int Transtime { get; set; }

        [Column(Name = "SHIFT")]
        public string Shift { get; set; }

        [Column(Name = "SHIFTDATE")]
        public DateTime Shiftdate { get; set; }

        [Column(Name = "WRONGSHIFT")]
        public int Wrongshift { get; set; }

        [Column(Name = "INFOCODEDISCGROUP")]
        public string Infocodediscgroup { get; set; }

        [Column(Name = "CUSTACCOUNT")]
        public string Custaccount { get; set; }

        [Column(Name = "TRANSCODE")]
        public int Transcode { get; set; }

        [Column(Name = "SALESPAYMENTDIFFERENCE")]
        public decimal Salespaymentdifference { get; set; }

        [Column(Name = "NETAMOUNT")]
        public decimal Netamount { get; set; }

        [Column(Name = "COSTAMOUNT")]
        public decimal Costamount { get; set; }

        [Column(Name = "GROSSAMOUNT")]
        public decimal Grossamount { get; set; }

        [Column(Name = "PAYMENTAMOUNT")]
        public decimal Paymentamount { get; set; }

        [Column(Name = "DISCAMOUNT")]
        public decimal Discamount { get; set; }

        [Column(Name = "CUSTDISCAMOUNT")]
        public decimal Custdiscamount { get; set; }

        [Column(Name = "TOTALDISCAMOUNT")]
        public decimal Totaldiscamount { get; set; }

        [Column(Name = "NUMBEROFITEMS")]
        public decimal Numberofitems { get; set; }

        [Column(Name = "AMOUNTTOACCOUNT")]
        public decimal Amounttoaccount { get; set; }

        [Column(Name = "ROUNDEDAMOUNT")]
        public decimal Roundedamount { get; set; }

        [Column(Name = "ENTRYSTATUS")]
        public int Entrystatus { get; set; }

        [Column(Name = "NUMBEROFINVOICES")]
        public int Numberofinvoices { get; set; }

        [Column(Name = "NUMBEROFITEMLINES")]
        public decimal Numberofitemlines { get; set; }

        [Column(Name = "STATEMENTCODE")]
        public string Statementcode { get; set; }

        [Column(Name = "STATEMENTID")]
        public string Statementid { get; set; }

        [Column(Name = "REFUNDRECEIPTID")]
        public string Refundreceiptid { get; set; }

        [Column(Name = "INCOMEEXPENSEAMOUNT")]
        public decimal Incomeexpenseamount { get; set; }

        [Column(Name = "TOACCOUNT")]
        public int Toaccount { get; set; }

        [Column(Name = "NUMBEROFPAYMENTLINES")]
        public int Numberofpaymentlines { get; set; }

        [Column(Name = "SALEISRETURNSALE")]
        public int Saleisreturnsale { get; set; }

        [Column(Name = "COUNTER")]
        public int Counter { get; set; }

        [Column(Name = "TIMEWHENTOTALPRESSED")]
        public int Timewhentotalpressed { get; set; }

        [Column(Name = "TIMEWHENTRANSCLOSED")]
        public int Timewhentransclosed { get; set; }

        [Column(Name = "CURRENCY")]
        public string Currency { get; set; }

        [Column(Name = "TRANSTABLEID")]
        public int Transtableid { get; set; }

        [Column(Name = "OPENDRAWER")]
        public int Opendrawer { get; set; }

        [Column(Name = "REPLICATED")]
        public int Replicated { get; set; }

        [Column(Name = "REPLICATIONCOUNTER")]
        public int Replicationcounter { get; set; }

        [Column(Name = "INCLUDEDINSTATISTICS")]
        public int Includedinstatistics { get; set; }

        [Column(Name = "RETRIEVEDFROMRECEIPTID")]
        public string Retrievedfromreceiptid { get; set; }

        [Column(Name = "CREATEDONPOSTERMINAL")]
        public string Createdonposterminal { get; set; }

        [Column(Name = "POSTASSHIPMENT")]
        public int Postasshipment { get; set; }

        [Column(Name = "ITEMSPOSTED")]
        public int Itemsposted { get; set; }

        [Column(Name = "MODIFIEDDATE")]
        public DateTime Modifieddate { get; set; }

        [Column(Name = "MODIFIEDTIME")]
        public int Modifiedtime { get; set; }

        [Column(Name = "MODIFIEDBY")]
        public string Modifiedby { get; set; }

        [Column(Name = "CREATEDDATE")]
        public DateTime Createddate { get; set; }

        [Column(Name = "CREATEDTIME")]
        public int Createdtime { get; set; }

        [Column(Name = "CREATEDBY")]
        public string Createdby { get; set; }

        [Column(IsPrimaryKey = true, Name = "DATAAREAID")]
        public string Dataareaid { get; set; }

        [Column(Name = "DESCRIPTION")]
        public string Description { get; set; }

        [Column(Name = "CUSTPURCHASEORDER")]
        public string Custpurchaseorder { get; set; }

        [Column(Name = "COMMENT")]
        public string Comment { get; set; }

        [Column(Name = "INVOICECOMMENT")]
        public string Invoicecomment { get; set; }

        [Column(Name = "SALESORDERAMOUNT")]
        public decimal Salesorderamount { get; set; }

        [Column(Name = "SALESINVOICEAMOUNT")]
        public decimal Salesinvoiceamount { get; set; }

        [Column(Name = "RECEIPTEMAIL")]
        public string Receiptemail { get; set; }

        [Column(Name = "EXCHRATE")]
        public decimal Exchrate { get; set; }

        [Column(Name = "BATCHTERMINALID")]
        public string Batchterminalid { get; set; }

        [Column(Name = "BATCHID")]
        public long Batchid { get; set; }

        [Column(Name = "FISCALSERIALID")]
        public string Fiscalserialid { get; set; }

        [Column(Name = "FISCALDOCUMENTID")]
        public string Fiscaldocumentid { get; set; }

        [Column(Name = "CREATEDOFFLINE")]
        public int Createdoffline { get; set; }

        [Column(Name = "INVENTLOCATIONID")]
        public string Inventlocationid { get; set; }

        [Column(Name = "INVENTSITEID")]
        public string Inventsiteid { get; set; }

        [Column(Name = "DLVMODE")]
        public string Dlvmode { get; set; }

        [Column(Name = "RECEIPTDATEREQUESTED")]
        public DateTime Receiptdaterequested { get; set; }

        [Column(Name = "SHIPPINGDATEREQUESTED")]
        public DateTime Shippingdaterequested { get; set; }

        [Column(Name = "CHANNELREFERENCEID")]
        public string Channelreferenceid { get; set; }

        [Column(Name = "LOGISTICSPOSTALADDRESS")]
        public long Logisticspostaladdress { get; set; }

        [Column(Name = "CHANNEL")]
        public long Channel { get; set; }

        [Column(Name = "SALESORDERID")]
        public string Salesorderid { get; set; }
    }
}
