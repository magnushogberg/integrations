using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace If.Itc.Integrations.Web.Context
{
    public class Environment
    {
        [Key, MaxLength(5)]
        public string EnvironmentCode { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }

        public List<Integration> Integrations { get; set; }

    }
}
