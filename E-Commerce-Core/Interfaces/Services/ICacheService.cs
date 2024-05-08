﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Core.Interfaces.Services
{
    public interface ICacheService
    {
        Task SetCacheResponseAsync (string key , object response , TimeSpan time);
        Task<string?> GetCacheResponseAsync(string key);


    }
}
