﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WhiteLagoon.Domain.Entities;

namespace WhiteLagoon.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }
        public DbSet<Amenity> Amenities { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().ToTable("Villas").HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Description = "A luxurious villa with stunning views and modern amenities.",
                    ImageUrl = "https://placehold.co/600x400",
                    Occupancy = 4,
                    Price = 200,
                    Sqft = 500
                },
                new Villa
                {
                    Id = 2,
                    Name = "Ocean View Villa",
                    Description = "A beautiful villa overlooking the ocean, perfect for a relaxing getaway.",
                    ImageUrl = "https://placehold.co/600x401",
                    Occupancy = 4,
                    Price = 300,
                    Sqft = 550
                },
                new Villa
                {
                    Id = 3,
                    Name = "Mountain Retreat Villa",
                    Description = "A serene villa nestled in the mountains, ideal for nature lovers.",
                    ImageUrl = "https://placehold.co/600x402",
                    Occupancy = 4,
                    Price = 400,
                    Sqft = 750
                });

            modelBuilder.Entity<VillaNumber>().HasData(
                new VillaNumber
                {
                    Villa_Number = 101,
                    VillaId = 1
                },
                new VillaNumber
                {
                    Villa_Number = 102,
                    VillaId = 1
                },
                new VillaNumber
                {
                    Villa_Number = 103,
                    VillaId = 1
                },
                new VillaNumber
                {
                    Villa_Number = 104,
                    VillaId = 1
                },
                new VillaNumber
                {
                    Villa_Number = 201,
                    VillaId = 2
                },
                new VillaNumber
                {
                    Villa_Number = 202,
                    VillaId = 2
                },
                new VillaNumber
                {
                    Villa_Number = 203,
                    VillaId = 2
                },
                new VillaNumber
                {
                    Villa_Number = 301,
                    VillaId = 3
                },
                new VillaNumber
                {
                    Villa_Number = 302,
                    VillaId = 3
                }
            );

            modelBuilder.Entity<Amenity>().HasData(
                new Amenity
                {
                    Id = 1,
                    VillaId = 1,
                    Name = "Private Pool"
                },
                new Amenity
                {
                    Id = 2,
                    VillaId = 1,
                    Name = "Microwave"
                },
                new Amenity
                {
                    Id = 3,
                    VillaId = 1,
                    Name = "Private Balcony"
                },
                new Amenity
                {
                    Id = 4,
                    VillaId = 1,
                    Name = "1 king bed and 1 sofa bed"
                },
                new Amenity
                {
                    Id = 5,
                    VillaId = 2,
                    Name = "Private Plunge Pool"
                },
                new Amenity
                {
                    Id = 6,
                    VillaId = 2,
                    Name = "Microwave and Mini Refrigerator"
                },
                new Amenity
                {
                    Id = 7,
                    VillaId = 2,
                    Name = "Private Balcony"
                },
                new Amenity
                {
                    Id = 8,
                    VillaId = 2,
                    Name = "king bed or 2 double beds"
                },
                new Amenity
                {
                    Id = 9,
                    VillaId = 3,
                    Name = "Private Pool"
                },
                new Amenity
                {
                    Id = 10,
                    VillaId = 3,
                    Name = "Jacuzzi"
                },
                new Amenity
                {
                    Id = 11,
                    VillaId = 3,
                    Name = "Private Balcony"
                }
            );
        }
    }
}