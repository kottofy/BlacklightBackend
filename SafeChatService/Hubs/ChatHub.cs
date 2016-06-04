using Microsoft.AspNet.SignalR;
using SafeChatService.DataObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafeChatService.Hubs
{
    public class ChatHub : Hub

    {

        public void Send(ChatMessage message)

        {

            Clients.All.broadcastMessage(message);

        }

    }
}
