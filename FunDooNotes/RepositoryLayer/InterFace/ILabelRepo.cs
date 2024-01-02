using RepositoryLayer.Entity;
using System.Collections.Generic;

namespace RepositoryLayer.InterFace
{
    public interface ILabelRepo
    {
        LabelEntity AddLabel(int userid, int NoteId, string LabelName);
        IEnumerable<LabelEntity> GetLabels();
        LabelEntity UpdateLabel(int userId, int noteId,int labelId,string labelName);
        LabelEntity Delete(int userId, int noteId, int labelId);
    }
}