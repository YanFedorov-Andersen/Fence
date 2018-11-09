using Fence.DataAccess;
using System;

namespace Fence.Domain
{
    public class MapMessage : IMapper<MessageEntity, MessageDTO>
    {
        public MessageDTO AutoMap(MessageEntity item)
        {
            var messageDTO = new MessageDTO()
            {
                Id = item.Id,
                TextField = item.TextField,
                LeaveDate = item.LeaveDate,
                Stars = item.Stars
            };

            return messageDTO;
        }

        public MessageEntity ReverseAutoMap(MessageDTO item, MessageEntity initialItem)
        {
            throw new NotImplementedException();
        }
    }
}
