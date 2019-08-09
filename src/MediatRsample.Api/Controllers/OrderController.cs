using clearwaterstream.Util;
using MediatRsample.Domain.Requests;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRsample.Api.Controllers
{
    public class OrderController : Controller
    {
        public async Task<IActionResult> Place(CancellationToken cancellationToken)
        {
            // we need to get the posted request, and send it to MediatR to execute ...
            var req = JsonUtil.Deserialize<PlaceOrderRequest>(Request.Body);

            var resp = await req.Execute(cancellationToken);

            // we then serialize the response
            return Json(resp);
        }
    }
}
