using System.Threading.Tasks;
using ChatApp.Dto;
using System.Collections.Generic;

public interface IMessageService
{
    Task<ResultDto> SendMessageToGroup(string groupName, string user, string message);
    Task<ResultDto> SendMessageToAll(string user, string message);
    Task<ResultDto> SendMessage(MessageDto messageDto);
    Task<MessageDto> GetMessageById(int messageId);
    Task<List<MessageDto>> GetMessagesByGroupId(int groupId);
    Task<ResultDto> UpdateMessage(MessageDto messageDto);
    Task<ResultDto> DeleteMessage(int messageId);
}
