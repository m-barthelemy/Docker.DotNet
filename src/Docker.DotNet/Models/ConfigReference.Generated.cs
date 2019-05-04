using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class ConfigReference // (swarm.ConfigReference)
    {
        [DataMember(Name = "File", EmitDefaultValue = false)]
        public SecretAndConfigReferenceFileTarget File { get; set; }

        [DataMember(Name = "ConfigID", EmitDefaultValue = false)]
        public string ConfigID { get; set; }

        [DataMember(Name = "ConfigName", EmitDefaultValue = false)]
        public string ConfigName { get; set; }
    }
}
