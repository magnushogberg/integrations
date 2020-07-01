using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace If.Itc.Integrations.Web.Context
{
    public class Integration
    {
        [Key]
        public Guid IntegrationId { get; set; }
        [MaxLength(8)]
        public string AssetCode { get; set; }
        [MaxLength(5)]
        public string EnvironmentCode { get; set; }
        [MaxLength(50)]
        public string IntegrationName { get; set; }
        [MaxLength(8)]
        public string CallerSenderCode { get; set; }
        [MaxLength(8)]
        public string ProviderReceiverCode { get; set; }
        [MaxLength(8)]
        public string ProtocolCode { get; set; }
        [MaxLength(500)]
        public string Address { get; set; }
        [MaxLength(150)]
        public string DataObject { get; set; }
        [DataType(DataType.Text)]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        [MaxLength(150)]
        public string CreatedBy { get; set; }
        [MaxLength(150)]
        public DateTime Updated { get; set; }
        public string UpdatedBy { get; set; }

        public Asset Asset { get; set; }
        public Protocol Protocol { get; set; }
        public Environment Environment { get; set; }
    }
}
