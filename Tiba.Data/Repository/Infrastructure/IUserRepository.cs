using System;
using System.Collections.Generic;
using System.Text;
using Tiba.Domain;

namespace Tiba.Data.Repository.Infrastructure
{
    public interface IUserRepository : IRepository<User>
    {
        public void Test();
    }
}
