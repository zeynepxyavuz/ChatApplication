using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using ChatApp.Dto;
using ChatApp.Models;

namespace ChatApp.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMapper _mapper;

        public MessageService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<ResultDto> SendMessageToGroup(string groupName, string user, string message)
        {
            // TODO: Implement SendMessageToGroup
            throw new NotImplementedException();
        }

        public async Task<ResultDto> SendMessageToAll(string user, string message)
        {
            // TODO: Implement SendMessageToAll
            throw new NotImplementedException();
        }

        public async Task<ResultDto> SendMessage(MessageDto messageDto)
        {
            // TODO: Implement SendMessage
            throw new NotImplementedException();
        }

        public async Task<MessageDto> GetMessageById(int messageId)
        {
            // TODO: Implement GetMessageById
            throw new NotImplementedException();
        }

        public async Task<List<MessageDto>> GetMessagesByGroupId(int groupId)
        {
            // TODO: Implement GetMessagesByGroupId
            throw new NotImplementedException();
        }

        public async Task<ResultDto> UpdateMessage(MessageDto messageDto)
        {
            // TODO: Implement UpdateMessage
            throw new NotImplementedException();
        }

        public async Task<ResultDto> DeleteMessage(int messageId)
        {
            // TODO: Implement DeleteMessage
            throw new NotImplementedException();
        }
    }
}
