using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class WeatherInfo
    {
        public long Id { get; set; }
        public long IdIabox { get; set; }
        public string Weather { get; set; }
        public double? Temperature { get; set; }
        public double? Humidity { get; set; }
        public double? Wind { get; set; }
        public double? Rain { get; set; }
        public DateTime? DateUpdate { get; set; }

        public virtual IaBox IdIaboxNavigation { get; set; }
    }
}
