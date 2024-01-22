using Pay.Domain.Interfaces.Repositories;
using Pay.Domain.Moldes;
using Pay.Infra.Data.Contexts;

namespace Pay.Infra.Data.Repositories
{
    public class PaymentSlipRepository : BaseRepository<PaymentSlip, Guid>, IPaymentSlipRepository
    {
        private readonly DataContext? _dataContext;

        public PaymentSlipRepository(DataContext? dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
