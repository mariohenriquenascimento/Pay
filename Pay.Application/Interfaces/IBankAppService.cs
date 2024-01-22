using Pay.Application.Dtos.Requests;
using Pay.Application.Dtos.Responses;

namespace Pay.Application.Interfaces
{
    public interface IBankAppService : IDisposable
    {
        BankResponseDto Create(BankAddRequestDto dto);
        BankResponseDto GetByBankCode(int bankCode);
        List<BankResponseDto> GetAll();
    }
}
