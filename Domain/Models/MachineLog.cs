using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Domain.Models
{
    public class MachineLog
    {
        public int Id { get; set; }
        public int MachineId { get; set; }
        public Machine? Machine { get; set; }
        public DateTime Timestamp { get; set; }
        public string Message { get; set; } = string.Empty;
    }
}
