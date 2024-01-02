using BusinessLayer.InterFace;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using System.Collections.Generic;
using System.Linq;

namespace FunDooNotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LabelController : ControllerBase
    {
        private readonly ILabelBusiness labelBusiness;
        public LabelController(ILabelBusiness labelBusiness)
        {
            this.labelBusiness = labelBusiness;
        }
        [Authorize]
        [HttpPost]
        [Route("AddLabel")]
        public ActionResult AddLabel(int noteId,string labelName)
        {
            var userid = int.Parse(User.Claims.FirstOrDefault(x => x.Type == "UserID").Value);
            var label = labelBusiness.AddLabel(userid,noteId,labelName);
            if(label != null)
            {
                return Ok(new ResponseModel<LabelEntity> { IsSuccess = true, Message = "Label Added", Data = label });
            }
            else
            {
                return BadRequest(new ResponseModel<LabelEntity> { IsSuccess= false,Message=" Not Added", Data = label});
            }
        }

        [Authorize]
        [HttpGet]
        [Route("GetLabel")]
        public ActionResult GetLabel()
        {
            IEnumerable<LabelEntity> label = labelBusiness.GetLabels();
            if(label != null)
            {
                return Ok(new ResponseModel<IEnumerable<LabelEntity>> { IsSuccess = true, Message = "Displaying Data", Data = label });
            }
            else 
            {
                return BadRequest(new ResponseModel<string> { IsSuccess = false, Message="No Data"});
            }
        }

        [Authorize]
        [HttpPost]
        [Route("UpdateLabel")]
        public ActionResult UpdateLabel(int noteId,int labelId,string labelName)
        {
            var userId = int.Parse(User.Claims.Where(x=>x.Type == "UserID").FirstOrDefault().Value);
            var list = labelBusiness.UpdateLabel(userId, noteId,labelId, labelName);
            if(list != null)
            {
                return Ok(new ResponseModel<LabelEntity> { IsSuccess = true, Message = "Updated", Data= list});
            }
            else
            {
                return BadRequest(new ResponseModel<LabelEntity> { IsSuccess = false, Message = "NotUpdated", Data = list });
            }
        }

        [Authorize]
        [HttpDelete]
        [Route("DeleteLabel")]
        public ActionResult DeleteLabel(int noteId,int labelId)
        {
            var userId = int.Parse(User.Claims.Where(a => a.Type == "UserID").FirstOrDefault().Value);
            var list = labelBusiness.Delete(userId, noteId,labelId);
            if( list != null)
            {
                return Ok(new ResponseModel<LabelEntity> { IsSuccess = true,Message="Deleted successfully",Data=list});
            }
            else
            {
                return BadRequest(new ResponseModel<LabelEntity> { IsSuccess = false, Message = "Delete Failed", Data = list });
            }
        }

    }
}
