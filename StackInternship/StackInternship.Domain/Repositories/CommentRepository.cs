using StackInternship.Data.Entities;
using StackInternship.Data.Entities.Models;
using StackInternship.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackInternship.Domain.Repositories
{
    public class CommentRepository : RepositoryBase
    {
        public CommentRepository(StackInternshipDbContext dbContext) : base(dbContext)
        {
        }

        public ResponseResultType Add(Comment comment)
        {
            DbContext.Comments.Add(comment);

            return SaveChanges();
        }
        public ResponseResultType Edit(Comment comment, int commentId)
        {
            var edittingComment = DbContext.Comments.Find(commentId);
            if (edittingComment is null)
            {
                return ResponseResultType.NotFound;
            }
            edittingComment.Content = comment.Content;
            edittingComment.DateOfPosting = comment.DateOfPosting;

            return SaveChanges();
        }
        public ResponseResultType Delete(int commentId)
        {
            var deletingComment = DbContext.Comments.Find(commentId);
            if (deletingComment is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Comments.Remove(deletingComment);

            return SaveChanges();
        }

        public ICollection<Comment> GetAll() => DbContext.Comments.ToList();
    }
}
