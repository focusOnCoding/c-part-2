 namespace Testability
{
    // here i define a role of this class
    // interface methods a always public
    public interface IShippingCalculator
    {
        // no access modifier,
        float CalculateShipping(Order order); // takes an oder object
    }

    // interfaces dont use inheritance but they implemant the interface
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }   
}