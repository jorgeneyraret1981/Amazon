﻿using Microsoft.EntityFrameworkCore;
namespace Amazon.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }
        public DbSet<Book> Books { get; set; }    //ACCESO A LA TABLA BOOKS
    }
}