using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using System.Collections.Generic;

namespace BusinessLayer.Interfaces
{
    public interface INoteBusiness
    {
        NoteEntity Register(int userId, NoteModel noteModel);
        IEnumerable<NoteEntity> GetAll();
    }
}