namespace Model
{
    public class Monitor : SingleProduct
    {
        public (int, int) Resolution { get; set; }
        public MatrixType Matrix { get; set; }
        public float ReactionTime { get; set; }

        public override string ToString()
        {
            return base.ToString() + "\n" +
                $"Кількість пікселів: {Resolution.Item1}x{Resolution.Item2}" +
                $" Тип матриці: {Matrix} Затримка кадру: {ReactionTime}";
        }
    }
}
