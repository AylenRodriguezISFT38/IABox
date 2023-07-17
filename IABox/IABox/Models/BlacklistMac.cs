using System;
using System.Collections.Generic;

namespace Api.Entity
{
    public partial class BlacklistMac
    {
        public int Id { get; set; }
        public string MacAddress { get; set; }
        public string Descrip { get; set; }
        public string AccNum { get; set; }
        public byte[] Photo1 { get; set; }
    }
}
