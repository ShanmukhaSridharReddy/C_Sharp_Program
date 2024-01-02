using BusinessLayer.InterFace;
using Microsoft.AspNetCore.Http;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Sessions
{
    public class NotesBusiness : INotesBusiness
    {
        private readonly INotesRepo noteRepo;
        public NotesBusiness(INotesRepo noteRepo)
        {
            this.noteRepo = noteRepo;
        }
        public NotesEntity RegisterNote(int userId, NotesModel noteModel)
        {
            return noteRepo.Register(userId, noteModel);
        }
        public IEnumerable<NotesEntity> GetAllNotes()
        {
            return noteRepo.GetAllNotes();
        }
        public NotesEntity Delete(int userId, int noteId)
        {
            return noteRepo.Delete(userId, noteId);
        }
        public NotesEntity Update(int userId, int noteId, NotesModel notesModel)
        {
            return noteRepo.Update( userId,noteId, notesModel);
        }
        public bool CheckIsTrash(int userId, int noteId)
        {
            return noteRepo.CheckIsTrash(userId, noteId);
        }
        public bool CheckIsPin(int userId, int noteId)
        {
            return noteRepo.CheckIsPin(userId, noteId);
        }
        public bool CheckIsArchive(int userId, int noteId)
        {
            return noteRepo.CheckIsArchive(userId, noteId);
        }
        public NotesEntity Colour(int userId, int noteId, string colour)
        {
            return noteRepo.Colour(userId, noteId, colour);
        }
        public NotesEntity Remainder(int userId, int noteId, DateTime dateTime)
        {
            return noteRepo.Remainder(userId, noteId, dateTime);
        }
        public NotesEntity AddImage(int userId, int noteId, IFormFile image)
        {
            return noteRepo.AddImage(userId, noteId, image);
        }
        public IEnumerable<NotesEntity> GetAllNotesVyDate(int userId, int noteId, DateTime remainder)
        {
            return noteRepo.GetAllNotesVyDate(userId,noteId,remainder);
        }
        
    }
}
