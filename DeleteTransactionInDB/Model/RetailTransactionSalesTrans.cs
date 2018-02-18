using System;
using System.Data.Linq.Mapping;

namespace DeleteTransactionInDB.Model
{
    [Table(Name = "RETAILTRANSACTIONSALESTRANS")]
    public class RetailTransactionSalesTrans
    {
        [Column(IsPrimaryKey = true, Name = "TRANSACTIONID")]
        public string Transactionid { get; set; }

        [Column(IsPrimaryKey = true, Name = "LINENUM")]
        public decimal Linenum { get; set; }

        [Column(Name = "RECEIPTID")]
        public string Receiptid { get; set; }

        [Column(Name = "BARCODE")]
        public string Barcode { get; set; }

        [Column(Name = "ITEMID")]
        public string Itemid { get; set; }

        [Column(Name = "ITEMDEPARTMENTID")]
        public string Itemdepartmentid { get; set; }

        [Column(Name = "ITEMGROUPID")]
        public string Itemgroupid { get; set; }

        [Column(Name = "PRICE")]
        public decimal Price { get; set; }

        [Column(Name = "NETPRICE")]
        public decimal Netprice { get; set; }

        [Column(Name = "QTY")]
        public decimal Qty { get; set; }

        [Column]
        public string Taxgroup { get; set; }

        [Column]
        public int Transactionstatus { get; set; }

        [Column]
        public decimal Discamount { get; set; }

        [Column]
        public decimal Costamount { get; set; }

        [Column]
        public DateTime Transdate { get; set; }

        [Column]
        public int Transtime { get; set; }

        [Column]
        public string Shift { get; set; }

        [Column]
        public DateTime Shiftdate { get; set; }

        [Column]
        public decimal Netamount { get; set; }

        [Column]
        public string Discofferid { get; set; }

        [Column]
        public string Discgroupid { get; set; }

        [Column]
        public decimal Stdnetprice { get; set; }

        [Column]
        public decimal Discamountfromstdprice { get; set; }

        [Column]
        public string Statementid { get; set; }

        [Column]
        public string Custaccount { get; set; }

        [Column]
        public string Section { get; set; }
        
        [Column]
        public string Shelf { get; set; }

        [Column]
        public string Statementcode { get; set; }

        [Column]
        public int Transactioncode { get; set; }

        [Column(IsPrimaryKey = true)]
        public string Store { get; set; }

        [Column]
        public int Itemidscanned { get; set; }

        [Column]
        public int Keyboarditementry { get; set; }

        [Column]
        public int Priceinbarcode { get; set; }

        [Column]
        public int Pricechange { get; set; }

        [Column]
        public int Weightmanuallyentered { get; set; }

        [Column]
        public int Linewasdiscounted { get; set; }

        [Column]
        public int Scaleitem { get; set; }

        [Column]
        public int Weightitem { get; set; }

        [Column]
        public int Returnnosale { get; set; }

        [Column]
        public int Itemcorrectedline { get; set; }

        [Column]
        public int Salestype { get; set; }

        [Column]
        public int Linkeditemnotoriginal { get; set; }

        [Column]
        public int Originaloflinkeditemlist { get; set; }

        [Column(IsPrimaryKey = true)]
        public string Terminalid { get; set; }

        [Column]
        public string Staff { get; set; }

        [Column]
        public string Itempostinggroup { get; set; }

        [Column]
        public decimal Totalroundedamount { get; set; }

        [Column]
        public int Counter { get; set; }

        [Column]
        public int Replicationcounter { get; set; }

        [Column]
        public string Variantid { get; set; }

        [Column]
        public decimal Linedscamount { get; set; }

        [Column]
        public int Replicated { get; set; }

        [Column]
        public decimal Custdiscamount { get; set; }

        [Column]
        public decimal Infocodediscamount { get; set; }

        [Column]
        public decimal Custinvoicediscamount { get; set; }

        [Column]
        public string Unit { get; set; }

        [Column]
        public decimal Unitqty { get; set; }

        [Column]
        public decimal Unitprice { get; set; }

        [Column]
        public decimal Taxamount { get; set; }

        [Column]
        public decimal Totaldiscamount { get; set; }

        [Column]
        public decimal Totaldiscpct { get; set; }

        [Column]
        public decimal Totaldiscinfocodelinenum { get; set; }

        [Column]
        public int Periodicdisctype { get; set; }

        [Column]
        public decimal Periodicdiscamount { get; set; }

        [Column]
        public decimal Discountamountforprinting { get; set; }

        [Column]
        public string Staffid { get; set; }

        [Column]
        public string Periodicdiscgroup { get; set; }

        [Column]
        public string Inventtransid { get; set; }

        [Column]
        public string Inventdimid { get; set; }

        [Column]
        public string Purchid { get; set; }

        [Column]
        public string Filelogid { get; set; }

        [Column]
        public DateTime Modifieddate { get; set; }

        [Column]
        public int Modifiedtime { get; set; }

        [Column]
        public string Modifiedby { get; set; }

        [Column]
        public long Modifiedtransactionid { get; set; }

        [Column]
        public DateTime Createddate { get; set; }

        [Column]
        public int Createdtime { get; set; }

        [Column]
        public string Createdby { get; set; }

        [Column]
        public long Createdtransactionid { get; set; }

        [Column(IsPrimaryKey = true)]
        public string Dataareaid { get; set; }

        [Column]
        public string Prescriptionid { get; set; }

        [Column]
        public string Comment { get; set; }

        [Column]
        public decimal Linediscpct { get; set; }

        [Column]
        public decimal Wholediscamountwithtax { get; set; }

        [Column]
        public decimal Totaldiscamountwithtax { get; set; }

        [Column]
        public decimal Linediscamountwithtax { get; set; }

        [Column]
        public decimal Periodicdiscamountwithtax { get; set; }

        [Column]
        public string Inventbatchid { get; set; }

        [Column]
        public int Giftcard { get; set; }

        [Column]
        public string Inventserialid { get; set; }

        [Column]
        public string Rfidtagid { get; set; }

        [Column]
        public string Returntransactionid { get; set; }

        [Column]
        public decimal Returnqty { get; set; }

        [Column]
        public string Taxitemgroup { get; set; }

        [Column]
        public string Originaltaxgroup { get; set; }

        [Column]
        public string Originaltaxitemgroup { get; set; }

        [Column]
        public decimal Netamountincltax { get; set; }

        [Column]
        public string Inventlocationid { get; set; }

        [Column]
        public string Inventsiteid { get; set; }

        [Column]
        public string Dlvmode { get; set; }

        [Column]
        public DateTime Receiptdaterequested { get; set; }

        [Column]
        public DateTime Shippingdaterequested { get; set; }

        [Column]
        public string Listingid { get; set; }

        [Column]
        public long Logisticspostaladdress { get; set; }

        [Column]
        public decimal Returnlinenum { get; set; }

        [Column]
        public string Returnstore { get; set; }

        [Column]
        public string Returnterminalid { get; set; }

        [Column]
        public long Channel { get; set; }

    }
}
