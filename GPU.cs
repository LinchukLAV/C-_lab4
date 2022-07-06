namespace Model
{
    public class GPU : SingleProduct
    {
        public int CudaFrequency { get; init; }
        public int MemoryAmount { get; init; }
        public MemoryType MemoryType { get; init; }
        public int TDP { get; init; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Частота одного ядра: {CudaFrequency} Кількість відеопам'яті: {MemoryAmount} " +
                $"Тип пам'яті: {MemoryType} TDP: {TDP}";
        }
    }
}
