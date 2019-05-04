using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class EncryptionConfig // (swarm.EncryptionConfig)
    {
        [DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
        public bool AutoLockManagers { get; set; }
    }
}
