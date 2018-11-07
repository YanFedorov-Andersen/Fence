using System;
using System.Linq;

namespace Fence.DataAccess
{
    public static class SeedData
    {
        public static void Initialize(UserAndMessagesEntities _modelContext)
        {
            _modelContext.Database.Exists();

            var message1 = new MessageEntity()
            {
                Id = 1,
                TextField = "Message1",
                LeaveDate = DateTime.Now,
                UserEntityId = 1
            };
            var message2 = new MessageEntity()
            {
                Id = 2,
                TextField = "Message2",
                LeaveDate = DateTime.Now,
                UserEntityId = 1
            };
            var message3 = new MessageEntity()
            {
                Id = 1,
                TextField = "Message3",
                LeaveDate = DateTime.Now,
                UserEntityId = 4
            };


            if (!_modelContext.MessageEntity.Any())
            {
                _modelContext.MessageEntity.Add(message1);
                _modelContext.MessageEntity.Add(message2);
                _modelContext.MessageEntity.Add(message3);
            }

            _modelContext.SaveChanges();
        }
    }
}
