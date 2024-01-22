using AutoMapper;
using Pay.Application.Dtos.Requests;
using Pay.Application.Dtos.Responses;
using Pay.Application.Interfaces;
using Pay.Domain.Interfaces.Services;
using Pay.Domain.Moldes;

namespace Pay.Application.Services
{
    public class PaymentSlipAppService : IPaymentSlipAppService
    {
        private readonly IPaymentSlipDomainService _paymentSlipDomainService;
        private readonly IMapper _mapper;

        public PaymentSlipAppService(IPaymentSlipDomainService paymentSlipDomainService
            , IMapper mapper)
        {
            _paymentSlipDomainService = paymentSlipDomainService;
            _mapper = mapper;
        }

        public PaymentSlipResponseDto Create(PaymentSlipAddRequestDto dto)
        {
            var paymentSlip = new PaymentSlip
            {
                Id = Guid.NewGuid(),
                PayerName = dto.PayerName,
                PayerDocument = dto.PayerDocument,
                BeneficiaryName = dto.BeneficiaryName,
                BeneficiaryDocument = dto.BeneficiaryDocument,
                Value = dto.Value,
                DueDate = dto.DueDate,
                Observation = dto.Observation,
                BankId = dto.BankId
            };

            _paymentSlipDomainService.Create(paymentSlip);
            return _mapper.Map<PaymentSlipResponseDto>(paymentSlip);
        }

        public void Dispose()
        {
            _paymentSlipDomainService.Dispose();
        }

        public PaymentSlipResponseDto Get(Guid id)
        {
            var paymentSlip = _paymentSlipDomainService.Get(id);

            if (paymentSlip == null) { return new PaymentSlipResponseDto(); }

            return _mapper.Map<PaymentSlipResponseDto>(paymentSlip);
        }
    }
}
