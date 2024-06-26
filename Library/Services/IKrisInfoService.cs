﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    public interface IKrisInfoService
    {
        Task<List<KrisInfoResponse>> GetJsonDataAll();
        Task<KrisInfoResponse> GetJsonDataOne(int id);
    }
}
