using AutoMapper;
using Pay.Application.Dtos.Requests;
using Pay.Application.Dtos.Responses;
using Pay.Application.Interfaces;
using Pay.Domain.Interfaces.Services;
using Pay.Domain.Moldes;

namespace Pay.Application.Services
{
    public class BankAppService : IBankAppService
    {
        private readonly IBankDomainService _bankDomainService;
        private readonly IMapper _mapper;

        public BankAppService(IBankDomainService bankDomainService, IMapper mapper)
        {
            _bankDomainService = bankDomainService;
            _mapper = mapper;
        }

        public BankResponseDto Create(BankAddRequestDto dto)
        {
            var bank = new Bank
            {
                Id = Guid.NewGuid(),
                BankName = dto.BankName,
                BankCode = dto.BankCode,
                InterestPercentage = dto.InterestPercentage
            };

            _bankDomainService.Create(bank);
            return _mapper.Map<BankResponseDto>(bank);
        }

        public BankResponseDto GetByBankCode(int bankCode)
        {
            var bank = _bankDomainService.GetByBankCode(bankCode);

            if (bank == null) { return new BankResponseDto(); }

            return _mapper.Map<BankResponseDto>(bank);
        }

        public List<BankResponseDto> GetAll()
        {
            var bank = _bankDomainService.GetAll();

            if (bank == null) { return new List<BankResponseDto>(); }   
            return _mapper.Map<List<BankResponseDto>>(bank);
        }

        public void Dispose()
        {
            _bankDomainService.Dispose();
        }
    }
}
