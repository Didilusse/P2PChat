using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start as (S)erver or (C)lient?");
        string choice = Console.ReadLine();

        Console.WriteLine("Enter IP Address:");
        string ipAddress = Console.ReadLine();

        Console.WriteLine("Enter Port Number:");
        int port = int.Parse(Console.ReadLine());

        if (choice.ToUpper() == "S")
        {
            P2PServer server = new P2PServer(ipAddress, port);
            while (true)
            {
                string message = Console.ReadLine();
                server.SendMessage(message);
            }
        }
        else if (choice.ToUpper() == "C")
        {
            P2PClient client = new P2PClient(ipAddress, port);
            while (true)
            {
                string message = Console.ReadLine();
                client.SendMessage(message);
            }
        }
    }
}