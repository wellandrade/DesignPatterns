using ExemploMediatorComCQRS.Domain.Commands.Requests;
using ExemploMediatorComCQRS.Domain.Commands.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ExemploMediatorComCQRS.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /* Versao do .net core 2.0 ou superior, já é possível uasr o FromService, nao precisa resolver no construtor 
           Mediator é um padrao que abstrai a comunicao, nao vai precisar especificar qual interface esta relacionada a classe e 
            também qual handler vai gerenciar qual command 
        */

        [HttpPost]
        [Route("customer")]
        public Task<CreateCustomerResponse> Create([FromServices]IMediator mediator, [FromBody]CreateCustomerRequest request)
        {
            return mediator.Send(request);
        }

        [HttpDelete]
        [Route("customer")]
        public Task<DeleteCustomerResponse> Delete([FromServices] IMediator mediator, [FromBody]DeleteCustomerRequest request)
        {
            return mediator.Send(request);
        }
    }
}