namespace salesreportapi.Models
{
    public class Sales
    {
        public int TransactionKey { get; set; }
        public DateTime TransactionDate { get; set; }
        public Guid Guid { get; set; }
        public int TicketNumber { get; set; }
        public string LocationName { get; set; }
        public string DeviceName { get; set; }
        public string CashierName { get; set; }
        public string CustomerName { get; set; }

        public List<SaleLines> SaleLines { get; set; }
    }
}
