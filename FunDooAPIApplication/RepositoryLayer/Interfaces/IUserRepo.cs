using ModelLayer.Models;
using RepositoryLayer.EntitIes;

namespace RepositoryLayer.Interfaces
{
    public interface IUserRepo
    {
        UsersEntity Register(RegisterModel Register);
        string Login(string email, string password);
        bool Email(string email);
        ForgotPassword ForgotPassword(string email);
    }
}