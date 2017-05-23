using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentForm_Spring2017.Models
{
    public class CommentFormViewModel
    {
        public Comment comment { get; set; }
        public Procedure procedure { get; set; }
    }
}