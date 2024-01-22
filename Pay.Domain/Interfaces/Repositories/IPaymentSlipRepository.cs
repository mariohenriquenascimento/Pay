using Pay.Domain.Moldes;

namespace Pay.Domain.Interfaces.Repositories
{
    public interface IPaymentSlipRepository : IBaseRepository<PaymentSlip, Guid>
    {
    }
}
