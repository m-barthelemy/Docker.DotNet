using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class ContainerSpec // (swarm.ContainerSpec)
    {
        /// <summary>
        /// The image name to use for the container.
        /// </summary>
        [DataMember(Name = "Image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// User-defined key/value data.
        /// </summary>
        [DataMember(Name = "Labels", EmitDefaultValue = false)]
        public IDictionary<string, string> Labels { get; set; }

        /// <summary>
        /// The command to be run in the image.
        /// </summary>
        [DataMember(Name = "Command", EmitDefaultValue = false)]
        public IList<string> Command { get; set; }

        /// <summary>
        /// Arguments to the command.
        /// </summary>
        [DataMember(Name = "Args", EmitDefaultValue = false)]
        public IList<string> Args { get; set; }

        /// <summary>
        /// The hostname to use for the container, as a valid RFC 1123 hostname.
        /// </summary>
        [DataMember(Name = "Hostname", EmitDefaultValue = false)]
        public string Hostname { get; set; }

        /// <summary>
        /// A list of environment variables in the form VAR=value.
        /// </summary>
        [DataMember(Name = "Env", EmitDefaultValue = false)]
        public IList<string> Env { get; set; }

        /// <summary>
        /// The working directory for commands to run in.
        /// </summary>
        [DataMember(Name = "Dir", EmitDefaultValue = false)]
        public string Dir { get; set; }

        /// <summary>
        /// The user inside the container.
        /// </summary>
        [DataMember(Name = "User", EmitDefaultValue = false)]
        public string User { get; set; }

        /// <summary>
        /// A list of additional groups that the container process will run as.
        /// </summary>
        [DataMember(Name = "Groups", EmitDefaultValue = false)]
        public IList<string> Groups { get; set; }

        /// <summary>
        /// Security options for the container
        /// </summary>
        //TODO: Implement.
        //public ContainerSecurityOptions Privileges { get; set; }

        /// <summary>
        /// Whether a pseudo-TTY should be allocated.
        /// </summary>
        [DataMember(Name = "TTY", EmitDefaultValue = false)]
        public bool TTY { get; set; }

        /// <summary>
        /// Open stdin
        /// </summary>
        [DataMember(Name = "OpenStdin", EmitDefaultValue = false)]
        public bool OpenStdin { get; set; }

        /// <summary>
        /// Mount the container's root filesystem as read only.
        /// </summary>
        [DataMember(Name = "ReadOnly", EmitDefaultValue = false)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Specification for mounts to be added to containers created as part of the service.
        /// </summary>
        [DataMember(Name = "Mounts", EmitDefaultValue = false)]
        public IList<Mount> Mounts { get; set; }

        /// <summary>
        /// Unix Signal to stop the container.
        /// </summary>
        [DataMember(Name = "StopSignal", EmitDefaultValue = false)]
        public string StopSignal { get; set; }

        /// <summary>
        /// Amount of time to wait for the container to terminate before forcefully killing it.
        /// </summary>
        /// <value>The stop grace period.</value>
        [DataMember(Name = "StopGracePeriod", EmitDefaultValue = false)]
        public long? StopGracePeriod { get; set; }

        /// <summary>
        /// A test to perform to check that the container is healthy.
        /// </summary>
        [DataMember(Name = "Healthcheck", EmitDefaultValue = false)]
        public HealthConfig Healthcheck { get; set; }

        /// <summary>
        /// A list of hostname/IP mappings to add to the container's hosts file. 
        /// The format of extra hosts is specified in the hosts(5) man page:
        /// </summary>
        [DataMember(Name = "Hosts", EmitDefaultValue = false)]
        public IList<string> Hosts { get; set; }

        /// <summary>
        /// Specification for DNS related configurations in resolver configuration file (resolv.conf).
        /// </summary>
        [DataMember(Name = "DNSConfig", EmitDefaultValue = false)]
        public DNSConfig DNSConfig { get; set; }

        /// <summary>
        /// References to zero or more secrets that will be exposed to the service.
        /// </summary>
        [DataMember(Name = "Secrets", EmitDefaultValue = false)]
        public IList<SecretReference> Secrets { get; set; }

        [DataMember(Name = "Configs", EmitDefaultValue = false)]
        public IList<ConfigReference> Configs { get; set; }

        /// <summary>
        /// Valid values: "default" "process" "hyperv"
        /// Isolation technology of the containers running the service. (Windows only)
        /// </summary>
        [DataMember(Name = "Isolation", EmitDefaultValue = false)]
        public string Isolation { get; set; }

    }
}