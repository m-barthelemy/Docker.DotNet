using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class SecretAndConfigReferenceFileTarget // (swarm.SecretReferenceFileTarget)
    {
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "UID", EmitDefaultValue = false)]
        public string UID { get; set; }

        [DataMember(Name = "GID", EmitDefaultValue = false)]
        public string GID { get; set; }

        [DataMember(Name = "Mode", EmitDefaultValue = false)]
        public uint Mode { get; set; }
    }
}
