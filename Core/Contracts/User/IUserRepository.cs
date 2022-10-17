﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts.User
{
    public interface IUserRepository : IAsyncGenericRepository<Entities.User>
    {
    }
}
