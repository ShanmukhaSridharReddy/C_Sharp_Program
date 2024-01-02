using BusinessLayer.InterFace;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using RepositoryLayer.Sessiions;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class CollaboratorBusiness : ICollaboratorBusiness
    {
        private readonly ICollaboratorRepo collaboratorRepo;
        public CollaboratorBusiness(ICollaboratorRepo collaboratorRepo)
        {
            this.collaboratorRepo = collaboratorRepo;
        }
        public CollaboratorEntity AddCollaborator(int userid, int noteId, string collaboratorEmail)
        {
            return collaboratorRepo.AddCollaborator(userid, noteId, collaboratorEmail);
        }
        public IEnumerable<CollaboratorEntity> GetCollaborator()
        {
            return collaboratorRepo.GetCollaborator();
        }
        public CollaboratorEntity DeleteCollaborator(int userId, long noteId, string CollaboratorEmail)
        {
            return collaboratorRepo.DeleteCollaborator(userId, noteId, CollaboratorEmail);
        }
    }
}
