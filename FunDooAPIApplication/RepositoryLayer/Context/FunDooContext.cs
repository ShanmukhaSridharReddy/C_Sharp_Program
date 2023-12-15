using Microsoft.EntityFrameworkCore;
using RepositoryLayer.EntitIes;
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
        public DbSet<UsersEntity> Users { get; set; }

        public DbSet<ReviewEntity> Review { get; set; }
    }
}
