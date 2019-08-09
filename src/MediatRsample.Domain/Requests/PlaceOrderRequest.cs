using FluentValidation.Results;
using MediatR;
using MediatRsample.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRsample.Domain.Requests
{
    public class PlaceOrderRequest : IRequest<PlaceOrderResponse>
    {
        public string RequestId { get; set; }
        public DateTime RequestDate { get; set; }
        public Order Order { get; set; }
    }

    public class PlaceOrderResponse
    {
        public string ResponseId { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
