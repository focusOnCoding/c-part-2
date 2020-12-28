namespace Generics
{
    // constrance type
    /*
     where T : IComparable {Interface} above
     where T : Product {class or subclass}
     where T : struct {Value}
     where T : class {referance type}
     where T : new() {Object defualt constructor}
     */

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class Books : Product
    {
        public string Isbn { get; set; }
    }

    //where T : Product {class or subclass
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    //where T : struct {Value types} cant be null
    public class Nullable<T> where T : struct
    {
        // give this type an ablility to be nullable == null
        private object _value;

        // default constractor in case value is not set
        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}

