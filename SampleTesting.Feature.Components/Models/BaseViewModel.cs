using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Glass.Mapper.Sc;
using Sitecore.Data.Items;
using SampleTesting.Feature.Components.Models.Glass;

namespace SampleTesting.Feature.Components.Models
{
    public class BaseViewModel<TDatasource, TRenderingParameter> : BaseViewModel<TDatasource>
		where TDatasource : IGlassBase
		where TRenderingParameter : IGlassBase
	{
		public virtual TRenderingParameter RenderingParameters { get; internal set; }

		public override void Initialize(Rendering rendering)
		{
			base.Initialize(rendering);

			RenderingParameters = (TRenderingParameter)Activator.CreateInstance(typeof(TRenderingParameter), Rendering.Properties["Parameters"]);
		}

	}

	public class BaseViewModel<TDatasource> : RenderingModel 
		where TDatasource : IGlassBase
	{
		public virtual TDatasource Datasource { get; internal set; }

		public override void Initialize(Rendering rendering)
		{
		
			base.Initialize(rendering);

			Datasource = (TDatasource)Activator.CreateInstance(typeof(TDatasource), (Item)Item);
		}
	}
}