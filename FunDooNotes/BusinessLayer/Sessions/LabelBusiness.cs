using BusinessLayer.InterFace;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class LabelBusiness : ILabelBusiness
    {
        private readonly ILabelRepo labelRepo;
        public LabelBusiness(ILabelRepo labelRepo)
        {
            this.labelRepo = labelRepo;
        }
        public LabelEntity AddLabel(int userid, int NoteId, string LabelName)
        {
            return labelRepo.AddLabel(userid, NoteId, LabelName);
        }

        public IEnumerable<LabelEntity> GetLabels()
        {
            return labelRepo.GetLabels();
        }
        public LabelEntity UpdateLabel(int userId,int noteId , int labelId, string labelName)
        {
            return labelRepo.UpdateLabel(userId, noteId,labelId, labelName);
        }
        public LabelEntity Delete(int userId, int noteId, int labelId)
        {
            return labelRepo.Delete(userId, noteId, labelId);
        }
    }
}
