using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR.Client;

namespace signalrtest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var builder = new HubConnectionBuilder().WithUrl("http://localhost:5000/chat");
            var conn = builder.Build();
            while (true)
            {
                await conn.StartAsync();
                await Task.Delay(500);
                await conn.StopAsync();
                await Task.Delay(500);
            }
        }
    }
}
