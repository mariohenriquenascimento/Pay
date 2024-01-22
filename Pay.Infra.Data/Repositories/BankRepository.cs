using Pay.Domain.Interfaces.Repositories;
using Pay.Domain.Moldes;
using Pay.Infra.Data.Contexts;

namespace Pay.Infra.Data.Repositories
{
    public class BankRepository : BaseRepository<Bank, Guid>, IBankRepository
    {
        private readonly DataContext? _dataContext;

        public BankRepository(DataContext? dataContext) : base(dataContext)
        {
            _dataContext = dataContext;
        }
    }
}
