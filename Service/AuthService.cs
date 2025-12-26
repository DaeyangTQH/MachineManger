using Haichann.MachineManager.Data;
using Haichann.MachineManager.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Text;

namespace Haichann.MachineManager.Service
{
    public class AuthService : IAuthService
    {
        private readonly AppDbContext _context;

        public AuthService(AppDbContext context)
        {
            _context = context;
        }

        private bool _isAuthenticated = false;
        private User? _currentUser;



        public bool IsAuthenticated => _currentUser != null;

        public User? CurrentUser => _currentUser;

        public bool Login(string username, string password)
        {
            var user = _context.Users
                .AsNoTracking()
                .FirstOrDefault(u => 
                    u.UserName == username && 
                    u.Password == password);
            if (user == null) return false;
            _currentUser = user;
            return true;

        }

        public void Logout()
        {
            _currentUser = null;
        }
    }
}
