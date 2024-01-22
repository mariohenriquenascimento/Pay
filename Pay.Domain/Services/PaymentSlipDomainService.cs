using Pay.Domain.Interfaces.Repositories;
using Pay.Domain.Interfaces.Services;
using Pay.Domain.Moldes;

namespace Pay.Domain.Services
{
    public class PaymentSlipDomainService : IPaymentSlipDomainService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PaymentSlipDomainService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(PaymentSlip paymentSlip)
        {
            _unitOfWork.PaymentSlipRepository.Add(paymentSlip);
            _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork?.Dispose();
        }

        public PaymentSlip? Get(Guid id)
        {
            var paymentSlip = _unitOfWork.PaymentSlipRepository.GetById(id);

            if (paymentSlip == null) { return null; }

            var bank = _unitOfWork.BankRepository.GetById(paymentSlip.BankId);

            if (bank == null) { return null; }

            if (IsPaymentSlipExpired(paymentSlip))
            {
                int diasAtraso = (int)(DateTime.Now - paymentSlip.DueDate).TotalDays;

                paymentSlip.Value = (paymentSlip.Value * bank.InterestPercentage * diasAtraso);
                return paymentSlip;
            }
            else
            {
                return paymentSlip;
            }
        }

        private bool IsPaymentSlipExpired(PaymentSlip paymentSlip)
        {
            return DateTime.Now > paymentSlip.DueDate;
        }
        
    }
}
