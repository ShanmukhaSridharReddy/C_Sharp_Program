using Microsoft.AspNetCore.Http;
using ModelLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;

namespace BusinessLayer.InterFace
{
    public interface INotesBusiness
    {
        NotesEntity RegisterNote(int userId, NotesModel noteModel);
        IEnumerable<NotesEntity> GetAllNotes();
        NotesEntity Delete(int userId, int noteId);
        NotesEntity Update(int userId, int noteId, NotesModel notesModel);
        bool CheckIsTrash(int userId, int noteId);
        bool CheckIsPin(int userId, int noteId);
        bool CheckIsArchive(int userId, int noteId);
        NotesEntity Colour(int userId, int noteId, string colour);
        NotesEntity Remainder(int userId, int noteId, DateTime dateTime);
        NotesEntity AddImage(int userId, int noteId, IFormFile image);
        IEnumerable<NotesEntity> GetAllNotesVyDate(int userId, int noteId, DateTime remainder);
        
    }
}