using ModelLayer.Models;
using RepositoryLayer.EntitIes;

namespace BusinessLayer.Interfaces
{
    public interface IUserBusiness
    {
        UsersEntity Register(RegisterModel register);
        string Login(string email, string password);
        bool Email(string email);
        ForgotPassword ForgotPassword(string email);
    }
}