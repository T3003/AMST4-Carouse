﻿
using AMST4.Carousel.MVC.Models;
using Microsoft.EntityFrameworkCore;


    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; }
    }

