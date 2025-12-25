using Haichann.MachineManager.Data;
using Haichann.MachineManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Haichann.MachineManager.Service
{
    public class AuthService
    {
        private readonly AppDbContext _context = new AppDbContext();
        
        public User Authentication(string username, string password)
        {
            var hash = Hash(password);

        }
    }
}
