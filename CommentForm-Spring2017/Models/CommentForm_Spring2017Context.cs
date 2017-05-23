using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CommentForm_Spring2017.Models
{
    public class CommentForm_Spring2017Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CommentForm_Spring2017Context() : base("name=CommentForm_Spring2017Context")
        {
        }

        public System.Data.Entity.DbSet<CommentForm_Spring2017.Models.Comment> Comments { get; set; }

        public System.Data.Entity.DbSet<CommentForm_Spring2017.Models.Procedure> Procedures { get; set; }
    }
}
