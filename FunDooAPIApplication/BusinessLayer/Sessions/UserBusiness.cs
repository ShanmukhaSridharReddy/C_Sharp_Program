using BusinessLayer.Interfaces;
using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using RepositoryLayer.Sessions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepo userRepo;

        public UserBusiness(IUserRepo user)
        {
            this.userRepo = user;
        }
        public UsersEntity Register(RegisterModel register)
        {
            return userRepo.Register(register);
        }
        public string Login(string email, string password)
        {
            return userRepo.Login(email, password);
        }

        public bool Email(string email)
        {
            return userRepo.Email(email);
        }

        public ForgotPassword ForgotPassword(string email)
        {
            return userRepo.ForgotPassword(email);
        }

        public bool ResetPassword(string email, ResetPasswordModel resetPasswordModel)
        {
            return userRepo.ResetPassword(email, resetPasswordModel);
        }
        public IEnumerable<UsersEntity> GetAllUsers()
        {
            return userRepo.GetAllUsers();

        }
        public UsersEntity Find(string name)
        {
            return userRepo.Find(name);
        }
        public UsersEntity SessionLogin(string email, string password)
        {
            return userRepo.SessionLogin(email, password);
        }
    }
}
