using BusinessLayer.Interfaces;
using BusinessLayer.Sessions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;
using RepositoryLayer.EntitIes;

namespace FunDooAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewBusiness reviewBusiness ;
        public ReviewController (IReviewBusiness reviewBusiness)
        {
            this.reviewBusiness = reviewBusiness;
        }

        [HttpPost]
        [Route("AddReview")]
        public ActionResult AddReview(ReviewModel addReview)
        { 
            var user = reviewBusiness.AddReview(addReview);
            if(user == null)
            {
                return BadRequest(new ResponseModel<ReviewEntity> { IsSuccess= false, Message="Review Not Added"});
            }
            else
            {
                return Ok(new ResponseModel<ReviewEntity> { IsSuccess = true, Message="Review Added", Data = user });
            }
        }
    }
}
