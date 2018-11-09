using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fence.DataAccess.Interfaces
{
    public interface IMessageDataAccess
    {
        Task<List<UserAndMessage>> GetMessages();
    }
}
