namespace Exercise.Delegates
{
    class Delegate
    {
        // Messager2 messager = new Messager2();
        // var user1 = new User1("Bob");
        // var user2 = new User1("Alicia");

        // messager.MsgRecieved += user1.OnMsgRec;
        // messager.MsgRecieved += user2.OnMsgRec;

        // messager.SendMsg("Hallo user");

        // // Ini delegate
        // public delegate void MsgRecHandler(string msg);


        // // Publisher
        // class Messager2
        // {
        //     // Ini event dari delegate MsgRecHandler yang bernama MsgRecieved
        //     public event MsgRecHandler? MsgRecieved;

        //     Func<int, int, int> MsgRecieveHandler = (a, b ) => { return a * b; };

        //     int z = MsgRecieveHandler(2, 5);

        //     Func<int, int> MsgRecieveHandler = HandleMsg; 
        //     public static int HandleMsg(int msg)
        //     {
        //         return msg;
        //     }

        //     // Pada method ini mengontrol agar hanya bisa di invoke jadi class Messager2
        //     public void SendMsg(string message)
        //     {
        //         Console.WriteLine("Sending Message");
        //         MsgRecieved?.Invoke(message);
        //         throw new ArgumentOutOfRangeException();
        //     }
        // }

        // // Subcriber
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
    }
}