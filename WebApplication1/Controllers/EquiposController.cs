using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperExampleGame.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    public class EquiposController : Controller
    {
        private readonly IMediator _mediator;


        public EquiposController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("CompraEquipos")]
        [ProducesResponseType(typeof(CompraItemSalidaModel), (int)HttpStatusCode.OK)]
        public async Task<ActionResult> PostEquiposCompra([FromBody] CompraItemCommand compraItemCommand)
        {

            var result = await _mediator.Send(compraItemCommand);

            return Ok(result);

        }
    }
}
