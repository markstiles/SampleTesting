using System;
using Xunit;
using AutoFixture;
using AutoFixture.AutoNSubstitute;
using NSubstitute;
using FluentAssertions;
using SampleTesting.Feature.Components;
using SampleTesting.Feature.Components.Models;
using SampleTesting.Feature.Components.Services;
using SampleTesting.Feature.Components.Services.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleTesting.Feature.Components.Tests
{
    [TestClass]
    public class ServiceTests
    {
        [TestMethod]
        public void SampleService_ShouldStartEmpty()
        {
            var sampleService = new SampleService();
            var firstObject = sampleService.GetObject(0);

            firstObject.Should().BeNull();
        }

        [TestMethod]
        public void SampleService_ShouldAddObject()
        {
            var sampleService = new SampleService();

            var fixture = new Fixture().Customize(new AutoNSubstituteCustomization() { ConfigureMembers = true });
            var newObject = fixture.Create<SampleObject>();

            sampleService.AddObject(newObject);

            var returnObject = sampleService.GetObject(0);

            returnObject.Id.Should().Be(newObject.Id);
        }

        [TestMethod]
        public void SampleService_ShouldRemoveObject()
        {
            var sampleService = new SampleService();

            var fixture = new Fixture().Customize(new AutoNSubstituteCustomization() { ConfigureMembers = true });
            var newObject = fixture.Create<SampleObject>();

            sampleService.AddObject(newObject);
            sampleService.RemoveObject(newObject);

            var returnObject = sampleService.GetObject(0);

            returnObject.Should().BeNull();
        }
    }
}
