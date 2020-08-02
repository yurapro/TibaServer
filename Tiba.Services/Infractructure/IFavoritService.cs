using System;
using System.Collections.Generic;
using System.Text;
using Tiba.Domain;

namespace Tiba.Services.Infractructure
{
    public interface IFavoritService
    {
        IEnumerable<Favorit> GetFavorites(int userId);
        bool AddFavorit(Favorit favorit);
    }
}
