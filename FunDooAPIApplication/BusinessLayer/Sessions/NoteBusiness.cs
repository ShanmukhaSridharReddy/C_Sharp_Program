using BusinessLayer.Interfaces;
using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class NoteBusiness : INoteBusiness
    {
        private readonly INoteRepo noteRepo;
        public NoteBusiness(INoteRepo noteRepo)
        {
            this.noteRepo = noteRepo;
        }
        public NoteEntity Register(int userId, NoteModel noteModel)
        {
            return noteRepo.Register(userId, noteModel);
        }

        public IEnumerable<NoteEntity> GetAll() 
        {
            return noteRepo.GetAll(); 
        }
    }
}
