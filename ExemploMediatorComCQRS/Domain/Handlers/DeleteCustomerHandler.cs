using ExemploMediatorComCQRS.Domain.Commands.Requests;
using ExemploMediatorComCQRS.Domain.Commands.Responses;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace ExemploMediatorComCQRS.Domain.Handlers
{
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerRequest, DeleteCustomerResponse>
    {
        public Task<DeleteCustomerResponse> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            var removeCustomer = new DeleteCustomerResponse
            {
                Sucess = true,
                Message = "Customer sucessfully removed"
            };

            return Task.FromResult(removeCustomer);
        }
    }
}
