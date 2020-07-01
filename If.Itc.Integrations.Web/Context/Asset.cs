
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace If.Itc.Integrations.Web.Context
{
    public class Asset
    {
        [Key, MaxLength(8)]
        public string AssetCode { get; set; }
        [MaxLength(150)]
        public string AssetName { get; set; }
        [MaxLength(150)]
        public string ResponsibleEmail { get; set; }

        public List<Integration> Integrations { get; set; }

    }
}
