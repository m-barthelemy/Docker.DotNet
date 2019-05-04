using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class ExternalCA // (swarm.ExternalCA)
    {
        /// <summary>
        /// Protocol for communication with the external CA (currently only cfssl is supported).
        /// </summary>
        [DataMember(Name = "Protocol", EmitDefaultValue = false)]
        public string Protocol { get; set; }

        /// <summary>
        /// URL where certificate signing requests should be sent.
        /// </summary>
        [DataMember(Name = "URL", EmitDefaultValue = false)]
        public string URL { get; set; }

        /// <summary>
        /// The root CA certificate (in PEM format) this external CA uses to issue TLS certificates 
        /// (assumed to be to the current swarm root CA certificate if not provided).
        /// </summary>
        [DataMember(Name = "CACert", EmitDefaultValue = false)]
        public string CACert { get; set; }

        /// <summary>
        /// An object with key/value pairs that are interpreted as protocol-specific options for the external CA driver.
        /// </summary>
        [DataMember(Name = "Options", EmitDefaultValue = false)]
        public IDictionary<string, string> Options { get; set; }
    }
}
