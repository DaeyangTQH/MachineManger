using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Haichann.MachineManager.Domain.Models
{
    [Table("Machine")]
    public class Machine
    {
        public int Id { get; set; }
        public String Code { get; set; } = string.Empty;
        public String Name { get; set; } = string.Empty;
        public String Description { get; set; } = string.Empty;
        public MachineStatus Status { get; set; }

    }
}
