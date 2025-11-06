namespace CarManufacture.Brand
{
    public class Toyota : Car
    {
        public Toyota(string engine, int speed, int year, string color, int price)
            : base("Toyota", engine, speed, year, color, price)
        {

        }

        public void Turbo()
        {
            Speed += 50;
        }

        public void MakeToyota()
        {
            Console.WriteLine("Welcome To Toyota Creation");

            Console.Write("Enter Car Engine: ");
            string eng = Console.ReadLine()!;
            Console.Write("Enter Car Speed: ");
            int spd = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Car Year: ");
            int yr = int.Parse(Console.ReadLine()!);
            Console.Write("Enter Car Color: ");
            string col = Console.ReadLine()!;
            Console.Write("Enter Car Price: ");
            int prc = int.Parse(Console.ReadLine()!);

            Toyota newCar = new Toyota(eng, spd, yr, col, prc);
            newCar.ShowInfo();
        }
    }
}
