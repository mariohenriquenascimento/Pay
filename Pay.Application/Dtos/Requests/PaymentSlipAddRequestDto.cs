using System.ComponentModel.DataAnnotations;

namespace Pay.Application.Dtos.Requests
{
    public class PaymentSlipAddRequestDto
    {
        public Guid? Id { get; set; }
        [Required(ErrorMessage = "Informe o nome do pagador.")]
        [MinLength(8, ErrorMessage = "Informe o nome com pelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe o nome com no máximo {1} caracteres.")]
        public string PayerName { get; set; }

        [Required(ErrorMessage = "Informe o documento do pagador.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$|^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$", 
            ErrorMessage = "Documento inválido.")]
        public string PayerDocument { get; set; }

        [Required(ErrorMessage = "Informe o nome do benificiario.")]
        [MinLength(8, ErrorMessage = "Informe o nome com pelo menos {1} caracteres.")]
        [MaxLength(150, ErrorMessage = "Informe o nome com no máximo {1} caracteres.")]
        public string BeneficiaryName { get; set; }

        [Required(ErrorMessage = "Informe o documento do benificiario.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$|^\d{2}\.\d{3}\.\d{3}\/\d{4}-\d{2}$", 
            ErrorMessage = "Documento inválido.")]
        public string BeneficiaryDocument { get; set; }

        [Required(ErrorMessage = "Informe o nome do benificiario.")]
        [RegularExpression(@"^\d+(\.\d{1,2})?$", 
            ErrorMessage = "O campo Value deve ser um valor decimal válido.")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "Informe a data de vencimento.")]
        [DataType(DataType.DateTime, ErrorMessage = "O campo DueDate deve ser do tipo DateTime.")]
        public DateTime DueDate { get; set; }
        public string? Observation { get; set; }

        [Required(ErrorMessage = "Informe o ID do banco.")]
        [RegularExpression(@"^[0-9a-fA-F]{8}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{4}-[0-9a-fA-F]{12}$", 
            ErrorMessage = "O campo Id deve ser um valor GUID válido.")]
        public Guid BankId { get; set; }

        
    }
}
