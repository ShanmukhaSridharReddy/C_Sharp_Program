using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface IUserBusiness
    {
        UsersEntity Register(RegisterModel register);
        string Login(string email, string password);
        bool Email(string email);
        ForgotPassword ForgotPassword(string email);
        bool ResetPassword(string email, ResetPasswordModel resetPasswordModel);
        IEnumerable<UsersEntity> GetAllUsers();
        UsersEntity SessionLogin(string email, string password);
        UsersEntity Find(string name);
    }
}