namespace CarManufacture.Brand
{
    class Wuling : Car
    {
        public Wuling(string engine, int speed, int year, string color, int price)
            : base("Wuling", engine, speed, year, color, price)
        {

        }
        
        public void Hybrid()
        {
            Speed += 40;
        }
    }
}