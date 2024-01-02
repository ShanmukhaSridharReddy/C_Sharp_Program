using BusinessLayer.InterFace;
using BusinessLayer.Sessions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Model;
using RabbitMQ.Client;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FunDooNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        private readonly INotesBusiness notesBusiness;
        public NotesController(INotesBusiness noteBusiness)
        {
            this.notesBusiness = noteBusiness;
        }

        //[Authorize]
        [HttpPost]
        [Route("AddNote")]
        public ActionResult Register(NotesModel noteModel)
        {
            // int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserID").Value);
            int userId =(int)HttpContext.Session.GetInt32("userId");
            var note = notesBusiness.RegisterNote(userId, noteModel);
            if (note == null)
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "Not Added", Data = "Access Failed" });
            }
            else
            {
                return Ok(new ResponseModel<NotesEntity> { IsSuccess = true, Message = "Added", Data = note });
            }
        }
        [HttpGet]
        [Route("GetAllNotes")]
        public ActionResult GetAllNotes()
        {
            IEnumerable<NotesEntity> result = notesBusiness.GetAllNotes();
            if(result != null)
            {
                return Ok(new ResponseModel<IEnumerable<NotesEntity>> { IsSuccess = true, Message = "Note Found", Data = result});
            }
            return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "Note not found", Data = "No Data" });
        }
        [HttpDelete]
        [Route("DeleteNote")]
        public ActionResult Delete(int id,int noteId)
        {
            NotesEntity del = notesBusiness.Delete(id, noteId);
            if (del != null)
            {
                
                return Ok(new ResponseModel<string> { IsSuccess= true, Message = "Deleted Successfully", Data ="Deleted"} );
            }
            return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "Not Deleted", Data = "Failed" });
        }
        [Authorize]
        [HttpPut]
        [Route("UpdateNote/{noteId}")]
        public ActionResult Update( int noteId, NotesModel notesModel)
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserID").Value);
            
            var update = notesBusiness.Update(userId, noteId, notesModel);
            if(update != null)
            {
                
                return Ok(new ResponseModel<NotesEntity> { IsSuccess = true, Message = "Updated Sucessfull", Data = update });
            
            }
            return BadRequest(new ResponseModel<NotesEntity> { IsSuccess = false, Message = "Not Updated", Data =update });
        
        }
        [Authorize]
        [HttpPut]
        [Route("IsTrash")]
        public ActionResult IsTrash(int noteId)
        {
            int userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserID").Value);
            var result = notesBusiness.CheckIsTrash(userId, noteId);
            if (result)
            {
                return Ok(new ResponseModel<string> { IsSuccess = true, Message = "Trashed" });

            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = " Not Trashed " });
            }
            
        }

        [Authorize]
        [HttpGet]
        [Route("IsPin")]
        public ActionResult IsPin(int noteId)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserID").Value);
            var result = notesBusiness.CheckIsPin(userId, noteId);
            if(result)
            {
                return Ok(new ResponseModel<string> {IsSuccess = true, Message ="Pin" });

            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess=false,Message = "Not pin"}); 
            }
        }

        [Authorize]
        [HttpGet]
        [Route("IsArchive")]
        public ActionResult IsArchive(int noteId)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(s => s.Type == "UserID").Value);
            var result = notesBusiness.CheckIsArchive(userId, noteId);
            if(result)
            {
                return Ok(new ResponseModel<string> { IsSuccess = true, Message = "Archive" });
            }
            else
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message = "Not Archived" });
            }
        }

        [Authorize]
        [HttpGet]
        [Route("Color")]
        public ActionResult Color(int noteId,string color) 
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(a => a.Type == "UserID").Value);
            var result = notesBusiness.Colour(userId, noteId, color);   
            if(result != null)
            {
              return Ok(new ResponseModel<NotesEntity> { IsSuccess = true,Message ="Color Added",Data=result});
            }
            else
            {
                return BadRequest(new ResponseModel<NotesEntity> { IsSuccess = false, Message = "Not Added", Data = result });
            }
        }
        [Authorize]
        [HttpGet]
        [Route("Remainder")]
        public ActionResult Remainder(int noteId,DateTime dateTime)
        {
            var userId = int.Parse(User.Claims.FirstOrDefault(a => a.Type == "UserID").Value);
            var result = notesBusiness.Remainder(userId, noteId,dateTime);
            if(result != null)
            {
                return Ok(new ResponseModel<NotesEntity> { IsSuccess = true, Message = "Remainder Success", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<NotesEntity> { IsSuccess = false,Message = "Failed",Data = result});
            }
        }
        [Authorize]
        [HttpPost]
        [Route("AddImage/{noteId}")]
        public ActionResult AddImage(int noteId,IFormFile imageId)
        {
            var userId = int.Parse(User.Claims.Where(a => a.Type == "UserID").FirstOrDefault().Value);
            var photo = notesBusiness.AddImage(userId, noteId, imageId);
            if(photo != null)
            {
                return Ok(new ResponseModel<NotesEntity> { IsSuccess = true, Message = "Uploaded Successfully", Data = photo});
            }
            return BadRequest(new ResponseModel<NotesEntity> { IsSuccess = false, Message = " Failed", Data = photo });
        }
        [Authorize]
        [HttpPost]
        [Route("GetByRemainder")]
        public ActionResult GetByRemainder(int noteId,DateTime remainder) 
        {
            var userid = int.Parse(User.Claims.Where(a => a.Type == "UserID").FirstOrDefault().Value);
            IEnumerable<NotesEntity> date = notesBusiness.GetAllNotesVyDate(userid, noteId,remainder);
            if (date != null)
            {
                return Ok(new ResponseModel<IEnumerable<NotesEntity>> { IsSuccess = true, Message = "Displayed", Data = date });
            }
            else
            {
                return BadRequest(new ResponseModel<IEnumerable<NotesEntity>> { IsSuccess=false,Message = "No Data",Data = date});
            }
        }

        
    }
}
