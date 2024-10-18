//using APortfolio.DAL.Entitites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APortfolio.DAL.Data.Seed
{
    public class DbSeeder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            SeedPortfolios(modelBuilder);
            SeedProjects(modelBuilder);
        }
        private void SeedPortfolios(ModelBuilder modelBuilder)
        {
            // Sample data for seeding
            modelBuilder.Entity<Portfolio>().HasData(
                new Portfolio
                {
                    Id = 1,
                    Title = "Portfolio 1",
                    Description = "This is the description for Portfolio 1",
                    CreatedDate = DateTime.Now,
                    UserId = "c2c38126-c0ff-46c1-8fc5-23fb21ec07ed", // This should correspond to a valid AppUser in your data
                },
                new Portfolio
                {
                    Id = 2,
                    Title = "Portfolio 2",
                    Description = "This is the description for Portfolio 2",
                    CreatedDate = DateTime.Now,
                    UserId = "c2c38126-c0ff-46c1-8fc5-23fb21ec07ed", // This should correspond to a valid AppUser in your data
                },
                new Portfolio
                {
                    Id = 3,
                    Title = "Portfolio 3",
                    Description = "This is the description for Portfolio 3",
                    CreatedDate = DateTime.Now,
                    UserId = "c2c38126-c0ff-46c1-8fc5-23fb21ec07ed", // This should correspond to a valid AppUser in your data
                }

            );
        }

        private void SeedProjects(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = 1,
                    Title = "Project #1",
                    Description = "Project #1 Portfolio #1",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project1.jpeg",
                    PortfolioId = 1
                },
                new Project
                {
                    Id = 2,
                    Title = "Project #2",
                    Description = "Project #2 Portfolio #1",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project2.jpeg",
                    PortfolioId = 1
                },
                new Project
                {
                    Id = 3,
                    Title = "Project #3",
                    Description = "Project #3 Portfolio #1",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project3.jpeg",
                    PortfolioId = 1
                },
                new Project
                {
                    Id = 4,
                    Title = "Project #1",
                    Description = "Project #1 Portfolio #2",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project4.jpeg",
                    PortfolioId = 2
                },
                new Project
                {
                    Id = 5,
                    Title = "Project #2",
                    Description = "Project #2 Portfolio #2",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project5.jpeg",
                    PortfolioId = 2
                },
                new Project
                {
                    Id = 6,
                    Title = "Project #1",
                    Description = "Project #1 Portfolio #3",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project6.jpeg",
                    PortfolioId = 3
                },
                new Project
                {
                    Id = 7,
                    Title = "Project #2",
                    Description = "Project #2 Portfolio #3",
                    CreatedDate = DateTime.Now,
                    ImageUrl = "/images/projects/project7.jpeg",
                    PortfolioId = 3
                }

            );
        }
    }
}
