using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class CAConfig // (swarm.CAConfig)
    {
        /// <summary>
        /// The duration node certificates are issued for.
        /// </summary>
        [DataMember(Name = "NodeCertExpiry", EmitDefaultValue = false)]
        public long NodeCertExpiry { get; set; }

        /// <summary>
        /// Configuration for forwarding signing requests to an external certificate authority.
        /// </summary>
        [DataMember(Name = "ExternalCAs", EmitDefaultValue = false)]
        public IList<ExternalCA> ExternalCAs { get; set; }

        /// <summary>
        /// The desired signing CA certificate for all swarm node TLS leaf certificates, in PEM format.
        /// </summary>
        [DataMember(Name = "SigningCACert", EmitDefaultValue = false)]
        public string SigningCACert { get; set; }

        /// <summary>
        /// The desired signing CA key for all swarm node TLS leaf certificates, in PEM format.
        /// </summary>
        [DataMember(Name = "SigningCAKey", EmitDefaultValue = false)]
        public string SigningCAKey { get; set; }

        /// <summary>
        /// An integer whose purpose is to force swarm to generate a new signing CA certificate and key, 
        /// if none have been specified in SigningCACert and SigningCAKey
        /// </summary>
        [DataMember(Name = "ForceRotate", EmitDefaultValue = false)]
        public ulong ForceRotate { get; set; }
    }
}
