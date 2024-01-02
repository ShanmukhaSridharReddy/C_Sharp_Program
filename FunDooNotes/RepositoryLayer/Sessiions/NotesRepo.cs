using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using ModelLayer.Model;
using RepositoryLayer.Context;
using RepositoryLayer.Entity;
using RepositoryLayer.InterFace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Sessiions
{
    public class NotesRepo : INotesRepo
    {
        private readonly FunDooContext funDooContext;
        private readonly IConfiguration configuration;
        public NotesRepo(FunDooContext funDooContext, IConfiguration configuration)
        {
            this.funDooContext = funDooContext;
            this.configuration = configuration;
        }
        public NotesEntity Register(int userId, NotesModel noteModel)
        {

            NotesEntity noteEntity = new NotesEntity();
            noteEntity.Title = noteModel.Title;
            noteEntity.Description = noteModel.Description;
            noteEntity.Remainder = noteModel.Remainder;
            noteEntity.Colors = noteModel.Colors;
            noteEntity.image = noteModel.image;
            noteEntity.IsArchive = noteModel.IsArchive;
            noteEntity.IsPin = noteModel.IsPin;
            noteEntity.IsTrash = noteModel.IsTrash;
            noteEntity.UserId = userId;
            funDooContext.Notes.Add(noteEntity);
            funDooContext.SaveChanges();
            return noteEntity;
        }
        public IEnumerable<NotesEntity> GetAllNotes()
        {
            if(funDooContext.Notes == null)
            {
                return null;
            }
            return funDooContext.Notes.ToList();
        }
        public IEnumerable<NotesEntity> GetAllNotesVyDate(int userId,int noteId,DateTime remainder)
        {
            IEnumerable<NotesEntity> user = funDooContext.Notes.Where(a => a.UserId == userId && a.NoteId == noteId && a.Remainder==remainder).ToList();
            if (user ==null )
            {
                return null;
            }
            return funDooContext.Notes.ToList();
        }
        public NotesEntity Delete(int userId,int noteId)
        {
            NotesEntity result = funDooContext.Notes.Where(a=> a.UserId==userId).FirstOrDefault();
            if ( result.UserId ==userId && result.NoteId == noteId )
            {

                funDooContext.Notes.Remove(result);
                funDooContext.SaveChanges();
                return result;

            }
            return null;
        }
        public NotesEntity Update( int userId,int noteId,NotesModel notesModel)
        {
            NotesEntity user = funDooContext.Notes.Where(a=> a.UserId==userId &&  a.NoteId == noteId).FirstOrDefault();
            if( user != null)
            {
               
                user.Title = notesModel.Title;
                user.Description = notesModel.Description;
                user.Remainder = notesModel.Remainder;
                user.Colors = notesModel.Colors;
                user.image = notesModel.image;
                user.IsArchive = notesModel.IsArchive;
                user.IsPin = notesModel.IsPin;
                user.IsTrash = notesModel.IsTrash;
                funDooContext.Entry(user).State=EntityState.Modified;
                funDooContext.SaveChanges();
                return user;
            }
            return null;
            
        }
        public bool CheckIsTrash(int userId,int noteId)
        {
            var note = funDooContext.Notes.Where(a=>a.UserId==userId).FirstOrDefault();
            if( note.IsTrash == false)
            {
                note.IsTrash = true;
                    funDooContext.SaveChanges(); 
                    return true;
            }
            else
            {
                note.IsTrash= false;
                funDooContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CheckIsPin(int userId,int noteId)
        {
            var note = funDooContext.Notes.Where(a=>a.UserId == userId).FirstOrDefault();
            if(note.IsPin == false)
            {
                note.IsPin = true;
                funDooContext.SaveChanges();
                return true;
            }
            else
            {
                note.IsPin= false;
                funDooContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool CheckIsArchive(int userId,int noteId)
        {
            var note = funDooContext.Notes.Where(a=>a.UserId == userId).FirstOrDefault();
            if( note.IsArchive == false)
            {
                note.IsArchive = true;
                funDooContext.SaveChanges();
                return true;
            }
            else
            {
                note.IsArchive= false;
                funDooContext.SaveChanges();
                return true;
            }
            return false;
        }
        public NotesEntity Colour(int userId,int noteId,string colour) 
        {
            var note = funDooContext.Notes.Where(a=>a.UserId==userId && a.NoteId==noteId).FirstOrDefault();
            if(note.Colors != null)
            {
                note.Colors = colour;
                funDooContext.SaveChanges();
                return note;

            }
            return null;
        }
        public NotesEntity Remainder(int userId,int noteId,DateTime dateTime)
        {
            var note = funDooContext.Notes.Where(a=>a.UserId == userId &&  a.NoteId==noteId).FirstOrDefault();  
            DateTime currentdatetime = DateTime.Now;
            DateTime remainder = dateTime;
            if(remainder > currentdatetime)
            {
                note.Remainder = dateTime;
                funDooContext.SaveChanges();
                return note;
            }
            return null;
        }

        public NotesEntity AddImage(int userId, int noteId, IFormFile image)
        {
            NotesEntity notesEntity= funDooContext.Notes.Where(a=>a.UserId == userId && a.NoteId==noteId).FirstOrDefault();
            if(notesEntity != null)
            {
                Account account = new Account(
                    configuration["CloudinarySettings:CloudName"],
                    configuration["CloudinarySettings:ApiKey"],
                    configuration["CloudinarySettings:ApiSecrect"]
                    );
                Cloudinary cloudinary = new Cloudinary(account);
                var UploadParameters = new ImageUploadParams()
                {
                    File = new FileDescription(image.FileName, image.OpenReadStream()),
                };

                var UploadResult = cloudinary.Upload(UploadParameters);
                string ImagePath = UploadResult.Url.ToString();
                notesEntity.image = ImagePath;
                funDooContext.SaveChanges();
                return notesEntity;
            }   
            return notesEntity;
        }

       



    }
}
