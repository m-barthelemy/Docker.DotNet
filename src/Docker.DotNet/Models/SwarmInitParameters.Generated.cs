using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class SwarmInitParameters // (swarm.InitRequest)
    {
        /// <summary>
        /// Listen address used for inter-manager communication, as well as determining the networking interface used 
        /// for the VXLAN Tunnel Endpoint (VTEP). 
        /// This can either be an address/port combination in the form 192.168.1.1:4567, or an interface followed by 
        /// a port number, like eth0:4567. 
        /// If the port number is omitted, the default swarm listening port is used.
        /// </summary>
        [DataMember(Name = "ListenAddr", EmitDefaultValue = false)]
        public string ListenAddr { get; set; }

        /// <summary>
        /// Externally reachable address advertised to other nodes. 
        /// This can either be an address/port combination in the form 192.168.1.1:4567, or an interface followed by 
        /// a port number, like eth0:4567. 
        /// If the port number is omitted, the port number from the listen address is used. 
        /// If not specified, it will be automatically detected when possible.
        /// </summary>
        [DataMember(Name = "AdvertiseAddr", EmitDefaultValue = false)]
        public string AdvertiseAddr { get; set; }

        /// <summary>
        /// The DataPathAddr specifies the address that global scope network drivers will publish towards other nodes 
        /// in order to reach the containers running on this node. 
        /// Using this parameter it is possible to separate the container data traffic from the management traffic of 
        /// the cluster.
        /// </summary>
        [DataMember(Name = "DataPathAddr", EmitDefaultValue = false)]
        public string DataPathAddr { get; set; }

        /// <summary>
        /// Default Address Pool specifies default subnet pools for global scope networks.
        /// </summary>
        [DataMember(Name = "DefaultAddrPool", EmitDefaultValue = false)]
        public IList<string> DefaultAddrPool { get; set; }

        /// <summary>
        /// Force creation of a new swarm.
        /// </summary>
        [DataMember(Name = "ForceNewCluster", EmitDefaultValue = false)]
        public bool ForceNewCluster { get; set; }

        /// <summary>
        /// SubnetSize specifies the subnet size of the networks created from the default subnet pool
        /// </summary>
        [DataMember(Name = "SubnetSize", EmitDefaultValue = false)]
        public uint SubnetSize { get; set; }

        /// <summary>
        /// User modifiable swarm configuration.
        /// </summary>
        [DataMember(Name = "Spec", EmitDefaultValue = false)]
        public Spec Spec { get; set; }


        // This doesn't seem to exist anywhere in Docker API 1.25 to 1.39
        //[DataMember(Name = "AutoLockManagers", EmitDefaultValue = false)]
        //public bool AutoLockManagers { get; set; }
    }
}
