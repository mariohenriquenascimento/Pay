namespace Pay.Domain.Moldes
{
    public class Bank
    {
        public Guid Id { get; set; }
        public string BankName { get; set; }
        public int BankCode { get; set; }
        public decimal InterestPercentage { get; set; }
        public List<PaymentSlip> PaymentSlips { get; set; }
    }
}
