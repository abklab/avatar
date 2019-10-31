using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NEWHIRES.DAL;

namespace NEWHIRES.Interfaces
{
    interface IDriversLicense : IGenericService<DriversLicense>
    {
        Task<DriversLicense> GetByAppId(int appid);
    }
}
