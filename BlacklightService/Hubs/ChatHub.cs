using Microsoft.AspNet.SignalR;
using BlacklightService.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlacklightService.Hubs
{
    public class ChatHub : Hub

    {

        public void Send(ChatMessage message)

        {

            Clients.All.broadcastMessage(message);

        }

    }
}
