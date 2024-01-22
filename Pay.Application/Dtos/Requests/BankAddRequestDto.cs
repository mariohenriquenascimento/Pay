using System.ComponentModel.DataAnnotations;

namespace Pay.Application.Dtos.Requests
{
    public class BankAddRequestDto
    {
        [Required(ErrorMessage = "Informe o nome do banco.")]
        [MinLength(8, ErrorMessage = "Informe o nome compelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe o nome com no máximo {1} caracteres.")]
        public string BankName { get; set; }

        [Required(ErrorMessage = "Informe o codigo do banco.")]
        public int BankCode { get; set; }

        [Required(ErrorMessage = "Informe o percentual de juros.")]
        public decimal InterestPercentage { get; set; }
    }
}
