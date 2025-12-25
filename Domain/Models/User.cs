using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }
        public int RoleId { get; set; }
        public Role? Role { get; set; }
    }
}
