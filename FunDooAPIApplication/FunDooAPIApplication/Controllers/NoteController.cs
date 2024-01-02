using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Models;
using Newtonsoft.Json.Linq;
using RepositoryLayer.EntitIes;
using System.Collections.Generic;
using System.Linq;

namespace FunDooAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoteController : ControllerBase
    {
        private readonly INoteBusiness noteBusiness;
        public NoteController(INoteBusiness noteBusiness)
        {
            this.noteBusiness = noteBusiness;
        }

        [HttpPost]
        [Route("AddNote")]
        public ActionResult Register(NoteModel noteModel)
        {
            int userId = int.Parse(User.Claims.Where(a => a.Type == "UserID").FirstOrDefault().Value);
            var result = noteBusiness.Register(userId, noteModel);
            if (result == null)
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "Not Added", Data = "Added Failed" });
            }
            else
            {
                return Ok(new ResponseModel<NoteEntity> { IsSuccess = true, Message = "Added", Data = result });

            }
        }

        [HttpGet]
        [Route("GetNote")]
        public ActionResult GetAllNote()
        {
            IEnumerable<NoteEntity> noteEntities = noteBusiness.GetAll();
            if(noteEntities != null)
            {
                return Ok(new ResponseModel<IEnumerable<NoteEntity>> { IsSuccess= true, Message="Data Found", Data= noteEntities});
            }
            else
            {
                return BadRequest(new ResponseModel<IEnumerable<NoteEntity>> { IsSuccess = false, Message = " No Data", Data = noteEntities });
            }
        }



    }
}
