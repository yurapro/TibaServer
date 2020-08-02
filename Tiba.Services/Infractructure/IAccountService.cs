using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Tiba.Services.Infractructure
{
    public interface IAccountService
    {
        public object LogIn(string login, string password);
    }
}
