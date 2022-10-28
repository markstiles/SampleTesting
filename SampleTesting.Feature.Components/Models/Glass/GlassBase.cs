using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleTesting.Feature.Components.Models.Glass
{
    public partial class GlassBase : IGlassBase
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreInfo(SitecoreInfoType.FullPath)]
        public virtual string Path { get; set; }

        [SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language { get; set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; set; }

        [SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; set; }

        [SitecoreInfo(SitecoreInfoType.BaseTemplateIds)]
        public virtual IEnumerable<Guid> BaseTemplateIds { get; set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string ItemName { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid TemplateId { get; set; }

        [SitecoreInfo(SitecoreInfoType.TemplateName)]
        [SitecoreFieldAttribute(FieldName = "Title")]
        public virtual string TemplateName { get; set; }

        [SitecoreField("__Sortorder")]
        public virtual string Sortorder { get; set; }

        [SitecoreField("__Created")]
        public virtual DateTime CreatedDate { get; set; }

        [SitecoreParent]
        public virtual GlassBase Parent { get; set; }
    }
}