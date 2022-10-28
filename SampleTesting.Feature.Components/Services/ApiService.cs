using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleTesting.Feature.Components.Services.Models;

namespace SampleTesting.Feature.Components.Services
{
    public class ApiService : IApiService
    {
        public void SendData(ApiRequest request)
        {

        }

        public ApiResponse GetData()
        {
            return new ApiResponse
            {
                Data = "Response"
            };
        }
    }
}