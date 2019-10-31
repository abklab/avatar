using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NEWHIRES.DAL;

namespace NEWHIRES.Interfaces
{
    interface IBackgroundInfo : IGenericService<BackgroundInfo>
    {
        Task<BackgroundInfo> FindByAppId(int appid);
    }
}
