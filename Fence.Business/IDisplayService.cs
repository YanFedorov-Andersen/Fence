using Fence.DataAccess;
using Fence.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fence.Business
{
    public interface IDisplayService
    {
        Task<UserDTO> GetUserAndMessagesById(int userId);
        Task<IEnumerable<UserAndMessage>> GetUsersWithMessages();
    }
}
