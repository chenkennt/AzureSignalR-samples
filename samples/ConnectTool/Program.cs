using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace ConnectTool
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HubConnectionBuilder().WithUrl("http://localhost:5000/chat");
            var conn = builder.Build();
            while (true)
            {
                try
                {
                    await conn.StartAsync();
                    Console.WriteLine("Connected!");
                    await Task.Delay(500);
                    await conn.StopAsync();
                    await Task.Delay(500);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection failed: " + ex.Message);
                }
            }
        }
    }
}
