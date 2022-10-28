using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTesting.Feature.Components.Services.Models
{
    public class SampleObject
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public List<string> Options { get; set; }
    }
}