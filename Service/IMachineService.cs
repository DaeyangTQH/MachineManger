using Haichann.MachineManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Service
{
    public interface IMachineService
    {
        List<Machine> GetAllMachines();
        Machine? GetMachineById(int id);
        Machine? GetMachineByName(string name);
        void AddMachine(Machine machine);
        void RemoveMachine(Machine machine);
        void UpdateMachine(Machine machine);
    }
}
