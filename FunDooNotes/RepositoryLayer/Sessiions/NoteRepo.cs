using RepositoryLayer.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Sessiions
{
    public class NoteRepo
    {
        private readonly FunDooContext funDooContext;

        public NoteRepo (FunDooContext funDooContext)
        {
            this.funDooContext = funDooContext;
        }
    }
}
