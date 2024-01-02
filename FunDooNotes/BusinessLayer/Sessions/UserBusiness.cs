using BusinessLayer.InterFace;
using ModelLayer;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class UserBusiness : IUserBusiness
    {
        private readonly IUserRepo userRepo;
        public UserBusiness(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        public UsersEntity Register(RegisterModel register)
        {
            return userRepo.Register(register);
        }

        public string Login(string email, string password)
        {
            return userRepo.Login(email, password);
        }
        public Boolean Email(string email)
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

        public UsersEntity SessionLogin(string email, string password)
        {
            return userRepo.SessionLogin(email, password);
        }

        public ArrayList GetAllDetails(int userid)
        {
            return userRepo.GetAllDetails(userid);
        }
    }

}
