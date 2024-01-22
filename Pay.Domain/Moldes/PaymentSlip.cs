namespace Pay.Domain.Moldes
{
    public class PaymentSlip
    {
        public Guid Id { get; set; }
        public string PayerName { get; set; }
        public string PayerDocument { get; set; }
        public string BeneficiaryName { get; set; }
        public string BeneficiaryDocument { get; set; }
        public decimal Value { get; set; }
        public DateTime DueDate { get; set; }
        public string Observation { get; set; }

        public Guid BankId { get; set; }
        public Bank Bank { get; set; }

    }
}
