namespace Exercise.Loop
{
    class LoopTask
    {
        public static void RunLoop()
        {
            Loop1();
            Loop2();
            Loop3();
            Loop4();
            Loop5();
        }

        // TODO: Soal 1 — FizzBuzz versi 4 angka
        // Buat program yang menampilkan:
        // "foo" jika habis dibagi 3, "bar" jika habis dibagi 5, "baz" jika habis dibagi 7, "qux" jika habis dibagi 9
        // Gabungkan kata-kata tersebut jika lebih dari satu kondisi terpenuhi, Jika tidak ada yang cocok, tampilkan angkanya
        // Gunakan kode sederhana (tanpa nested if).
        public static void Loop1()
        {
            int number = 0;
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                string output = "";

                if (i % 3 == 0)
                {
                    output += "foo";
                }
                if (i % 5 == 0)
                {
                    output += "bar";
                }
                if (i % 7 == 0)
                {
                    output += "jaz";
                }
                if (i % 9 == 0)
                {
                    output += "qux";
                }

                Console.Write((output == "" ? i.ToString() : output) + ", ");
            }
        }

        public static void Loop2()
        {
            // TODO: Buat program yang menggunakan switch untuk menentukan aktivitas berdasarkan hari:
            // Senin–Jumat: "Kerja", Sabtu: "Liburan", Minggu: "Istirahat"
            // Namun, ubahlah logika switch ini menjadi tanpa switch dan tanpa nested if
            // Buat satu baris logika sederhana menggunakan operator ternary(? :).
            string day = "";
            Console.Write("\nEnter a day: ");
            day = Console.ReadLine();
            
            string daySmallChar = day.ToLower();
            Console.WriteLine("Saran aktifitas " +
                                (daySmallChar == "sabtu" || daySmallChar == "saturday" ? "Liburan" : 
                                daySmallChar == "minggu" || daySmallChar == "sunday" ? "Istirahat" : "Kerja"));
        }

        public static void Loop3()
        {
            // TODO: Kamu punya score (0–100). Buat program yang memberi grade:
            // A jika ≥ 90, B jika ≥ 80, C jika ≥ 70, D jika ≥ 60, E jika < 60
            // Awalnya program menggunakan nested if-else, ubahlah menjadi if-else linear atau gunakan expression-bodied switch (fitur C# modern).
            int score = 0;
            string grade = "";

            Console.Write("Enter your score: ");
            score = int.Parse(Console.ReadLine());
            
            if (score >= 90) grade = "A"; 
            else if (score >= 80) grade = "B"; 
            else if (score >= 70) grade = "C"; 
            else if (score >= 60) grade = "D"; 
            else grade = "E"; 

            Console.WriteLine($"With score: {score}, your grade is: {grade}");
        }

        public static void Loop4()
        {
            // TODO: Program awal membuat segitiga bintang menggunakan nested loop for seperti
            // Ubah program tersebut agar tetap menghasilkan pola yang sama tanpa menggunakan nested loop
            // misalnya dengan new string('*', i).

            int triangle = 0;
            Console.Write("Enter number to make triangle: ");
            triangle = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= triangle; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        public static void Loop5()
        {
            // TODO: Toko memberikan diskon berdasarkan kategori dan harga:
            // Jika kategori "Elektronik" dan harga > 2 juta → diskon 10%
            // Jika "Fashion" dan harga > 500 ribu → diskon 20% dan Jika "Makanan" → diskon 5%
            // Awalnya kode menggunakan nested if:
            // Ubahlah menjadi kode sederhana menggunakan kombinasi && dan operator ternary (? :).

            int elektronikPrice = 500_000;
            int fashionPrice = 300_000;
            int foodPrice = 50_000;

            Console.Write("Enter amount you electrict product: ");
            int electrictAmount = int.Parse(Console.ReadLine());

            Console.Write("Enter amount you fashion product: ");
            int fashionAmount = int.Parse(Console.ReadLine());

            Console.Write("Enter amount you food product: ");
            int foodAmount = int.Parse(Console.ReadLine());

            int totalPrice = (electrictAmount * elektronikPrice) + (fashionAmount * fashionPrice) + (foodAmount * foodPrice);

            double diskon = 0;
            diskon += electrictAmount * elektronikPrice > 2_000_000 ? electrictAmount * elektronikPrice * 0.1 : 0;
            diskon += fashionAmount * fashionPrice > 500_000 ? fashionAmount * fashionPrice * 0.2 : 0;
            diskon += foodAmount * foodPrice * 0.05;
                        
            double finalPrice = totalPrice - diskon;
            
            Console.WriteLine($"Total price: Rp{finalPrice:C} from Rp{totalPrice:C} and discount: RP{diskon:C}");
        }
    }
}