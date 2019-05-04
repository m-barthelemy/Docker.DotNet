using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class Spec // (swarm.Spec)
    {
        public Spec()
        {
        }

        public Spec(Annotations Annotations)
        {
            if (Annotations != null)
            {
                this.Name = Annotations.Name;
                this.Labels = Annotations.Labels;
            }
        }

        /// <summary>
        /// Name of the swarm.
        /// </summary>
        [DataMember(Name = "Name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// User-defined key/value metadata.
        /// </summary>
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// Orchestration configuration.
        /// </summary>
        [DataMember(Name = "Orchestration", EmitDefaultValue = false)]
        public OrchestrationConfig Orchestration { get; set; }

        /// <summary>
        /// Raft configuration.
        /// </summary>
        [DataMember(Name = "Raft", EmitDefaultValue = false)]
        public RaftConfig Raft { get; set; }

        /// <summary>
        /// Dispatcher configuration.
        /// </summary>
        [DataMember(Name = "Dispatcher", EmitDefaultValue = false)]
        public DispatcherConfig Dispatcher { get; set; }

        /// <summary>
        /// CA configuration.
        /// </summary>
        [DataMember(Name = "CAConfig", EmitDefaultValue = false)]
        public CAConfig CAConfig { get; set; }

        /// <summary>
        /// Defaults for creating tasks in this cluster.
        /// </summary>
        [DataMember(Name = "TaskDefaults", EmitDefaultValue = false)]
        public TaskDefaults TaskDefaults { get; set; }

        /// <summary>
        /// Parameters related to encryption-at-rest.
        /// </summary>
        [DataMember(Name = "EncryptionConfig", EmitDefaultValue = false)]
        public EncryptionConfig EncryptionConfig { get; set; }
    }
}
