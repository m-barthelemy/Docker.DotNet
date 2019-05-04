using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class TaskDefaults // (swarm.TaskDefaults)
    {
        [DataMember(Name = "LogDriver", EmitDefaultValue = false)]
        public SwarmDriver LogDriver { get; set; }
    }
}
