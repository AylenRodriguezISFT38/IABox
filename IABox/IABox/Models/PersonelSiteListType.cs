using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class PersonelSiteListType
    {
        public long Id { get; set; }
        public long IdSite { get; set; }
        public long IdPersonel { get; set; }
        public long IdListType { get; set; }
        public bool? Enable { get; set; }
        public DateTime InsertDate { get; set; }
        public long IdPersonnelEventType { get; set; }

        public virtual ListType IdListTypeNavigation { get; set; }
        public virtual Personnel IdPersonelNavigation { get; set; }
        public virtual PersonelEventType IdPersonnelEventTypeNavigation { get; set; }
        public virtual Site IdSiteNavigation { get; set; }
    }
}
