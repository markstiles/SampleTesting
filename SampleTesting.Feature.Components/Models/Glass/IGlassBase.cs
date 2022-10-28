using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTesting.Feature.Components.Models.Glass
{
    public partial interface IGlassBase
    {
        [SitecoreId]
        Guid Id { get; set; }
        [SitecoreInfo(SitecoreInfoType.FullPath)]
        string Path { get; set; }
        [SitecoreInfo(SitecoreInfoType.Language)]
        Language Language { get; set; }
        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; set; }
        [SitecoreInfo(SitecoreInfoType.BaseTemplateIds)]
        IEnumerable<Guid> BaseTemplateIds { get; set; }
        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; set; }
        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; set; }
        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        [SitecoreFieldAttribute(FieldName = "Title")]
        string TemplateName { get; set; }
        [SitecoreField("__Sortorder")]
        string Sortorder { get; set; }
        [SitecoreField("__Created")]
        DateTime CreatedDate { get; set; }
    }
}