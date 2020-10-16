using ExemploMediatorComCQRS.Domain.Commands.Responses;
using MediatR;

namespace ExemploMediatorComCQRS.Domain.Commands.Requests
{
    /* O command no CQRS representa uma ação, lembrando que o CQRS é quando separamos a aplicação com duas fonte de dados
        Uma fonte para leitura e outra fonte para escrita
    */
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
