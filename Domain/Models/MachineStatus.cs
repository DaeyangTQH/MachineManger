using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Domain.Models
{
    public class MachineStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; } = string.Empty;
    }
}
