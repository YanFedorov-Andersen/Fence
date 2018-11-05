using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fence.DataAccess
{
    public class UserStoreProceduresAccess
    {
        private readonly UserAndMessagesEntities _modelContext;
        public UserStoreProceduresAccess(UserAndMessagesEntities modelContext)
        {
            _modelContext = modelContext;
        }

        public List<UserEntity> GetUsers()
        {
            var result = _modelContext.Database.SqlQuery<UserEntity>("EXEC GetAllUsers");
            var usersList = result.ToListAsync().Result;
            return usersList;
        }

        public List<UserEntity> UpdateUser(UserEntity user)
        {
            var result = _modelContext.Database.SqlQuery<UserEntity>("EXEC UpdateUserEntity", new SqlParameter()
                );
            var usersList = result.ToListAsync().Result;
            return usersList;
        }
    }
}
