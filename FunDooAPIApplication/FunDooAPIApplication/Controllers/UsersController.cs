using BusinessLayer.Interfaces;
using BusinessLayer.Sessions;
using MassTransit;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;
using Newtonsoft.Json.Linq;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FunDooAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserBusiness userBusiness;
        private readonly IBus bus;
        public UsersController(IUserBusiness userBusiness, IBus bus)
        {
            this.userBusiness = userBusiness;
            this.bus = bus;
        }

        [HttpPost]
        [Route("Register")]

        public ActionResult Register(RegisterModel registerModel)
        {
            var user = userBusiness.Register(registerModel);
            if (user == null)
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = " User Not Added", Data = "Access Failed " });
            }
            else
            {
                return Ok(new ResponseModel<UsersEntity> { IsSuccess = true, Message = " User Added", Data = user });

            }
        }
        [HttpGet]
        [Route("Login")]

        public ActionResult Login(string email, string password)
        {
            var user = userBusiness.Login(email, password);
            if (user != null)
            {
                return Ok(new ResponseModel<string> { IsSuccess = true, Message = "Login Successful", Data = user });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "invalid User", Data = "Login Failed" });
            }
        }
        [HttpGet]
        [Route("Email")]
        public ActionResult ValidEmail(string email)
        {
            var result = userBusiness.Email(email);
            if (result)
            {
                return Ok(new ResponseModel<string> { IsSuccess = true, Message = "Valid User", Data = "Email Exists" });

            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = " Invalid User ", Data = "Email Not Exists" });
            }
        }

        [HttpGet]
        [Route("Forgot Password")]

        public async Task<IActionResult> UserForgottPassword(string email)
        {
            try
            {
                if (userBusiness.Email(email))
                {
                    Send send = new Send();
                    ForgotPassword forgotPasswordModel = userBusiness.ForgotPassword(email);
                    send.SendMail(forgotPasswordModel.Email, forgotPasswordModel.Token);

                    Uri uri = new Uri("rabbitmq://localhost/NotesEmail_Queue");
                    var endPoint = await bus.GetSendEndpoint(uri);

                    await endPoint.Send(forgotPasswordModel);
                    return Ok(new ResponseModel<ForgotPassword> { IsSuccess = true, Message = "email send successfull", Data = forgotPasswordModel });
                }
                else
                {
                    return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "email not send successfull", Data = "Email Not Found" });
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpGet]
        [Route("ResetPassword")]
        public ActionResult ResetPassword( ResetPasswordModel resetPasswordModel)
        {
            string email = User.Claims.Where(a=> a.Type == "email").FirstOrDefault().Value;
            var result = userBusiness.ResetPassword(email, resetPasswordModel);
            if(result != null)
            {
                return Ok(new ResponseModel<string> { IsSuccess = true, Message = "Reset Successful",Data = "changed" });
            }
            return BadRequest(new ResponseModel<string> { IsSuccess= false,Message="Failed",Data = "Not Changed" });
        }
        [HttpGet]
       [Route("GetAllUser")]
        public ActionResult GetAllUsers()
         {
            IEnumerable<UsersEntity> users = userBusiness.GetAllUsers();
            if(users != null)
            {
                return Ok(new ResponseModel<IEnumerable<UsersEntity>> { IsSuccess= true, Message="User Data",Data = users});
            }
            return BadRequest(new ResponseModel<string> { IsSuccess= true ,Message="No User Found", Data = "no data"});

         }
        [HttpGet]
        [Route("FindUser")]
        public ActionResult FindUser(string name)
        {
            var result = userBusiness.Find(name);
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest(null);
       
        }



    }
}
