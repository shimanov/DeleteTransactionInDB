using System;
using System.Data.Linq.Mapping;

namespace DeleteTransactionInDB.Model
{
    [Table(Name = "RETAILTRANSACTIONSALESTRANS")]
    public class RetailTransactionSalesTrans
    {
        [Column(IsPrimaryKey = true)]
        public string TRANSACTIONID { get; set; }

        [Column(IsPrimaryKey = true)]
        public decimal LINENUM { get; set; }

        [Column]
        public string RECEIPTID { get; set; }

        [Column]
        public string BARCODE { get; set; }

        [Column]
        public string ITEMID { get; set; }

        [Column]
        public string ITEMDEPARTMENTID { get; set; }

        [Column]
        public string ITEMGROUPID { get; set; }

        [Column]
        public decimal PRICE { get; set; }

        [Column]
        public decimal NETPRICE { get; set; }

        [Column]
        public decimal QTY { get; set; }

        [Column]
        public string TAXGROUP { get; set; }

        [Column]
        public int TRANSACTIONSTATUS { get; set; }

        [Column]
        public decimal DISCAMOUNT { get; set; }

        [Column]
        public decimal COSTAMOUNT { get; set; }

        [Column]
        public DateTime TRANSDATE { get; set; }

        [Column]
        public int TRANSTIME { get; set; }

        [Column]
        public string SHIFT { get; set; }

        [Column]
        public DateTime SHIFTDATE { get; set; }

        [Column]
        public decimal NETAMOUNT { get; set; }

        [Column]
        public string DISCOFFERID { get; set; }

        [Column]
        public string DISCGROUPID { get; set; }

        [Column]
        public decimal STDNETPRICE { get; set; }

        [Column]
        public decimal DISCAMOUNTFROMSTDPRICE { get; set; }

        [Column]
        public string STATEMENTID { get; set; }

        [Column]
        public string CUSTACCOUNT { get; set; }

        [Column]
        public string SECTION { get; set; }
        
        [Column]
        public string SHELF { get; set; }

        [Column]
        public string STATEMENTCODE { get; set; }

        [Column]
        public int TRANSACTIONCODE { get; set; }

        [Column(IsPrimaryKey = true)]
        public string STORE { get; set; }

        [Column]
        public int ITEMIDSCANNED { get; set; }

        [Column]
        public int KEYBOARDITEMENTRY { get; set; }

        [Column]
        public int PRICEINBARCODE { get; set; }

        [Column]
        public int PRICECHANGE { get; set; }

        [Column]
        public int WEIGHTMANUALLYENTERED { get; set; }

        [Column]
        public int LINEWASDISCOUNTED { get; set; }

        [Column]
        public int SCALEITEM { get; set; }

        [Column]
        public int WEIGHTITEM { get; set; }

        [Column]
        public int RETURNNOSALE { get; set; }

        [Column]
        public int ITEMCORRECTEDLINE { get; set; }

        [Column]
        public int SALESTYPE { get; set; }

        [Column]
        public int LINKEDITEMNOTORIGINAL { get; set; }

        [Column]
        public int ORIGINALOFLINKEDITEMLIST { get; set; }

        [Column(IsPrimaryKey = true)]
        public string TERMINALID { get; set; }

        [Column]
        public string STAFF { get; set; }

        [Column]
        public string ITEMPOSTINGGROUP { get; set; }

        [Column]
        public decimal TOTALROUNDEDAMOUNT { get; set; }

        [Column]
        public int COUNTER { get; set; }

        [Column]
        public int REPLICATIONCOUNTER { get; set; }

        [Column]
        public string VARIANTID { get; set; }

        [Column]
        public decimal LINEDSCAMOUNT { get; set; }

        [Column]
        public int REPLICATED { get; set; }

        [Column]
        public decimal CUSTDISCAMOUNT { get; set; }

        [Column]
        public decimal INFOCODEDISCAMOUNT { get; set; }

        [Column]
        public decimal CUSTINVOICEDISCAMOUNT { get; set; }

        [Column]
        public string UNIT { get; set; }

        [Column]
        public decimal UNITQTY { get; set; }

        [Column]
        public decimal UNITPRICE { get; set; }

        [Column]
        public decimal TAXAMOUNT { get; set; }

        [Column]
        public decimal TOTALDISCAMOUNT { get; set; }

        [Column]
        public decimal TOTALDISCPCT { get; set; }

        [Column]
        public decimal TOTALDISCINFOCODELINENUM { get; set; }

        [Column]
        public int PERIODICDISCTYPE { get; set; }

        [Column]
        public decimal PERIODICDISCAMOUNT { get; set; }

        [Column]
        public decimal DISCOUNTAMOUNTFORPRINTING { get; set; }

        [Column]
        public string STAFFID { get; set; }

        [Column]
        public string PERIODICDISCGROUP { get; set; }

        [Column]
        public string INVENTTRANSID { get; set; }

        [Column]
        public string INVENTDIMID { get; set; }

        [Column]
        public string PURCHID { get; set; }

        [Column]
        public string FILELOGID { get; set; }

        [Column]
        public DateTime MODIFIEDDATE { get; set; }

        [Column]
        public int MODIFIEDTIME { get; set; }

        [Column]
        public string MODIFIEDBY { get; set; }

        [Column]
        public long MODIFIEDTRANSACTIONID { get; set; }

        [Column]
        public DateTime CREATEDDATE { get; set; }

        [Column]
        public int CREATEDTIME { get; set; }

        [Column]
        public string CREATEDBY { get; set; }

        [Column]
        public long CREATEDTRANSACTIONID { get; set; }

        [Column(IsPrimaryKey = true)]
        public string DATAAREAID { get; set; }

        [Column]
        public string PRESCRIPTIONID { get; set; }

        [Column]
        public string COMMENT { get; set; }

        [Column]
        public decimal LINEDISCPCT { get; set; }

        [Column]
        public decimal WHOLEDISCAMOUNTWITHTAX { get; set; }

        [Column]
        public decimal TOTALDISCAMOUNTWITHTAX { get; set; }

        [Column]
        public decimal LINEDISCAMOUNTWITHTAX { get; set; }

        [Column]
        public decimal PERIODICDISCAMOUNTWITHTAX { get; set; }

        [Column]
        public string INVENTBATCHID { get; set; }

        [Column]
        public int GIFTCARD { get; set; }

        [Column]
        public string INVENTSERIALID { get; set; }

        [Column]
        public string RFIDTAGID { get; set; }

        [Column]
        public string RETURNTRANSACTIONID { get; set; }

        [Column]
        public decimal RETURNQTY { get; set; }

        [Column]
        public string TAXITEMGROUP { get; set; }

        [Column]
        public string ORIGINALTAXGROUP { get; set; }

        [Column]
        public string ORIGINALTAXITEMGROUP { get; set; }

        [Column]
        public decimal NETAMOUNTINCLTAX { get; set; }

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
        public string LISTINGID { get; set; }

        [Column]
        public long LOGISTICSPOSTALADDRESS { get; set; }

        [Column]
        public decimal RETURNLINENUM { get; set; }

        [Column]
        public string RETURNSTORE { get; set; }

        [Column]
        public string RETURNTERMINALID { get; set; }

        [Column]
        public long CHANNEL { get; set; }

    }
}
