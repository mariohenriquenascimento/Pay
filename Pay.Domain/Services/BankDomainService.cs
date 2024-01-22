using Pay.Domain.Interfaces.Repositories;
using Pay.Domain.Interfaces.Services;
using Pay.Domain.Moldes;

namespace Pay.Domain.Services
{
    public class BankDomainService : IBankDomainService
    {
        private readonly IUnitOfWork _unitOfWork;
        public BankDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(Bank bank)
        {
            _unitOfWork.BankRepository.Add(bank);
            _unitOfWork.SaveChanges();
        }        

        public Bank? GetByBankCode(int bankCode)
        {
            return _unitOfWork.BankRepository.Get(u => u.BankCode.Equals(bankCode));
        }

        public List<Bank>? GetAll()
        {
            return _unitOfWork.BankRepository.GetAll();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
