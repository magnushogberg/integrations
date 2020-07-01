using If.Itc.Integrations.Web.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace If.Itc.Integrations.Web.Models
{
    public class SearchViewModel
    {
        List<Integration> Integrations { get; set; }
        List<Protocol> Protocols { get; set; }
        List<Asset> Systems { get; set; }
        List<Context.Environment> Environments { get; set; }
    }
}
