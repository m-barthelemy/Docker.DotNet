using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class OrchestrationConfig // (swarm.OrchestrationConfig)
    {
        [DataMember(Name = "TaskHistoryRetentionLimit", EmitDefaultValue = false)]
        public long? TaskHistoryRetentionLimit { get; set; }
    }
}
