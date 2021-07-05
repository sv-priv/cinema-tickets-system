using Domain.DomainModels;
using Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Movie>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ApplicationUser>()
                .HasOne(z => z.UserCart)
                .WithOne(z => z.Owner)
                .HasForeignKey<ShoppingCart>(z => z.OwnerId);

            builder.Entity<ShoppingCart>()
                .HasMany(z => z.TicketsInShoppingCart)
                .WithOne(z => z.ShoppingCart);

            builder.Entity<Order>()
                .HasMany(z => z.Tickets)
                .WithOne(z => z.Order);

            builder.Entity<Order>()
                .HasOne(z => z.User)
                .WithMany(z => z.Orders);

            builder.Entity<Ticket>()
                .HasOne(z => z.Movie)
                .WithOne(z => z.Ticket)
                .HasForeignKey<Movie>(z => z.Id);

        }
    }
}
