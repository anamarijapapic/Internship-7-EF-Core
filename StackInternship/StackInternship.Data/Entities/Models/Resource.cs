using StackInternship.Data.Entities.Enums;
using System;
using System.Collections.Generic;

namespace StackInternship.Data.Entities.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ResourceCategory Category { get; set; }
        public DateTime DateOfPosting { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Upvote> Upvotes { get; set; }
        public ICollection<Downvote> Downvotes { get; set; }
        public ICollection<View> Views { get; set; }
    }
}
