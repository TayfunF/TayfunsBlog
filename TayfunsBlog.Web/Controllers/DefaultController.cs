using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TayfunsBlog.Core.Dtos;
using TayfunsBlog.Core.Services;

namespace TayfunsBlog.Web.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public DefaultController(IPostService postService, IMapper mapper)
        {
            _postService = postService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var Posts = await _postService.GetAllAsync();
            var PostsDtos = _mapper.Map<List<PostDto>>(Posts);
            var PostsDtosOrderBy = PostsDtos.OrderByDescending(x => x.Id).ToList();

            return View(PostsDtosOrderBy);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();
            int Id = Convert.ToInt32(id);
            var GetPostId = await _postService.GetByIdAsync(Id);
            var GetPostIdDto = _mapper.Map<PostDto>(GetPostId);

            return View(GetPostIdDto);
        }
    }
}
