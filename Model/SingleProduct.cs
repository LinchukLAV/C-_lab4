using System;
using System.Linq;

namespace Model
{
    public abstract class SingleProduct : Product
    {
        public override string Category => GetType().Name.Split(".").Last();
        public override void Add(Product product)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
