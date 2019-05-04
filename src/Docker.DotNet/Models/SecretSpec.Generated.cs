using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class SecretSpec // (swarm.SecretSpec)
    {
        public SecretSpec()
        {
        }

        public SecretSpec(Annotations Annotations)
        {
            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
            }
        }

        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public IDictionary<string, string> Labels { get; set; }

        [DataMember(Name = "Data", EmitDefaultValue = false)]
        public IList<byte> Data { get; set; }

        /// <summary>
        /// Optional Docker plugin or driver.
        /// </summary>
        [DataMember(Name = "Driver", EmitDefaultValue = false)]
        public SwarmDriver Driver { get; set; }

        /// <summary>
        /// Optional templating engine, example: "golang"
        /// </summary>
        [DataMember(Name = "Templating", EmitDefaultValue = false)]
        public SwarmDriver Templating { get; set; }
    }
}
