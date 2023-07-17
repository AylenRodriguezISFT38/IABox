using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class DetectedObjects
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
    }
}
