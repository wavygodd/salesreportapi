using System.ComponentModel.DataAnnotations;

namespace salesreportapi.Models
{
    public class SaleLines
    {

        [Key]
        public int SaleLineId { get; set; }
        public int TransactionKey { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public decimal VAT { get; set; }
        public decimal VATRate { get; set; }

        public Sales Sales { get; set; }
    }
}
