using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayfunsBlog.Core.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public bool Status { get; set; }

        //Nav Prop
        public ICollection<Post> Posts { get; set; }
    }
}
