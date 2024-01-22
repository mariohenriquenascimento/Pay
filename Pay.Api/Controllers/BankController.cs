using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Pay.Application.Dtos.Requests;
using Pay.Application.Interfaces;

namespace Pay.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BankController : ControllerBase
    {
        private readonly IBankAppService _bankAppService;

        public BankController(IBankAppService bankAppService)
        {
            _bankAppService = bankAppService;
        }

        /// <summary>
        /// Criar dados do Banco.
        /// </summary>
        [Route("create")]
        [HttpPost]
        public IActionResult Create([FromBody] BankAddRequestDto dto)
        {
            return StatusCode(201, _bankAppService.Create(dto));
        }

        /// <summary>
        /// Obter banco por id.
        /// </summary>
        [Route("getBankCode")]
        [HttpGet]
        public IActionResult GetByBankCode(int bankCode)
        {
            var response = _bankAppService.GetByBankCode(bankCode);
            return Ok(response);
        }

        /// <summary>
        /// Obter todos os bancos.
        /// </summary>
        [Route("getAll")]
        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _bankAppService.GetAll();
            return Ok(response);
        }
    }
}
