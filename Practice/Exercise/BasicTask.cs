using Exercise.Intermediate;

namespace Exercise.Basic
{
    class BasicExecise
    {
        public static void Task()
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            // Task8();
            // Task9();
            // Task10();
            // Task11();
            // Task12();
            // Task13();
            // Task14();
            // Task15();
            // Task16();
            // Task17();
            // Task18();
            // Task19();
            // Task20();
        }

        static void Task1()
        {
            // TODO: Lengkapi bagian yang kosong
            // Menampilkan hasil penjumlahan dari dua bilangan yang dimasukkan pengguna

            Console.Write("Masukkan angka pertama: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("Masukkan angka kedua: ");
            int b = int.Parse(Console.ReadLine()!);

            // Tambahkan kode di sini agar menampilkan hasil penjumlahan
            Console.WriteLine("Hasil: " + (a + b));
        }

        static void Task2()
        {
            // TODO: Gunakan operator modulus untuk memeriksa
            // Memeriksa apakah sebuah bilangan genap atau ganjil menggunakan operator modulus

            int x = 9;
            Console.Write($"Bilangan: {x} adalah ");
            if (x % 2 == 0)
            {
                Console.WriteLine("Genap");
            }
            else
            {
                Console.WriteLine("Ganjil");
            }
        }

        static void Task3()
        {
            // TODO: Lengkapi bagian for loop
            // Tampilkan semua elemen array numbers menggunakan perulangan for

            int[] numbers = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number on array: {numbers[i]}");
            }
        }

        static void Task4()
        {
            // TODO: Gunakan null-coalescing operator
            // Jika name bernilai null, program menampilkan "Guest"

            string? name = null;
            Console.WriteLine("Hello, " + (name ?? "Guest"));
        }

        static void Task5()
        {
            // TODO: Program perkalian sederhana
            int a = 4;
            int b = 5;

            Console.WriteLine($"Hasil perkalian {a} dan {b}: {a * b}");
        }

        static void Task6()
        {
            // TO DO: Buat program yang memiliki array berisi beberapa nilai ujian (misalnya 80, 90, 75, 100, 95).
            // Hitung dan tampilkan rata-rata nilai dari seluruh elemen array tersebut.

            int[] score = { 90, 80, 85, 75, 65, 78, 74, 98 };
            int totalScore = 0;
            float averageScore = 0;

            foreach (var scr in score)
            {
                totalScore += scr;
            }

            averageScore = (float)(totalScore / score.Length);

            Console.WriteLine($"Total score: {totalScore} and Average score: {averageScore}");
        }

        static void Task7()
        {
            // TODO: Buat program yang meminta pengguna memasukkan nama hari (misalnya: senin, sabtu, minggu).
            // Gunakan switch untuk menentukan aktivitas berdasarkan hari tersebut:

            Console.Write("Masukan nama hari favorit: ");
            string hari = Console.ReadLine()!.ToLower();

            Console.Write("Rekomendasi kegiatan: ");

            switch (hari)
            {
                case "senin":
                    Console.WriteLine("Ayo masuk kerja");
                    break;
                case "selasa":
                    Console.WriteLine("Kerja lagi");
                    break;
                case "rabu":
                    Console.WriteLine("Kerja mulu");
                    break;
                case "kamis":
                    Console.WriteLine("Kerja terus");
                    break;
                case "jumat":
                    Console.WriteLine("Sholat jumat");
                    break;
                case "sabtu":
                    Console.WriteLine("Beres beres rumah");
                    break;
                case "minggu":
                    Console.WriteLine("Libur deh");
                    break;
                default:
                    Console.WriteLine("Masukin hari yang bener");
                    break;
            }
        }

        static void Task8()
        {
            // TODO: Buat program yang meminta pengguna memasukkan nama.
            // Tampilkan: Nama dalam huruf besar, dan Jumlah karakter dalam nama tersebut.

            Console.Write("Masukan nama anda: ");
            string? nama = Console.ReadLine();

            string namaBesar = nama!.ToUpper();
            string namaKecil = nama.ToLower();
            int jumlahKarakter = nama.Length;

            Console.WriteLine($"Nama kamu: {nama}, besar: {namaBesar}, kecil: {namaKecil}, panjang: {jumlahKarakter} huruf");
        }

        static void Task9()
        {
            // TODO: Buat array berisi beberapa angka (misalnya 5, 10, 15, 20, 25).
            // Minta pengguna memasukkan angka, lalu periksa apakah angka tersebut ada dalam array.
            // Gunakan perulangan dan variabel boolean untuk menentukan hasil.

            int[] number = { 5, 10, 9, 7, 5, 4, 3, 2, 10, 11, 12 };
            Console.Write("Masukan bilangan: ");
            int inputNum = int.Parse(Console.ReadLine()!);
            bool anySameNum = false;
            foreach (var num in number)
            {
                if (inputNum == num)
                {
                    anySameNum = true;
                }
                else { anySameNum = false; }
            }

            Console.WriteLine($"Input number: {inputNum}, any same number? {(anySameNum ? "Yes" : "No")}");
        }

        static void Task10()
        {
            // TODO: Buat array string yang berisi beberapa nama, dan sisipkan satu elemen null.
            // Tampilkan semua nama dalam huruf besar, tetapi jika ada nilai null, tampilkan "TANPA NAMA".

            string?[] nameCol = { "Budi", "Aldi", "Alta", "Affa", "Noval", "Dimas", "Jewa", null };
            foreach (var name in nameCol)
            {
                Console.WriteLine($"Name list: {name?.ToUpper() ?? "Tanpa Nama"}");
            }
        }

        static void Task11()
        {
            // TODO: Buatlah class bernama Car yang memiliki properti:
            // Brand (string), Year (int), Method DisplayInfo() yang menampilkan "Mobil {Brand} tahun {Year}".
            // Kemudian di Main(), buat object dari Car dan tampilkan informasinya menggunakan method tersebut.

            Car Toyota = new Car("Kijang LGX", 2002);
            Toyota.DisplayInfo();
        }

        static void Task12()
        {
            // TODO: Buatlah class Animal dengan method MakeSound() yang menampilkan "Some sound".
            // Kemudian buat class Dog yang mewarisi Animal dan override MakeSound() menjadi "Woof!".
            // Panggil kedua method tersebut dari object Dog di Main().

            Dog Bulldog = new Dog("Kamam", 4, "Bulldog");
            Bulldog.MakeSound();
        }

        static void Task13()
        {
            // TODO: Buat interface ICalculable yang memiliki method int Add(int a, int b).
            // Lalu buat struct bernama Calculator yang mengimplementasikan interface tersebut.
            // Gunakan struct itu untuk menjumlahkan dua angka dan tampilkan hasilnya.

            SimpleCalculator simpleCalculator = new SimpleCalculator();
            simpleCalculator.Multiple(5, 9);

        }

        static void Task14()
        {
            // TODO: Buat enum Level dengan nilai: Beginner, Intermediate, Expert.
            // Lalu buat class Player yang memiliki: Field name (private), Property Level (public), 
            // Constructor untuk mengatur name dan Level
            // Method ShowProfile() yang menampilkan "Player: {name}, Level: {Level}"

            Player player1 = new Player("Affa", Level.Intermediate);
            string player1Name = player1.getName();
            player1.ShowProfile(player1Name, player1.level);
        }

        static void Task15()
        {
            // TODO: Buat class generic Box<T> yang memiliki:
            // Field Content (tipe T), Method ShowContent(), yang menampilkan isi dari Content Di dalam Box<T>
            // Buat nested class bernama BoxInfo yang memiliki method ShowType() untuk menampilkan jenis data T.

            Box<int> obj1 = new Box<int>(200);
            obj1.ShowContent();

            Box<string>.BoxInfo obj2 = new Box<string>.BoxInfo();
            obj2.ShowType("asdoasdon");
        }

        static void Task16()
        {
            // TODO: Buat abstract class bernama Shape dengan:
            // Method abstract double GetArea(), Property Name bertipe string
            // Lalu buat 2 class turunan: Rectangle dengan properti Width, Height dan Circle dengan properti Radius
            // Keduanya harus override GetArea() untuk menghitung luas sesuai rumus masing-masing, lalu tampilkan hasilnya.

            Rectangle rectangle = new Rectangle("segitiga", 5, 3);
            Console.WriteLine($"Luas {rectangle.getShapeName()} dengan lebar {5}, tinggi {3}: {rectangle.GetArea()}");

            Circle circle = new Circle("lingkaran", 9);
            Console.WriteLine($"Luas {circle.getShapeName()} dengan radius {9}: {circle.GetArea()}");
        }

        static void Task17()
        {
            // TODO: Buat dua interface IMovable dan IRotatable
            // Lalu buat class Robot yang mengimplementasikan kedua interface dan menampilkan pesan berbeda di setiap method:
            // Move() → "Robot is moving forward" Rotate() → "Robot is rotating"
            // Tambahkan method Operate() untuk menjalankan kedua fungsi tersebut.

            Robot testRobot = new Robot();
            testRobot.Operate(19, 50);
        }

        static void Task18()
        {
            // TODO: Buat dua class:
            // Engine → memiliki method Start() dan Stop()
            // Car → memiliki field private _engine bertipe Engine
            // Di dalam class Car, buat method: TurnOn() → memanggil _engine.Start() TurnOff() → memanggil _engine.Stop()
            // Gunakan prinsip composition (bukan inheritance).

            Engine hondaV4 = new Engine("V4 Inline");
            Car2 hyundai = new Car2(hondaV4, "S2000", "Honda");
            Console.WriteLine($"Car Information {hyundai.getCarInfo()}");
            hyundai.TurnOn();
            hyundai.TurnOff();
        }

        static void Task19()
        {
            // TODO: Buat enum Weather dengan nilai: Sunny, Rainy, Cloudy, Storm.
            // Buat class WeatherAdvisor dengan method: void GiveAdvice(Weather condition)

            Random _random = new Random();
            WeatherAdvisor weatherAdvisor = new WeatherAdvisor();
            weatherAdvisor.GiveAdvice(Weather.Rainy);
        }

        static void Task20()
        {
            // TODO: Buat generic class Repository<T> yang hanya menerima tipe data class (where T : class).
            // Tambahkan: Method Add(T item) → menambahkan data ke List<T> Method ShowAll() → menampilkan semua item di list
            // Lalu buat class User dengan properti Name, dan gunakan:
            // Repository<User> userRepo = new Repository<User>();
            // Tambahkan beberapa user dan tampilkan datanya.

            Repository<User> repo = new Repository<User>();
            User user_1 = new User("Dina");
            User user_2 = new User("Tara");
            User user_3 = new User("Gema");

            repo.Add(user_1);
            repo.Add(user_2);
            repo.Add(user_3);
            repo.ShowAll();

            Console.WriteLine(user_1.getUserName());
        }
    }
}