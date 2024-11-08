using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start as (S)erver or (C)lient?");
        string choice = Console.ReadLine();

        if (choice.ToUpper() == "S")
        {
            P2PServer server = new P2PServer("127.0.0.1", 8888);
            while (true)
            {
                string message = Console.ReadLine();
                server.SendMessage(message);
            }
        }
        else if (choice.ToUpper() == "C")
        {
            P2PClient client = new P2PClient("127.0.0.1", 8888);
            while (true)
            {
                string message = Console.ReadLine();
                client.SendMessage(message);
            }
        }
    }
}