using Pay.Application.Dtos.Requests;
using Pay.Application.Dtos.Responses;

namespace Pay.Application.Interfaces
{
    public interface IPaymentSlipAppService : IDisposable
    {
        PaymentSlipResponseDto Create(PaymentSlipAddRequestDto dto);
        PaymentSlipResponseDto Get(Guid id);
    }
}
