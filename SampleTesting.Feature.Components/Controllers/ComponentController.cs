using Sitecore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SampleTesting.Feature.Components.Models;
using SampleTesting.Feature.Components.Services;
using System.Web.Mvc;

namespace SampleTesting.Feature.Components.Controllers
{
    public class ComponentController : SitecoreController
    {
		protected readonly IApiService ApiService;

		public ComponentController(IApiService apiService)
		{
			ApiService = apiService;
		}

		public ActionResult ControllerComponent()
		{
			var model = new ControllerModel();

			return View(model);
		}
	}
}