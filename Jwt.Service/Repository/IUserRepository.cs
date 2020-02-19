using Jwt.Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jwt.Service.Repository
{
  public interface IUserRepository
    {
        User GetUserByUsername(User user);
        string Login(User user);
      
    }
}
