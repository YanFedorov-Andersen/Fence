using System;

namespace Fence.DataAccess
{
    public class UserAndMessage
    {
        public string Username { get; set; }
        public int Id { get; set; }
        public string TextField { get; set; }
        public DateTime? LeaveDate { get; set; }
        public short? Stars { get; set; }
        public bool? PaidMessage { get; set; }
    }
}
