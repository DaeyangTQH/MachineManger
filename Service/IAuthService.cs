using Haichann.MachineManager.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Haichann.MachineManager.Service
{
    public interface IAuthService
    {
        bool IsAuthenticated { get; }
        User? CurrentUser { get; }
        bool Login(string username, string password);
        void Logout();
    }
}
