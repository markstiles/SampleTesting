using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTesting.Feature.Components.Models.Glass
{

	[SitecoreType(TemplateId = ItemRenderingParametersConstants.TemplateIdString)]
	public partial interface IItemRenderingParameters : IGlassBase
	{
		[SitecoreField(ItemRenderingParametersConstants.PositionFieldName)]
		Guid Position { get; set; }
	}

	public static partial class ItemRenderingParametersConstants
	{

		public const string TemplateIdString = "04af1c8b-9d3c-4fd6-b7a7-bf7d889665f8";
		public static readonly ID TemplateId = new ID(TemplateIdString);
		public const string TemplateName = "ItemRenderingParameters";

		public static readonly ID PositionFieldId = new ID("7291cd38-44f9-4379-904e-d6c98b2a9068");
		public const string PositionFieldName = "Position";
	}

	[SitecoreType(TemplateId = ItemRenderingParametersConstants.TemplateIdString)]
	public partial class ItemRenderingParameters : GlassBase, IItemRenderingParameters
	{
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
		[SitecoreField(ItemRenderingParametersConstants.PositionFieldName)]
		public virtual Guid Position { get; set; }
	}
}