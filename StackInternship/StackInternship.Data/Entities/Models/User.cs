using StackInternship.Data.Entities.Enums;
using System;
using System.Collections.Generic;

namespace StackInternship.Data.Entities.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserRole Role { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime? DeactivationExpirationDate { get; set; }
        public int ReputationPoints { get; set; }
        public bool LabeledTrusted { get; set; }

        public ICollection<Resource> Resources { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Upvote> Upvotes { get; set; }
        public ICollection<Downvote> Downvotes { get; set; }
        public ICollection<View> Views { get; set; }
    }
}
