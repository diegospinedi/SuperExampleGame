using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SuperExampleGame.Application;
using System.Net;
using System.Threading.Tasks;

namespace SuperExampleGame.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EquiposController : ControllerBase
    {
        
        private readonly IMediator _mediator;


        public EquiposController (IMediator mediator)
        {
           _mediator = mediator;
        }

        [HttpPost]
        [Route("CompraEquipos")]
        [ProducesResponseType(typeof(CompraItemSalidaModel),(int)HttpStatusCode.OK)]
        public async Task <ActionResult> PostEquiposCompra ([FromBody] CompraItemCommand compraItemCommand) {

            var result = await _mediator.Send(compraItemCommand);

            return Ok(result);
        
        }

    }
}
