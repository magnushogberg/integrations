using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace If.Itc.Integrations.Web.Context
{
    public class Protocol
    {
        [Key, MaxLength(8)]
        public string ProtocolCode { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public List<Integration> Integrations { get; set; }
    }
}
