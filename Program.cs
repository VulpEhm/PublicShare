using System;
using System.Net.NetworkInformation;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Ping ping = new Ping();
        string host = "google.com";
        while (true)
        {
            try
            {
                PingReply reply = ping.Send(host);
                if (reply.Status == IPStatus.Success)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Success");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Failure");
                    Console.ResetColor();
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Failure");
                Console.ResetColor();
            }
            Thread.Sleep(1000); // wait for 1 second before sending the next ping
        }
    }
}
