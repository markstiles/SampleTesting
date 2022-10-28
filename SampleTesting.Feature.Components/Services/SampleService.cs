using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleTesting.Feature.Components.Services.Models;

namespace SampleTesting.Feature.Components.Services
{
    public class SampleService : ISampleService
    {
        protected List<SampleObject> Objects;

        public SampleService()
        {
            Objects = new List<SampleObject>();
        }

        public SampleObject GetObject(int position)
        {
            if (position < 0 || position >= Objects.Count)
                return null;

            return Objects[position];
        }

        public void AddObject(SampleObject sample)
        {
            Objects.Add(sample);
        }

        public void RemoveObject(SampleObject sample)
        {
            for (int i = 0; i < Objects.Count; i++)
            {
                var o = Objects[i];
                if (o.Id != sample.Id)
                    continue;

                Objects.RemoveAt(i);
            }
        }
    }
}