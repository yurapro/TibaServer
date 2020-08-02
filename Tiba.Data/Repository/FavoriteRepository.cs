using System;
using System.Collections.Generic;
using System.Text;
using Tiba.Data.Context;
using Tiba.Data.Repository.Infrastructure;
using Tiba.Domain;

namespace Tiba.Data.Repository
{
    public class FavoriteRepository : DataRepository<Favorit>, IFavoritRepository
    {
        public FavoriteRepository(DataContext context) : base(context)
        {

        }
    }
}
