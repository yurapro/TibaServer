using System;
using System.Collections.Generic;
using System.Text;
using Tiba.Data.Context;
using Tiba.Data.Repository.Infrastructure;
using Tiba.Domain;

namespace Tiba.Data.Repository
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        public UserRepository(DataContext context) : base(context)
        {

        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
