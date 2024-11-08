using System;
using System.Net.Sockets;
using System.IO;
using System.Threading;

public class P2PClient
{
    private TcpClient client;

    public P2PClient(string ip, int port)
    {
        client = new TcpClient(ip, port);
        Console.WriteLine($"Connected to the server at {ip}:{port}!");

        // Start receiving messages
        Thread receiveThread = new Thread(new ThreadStart(ReceiveMessages));
        receiveThread.Start();
    }

    private void ReceiveMessages()
    {
        StreamReader reader = new StreamReader(client.GetStream());
        while (true)
        {
            try
            {
                string message = reader.ReadLine();
                if (message != null)
                {
                    Console.WriteLine("Friend: " + message);
                }
            }
            catch
            {
                Console.WriteLine("Connection closed.");
                break;
            }
        }
    }

    public void SendMessage(string message)
    {
        StreamWriter writer = new StreamWriter(client.GetStream());
        writer.WriteLine(message);
        writer.Flush();
    }
}