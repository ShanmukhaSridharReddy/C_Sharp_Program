using RepositoryLayer.Entity;
using System.Collections.Generic;

namespace RepositoryLayer.InterFace
{
    public interface ICollaboratorRepo
    {
        CollaboratorEntity AddCollaborator(int userid, int noteId, string collaboratorEmail);
        IEnumerable<CollaboratorEntity> GetCollaborator();
        CollaboratorEntity DeleteCollaborator(int userId, long noteId, string CollaboratorEmail);
    }
}