using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface ITokenManager
    {
        Task<string> CreateToken(User user);
    }
}
