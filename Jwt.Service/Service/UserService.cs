using Jwt.DataLayer.Context;
using Jwt.Model.Models;
using Jwt.Service.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jwt.Service.Service
{
    public class UserService : IUserRepository
    {
        DataBaseContext _context;
        IJwtRepository _jwtRepository;
        public UserService(DataBaseContext context, IJwtRepository jwtRepository)
        {
            _context = context;
            _jwtRepository = jwtRepository;
        }
        public User GetUserByUsername(User user)
        {
            var model = _context.Users.Where(u => u.Username == user.Username && u.Password == user.Password).FirstOrDefault();
            try
            {
                if(model!=null)
                {
                    return model;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception )
            {

                 throw ;
            }
        }

        public string Login(User user)
        {
            var model = GetUserByUsername(user);
            try
            {
                if(model!=null)
                {
                   var token= _jwtRepository.Generate(model);
                    return token;
                }
                else
                {
                    return "unauthorized";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
