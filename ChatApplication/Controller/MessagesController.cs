using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ChatApp.Services;


[Route("api/[controller]")]
[ApiController]
public class MessageController : ControllerBase
{
    private readonly MessageService _messagingService;

    public MessageController(MessageService messagingService)
    {
        _messagingService = messagingService;
    }

    //[Authorize(Roles = "Admin")]
    [HttpPost("sendtogroup")]
    public async Task<IActionResult> SendMessageToGroup(string groupName, string user, string message)
    {
        await _messagingService.SendMessageToGroup(groupName, user, message);
        return Ok();
    }

    //[Authorize(Roles = "Admin")]
    [HttpPost("sendtoall")]
    public async Task<IActionResult> SendMessageToAll(string user, string message)
    {
        await _messagingService.SendMessageToAll(user, message);
        return Ok();
    }

    //[Authorize]
    [HttpPut("update/{id}")]
    public async Task<IActionResult> UpdateMessage(int id, [FromBody] string message)
    {
        // Mesaj güncelleme işlemleri burada yapılabilir
        return Ok($"Message with id {id} updated to: {message}");
    }

    //[Authorize]
    [HttpDelete("delete/{id}")]
    public async Task<IActionResult> DeleteMessage(int id)
    {
        // Mesaj silme işlemleri burada yapılabilir
        return Ok($"Message with id {id} deleted");
    }
    
    //[Authorize]
    [HttpGet("get/{id}")]
    public async Task<IActionResult> GetMessage(int id)
    {
        // Mesaj getirme işlemleri burada yapılabilir
        return Ok($"Message with id {id}");
    }

    // Diğer API metodları buraya eklenebilir
}


