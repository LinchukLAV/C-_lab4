using System.Text;
using System.Collections.Generic;

namespace Model
{
    public class AssemblyProduct : Product
    {
        private List<Product> _embeddedProducts = new();

        public override string Category { get; init; } = "Custom Assembly";

        public float DiscountPersentage { get; init; }

        public override void Add(Product product)
        {
            _embeddedProducts.Add(product);
            Price += product.Price;
            Price -= CalculatePrice();
        }
        public override void Remove(Product product)
        {
            _embeddedProducts.Remove(product);
            Price -= product.Price;
        }

        private float CalculatePrice()
        {
            float somePrice = (Price * DiscountPersentage) / 100;

            if (somePrice < 0)
            {
                somePrice = 0;
            }
            return somePrice;
        }

        public override string ToString()
        {
            StringBuilder sb = new(base.ToString() + "\n\n\n");
            foreach (Product product in _embeddedProducts)
            {
                sb.Append(product.ToString() + "\n\n");
            }
            return sb.ToString();
        }
    }
}
