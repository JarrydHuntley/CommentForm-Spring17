using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CommentForm_Spring2017.Models
{
    public class Procedure
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
        public int Priority { get; set; }
    }
}