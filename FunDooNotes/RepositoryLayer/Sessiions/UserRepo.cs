﻿using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using ModelLayer;
using ModelLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Claims;
using System.Text;
using System.Threading;

namespace RepositoryLayer.Sessiions
{
    public class UserRepo : IUserRepo
    {
        private readonly FunDooContext funDooContext;
        private readonly IConfiguration _config;
        public UserRepo(FunDooContext funDooContext, IConfiguration configuration)
        {
            this.funDooContext = funDooContext;
            this._config = configuration;
        }
        public UsersEntity Register(RegisterModel register)
        {
            UsersEntity userEntity = new UsersEntity();
            userEntity.FirstName = register.FirstName;
            userEntity.LastName = register.LastName;
            userEntity.Email = register.Email;
            userEntity.Password = EncodePassword(register.Password);
            funDooContext.Users.Add(userEntity);
            funDooContext.SaveChanges();
            return userEntity;
        }
        public string Login (string email,string password)
        {
            UsersEntity user = funDooContext.Users.Where(a => a.Email == email).FirstOrDefault();
            if( user != null)
            {
                if (user.Email == email && user.Password == EncodePassword(password))
                {
                    var token = GenerateToken(user.Id, user.Email);
                    return token;
                }
            }
            return null;
        }

        public Boolean Email(string email)
        {
            var user = funDooContext.Users.FirstOrDefault(a => a.Email == email);
            if( user != null )
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
                var result = funDooContext.Users.ToList().Find(x=> x.Email == email);
                ForgotPassword forgotPassword = new ForgotPassword();
                forgotPassword.Email = result.Email;
                forgotPassword.Token = GenerateToken(result.Id,result.Email);
                forgotPassword.Id = result.Id;
                return forgotPassword;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public bool ResetPassword(string email , ResetPasswordModel resetPasswordModel)
        {
            if (email != null)
            {
                var check = funDooContext.Users.FirstOrDefault(x=>x.Email == email);
                check.Password =EncodePassword( resetPasswordModel.NewPassword);
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
            UsersEntity user = funDooContext.Users.Where(a=> a.Email == email).FirstOrDefault();
            if(user != null)
            {
                if( user.Email== email && user.Password ==EncodePassword( password))
                {
                    return user;
                }
            }
            return null;
        }
        
        public ArrayList GetAllDetails(int userid )
        {
            ArrayList arrayList = new ArrayList();
            //var lusers = funDooContext.Users.Where(a => a.Id == userid).ToList();
            var lstnotes = funDooContext.Notes.Where(a => a.UserId == userid).ToList();
            var lstlabels = funDooContext.Labels.Where(a => a.Id == userid).ToList();
            var lstCols = funDooContext.Collaborators.Where(a => a.Id== userid).ToList();

             //var usercount = lstusers.Count();
            var notecount = lstnotes.Count();
            var labelcount = lstlabels.Count();
            var colcount = lstCols.Count();

           var notemessage= $"no.ofNotes given userid = {notecount}";
            arrayList.Add(notemessage);
            arrayList.Add(lstnotes);
            
            var labelMessage = $"no.of labels given userid = {labelcount}";
            arrayList.Add(labelMessage);
            arrayList.Add(lstlabels);

            var collaboratorMessage = $"no.of clooaborator = {colcount}";
          
            arrayList.Add(collaboratorMessage);
            arrayList.Add(lstCols);
            return arrayList;
        }
        
    }
}
