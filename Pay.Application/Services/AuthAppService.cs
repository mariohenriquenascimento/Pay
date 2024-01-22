using Pay.Application.Dtos.Requests;
using Pay.Application.Dtos.Responses;
using Pay.Application.Interfaces;
using Pay.Domain.Exceptions;
using Pay.Domain.Interfaces.Services;

namespace Pay.Application.Services
{
    public class AuthAppService : IAuthAppService
    {
        private readonly IUserDomainService _userDomainService;

        public AuthAppService(IUserDomainService userDomainService)
        {
            _userDomainService = userDomainService;
        }

        public LoginResponseDto Login(LoginRequestDto dto)
        {
            try
            {
                var accessToken = _userDomainService.Authenticate(dto.Email, dto.Password);

                return new LoginResponseDto
                {
                    AccessToken = accessToken
                };
            }
            catch (AccessDeniedException e)
            {
                throw new ApplicationException(e.Message);
            }
        }

        public void Dispose()
        {
            _userDomainService.Dispose();
        }
    }
}
