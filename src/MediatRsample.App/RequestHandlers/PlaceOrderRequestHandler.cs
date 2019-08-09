using MediatR;
using MediatRsample.Domain.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR_sample.App.RequestHandlers
{
    public class PlaceOrderRequestHandler : IRequestHandler<PlaceOrderRequest, PlaceOrderResponse>
    {
        public async Task<PlaceOrderResponse> Handle(PlaceOrderRequest request, CancellationToken cancellationToken)
        {
            var resp = new PlaceOrderResponse();

            var validator = new PlaceOrderRequestValidator();

            resp.ValidationResult = validator.Validate(request);

            if (resp.ValidationResult.Errors.Any())
                return resp;

            // execute whatever logic is needed to place the order
            await Task.CompletedTask;

            resp.ResponseId = "1";

            return resp;
        }
    }
}
