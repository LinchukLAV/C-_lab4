namespace Model
{
    public class Cooler : SingleProduct
    {
        public CoolerMaterial Material { get; init; }
        public CoolerType Type { get; init; }
        public int Speed { get; init; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Матеріал: {Material} Різновид кулеру: {Type} Швидкість обертання: {Speed} (об/сек.)";
        }
    }
}
