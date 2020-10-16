using ExemploMediatorComCQRS.Domain.Commands.Responses;
using MediatR;
using System;

namespace ExemploMediatorComCQRS.Domain.Commands.Requests
{
    public class DeleteCustomerRequest : IRequest<DeleteCustomerResponse>
    {
        public Guid Id { get; set; }
    }
}
