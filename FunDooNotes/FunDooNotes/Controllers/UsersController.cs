using BusinessLayer.InterFace;
using MassTransit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;
using ModelLayer;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FunDooNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {

        private readonly IUserBusiness userBusiness;
        private readonly IBus bus;
        private readonly ILogger<UsersController> logger;
        private readonly IDistributedCache _cache;
        

        public UsersController(IUserBusiness userBusiness, IBus bus, ILogger<UsersController> logger,IDistributedCache cache)
        {
            this.userBusiness = userBusiness;
            this.bus = bus;
            this.logger = logger;
            this._cache = cache;
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
                logger.LogInformation("login successfull");
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

        [HttpGet]
        [Route("GetAllUsers")]
         public ActionResult GetAllUsers()
        {
            IEnumerable<UsersEntity> users = userBusiness.GetAllUsers();
            if (users != null)
            {
                return Ok(new ResponseModel<IEnumerable<UsersEntity>> { IsSuccess = true, Message = "User Data", Data = users });
            }
            return BadRequest(new ResponseModel<string> { IsSuccess = true, Message = "No User Found", Data = "no data" });

        }

        [Authorize]
        [HttpGet]
        [Route("GetAll/{enableCache}")]
        public async Task<List<UsersEntity>> GetAll(string userId, bool enableCache)
        {
            if (!enableCache)
            {
                return userBusiness.GetAllUsers().ToList();
            }
            string cacheKey = userId;

            // Trying to get data from the Redis cache
            byte[] dataCache = await _cache.GetAsync(cacheKey);
            List<UsersEntity> userEntity = new List<UsersEntity>();
            if (dataCache != null)
            {
                // If the data is found in the cache, encode and deserialize cached data.
                var cachedDataString = Encoding.UTF8.GetString(dataCache);
                userEntity = JsonSerializer.Deserialize<List<UsersEntity>>(cachedDataString);
            }
            else
            {
                // If the data is not found in the cache, then fetch data from database
                userEntity = userBusiness.GetAllUsers().ToList();

                // Serializing the data
                string cachedDataString = JsonSerializer.Serialize(userEntity);
                var dataToCache = Encoding.UTF8.GetBytes(cachedDataString);

                // Setting up the cache options
                DistributedCacheEntryOptions options = new DistributedCacheEntryOptions()
                    .SetAbsoluteExpiration(DateTime.Now.AddMinutes(5))
                    .SetSlidingExpiration(TimeSpan.FromMinutes(3));

                // Add the data into the cache
                await _cache.SetAsync(cacheKey, dataToCache, options);
            }
            return userEntity; 
        }
       
        [HttpGet]
        [Route("SessionLogin")]
        public ActionResult Sessionlogin(string email, string password)
        {
            UsersEntity result= userBusiness.SessionLogin(email, password);
            if(result != null)
            {
                HttpContext.Session.SetInt32("userId", result.Id);
                return Ok(new ResponseModel<UsersEntity> { IsSuccess = true ,Message= "Login Successfully",Data=result});
            }
            else
            {
                return BadRequest(new ResponseModel<UsersEntity> { IsSuccess =  false ,Message="Login Failed",Data = result});
            }

        }

        [HttpGet]
        [Route("GetAllDetails")]
        public ActionResult GetAllDetails(int userid)
        {
             var alldetails = userBusiness.GetAllDetails(userid);
            if (alldetails != null)
            {
                
                return Ok(new ResponseModel<ArrayList> { IsSuccess = true, Message = "Data found", Data = alldetails });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "No Data Found", Data = "some error required"});
            }
        }
       
    }
}
