using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NEWHIRES.DAL;

namespace NEWHIRES.Interfaces
{
    interface IAddress : IGenericService<Address>
    {
         Task<Address> GetByAppId(int appid);
    }
}
