using BusinessLayer.Interfaces;
using BusinessLayer.Sessions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using System.Collections;
using System.Collections.Generic;

namespace FunDooAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness productBusiness;

        public ProductController(IProductBusiness productBusiness)
        {
            this.productBusiness = productBusiness;
        }
        [HttpPost]
        [Route("AddProduct")]
        public ActionResult Product (ProductModel model)
        {
            var result = productBusiness.Product (model);
            if(model == null)
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "Data Not Added", Data = "Failed" });
            }
            else
            {
                return Ok(new ResponseModel<ProductEntity> { IsSuccess = true, Message = "Data Added", Data = result });
            }
        }
        [HttpGet]
        [Route("Display")]
        public ActionResult Display()
        {
            IEnumerable < ProductEntity > product = productBusiness.DisplayProducts();
            if(product != null)
            {
                return Ok(new ResponseModel<IEnumerable<ProductEntity>> { IsSuccess = true, Message = "User Data", Data = product });
            }
            return BadRequest(new ResponseModel<string> { IsSuccess = true, Message = "User Data", Data = "No Data" });
        }



    }
}
