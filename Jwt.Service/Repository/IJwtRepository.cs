using Jwt.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jwt.Service.Repository
{
   public interface IJwtRepository
    {
        string Generate(User user);
    }
}
