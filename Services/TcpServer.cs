using Microsoft.AspNetCore.SignalR;

namespace ChatSignalR.Services
{
    public class TcpServer
    {
        private readonly IHubContext<ChatHub> _hubContext;

        public TcpServer(IHubContext<ChatHub> hubContext)
        {
            _hubContext = hubContext;
        }

        public async Task HandleMessageFromTcpClient(string user, string message)
        {
            // Broadcast the message to all SignalR clients.
            await _hubContext.Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
