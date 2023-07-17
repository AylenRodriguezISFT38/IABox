using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class SiteSchedules
    {
        public long Id { get; set; }
        public long IdSite { get; set; }
        public string DayOfWeek { get; set; }
        public string TimeIni { get; set; }
        public string TimeEnd { get; set; }

        public virtual Site IdSiteNavigation { get; set; }
    }
}
