using System;
namespace Docker.DotNet.Models
{
    /// <summary>
    /// Read-only spec type for non-swarm containers attached to swarm overlay networks.
    /// </summary>
    public class NetworkAttachmentSpec
    {
        /// <summary>
        /// ID of the container represented by this task
        /// </summary>
        public string ContainerID { get; set; }

        public NetworkAttachmentSpec()
        {
        }
    }
}
