using Microsoft.EntityFrameworkCore;
using StackInternship.Data.Entities.Enums;
using StackInternship.Data.Entities.Models;
using System;
using System.Collections.Generic;

namespace StackInternship.Data.Entities.Seeds
{
    class DatabaseSeeder
    {
        public static void Execute(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasData(new List<User>
                {
                    new User
                    {
                        Id = 1,
                        Username = "aanic",
                        Password = "123",
                        FirstName = "Ana",
                        LastName = "Anic",
                        Role = Enums.UserRole.Intern,
                        RegistrationDate = new DateTime(2021, 12, 31),
                        DeactivationExpirationDate = null,
                        ReputationPoints = 1,
                        LabeledTrusted = false
                    },
                    new User
                    {
                        Id = 2,
                        Username = "ddujic",
                        Password = "456",
                        FirstName = "Duje",
                        LastName = "Dujic",
                        Role = Enums.UserRole.Organizer,
                        RegistrationDate = new DateTime(2021, 12, 31),
                        DeactivationExpirationDate = null,
                        ReputationPoints = 100000,
                        LabeledTrusted = true
                    },
                    new User
                    {
                        Id = 3,
                        Username = "ttoncic",
                        Password = "789",
                        FirstName = "Tonci",
                        LastName = "Toncic",
                        Role = Enums.UserRole.Intern,
                        RegistrationDate = new DateTime(2022, 1, 1),
                        DeactivationExpirationDate = null,
                        ReputationPoints = 100,
                        LabeledTrusted = false
                    }
                });

            builder.Entity<Resource>()
                .HasData(new List<Resource>
                {
                    new Resource
                    {
                        Id = 1,
                        Content = "1. resurs",
                        Category = ResourceCategory.Dev,
                        DateOfPosting = DateTime.Now,
                        UserId = 1,
                    },
                    new Resource
                    {
                        Id = 2,
                        Content = "2. resurs",
                        Category = ResourceCategory.Dev,
                        DateOfPosting = DateTime.Now,
                        UserId = 2,
                    },
                    new Resource
                    {
                        Id = 3,
                        Content = "3. resurs",
                        Category = ResourceCategory.General,
                        DateOfPosting = DateTime.Now,
                        UserId = 3,
                    }
                });

            builder.Entity<Comment>()
                .HasData(new List<Comment>
                {
                    new Comment
                    {
                        Id = 1,
                        Content = "1. komentar",
                        DateOfPosting = DateTime.Now,
                        UserId = 1,
                        ResourceId = 1,
                        ParentId = null,
                    },
                    new Comment
                    {
                        Id = 2,
                        Content = "2. komentar",
                        DateOfPosting = DateTime.Now,
                        UserId = 2,
                        ResourceId = 2,
                        ParentId = null,
                    },
                    new Comment
                    {
                        Id = 3,
                        Content = "3. komentar",
                        DateOfPosting = DateTime.Now,
                        UserId = 3,
                        ResourceId = 2,
                        ParentId = 1,
                    }
                });
        }
    }
}
