using RepositoryLayer.Entity;
using System.Collections.Generic;

namespace BusinessLayer.InterFace
{
    public interface ICollaboratorBusiness
    {
        CollaboratorEntity AddCollaborator(int userid, int noteId, string collaboratorEmail);
        IEnumerable<CollaboratorEntity> GetCollaborator();
        CollaboratorEntity DeleteCollaborator(int userId, long noteId, string CollaboratorEmail);
    }
}