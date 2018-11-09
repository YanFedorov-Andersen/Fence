using System;

namespace Fence.Domain
{
    public class MessageDTO
    {
        public MessageDTO()
        {
                
        }
        public int Id { get; set; }
        public string TextField { get; set; }
        public DateTime? LeaveDate { get; set; }
        public short? Stars { get; set; }
    }
}
