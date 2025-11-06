namespace CarManufacture
{
    public class Car
    {
        public string Brand { get; set; }
        public string Engine { get; set; }
        public int Speed { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public static int TotalCar = 0;

        public Car(string brand, string engine, int speed, int year, string color, int price)
        {
            Brand = brand;
            Engine = engine;
            Speed = speed;
            Year = year;
            Color = color;
            Price = price;
            TotalCar++;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Engine: {Engine}, Top Speed: {Speed} ," +
                            $"Year: {Year}, Color: {Color}, Price: Rp{Price:C}");
        }
    }
}