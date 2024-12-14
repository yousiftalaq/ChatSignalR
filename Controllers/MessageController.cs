using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace ChatSignalR.Controllers
{
    [ApiController]
    [Route("api/messages")]
    public class MessageController : Controller
    {
        private readonly IHubContext<NotificationsHub> _hubContext;

        public MessageController(IHubContext<NotificationsHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMessage([FromBody] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveNotification", message); // Broadcasts to all clients
            return Ok($"Message sent: {message}");
        }
    }
}
