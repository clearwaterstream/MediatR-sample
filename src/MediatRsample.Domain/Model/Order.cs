using System;
using System.Collections.Generic;
using System.Text;

namespace MediatRsample.Domain.Model
{
    public class Order
    {
        public Customer Customer { get; set; }
        public IEnumerable<Product> ItemsOrdered { get; set; }
        public DateTime PlacedOn { get; set; }
    }
}
