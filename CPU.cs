namespace Model
{
    public class CPU : SingleProduct
    {
        public float Frequency { get; init; }
        public int CoresCount { get; init; }
        public int TDP { get; init; }
        public float MaxTemperature { get; init; }

        public override string ToString()
        {
            return base.ToString() + "\n"
                + $"Частота ядра: {Frequency} Кількість ядер: {CoresCount}" +
                $"TDP: {TDP} Максимально допустима температура: {MaxTemperature}";
        }
    }
}
