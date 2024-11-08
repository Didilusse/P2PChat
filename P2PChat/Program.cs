using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start as (S)erver or (C)lient?");
        string? choice = Console.ReadLine();

        // Check for null or invalid input
        if (string.IsNullOrWhiteSpace(choice))
        {
            Console.WriteLine("Invalid input.");
            return;
        }

        Console.WriteLine("Enter IP Address:");
        string? ipAddress = Console.ReadLine();

        Console.WriteLine("Enter Port Number:");
        string? portInput = Console.ReadLine();

        // Check if IP Address or port input is null
        if (string.IsNullOrWhiteSpace(ipAddress) || string.IsNullOrWhiteSpace(portInput) || !int.TryParse(portInput, out int port))
        {
            Console.WriteLine("Invalid IP address or port.");
            return;
        }

        if (choice.ToUpper() == "S")
        {
            P2PServer server = new P2PServer(ipAddress, port);
            while (true)
            {
                string? message = Console.ReadLine();
                
                // Ensure message is not null before sending
                if (!string.IsNullOrWhiteSpace(message))
                {
                    server.SendMessage(message);
                }
            }
        }
        else if (choice.ToUpper() == "C")
        {
            P2PClient client = new P2PClient(ipAddress, port);
            while (true)
            {
                string? message = Console.ReadLine();
                
                // Ensure message is not null before sending
                if (!string.IsNullOrWhiteSpace(message))
                {
                    client.SendMessage(message);
                }
            }
        }
    }
}