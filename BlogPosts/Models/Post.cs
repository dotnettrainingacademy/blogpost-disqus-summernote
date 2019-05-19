using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPosts.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Display(Name = "Post Title")]
        public string PostName { get; set; }

        [Display(Name = "Post Description")]
        public string PostDescription { get; set; }

        [Display(Name = "Post Content")]
        public string Content { get; set; }

        public DateTime TimeStamp { get; set; }

        public Post()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
