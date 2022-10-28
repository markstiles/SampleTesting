using System;
using System.Web.Mvc;
using Xunit;
using AutoFixture;
using NSubstitute;
using FluentAssertions;
using SampleTesting.Feature.Components;
using SampleTesting.Feature.Components.Controllers;
using SampleTesting.Feature.Components.Models;
using SampleTesting.Feature.Components.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;

namespace SampleTesting.Feature.Components.Tests
{
    [TestClass]
    public class ControllerTests
    {
        [TestMethod]
        public void ComponentController_ReturnsValidObject()
        {
            var apiService = Substitute.For<IApiService>();
            var controller = new ComponentController(apiService);

            var t = Substitute.For<HttpRequestBase>();
            var actionResult = (ViewResult)controller.ControllerComponent();

            actionResult.Should().NotBeNull();
        }

        [TestMethod]
        public void ComponentController_ShouldBeViewResult()
        {
            var apiService = Substitute.For<IApiService>();
            var controller = new ComponentController(apiService);

            var actionResult = (ViewResult)controller.ControllerComponent();

            actionResult.Should().BeOfType(typeof(ViewResult));
        }

        [TestMethod]
        public void ComponentController_ModelShouldBeControllerModel()
        {
            var apiService = Substitute.For<IApiService>();
            var controller = new ComponentController(apiService);

            var actionResult = (ViewResult)controller.ControllerComponent();

            actionResult.Model.Should().BeOfType(typeof(ControllerModel));
        }

        [TestMethod]
        public void ComponentController_ModelTitleShouldBeValid()
        {
            var apiService = Substitute.For<IApiService>();
            var controller = new ComponentController(apiService);

            var actionResult = (ViewResult)controller.ControllerComponent();

            var model = (ControllerModel)actionResult.Model;
            model.Title.Should().Be("Sample Title");
        }
    }
}
