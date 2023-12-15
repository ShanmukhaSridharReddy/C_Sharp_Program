using ModelLayer;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.InterFace
{
    public interface IUserRepo
    {
        UsersEntity Register(RegisterModel register);
        string Login(string email, string password);

        Boolean Email(string email);
        ForgotPassword ForgotPassword(string email);
        bool ResetPassword(string email, ResetPasswordModel resetPasswordModel);


    }
}
