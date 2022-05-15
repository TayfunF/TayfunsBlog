using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayfunsBlog.Core.Dtos
{
    public class CommentDto : BaseDto
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public int PostId { get; set; }
    }
}
