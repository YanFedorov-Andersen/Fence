using Fence.DataAccess;
using Fence.DataAccess.Interfaces;
using Fence.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fence.Business
{
    public class DisplayService: IDisplayService
    {
        private readonly IUserDataAccess _userDataAccess;
        private readonly IMessageDataAccess _messageDataAccess;
        private readonly IMapper<UserEntity, UserDTO> _mapUser;
        private readonly IMapper<MessageEntity, MessageDTO> _mapMessage;
        public DisplayService(IUserDataAccess userDataAccess, IMapper<UserEntity, UserDTO> mapUser, IMapper<MessageEntity, MessageDTO> mapMessage, IMessageDataAccess messageDataAccess)
        {
            _userDataAccess = userDataAccess;
            _messageDataAccess = messageDataAccess;
            _mapUser = mapUser;
            _mapMessage = mapMessage;
        }

        public async Task<UserDTO> GetUserAndMessagesById(int userId)
        {
            if (userId < 1)
            {
                throw new ArgumentException($"{nameof(userId)} is less then 1", nameof(userId));
            }

            var user = await _userDataAccess.GetUser(userId);
            var userDTO = _mapUser.AutoMap(user);

            return userDTO;
        }

        public async Task<IEnumerable<UserAndMessage>> GetUsersWithMessages()
        {            
            var users = await _messageDataAccess.GetMessages();
            users.OrderBy(x => x.LeaveDate);

            return users;
        }
    }
}
