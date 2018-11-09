using System.Collections.Generic;

namespace Fence.Domain
{
    public class UserDTO
    {
        public UserDTO()
        {
            
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public List<MessageDTO> Messages { get; set; }
    }
}
