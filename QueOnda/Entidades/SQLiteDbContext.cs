using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueOnda.Entidades
{
    class SQLiteDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        
    }
}
