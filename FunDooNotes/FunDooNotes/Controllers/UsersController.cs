using BusinessLayer.InterFace;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FunDooNotes.Controllers
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

        public ActionResult Register(RegisterModel register)
        {
            var user = userBusiness.Register(register);
            if (user == null)
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = " User Not Added", Data = " Access Failed" });
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
            string result = userBusiness.Login(email, password);
            if (result != null)
            {
                return Ok(new ResponseModel<string> { IsSuccess = true, Message = "Login Successfully", Data = result });

            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = " Invalid User ", Data = "Login Failed" });
            }
        }
        [HttpGet]
        [Route("EmailExists")]
        public ActionResult ValidEmail(string email) {
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
        [Route("ForgotPassword")]
        public async Task<IActionResult> UserForgottPassword(string email)
        {
            try
            {
                if (userBusiness.Email(email))
                {
                    Send send = new Send();
                    ForgotPassword forgotPasswordModel = userBusiness.ForgotPassword(email);
                    send.SendMail(forgotPasswordModel.Email,forgotPasswordModel.Token);

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

        [Authorize]
        [HttpPost]
        [Route("ResetPassword")]
         public ActionResult resetPassword(ResetPasswordModel resetPasswordModel)
        {
            string email = User.Claims.FirstOrDefault(x=>x.Type == "Email").Value;
            var result = userBusiness.ResetPassword(email, resetPasswordModel);
            if (result)
            {
                return Ok(new ResponseModel<bool> { IsSuccess = true, Message = "password Updated Successfully", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<bool> { IsSuccess = false, Message = "password updatetion failed"});

            }
        }


    }
}
