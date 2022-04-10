using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_game.Hubs
{
    public class ChatHub : Hub
    {
        public void LetsChat(string clientName, string clientMessage)
        {
            Clients.All.NewMessage(clientName, clientMessage);
        }
    }
}