using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalR.Server
{
    public class TextHub : Hub
    {
        public async Task Send(string text)
        {
            await Clients.All.SendAsync("ReceiveInformation", text);
        }
    }
}
