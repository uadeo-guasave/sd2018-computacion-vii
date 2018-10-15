using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueOnda.Entidades
{
    class SQLiteDbContext : DbContext
    {
        // TODO: definir la conexion a utilizar
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data source=db/queonda.db");
            base.OnConfiguring(optionsBuilder);
        }

        // TODO: definir la estructura de las tablas
        // en caso de no existir una (Fluent API)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>(usuario =>
            {
                usuario.HasIndex(i => i.NombreDeUsuario).IsUnique();
                usuario.HasIndex(i => i.CorreoElectronico).IsUnique();
                usuario.HasData(
                    new Usuario
                    {
                        NombreDeUsuario = "bidkar",
                        Contraseña = "123",
                        Nombre = "Bidkar",
                        Apellidos = "Aragon",
                        CorreoElectronico = "bidkar.aragon@udo.mx",
                        Id = 1
                    });
            });

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Usuario> Usuarios { get; set; }
    }
}
