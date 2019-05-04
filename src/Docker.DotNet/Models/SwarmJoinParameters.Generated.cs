using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class SwarmJoinParameters // (swarm.JoinRequest)
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
        /// Addresses of manager nodes already participating in the swarm.
        /// </summary>
        [DataMember(Name = "RemoteAddrs", EmitDefaultValue = false)]
        public IList<string> RemoteAddrs { get; set; }

        /// <summary>
        /// Secret token for joining this swarm.
        /// </summary>
        [DataMember(Name = "JoinToken", EmitDefaultValue = false)]
        public string JoinToken { get; set; }
    }
}
