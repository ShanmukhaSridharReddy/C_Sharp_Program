using Microsoft.Extensions.Primitives;
using ModelLayer.Models;
using RepositoryLayer.Context;
using RepositoryLayer.EntitIes;
using RepositoryLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Sessions
{
    public class NoteRepo : INoteRepo
    {
        private readonly FunDooContext funDooContext;
        public NoteRepo(FunDooContext funDooContext)
        {
            this.funDooContext = funDooContext;
        }
        public NoteEntity Register(int userId, NoteModel noteModel)
        {

            NoteEntity noteEntity = new NoteEntity();
            noteEntity.Title = noteModel.Title;
            noteEntity.Description = noteModel.Description;
            noteEntity.Remainder = noteModel.Remainder;
            noteEntity.Colors = noteModel.Colors;
            noteEntity.image = noteModel.image;
            noteEntity.IsArchive = noteModel.IsArchive;
            noteEntity.IsPin = noteModel.IsPin;
            noteEntity.IsTrash = noteModel.IsTrash;
            noteEntity.UserId = userId;
            funDooContext.Note.Add(noteEntity);
            funDooContext.SaveChanges();
            return noteEntity;
        }

        public IEnumerable<NoteEntity> GetAll()
        {
            if(funDooContext.Note == null)
            {
                return null;
            }
            return funDooContext.Note.ToList();
        }

        public NoteEntity Color(int userid, int noteid,string color)
        {
            var 
        }
    }
}
