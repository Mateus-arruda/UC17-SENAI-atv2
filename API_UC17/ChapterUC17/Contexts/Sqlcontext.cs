using ChapterUC17.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ChapterUC17.Contexts
{
    public class Sqlcontext : DbContext
    {
        public Sqlcontext() { }
        public Sqlcontext(DbContextOptions<Sqlcontext> options) : base(options) { }
        //Vamos utilizar método para configurar o bd

        protected override void

        OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source = HEITORPC\\SQLEXPRESS; initial catalog = Chapter; user id=sa; password = 123");
                optionsBuilder.UseSqlServer("Data Source = HEITORPC\\SQLEXPRESS; initial catalog = Chapter; Integrated Security = true");
            }
        }
        //dbset 
        public DbSet<Livro> Livros { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}