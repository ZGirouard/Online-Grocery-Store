﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managers
{
    public interface IUserManager
    {
        Int32 logInValidation(string username, string password);

        Int32 registerNewUser(string email, string username, string password);
    }
}
