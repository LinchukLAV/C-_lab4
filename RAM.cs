namespace Model
{
    public class RAM : SingleProduct
    {
        public int MemoryAmount { get; init; }
        public MemoryType MemoryType { get; init; }
        public int PinsCount { get; init; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Кількість пам'яті {MemoryAmount} (мб.) Тип пам'яті: {MemoryType} " +
                $"Кількість планок: {PinsCount} (шт.)";
        }
    }
}
