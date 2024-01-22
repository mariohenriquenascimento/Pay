using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pay.Application.Dtos.Responses
{
    public class BankResponseDto
    {
        public Guid? Id { get; set; }
        public string? BankName { get; set; }
        public int BankCode { get; set; }
        public decimal InterestPercentage { get; set; }
    }
}
