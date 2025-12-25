using Haichann.MachineManager.Data;
using Haichann.MachineManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Service
{
    public class MachineService
    {
        private readonly AppDbContext _context = new(); // new() = new AppDbContext()

        public List<Machine> GetAllMachines()
        {
            return [.. _context.Machines.Include(x => x.Status)]; // [.. collection] = collection.ToList()
        }
    }
}
