using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinaC2C.MVC.ServerHub
{
    public class ChatServer : Hub
    {
        public async Task SendMessage(string User, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", User, message);
        }
    }
}
