using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace If.Itc.Integrations.Web.Context
{   
    public class SubIntegration
    {
        [Key]
        Guid SubIntegrationId { get; set; }
        [ForeignKey("IntegrationId")]
        Guid ParentIntegrationId { get; set; }
        [ForeignKey("IntegrationId")]
        Guid ChildIntegrationId { get; set; }

        int Order { get; set; }
    }
}
