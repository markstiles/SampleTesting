using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTesting.Feature.Components.Models.Glass
{
	[SitecoreType(TemplateId = ItemDatasourceConstants.TemplateIdString)]
	public partial interface IItemDatasource : IGlassBase
	{
		[SitecoreField(ItemDatasourceConstants.TitleFieldName)]
		string Title { get; set; }

		[SitecoreField(ItemDatasourceConstants.DescriptionFieldName)]
		string Description { get; set; }
	}

	public static partial class ItemDatasourceConstants
	{

		public const string TemplateIdString = "04af1c8b-9d3c-4fd6-b7a7-bf7d889665f8";
		public static readonly ID TemplateId = new ID(TemplateIdString);
		public const string TemplateName = "ItemDatasource";

		public static readonly ID TitleFieldId = new ID("7291cd38-44f9-4379-904e-d6c98b2a9068");
		public const string TitleFieldName = "Title";

		public static readonly ID DescriptionFieldId = new ID("7291cd38-44f9-4379-904e-d6c98b2a9068");
		public const string DescriptionFieldName = "Description";
	}

	[SitecoreType(TemplateId = ItemDatasourceConstants.TemplateIdString)]
	public partial class ItemDatasource : GlassBase, IItemDatasource
	{
		[SitecoreField(ItemDatasourceConstants.TitleFieldName)]
		public virtual string Title { get; set; }

		[SitecoreField(ItemDatasourceConstants.DescriptionFieldName)]
		public virtual string Description { get; set; }
	}
}