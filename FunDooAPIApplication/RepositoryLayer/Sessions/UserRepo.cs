using ModelLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace RepositoryLayer.Sessions
{
    public class UserRepo : IUserRepo
    {
        private readonly FunDooContext funDooContext;
        private readonly IConfiguration _config;
       
        public UserRepo(FunDooContext funDooContext, IConfiguration _config)
        {
            this.funDooContext = funDooContext;
            this._config = _config;
            
        }

        public UsersEntity Register(RegisterModel Register)
        {
            UsersEntity usersEntity = new UsersEntity();
            usersEntity.FirstName = Register.FirstName;
            usersEntity.LastName = Register.LastName;
            usersEntity.Email = Register.Email;
            usersEntity.Password = EncodePassword(Register.Password);
            usersEntity.CreatedAt = DateTime.Now;
            usersEntity.UpdatedAt = DateTime.Now;
            funDooContext.Users.Add(usersEntity);
            funDooContext.SaveChanges();
            return usersEntity;
        }

        public string Login(string email, string password)
        {
            UsersEntity user = funDooContext.Users.Where(v=> v.Email == email).FirstOrDefault();
            if(user != null)
            {
               if( user.Email == email && user.Password== EncodePassword(password))
                {
                    var token = GenerateToken(user.Id,user.Email);
                    return token;
                }
            }
            return null;
        }

        public bool Email(string email)
        {
            UsersEntity user = funDooContext.Users.FirstOrDefault(a => a.Email == email);
            if(user != null)
            {
                return true;
            }
            return false;
        }

        public string EncodePassword(string password)
        {
            try
            {
                byte[] encData_byte = new byte[password.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(password);
                string encodedData = Convert.ToBase64String(encData_byte);
                return encodedData;
            }
            catch (Exception ex)
            {
                throw new Exception("Error in base64Encode" + ex.Message);
            }
        }

        private string GenerateToken(int userId, string userEmail)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
            var claims = new[]
            {
                new Claim("Email",userEmail),
                new Claim("UserID",userId.ToString())
            };
            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.Now.AddMinutes(15),
                signingCredentials: credentials);


            return new JwtSecurityTokenHandler().WriteToken(token);

        }

        public ForgotPassword ForgotPassword(string email)
        {
            try
            {
                var result = funDooContext.Users.ToList().Find(x => x.Email == email);
                ForgotPassword forgotPassword = new ForgotPassword();
                forgotPassword.Email = result.Email;
                forgotPassword.Token = GenerateToken(result.Id, result.Email);
                forgotPassword.Id = result.Id;
                return forgotPassword;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool ResetPassword(string email,ResetPasswordModel resetPasswordModel)
        {
            if( email != null )
            {
                var check = funDooContext.Users.FirstOrDefault(x => x.Email == email);
                check.Password = EncodePassword(resetPasswordModel.NewPassword);
                funDooContext.SaveChanges();
                return true;
            }
            return false;
        }
        public IEnumerable<UsersEntity> GetAllUsers() 
        {
            if(funDooContext.Users == null)
            {
                return null;
            }
            return funDooContext.Users.ToList();   
                            
        }

        public UsersEntity SessionLogin(string email, string password)
        {
            UsersEntity user = funDooContext.Users.Where(a => a.Email == email).FirstOrDefault();
            if (user != null)
            {
                if (user.Email == email && user.Password == EncodePassword(password))
                {
                    return user;
                }
            }
            return null;
        }
        public UsersEntity Find( string name)
        {
            UsersEntity user = funDooContext.Users.FirstOrDefault(x=>x.FirstName==name);
            if ( user !=null)
            {
                return user;
            }
            return null;
        }
        

    }
}
