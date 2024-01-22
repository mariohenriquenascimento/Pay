using Pay.Domain.Moldes;

namespace Pay.Domain.Interfaces.Services
{
    public interface IPaymentSlipDomainService : IDisposable
    {
        void Create(PaymentSlip user);
        PaymentSlip? Get(Guid id);

    }
}
