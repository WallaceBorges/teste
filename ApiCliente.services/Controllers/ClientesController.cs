using ApiCliente.Services.Models.Requests;
using ApiCliente.Services.Models.responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiCliente.services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        /// <summary>
        /// serviço para cadastro de clientes
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(ClientesReponse),StatusCodes.Status201Created)]
        public IActionResult Post(ClientesCreateRequest request)
        {
            return Ok();
        }

        /// <summary>
        /// serviço para Atualização de clientes
        /// </summary>
        [HttpPut]
        [ProducesResponseType(typeof(ClientesReponse),StatusCodes.Status200OK)]
        public IActionResult Put(ClientesUpdateRequest request)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(ClientesReponse), StatusCodes.Status200OK)]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ClientesReponse>), StatusCodes.Status200OK)]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClientesReponse), StatusCodes.Status200OK)]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }
    }
}
