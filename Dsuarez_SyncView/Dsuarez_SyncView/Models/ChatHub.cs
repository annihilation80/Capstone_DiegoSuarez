using System;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;

namespace Dsuarez_SyncView.Models
{
    public class ChatHub : Hub
    {

        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
    }
}