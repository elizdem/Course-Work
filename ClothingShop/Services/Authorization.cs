using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingShop.Services
{
    class Authorization : IAuthorization
    {
        public bool Authorize(string login, string password)
        {
            return true;
        }
    }
}
