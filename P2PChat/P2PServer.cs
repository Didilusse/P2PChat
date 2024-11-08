using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

public class P2PServer
{
    private TcpListener listener;
    private TcpClient client;

    public P2PServer(string ip, int port)
    {
        listener = new TcpListener(IPAddress.Parse(ip), port);
        listener.Start();
        Console.WriteLine($"Listening for connections on {ip}:{port}...");
        client = listener.AcceptTcpClient();
        Console.WriteLine("Connection established!");

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