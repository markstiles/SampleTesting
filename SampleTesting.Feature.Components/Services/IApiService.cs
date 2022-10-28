using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleTesting.Feature.Components.Services.Models;

namespace SampleTesting.Feature.Components.Services
{
    public interface IApiService
    {
        void SendData(ApiRequest request);
        ApiResponse GetData();
    }
}