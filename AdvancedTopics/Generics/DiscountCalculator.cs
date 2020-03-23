using AdvancedTopics.Samples;

namespace AdvancedTopics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float ClaculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
}
