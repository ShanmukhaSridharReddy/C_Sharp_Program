using BusinessLayer.InterFace;
using BusinessLayer.Sessions;
using MassTransit.Audit;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using RepositoryLayer.Sessiions;
using System.Collections.Generic;
using System.Linq;

namespace FunDooNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CollaboratorController : ControllerBase
    {
        private readonly ICollaboratorBusiness collaboratorBusiness;
        public CollaboratorController(ICollaboratorBusiness collaboratorBusiness)
        {
            this.collaboratorBusiness = collaboratorBusiness;
        }
        [Authorize]
        [HttpPost]
        [Route("AddCollaborator")]
        public ActionResult AddCollaborator(int noteId,string CollaboratorEmail)
        {
            var userid = int.Parse(User.Claims.Where(a => a.Type == "UserID").FirstOrDefault().Value);
            var collaborator = collaboratorBusiness.AddCollaborator(userid, noteId, CollaboratorEmail);
            if(collaborator != null)
            {
                return Ok(new ResponseModel<CollaboratorEntity> { IsSuccess = true, Message = "CollaboratorAdded", Data = collaborator });
            }
            else
            {
                return BadRequest(new ResponseModel<CollaboratorEntity> { IsSuccess = false, Message ="no Collabotator",Data = collaborator });
            }
        }
        [Authorize]
        [HttpGet]
        [Route("GetData")]
        public ActionResult GetData()
        {
            IEnumerable < CollaboratorEntity > data = collaboratorBusiness.GetCollaborator();
            if(data != null)
            {
                return Ok(new ResponseModel<IEnumerable<CollaboratorEntity>> { IsSuccess = true, Message = "DataDisplayed", Data = data });
            }
            else
            {
                return BadRequest(new ResponseModel<IEnumerable<CollaboratorEntity>>{ IsSuccess = false, Message = "Not displayed", Data = data });
            }
        }
        [Authorize]
        [HttpDelete]
        [Route("DeleteCollaborator")]
        public ActionResult DeleteData(int noteId, string collaboratorEmail)
        {
            var userid = int.Parse(User.Claims.Where(x => x.Type == "UserID").FirstOrDefault().Value);
            var label = collaboratorBusiness.DeleteCollaborator(userid, noteId, collaboratorEmail);
            if (label != null)
            {
                return Ok(new ResponseModel<CollaboratorEntity> { IsSuccess= true,Message = "Deleted Successfully",Data = label});
            }
            else
            {
                return BadRequest(new ResponseModel<CollaboratorEntity> { IsSuccess = false, Message = "not Deleted", Data = label });
            }
        }
    }
}
