using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
namespace ChatSignalR
{

    public class NotificationsHub : Hub
    {
        public override async Task OnConnectedAsync()
        {

            await Clients.Caller.SendAsync("ReceiveNotification", "Welcome to the SignalR NotificationsHub!");
            await base.OnConnectedAsync();
        }

        public async Task TestWebSocketEcho()
        {
            // Get IP Address from HttpContext
            var httpContext = Context.GetHttpContext();
            string clientIpAddress = httpContext.Connection.RemoteIpAddress?.ToString();

            //await Clients.All.SendAsync("ReceiveNotification", $"{Context.User.Identity.Name} This is a test message from the server.");
            await Clients.All.SendAsync("ReceiveNotification", $"Your IP Address is: {clientIpAddress}");
            //await Clients.All.SendAsync("ReceiveNotification", $"Your Messages is: {Messages}");
        }

        public async Task SendMessage(string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", message);
           
        }

        public string SM(string message)
        {
            return message;
        }
    }

}
