using Fence.DataAccess;
using System;
using System.Linq;

namespace Fence.Domain
{
    public class MapUser : IMapper<UserEntity, UserDTO>
    {
        private readonly IMapper<MessageEntity, MessageDTO> _mapMessage;
        public MapUser(IMapper<MessageEntity, MessageDTO> mapMessage)
        {
            _mapMessage = mapMessage;
        }
        public UserDTO AutoMap(UserEntity item)
        {
            var userDTO = new UserDTO()
            {
                Id = item.Id,
                FirstName = item.FirstName,
                LastName = item.LastName,
                Username = item.Username,
                Messages = item.MessageEntity.Select(_mapMessage.AutoMap).ToList()
            };
            return userDTO;
        }

        public UserEntity ReverseAutoMap(UserDTO item, UserEntity initialItem)
        {
            throw new NotImplementedException();
        }
    }
}
