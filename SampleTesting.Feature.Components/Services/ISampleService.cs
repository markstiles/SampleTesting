using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleTesting.Feature.Components.Services.Models;

namespace SampleTesting.Feature.Components.Services
{
    public interface ISampleService
    {
        SampleObject GetObject(int position);
        void AddObject(SampleObject sample);
        void RemoveObject(SampleObject sample);
    }
}