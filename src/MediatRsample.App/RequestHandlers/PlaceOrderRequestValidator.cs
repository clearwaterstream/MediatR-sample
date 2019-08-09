using FluentValidation;
using MediatRsample.Domain.Model;
using MediatRsample.Domain.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediatR_sample.App.RequestHandlers
{
    public class PlaceOrderRequestValidator : AbstractValidator<PlaceOrderRequest>
    {
        public PlaceOrderRequestValidator()
        {
            RuleFor(x => x.RequestId).NotEmpty();
            RuleFor(x => x.Order).NotNull();
            RuleFor(x => x.Order).SetValidator(new OrderValidator());
            // etc...
        }

        class OrderValidator : AbstractValidator<Order>
        {
            public OrderValidator()
            {
                RuleFor(x => x.ItemsOrdered).NotNull();
                // etc...
            }
        }
    }
}
