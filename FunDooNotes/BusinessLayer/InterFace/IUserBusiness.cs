using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;

namespace BusinessLayer.InterFace
{
    public interface IUserBusiness
    {
        UsersEntity Register(RegisterModel Register);
        string Login(string email, string password);
        Boolean Email(string email);

        ForgotPassword ForgotPassword(string email);
        bool ResetPassword(string email, ResetPasswordModel resetPasswordModel);
    }
}