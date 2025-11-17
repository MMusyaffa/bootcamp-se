using PracticeTask;
using Exercise.Loop;
using Exercise.Basic;
using Exercise.Intermediate;


// Task1.RunTask1();
// Task2.RunTask2();
Task3.RunTask();
// LoopTask.RunLoop();
// InterviewQuestion.Run();

// Toyota lgx = new Toyota("V4", 200, 1998, "Red", 84_000_000);
// lgx.Turbo();
// lgx.ShowInfo();

// Wuling airev = new Wuling("V3", 120, 2023, "White", 300_000_000);
// airev.Hybrid();
// airev.ShowInfo();

// lgx.MakeToyota();
// Console.WriteLine("Total Car on showroom " + Car.TotalCar);

// BalockTask.Run();

// BasicExecise.Task();

// Messager2 messager = new Messager2();

// var user1 = new User1("Bob");
// var user2 = new User1("Alicia");

// messager.MsgRecieved += user1.OnMsgRec;
// messager.MsgRecieved += user2.OnMsgRec;

// messager.SendMsg("Hallo user");

// Ini delegate
// public delegate void MsgRecHandler(string msg);


// Publisher
// class Messager2
// {
    // Ini event dari delegate MsgRecHandler yang bernama MsgRecieved
    // public event MsgRecHandler? MsgRecieved;

    // Func<int, int, int> MsgRecieveHandler = (a, b ) => { return a * b; };

    // int z = MsgRecieveHandler(2, 5);

    // Func<int, int> MsgRecieveHandler = HandleMsg; 
    // public static int HandleMsg(int msg)
    // {
    //     return msg;
    // }

    // Pada method ini mengontrol agar hanya bisa di invoke jadi class Messager2
//     public void SendMsg(string message)
//     {
//         Console.WriteLine("Sending Message");
//         MsgRecieved?.Invoke(message);
//         throw new ArgumentOutOfRangeException();
//     }
// }

// Subcriber
// class User1
// {
//     public string Name { get; }
//     public User1(string name)
//     {
//         Name = name;
//     }

//     public void OnMsgRec(string msg)
//     {
//         Console.WriteLine($"Name: {Name}, Message: {msg}");
//     }
// }