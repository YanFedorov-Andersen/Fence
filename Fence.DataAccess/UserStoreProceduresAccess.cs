using System;
using Fence.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Fence.DataAccess
{
    public class UserStoreProceduresAccess: IUserDataAccess
    {
        private readonly UserAndMessagesEntities _modelContext;
        public UserStoreProceduresAccess()
        {
            _modelContext = new UserAndMessagesEntities();
        }

        public async Task<List<UserEntity>> GetUsers()
        {
            var result = _modelContext.Database.SqlQuery<UserEntity>("EXEC GetAllUsers");

            return await result.ToListAsync();
        }

        public async Task<int> UpdateUser(UserEntity user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), $"{nameof(user)} is null");
            }

            var result = _modelContext.Database.SqlQuery<int>("EXEC UpdateUserEntity @userId, @firstName, @lastName, @DateOfBirth, @Username", new SqlParameter("@UserId", user.Id), new SqlParameter("@firstName", user.FirstName), new SqlParameter("@LastName", user.LastName), new SqlParameter("@DateOfBirth", user.DateOfBirth), new SqlParameter("@Username", user.Username)
                ); 
            
            return await result.SingleAsync();
        }

        public async Task<UserEntity> GetUser(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException($"{nameof(id)} is less then 1", nameof(id));
            }

            var result = _modelContext.Database.SqlQuery<UserEntity>("EXEC GetUserById @Id", new SqlParameter("@Id", id)
            );

            return await result.SingleAsync();
        }

        public async Task<int> CreateUser(UserEntity user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), $"{nameof(user)} is null");
            }

            var result = _modelContext.Database.SqlQuery<int>("EXEC CreateUser @firstName, @lastName, @DateOfBirth, @Username, @userId", new SqlParameter("@firstName", user.FirstName), new SqlParameter("@LastName", user.LastName), new SqlParameter("@DateOfBirth", user.DateOfBirth), new SqlParameter("@Username", user.Username), new SqlParameter("@UserId", user.Id)
            );

            return await result.SingleAsync();
        }

        public async Task<List<int>> DeleteUser(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException($"{nameof(id)} is less then 1", nameof(id));
            }

            var result = _modelContext.Database.SqlQuery<List<int>>("EXEC DeleteUserEntity @Id", new SqlParameter("@Id", id)
            );

            return await result.FirstOrDefaultAsync();
        }

        public async Task<List<MessageEntity>> GetAllUserMessages(int id)
        {
            if (id < 1)
            {
                throw new ArgumentException($"{nameof(id)} is less then 1", nameof(id));
            }

            var result = _modelContext.Database.SqlQuery<MessageEntity>("EXEC GetAllUserMessages @UserId", new SqlParameter("@UserId", id)
            );

            return await result.ToListAsync();
        }
    }
}
