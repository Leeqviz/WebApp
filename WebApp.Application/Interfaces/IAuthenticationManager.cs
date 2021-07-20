﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApp.Application.Models.DataTransferObjects.Incoming.Users;

namespace WebApp.Application.Interfaces
{
    public interface IAuthenticationManager
    {
        Task<bool> ValidateUser(UserAuthenticationDto userAuth);
        Task<string> CreateToken();
    }
}
