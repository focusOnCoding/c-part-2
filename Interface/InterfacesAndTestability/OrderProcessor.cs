using System;

namespace Testability
{
    public class OrderProcessor
    {
        // change this to a interface so im not dependent on this class
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            // change this so i isolate this from ShippingCalculator
            //_shippingCalculator = new ShippingCalculator();
            _shippingCalculator = shippingCalculator; // now im just referancing the shC
        }

        public void Process(Order order)
        {
            // defansive programming
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            // when tesing a class i need to isolat it from other classes
            // thats why its called unit tseting
            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}