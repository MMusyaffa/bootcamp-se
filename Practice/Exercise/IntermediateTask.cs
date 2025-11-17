namespace Exercise.Intermediate
{
    class Car
    {
        private string _brand;
        private int _year;

        public Car(string brand, int year)
        {
            _brand = brand;
            _year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {_brand}, Year: {_year}");
        }
    }

    class Animal
    {
        private string? _name;
        public string Name { get => _name!; set => _name = value; }
        public int Age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine($"{Name}, Some Sound");
        }
    }

    class Dog : Animal
    {
        public string race = "";
        public Dog(string name, int age, string race) : base(name, age)
        {
            this.race = race;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name}, Whoof");
        }
    }

    interface IMathOperation
    {
        void Multiple(int a, int b);
    }

    struct SimpleCalculator : IMathOperation
    {
        public void Multiple(int a, int b)
        {
            Console.WriteLine($"Perkalian dari {a} * {b} = {a * b}");
        }
    }

    enum Level
    {
        Beginner,
        Intermediate,
        Expert,
    }

    class Player
    {
        private string _name;
        public Level level;

        public Player(string nm, Level lv)
        {
            _name = nm;
            level = lv;
        }

        public string getName()
        {
            return _name;
        }

        public void ShowProfile(string name, Level level)
        {
            Console.WriteLine($"Player name: {name}, level: {level}");
        }
    }

    class Box<T>
    {
        private T _content;

        public Box(T value)
        {
            _content = value;
        }
        public void ShowContent()
        {
            Console.WriteLine($"Value: {_content}");
        }

        public class BoxInfo
        {
            public void ShowType(T content)
            {
                Console.WriteLine($"Type of Content is {content?.GetType()}");
            }
        }
    }

    abstract class Shape
    {
        private string _name { get; set; }

        public abstract double GetArea();

        public Shape(string name)
        {
            _name = name;
        }

        public string getShapeName()
        {
            return _name;
        }
    }

    class Rectangle : Shape
    {
        private int _width;
        public int width{ get; set; }
        private int _height { get; set; }

        public Rectangle(string name, int width, int height) : base(name)
        {
            this._width = width;
            this._height = height;
        }

        public override double GetArea()
        {
            return 0.5 * _width * _height;
        }
    }

    class Circle : Shape
    {
        private int _radius { get; set; }

        public Circle(string name, int radius) : base(name)
        {
            this._radius = radius;
        }

        public override double GetArea()
        {
            return 22 / 7 * _radius * 2;
        }
    }

    interface IMovable
    {
        void Move(int step);
    }

    interface IRotateable
    {
        void Rotate(int degree);
    }

    class Robot : IMovable, IRotateable
    {
        private int _step { get; set; }
        private int _rotationDegree { get; set; }

        public void Move(int step)
        {
            Console.WriteLine($"Robot is moving {step} step foward");
        }

        public void Rotate(int degree)
        {
            Console.WriteLine($"Robot is rotating {degree} degree");
        }

        public void Operate(int stepMove, int degreeRotation)
        {
            Move(stepMove);
            Rotate(degreeRotation);
        }
    }

    class Car2
    {
        private Engine _engine { get; set; }
        private string _brand { get; set; }
        private string _name { get; set; }

        public Car2(Engine engine, string name ,string brand)
        {
            _engine = engine;
            _name = name;
            _brand = brand;
        }

        public void TurnOn()
        {
            _engine.Start();
        }

        public void TurnOff()
        {
            _engine.Stop();
        }
        
        public string getCarInfo()
        {
            return _brand + " " +_name;
        }
    }

    class Engine
    {
        private string _name { get; set; }

        public Engine(string name)
        {
            _name = name;
        }

        public void Start()
        {
            Console.WriteLine("Engine Start");
        }

        public void Stop()
        {
            Console.WriteLine("Engine Stop");
        }

        public string getEngineName()
        {
            return _name;
        }
    }

    public enum Weather
    {
        Sunny,
        Rainy,
        Cloudy,
        Storm,
        Windy,
    }

    class WeatherAdvisor
    {
        public void GiveAdvice(Weather condition)
        {
            switch (condition)
            {
                case Weather.Sunny:
                    Console.WriteLine("Ayo pergi jalan jalan");
                    break;
                case Weather.Rainy:
                    Console.WriteLine("Jangan lupa bawa payung");
                    break;
                case Weather.Windy:
                    Console.WriteLine("Pake jaket nanti masuk angin");
                    break;
                case Weather.Storm:
                    Console.WriteLine("Lebih baik dirumah");
                    break;
                case Weather.Cloudy:
                    Console.WriteLine("Mungkin turun hujan");
                    break;
                default:
                    Console.WriteLine("App is under maintenance, try again later");
                    break;

            }
        }
    }

    class Repository<T> where T : class
    {
        List<T> userList = new List<T>();
        
        public void Add(T item)
        {

            userList.Add(item);
        }

        public void ShowAll()
        {
            foreach (var user in userList)
            {
                Console.WriteLine($"Hello new user: {user}");
            }
        }
    }
    
    class User
    {
        private string _name;
        public User(string name)
        {
            _name = name;
        }

        public string getUserName()
        {
            return _name;
        }

        public override string ToString()
        {
            return _name;
        }
    }
}