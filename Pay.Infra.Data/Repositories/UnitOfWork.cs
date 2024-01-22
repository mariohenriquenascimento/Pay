using Pay.Domain.Interfaces.Repositories;
using Pay.Infra.Data.Contexts;

namespace Pay.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext? _dataContext;
        public UnitOfWork(DataContext? dataContext)
        {
            _dataContext = dataContext;
        }

        public IBankRepository BankRepository => new BankRepository(_dataContext);

        public IPaymentSlipRepository PaymentSlipRepository => new PaymentSlipRepository(_dataContext);

        public IUserRepository UserRepository => new UserRepository(_dataContext);

        public void SaveChanges()
        {
            _dataContext?.SaveChanges();
        }
        public void Dispose()
        {
            _dataContext?.Dispose();
        }
    }
}
