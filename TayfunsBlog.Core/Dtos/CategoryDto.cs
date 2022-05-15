using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TayfunsBlog.Core.Dtos
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public bool Status { get; set; }
    }
}
