using Pay.Domain.Moldes;

namespace Pay.Domain.Interfaces.Services
{
    public interface IBankDomainService : IDisposable
    {
        void Create(Bank bank);
        Bank? GetByBankCode(int bankCode);
        List<Bank>? GetAll();
    }
}
