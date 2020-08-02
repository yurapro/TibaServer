using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tiba.Domain;
using Tiba.Services.Infractructure;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FavoritController : ControllerBase
    {
        private readonly ILogger<FavoritController> _logger;
        private readonly IFavoritService _favoritService;

        public FavoritController(ILogger<FavoritController> logger, IFavoritService favoritService)
        {
            _logger = logger;
            _favoritService = favoritService;
        }

        [Authorize]
        [HttpGet()]
        public IEnumerable<Favorit> Get()
        {
            string Id = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int userId;
            int.TryParse(Id, out userId);

            if (userId > 0)
            {
                return _favoritService.GetFavorites(userId);
            }

            return null;
        }

        [HttpPost]
        public bool Post(Favorit model)
        {
            string Id = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int userId;
            int.TryParse(Id, out userId);

            if (userId > 0)
            {
                model.UserID = userId;
                return _favoritService.AddFavorit(model);
            }

            return false;
        }
    }
}
