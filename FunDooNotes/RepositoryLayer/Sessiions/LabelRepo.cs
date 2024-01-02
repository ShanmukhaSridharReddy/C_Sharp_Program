using Microsoft.AspNetCore.Mvc.Infrastructure;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using RepositoryLayer.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Sessiions
{
    public class LabelRepo : ILabelRepo
    {
        private readonly FunDooContext funDooContext;

        public LabelRepo(FunDooContext funDooContext)
        {
            this.funDooContext = funDooContext;
        }

        //Adding Label
        public LabelEntity AddLabel(int userid, int NoteId, string LabelName)
        {
            LabelEntity label = new LabelEntity();

            label.Id = userid;
            label.NoteId = NoteId;
            label.LabelName = LabelName;
            funDooContext.Labels.Add(label);
            funDooContext.SaveChanges();
            return label;
        }
        //Getting Label
        public IEnumerable<LabelEntity> GetLabels()
        {
            if (funDooContext.Labels == null)
            {
                return null;
            }
            return funDooContext.Labels.ToList();
        }

        //Update Label
        public LabelEntity UpdateLabel(int userId,int noteId,int labelId ,string labelName )
        {
            var label = funDooContext.Labels.Where(a=>a.Id == userId && a.NoteId ==noteId && a.LabelId == labelId ).FirstOrDefault();
            if(label != null)
            {
                label.LabelName = labelName;
                funDooContext.SaveChanges();
                return label;
            }
            return null;

        }

        //Delete Label
        public LabelEntity Delete ( int userId, int noteId ,int labelId)
        {
            var label = funDooContext.Labels.Where(a=>a.Id == userId && a.NoteId == noteId && a.LabelId == labelId ).FirstOrDefault();
            if(label != null )
            {
                funDooContext.Remove(label);
                funDooContext.SaveChanges ();
                return label;
            }
            return null;
        }

    }
}
