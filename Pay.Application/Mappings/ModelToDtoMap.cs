using AutoMapper;
using Pay.Application.Dtos.Responses;
using Pay.Domain.Moldes;

namespace Pay.Application.Mappings
{
    public class ModelToDtoMap : Profile
    {
        public ModelToDtoMap()
        {
            CreateMap<Bank, BankResponseDto>();
            CreateMap<PaymentSlip, PaymentSlipResponseDto>();
            CreateMap<User, UserResponseDto>();
        }
    }
}
