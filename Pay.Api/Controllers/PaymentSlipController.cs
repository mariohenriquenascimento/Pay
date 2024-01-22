using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pay.Application.Dtos.Requests;
using Pay.Application.Interfaces;

namespace Pay.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentSlipController : ControllerBase
    {
        private readonly IPaymentSlipAppService _paymentSlipAppService;

        public PaymentSlipController(IPaymentSlipAppService paymentSlipAppService)
        {
            _paymentSlipAppService = paymentSlipAppService;
        }

        /// <summary>
        /// Criar Boleto
        /// </summary>
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] PaymentSlipAddRequestDto dto)
        {
            return StatusCode(201, _paymentSlipAppService.Create(dto));
        }

        /// <summary>
        /// Obter boleto por id
        /// </summary>
        [Route("getAll")]
        [HttpGet]
        public IActionResult GetById(Guid id)
        {
            return StatusCode(201, _paymentSlipAppService.Get(id));
        }
    }
}
