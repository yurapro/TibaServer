using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Tiba.Data.Repository;
using Tiba.Data.Repository.Infrastructure;
using Tiba.Domain;
using Tiba.Services.Infractructure;

namespace Tiba.Services
{
    public class FavoritService : IFavoritService
    {
        private readonly IFavoritRepository _favoritRepository;

        public FavoritService(IFavoritRepository favoritRepository)
        {
            _favoritRepository = favoritRepository;
        }

        [Authorize]
        public bool AddFavorit(Favorit favorit)
        {
            return _favoritRepository.Insert(favorit);
        }

        [Authorize]
        public IEnumerable<Favorit> GetFavorites(int userId)
        {
            List<Favorit> favorits = _favoritRepository.Query(x => x.UserID == userId).ToList();

            return favorits;
        }
    }
}
