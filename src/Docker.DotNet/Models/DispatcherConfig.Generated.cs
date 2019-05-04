using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class DispatcherConfig // (swarm.DispatcherConfig)
    {
        [DataMember(Name = "HeartbeatPeriod", EmitDefaultValue = false)]
        public long HeartbeatPeriod { get; set; }
    }
}
