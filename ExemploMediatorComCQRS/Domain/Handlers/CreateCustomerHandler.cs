using ExemploMediatorComCQRS.Domain.Commands.Requests;
using ExemploMediatorComCQRS.Domain.Commands.Responses;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExemploMediatorComCQRS.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            /* Handle responsavel por toda validacao
                Verifica se cliente ja existe
                Valida os dados
                Faz o cadastro
                Notificacao
            */

            var createCustomer = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Well",
                Email = "well@gmail.com",
                Date = DateTime.Now
            };


            return Task.FromResult(createCustomer);
        }
    }
}
