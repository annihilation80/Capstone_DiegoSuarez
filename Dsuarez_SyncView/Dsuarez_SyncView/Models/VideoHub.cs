using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace Dsuarez_SyncView.Models
{
    public class VideoHub : Hub
    {
        public void SendPlayPause()
        {
            Clients.All.playPauseVideo();
        }

        public void SendSync()
        {
            Clients.All.syncVideo();
        }

        public void sendSeek()
        {
            Clients.All.seek();
        }
    }
}