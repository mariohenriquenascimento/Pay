using System;
using AutoMapper;
using Moq;
using Pay.Application.Dtos.Requests;
using Pay.Application.Dtos.Responses;
using Pay.Application.Services;
using Pay.Domain.Interfaces.Services;
using Pay.Domain.Moldes;
using Xunit;

namespace Pay.Tests
{
    public class PaymentSlipAppServiceTest
    {
        [Fact]
        public void Create_DeveChamarMetodoCreateDoDomainServiceEMappearParaDto()
        {
            // Arrange
            var paymentSlipDomainServiceMock = new Mock<IPaymentSlipDomainService>();
            var mapperMock = new Mock<IMapper>();

            var paymentSlipAppService = new PaymentSlipAppService(paymentSlipDomainServiceMock.Object, mapperMock.Object);

            var paymentSlipAddRequestDto = new PaymentSlipAddRequestDto
            {
                PayerName = "John Doe",
                // Outras propriedades necessárias para criar um PaymentSlipAddRequestDto
            };

            var paymentSlip = new PaymentSlip
            {
                Id = Guid.NewGuid(),
                PayerName = paymentSlipAddRequestDto.PayerName,
                // Outras propriedades necessárias para criar um PaymentSlip
            };

            mapperMock.Setup(x => x.Map<PaymentSlipResponseDto>(paymentSlip)).Returns(new PaymentSlipResponseDto());

            // Act
            var result = paymentSlipAppService.Create(paymentSlipAddRequestDto);

            // Assert
            paymentSlipDomainServiceMock.Verify(x => x.Create(It.IsAny<PaymentSlip>()), Times.Once);
            mapperMock.Verify(x => x.Map<PaymentSlipResponseDto>(paymentSlip), Times.Once);

            // Adicione mais verificações conforme necessário para garantir que o método está se comportando conforme esperado.
        }
    }

}
