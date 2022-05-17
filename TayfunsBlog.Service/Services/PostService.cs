using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TayfunsBlog.Core.Models;
using TayfunsBlog.Core.Repositories;
using TayfunsBlog.Core.Services;
using TayfunsBlog.Core.UnitOfWorks;

namespace TayfunsBlog.Service.Services
{
    public class PostService : Service<Post>, IPostService
    {
        public PostService(IGenericRepository<Post> genericRepository, IUnitOfWork unitOfWork) : base(genericRepository, unitOfWork)
        {
        }
    }
}
