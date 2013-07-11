using Microsoft.AspNet.SignalR;

namespace Falys.BrowserLinkLib
{
    public class BrowserLinkHub : Hub
    {
        public void Send(string message)
        {
            Clients.All.addMessage(message);
        }
    }
}