using Haichann.MachineManager.Data;
using Haichann.MachineManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Service
{
    public class MachineService : IMachineService
    {
        private readonly AppDbContext _context = new(); // new() = new AppDbContext

        public List<Machine> GetAllMachines()
        {
            return _context.Machines.ToList();
        }

        public Machine? GetMachineById(int id)
        {
            return _context.Machines.Find(id);
        }

        public Machine? GetMachineByName(string name)
        {
            return _context.Machines
                .AsNoTracking()
                .FirstOrDefault(m => m.Name == name);
        }

        public void AddMachine(Machine machine)
        {
            throw new NotImplementedException();
        }

        public void RemoveMachine(Machine machine)
        {
            throw new NotImplementedException();
        }

        public void UpdateMachine(Machine machine)
        {
            throw new NotImplementedException();
        }
    }
}
