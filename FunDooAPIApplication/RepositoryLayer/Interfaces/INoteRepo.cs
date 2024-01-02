using ModelLayer.Models;
using RepositoryLayer.EntitIes;
using System.Collections.Generic;

namespace RepositoryLayer.Interfaces
{
    public interface INoteRepo
    {
        NoteEntity Register(int userId, NoteModel noteModel);
        IEnumerable<NoteEntity> GetAll();
    }
}