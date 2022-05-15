using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayfunsBlog.Core.Models
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public bool Active { get; set; } = true;
        public int CategoryId { get; set; }

        //Nav Prop
        public Category Category { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
