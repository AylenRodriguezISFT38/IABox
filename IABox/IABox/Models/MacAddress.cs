using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class MacAddress
    {
        public long Id { get; set; }
        public string AccNum { get; set; }
        public string MacAddress1 { get; set; }
        public DateTime? DateIni { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? SignalStrength { get; set; }
        public double? Distance { get; set; }
        public string AntennaCode { get; set; }
    }
}
