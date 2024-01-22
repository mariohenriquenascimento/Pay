using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay.Application.Dtos.Responses
{
    public class PaymentSlipResponseDto
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
    }
}
