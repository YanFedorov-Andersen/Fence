using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fence.DataAccess.Interfaces
{
    public interface IUserDataAccess
    {
        List<UserEntity> GetUsers();
        Task<int> UpdateUser(UserEntity user);
        Task<UserEntity> GetUser(int id);
        Task<int> CreateUser(UserEntity user);
        Task<List<int>> DeleteUser(int id);
        Task<List<MessageEntity>> GetAllUserMessages(int id);
    }
}
