namespace Model
{
    public class HardDrive : SingleProduct
    {
        public int Speed { get; init; }
        public int Capasity { get; init; }
        public HardDriveType Type { get; init; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Швидкість пам'яті{Speed} Загальна кількість: {Capasity} Тип пам'яті: {Type}";
        }
    }
}
