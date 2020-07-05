using Newtonsoft.Json;
using System;

namespace TestingConnectionWithPostgre.Models
{
    public class Tenant
    {
        [JsonProperty("id")]
        public Guid id { get; set; }
        [JsonProperty("tenantId")]
        public Guid TenantId { get; set; }
        [JsonProperty("tenantType")]
        public string TenantType { get; set; }
    }
}
