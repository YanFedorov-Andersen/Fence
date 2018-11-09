using System.Collections.Generic;
using System.Threading.Tasks;
using Fence.DataAccess.Interfaces;

namespace Fence.DataAccess
{
    public class MessageStoreProceduresAccess: IMessageDataAccess
    {
        private readonly UserAndMessagesEntities _modelContext;
        public MessageStoreProceduresAccess()
        {
            _modelContext = new UserAndMessagesEntities();
        }

        public async Task<List<UserAndMessage>> GetMessages()
        {
            var result = _modelContext.Database.SqlQuery<UserAndMessage>("EXEC GetAllMessages");

            return await result.ToListAsync();
        }
    }
}
