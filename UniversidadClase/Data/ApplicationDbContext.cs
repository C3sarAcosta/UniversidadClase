﻿using Microsoft.EntityFrameworkCore;

namespace UniversidadClase.Data
{
    public class ApplicationDbContext : DbContext
    {
        //Sobreescribir constructor
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        //Sobreescribir metodo
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        //Vamos a decirle a EF Core las tablas que va a crear
    }
}
