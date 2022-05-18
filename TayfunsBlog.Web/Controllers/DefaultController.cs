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
    }
}
