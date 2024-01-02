using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Sessiions
{
    public class CollaboratorRepo : ICollaboratorRepo
    {
        private readonly FunDooContext funDooContext;
        public CollaboratorRepo(FunDooContext funDooContext)
        {
            this.funDooContext = funDooContext;
        }
        public CollaboratorEntity AddCollaborator(int userid, int noteId, string collaboratorEmail)
        {
            CollaboratorEntity collaboratorEntity = new CollaboratorEntity();
            collaboratorEntity.Id = userid;
            collaboratorEntity.NoteId = noteId;
            collaboratorEntity.Email = collaboratorEmail;
            funDooContext.Collaborators.Add(collaboratorEntity);
            funDooContext.SaveChanges();
            return collaboratorEntity;
        }
        public IEnumerable<CollaboratorEntity> GetCollaborator() 
        {
            if( funDooContext.Collaborators == null)
            {
                return null;
            }
            return funDooContext.Collaborators.ToList();
        }
        public CollaboratorEntity DeleteCollaborator(int userId,long noteId,string CollaboratorEmail)
        {
            var del = funDooContext.Collaborators.Where(a=>a.Id == userId && a.NoteId == noteId && a.Email== CollaboratorEmail).FirstOrDefault();
            if (del != null)
            {
                funDooContext.Remove(del);
                funDooContext.SaveChanges();
                return del;
            }
            return null;
        }

    }
}
