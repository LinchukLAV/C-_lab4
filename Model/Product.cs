namespace Model
{
    public abstract class Product
    {
        public string Title { get; init; } = string.Empty;
        public virtual string Category { get; init; } = string.Empty;
        public string SKU { get; init; } = string.Empty;
        public float Price { get; set; }

        public abstract void Add(Product product);
        public abstract void Remove(Product product);

        public override string ToString()
        {
            return $"Назва товару: {Title} Категорія товару: {Category} " +
                $"Артікул: {SKU} Ціна: {Price} $";
        }
    }
}
