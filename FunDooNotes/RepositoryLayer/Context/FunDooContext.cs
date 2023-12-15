using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Context
{
    public class FunDooContext : DbContext
    {
        public FunDooContext(DbContextOptions dbContext) : base(dbContext)
        {

        }
        public DbSet<UsersEntity>Users { get; set; }
        public DbSet<NoteEntity> Notes { get; set; }
    }
}
