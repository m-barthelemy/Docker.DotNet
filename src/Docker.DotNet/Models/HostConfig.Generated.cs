using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/05
    [DataContract]
    public class HostConfig // (container.HostConfig)
    {
        public HostConfig()
        {
        }

        public HostConfig(Resources Resources)
        {
            if (Resources != null)
            {
                this.CPUShares = Resources.CPUShares;
                this.Memory = Resources.Memory;
                this.NanoCPUs = Resources.NanoCPUs;
                this.CgroupParent = Resources.CgroupParent;
                this.BlkioWeight = Resources.BlkioWeight;
                this.BlkioWeightDevice = Resources.BlkioWeightDevice;
                this.BlkioDeviceReadBps = Resources.BlkioDeviceReadBps;
                this.BlkioDeviceWriteBps = Resources.BlkioDeviceWriteBps;
                this.BlkioDeviceReadIOps = Resources.BlkioDeviceReadIOps;
                this.BlkioDeviceWriteIOps = Resources.BlkioDeviceWriteIOps;
                this.CPUPeriod = Resources.CPUPeriod;
                this.CPUQuota = Resources.CPUQuota;
                this.CPURealtimePeriod = Resources.CPURealtimePeriod;
                this.CPURealtimeRuntime = Resources.CPURealtimeRuntime;
                this.CpusetCpus = Resources.CpusetCpus;
                this.CpusetMems = Resources.CpusetMems;
                this.Devices = Resources.Devices;
                this.DeviceCgroupRules = Resources.DeviceCgroupRules;
                this.DiskQuota = Resources.DiskQuota;
                this.KernelMemory = Resources.KernelMemory;
                this.MemoryReservation = Resources.MemoryReservation;
                this.MemorySwap = Resources.MemorySwap;
                this.MemorySwappiness = Resources.MemorySwappiness;
                this.OomKillDisable = Resources.OomKillDisable;
                this.PidsLimit = Resources.PidsLimit;
                this.Ulimits = Resources.Ulimits;
                this.CPUCount = Resources.CPUCount;
                this.CPUPercent = Resources.CPUPercent;
                this.IOMaximumIOps = Resources.IOMaximumIOps;
                this.IOMaximumBandwidth = Resources.IOMaximumBandwidth;
            }
        }

        /// <summary>
        /// A list of volume bindings for this container. Each volume binding is a string in one of these forms:
        /// host-src:container-dest to bind-mount a host path into the container. Both host-src, and container-dest must be an absolute path. 
        /// host-src:container-dest:ro to make the bind mount read-only inside the container. Both host-src, and container-dest must be an absolute path. 
        /// volume-name:container-dest to bind-mount a volume managed by a volume driver into the container.container-dest must be an absolute path.
        /// volume-name:container-dest:ro to mount the volume read-only inside the container. container-dest must be an absolute path.
        /// </summary>
        [DataMember(Name = "Binds", EmitDefaultValue = false)]
        public IList<string> Binds { get; set; }

        /// <summary>
        /// Path to a file (on the host) where the container ID is written.
        /// </summary>
        /// <value>The container IDF ile.</value>
        [DataMember(Name = "ContainerIDFile", EmitDefaultValue = false)]
        public string ContainerIDFile { get; set; }

        /// <summary>
        /// The logging configuration for this container
        /// </summary>
        [DataMember(Name = "LogConfig", EmitDefaultValue = false)]
        public LogConfig LogConfig { get; set; }

        /// <summary>
        /// Network mode to use for this container. Supported standard values are: bridge, host, none, 
        /// and container:<name|id>. Any other value is taken as a custom network's name to which this container should connect to.
        /// </summary>
        [DataMember(Name = "NetworkMode", EmitDefaultValue = false)]
        public string NetworkMode { get; set; }

        /// <summary>
        /// PortMap describes the mapping of container ports to host ports, using the container's port-number and 
        /// protocol as key in the format <port>/<protocol>, for example, 80/udp.
        /// If a container's port is mapped for multiple protocols, separate entries are added to the mapping table.
        /// </summary>
        [DataMember(Name = "PortBindings", EmitDefaultValue = false)]
        public IDictionary<string, IList<PortBinding>> PortBindings { get; set; }

        /// <summary>
        /// The behavior to apply when the container exits. The default is not to restart.
        /// An ever increasing delay(double the previous delay, starting at 100ms) is added before each restart to prevent flooding the server.
        /// </summary>
        [DataMember(Name = "RestartPolicy", EmitDefaultValue = false)]
        public RestartPolicy RestartPolicy { get; set; }

        /// <summary>
        /// Automatically remove the container when the container's process exits. 
        /// This has no effect if RestartPolicy is set.
        /// </summary>
        [DataMember(Name = "AutoRemove", EmitDefaultValue = false)]
        public bool AutoRemove { get; set; }

        /// <summary>
        /// Driver that this container uses to mount volumes.
        /// </summary>
        [DataMember(Name = "VolumeDriver", EmitDefaultValue = false)]
        public string VolumeDriver { get; set; }

        /// <summary>
        /// A list of volumes to inherit from another container, specified in the form <container name>[:<ro|rw>].
        /// </summary>
        [DataMember(Name = "VolumesFrom", EmitDefaultValue = false)]
        public IList<string> VolumesFrom { get; set; }

        /// <summary>
        /// A list of kernel capabilities to add to the container.
        /// </summary>
        [DataMember(Name = "CapAdd", EmitDefaultValue = false)]
        public IList<string> CapAdd { get; set; }

        /// <summary>
        /// A list of kernel capabilities to drop from the container.
        /// </summary>
        [DataMember(Name = "CapDrop", EmitDefaultValue = false)]
        public IList<string> CapDrop { get; set; }

        /// <summary>
        /// A list of DNS servers for the container to use.
        /// </summary>
        [DataMember(Name = "Dns", EmitDefaultValue = false)]
        public IList<string> DNS { get; set; }

        [DataMember(Name = "DnsOptions", EmitDefaultValue = false)]
        public IList<string> DNSOptions { get; set; }

        [DataMember(Name = "DnsSearch", EmitDefaultValue = false)]
        public IList<string> DNSSearch { get; set; }

        /// <summary>
        /// A list of hostnames/IP mappings to add to the container's /etc/hosts file. 
        /// Specified in the form ["hostname:IP"].
        /// </summary>
        [DataMember(Name = "ExtraHosts", EmitDefaultValue = false)]
        public IList<string> ExtraHosts { get; set; }

        /// <summary>
        /// A list of additional groups that the container process will run as.
        /// </summary>
        [DataMember(Name = "GroupAdd", EmitDefaultValue = false)]
        public IList<string> GroupAdd { get; set; }

        /// <summary>
        /// IPC sharing mode for the container. Possible values are:
        /// "none": own private IPC namespace, with /dev/shm not mounted. 
        /// "private": own private IPC namespace. 
        /// "shareable": own private IPC namespace, with a possibility to share it with other containers. 
        /// "container:<name|id>": join another(shareable) container's IPC namespace. 
        /// "host": use the host system's IPC namespace. 
        /// If not specified, daemon default is used, which can either be "private" or "shareable", depending on daemon version and configuration.
        /// </summary>
        [DataMember(Name = "IpcMode", EmitDefaultValue = false)]
        public string IpcMode { get; set; }

        /// <summary>
        /// Cgroup to use for the container.
        /// </summary>
        [DataMember(Name = "Cgroup", EmitDefaultValue = false)]
        public string Cgroup { get; set; }

        [DataMember(Name = "Links", EmitDefaultValue = false)]
        public IList<string> Links { get; set; }

        /// <summary>
        /// An integer value containing the score given to the container in order to tune OOM killer preferences.
        /// </summary>
        [DataMember(Name = "OomScoreAdj", EmitDefaultValue = false)]
        public long OomScoreAdj { get; set; }

        /// <summary>
        /// Set the PID (Process) Namespace mode for the container. It can be either:
        /// "container:<name|id>": joins another container's PID namespace. 
        /// "host": use the host's PID namespace inside the container.
        /// </summary>
        [DataMember(Name = "PidMode", EmitDefaultValue = false)]
        public string PidMode { get; set; }

        /// <summary>
        /// (dangerous) Gives the container full access to the host.
        /// </summary>
        [DataMember(Name = "Privileged", EmitDefaultValue = false)]
        public bool Privileged { get; set; }

        /// <summary>
        /// Allocates an ephemeral host port for all of a container's exposed ports.
        /// Ports are de-allocated when the container stops and allocated when the container starts. 
        /// The allocated port might be changed when restarting the container.
        /// The port is selected from the ephemeral port range that depends on the kernel. 
        /// For example, on Linux the range is defined by /proc/sys/net/ipv4/ip_local_port_range.
        /// </summary>
        [DataMember(Name = "PublishAllPorts", EmitDefaultValue = false)]
        public bool PublishAllPorts { get; set; }

        /// <summary>
        /// Mount the container's root filesystem as read only.
        /// </summary>
        [DataMember(Name = "ReadonlyRootfs", EmitDefaultValue = false)]
        public bool ReadonlyRootfs { get; set; }

        [DataMember(Name = "SecurityOpt", EmitDefaultValue = false)]
        public IList<string> SecurityOpt { get; set; }

        [DataMember(Name = "StorageOpt", EmitDefaultValue = false)]
        public IDictionary<string, string> StorageOpt { get; set; }

        /// <summary>
        /// A map of container directories which should be replaced by tmpfs mounts, 
        /// and their corresponding mount options. For example: { "/run": "rw,noexec,nosuid,size=65536k" }.
        /// </summary>
        [DataMember(Name = "Tmpfs", EmitDefaultValue = false)]
        public IDictionary<string, string> Tmpfs { get; set; }

        /// <summary>
        /// UTS namespace to use for the container.
        /// </summary>
        [DataMember(Name = "UTSMode", EmitDefaultValue = false)]
        public string UTSMode { get; set; }

        [DataMember(Name = "UsernsMode", EmitDefaultValue = false)]
        public string UsernsMode { get; set; }

        /// <summary>
        /// Size of /dev/shm in bytes. If omitted, the system uses 64MB.
        /// </summary>
        [DataMember(Name = "ShmSize", EmitDefaultValue = false)]
        public long ShmSize { get; set; }

        /// <summary>
        /// A list of kernel parameters (sysctls) to set in the container. For example: {"net.ipv4.ip_forward": "1"}
        /// </summary>
        [DataMember(Name = "Sysctls", EmitDefaultValue = false)]
        public IDictionary<string, string> Sysctls { get; set; }

        /// <summary>
        /// Runtime to use with this container.
        /// </summary>
        [DataMember(Name = "Runtime", EmitDefaultValue = false)]
        public string Runtime { get; set; }

        [DataMember(Name = "ConsoleSize", EmitDefaultValue = false)]
        public ulong[] ConsoleSize { get; set; }

        /// <summary>
        /// Isolation technology of the container. (Windows only).
        /// Valid values: "default" "process" "hyperv"
        /// </summary>
        /// <value>The isolation.</value>
        [DataMember(Name = "Isolation", EmitDefaultValue = false)]
        public string Isolation { get; set; }

        /// <summary>
        /// An integer value representing this container's relative CPU weight versus other containers.
        /// </summary>
        [DataMember(Name = "CpuShares", EmitDefaultValue = false)]
        public long CPUShares { get; set; }

        /// <summary>
        /// Memory limit in bytes.
        /// </summary>
        [DataMember(Name = "Memory", EmitDefaultValue = false)]
        public long Memory { get; set; }

        /// <summary>
        /// CPU quota in units of 10-9 CPUs.
        /// </summary>
        [DataMember(Name = "NanoCpus", EmitDefaultValue = false)]
        public long NanoCPUs { get; set; }

        /// <summary>
        /// Path to cgroups under which the container's cgroup is created. 
        /// If the path is not absolute, the path is considered to be relative to the cgroups path of the init process. 
        /// Cgroups are created if they do not already exist.
        /// </summary>
        [DataMember(Name = "CgroupParent", EmitDefaultValue = false)]
        public string CgroupParent { get; set; }

        /// <summary>
        /// Block IO weight (relative weight), Accepted values: 0..1000.
        /// </summary>
        [DataMember(Name = "BlkioWeight", EmitDefaultValue = false)]
        public ushort BlkioWeight { get; set; }

        /// <summary>
        /// Block IO weight (relative device weight).
        /// </summary>
        [DataMember(Name = "BlkioWeightDevice", EmitDefaultValue = false)]
        public IList<WeightDevice> BlkioWeightDevice { get; set; }

        /// <summary>
        /// Limit read rate (bytes per second) from a device, 
        /// </summary>
        [DataMember(Name = "BlkioDeviceReadBps", EmitDefaultValue = false)]
        public IList<ThrottleDevice> BlkioDeviceReadBps { get; set; }

        /// <summary>
        /// Limit write rate (bytes per second) to a device.
        /// </summary>
        [DataMember(Name = "BlkioDeviceWriteBps", EmitDefaultValue = false)]
        public IList<ThrottleDevice> BlkioDeviceWriteBps { get; set; }

        /// <summary>
        /// Limit read rate (IO per second) from a device.
        /// </summary>
        [DataMember(Name = "BlkioDeviceReadIOps", EmitDefaultValue = false)]
        public IList<ThrottleDevice> BlkioDeviceReadIOps { get; set; }

        /// <summary>
        /// Limit write rate (IO per second) to a device.
        /// </summary>
        [DataMember(Name = "BlkioDeviceWriteIOps", EmitDefaultValue = false)]
        public IList<ThrottleDevice> BlkioDeviceWriteIOps { get; set; }

        /// <summary>
        /// The length of a CPU period, in microseconds.
        /// </summary>
        [DataMember(Name = "CpuPeriod", EmitDefaultValue = false)]
        public long CPUPeriod { get; set; }

        /// <summary>
        /// Microseconds of CPU time that the container can get in a CPU period.
        /// </summary>
        [DataMember(Name = "CpuQuota", EmitDefaultValue = false)]
        public long CPUQuota { get; set; }

        /// <summary>
        /// The length of a CPU real-time period in microseconds. Set to 0 to allocate no time allocated to real-time tasks.
        /// </summary>
        [DataMember(Name = "CpuRealtimePeriod", EmitDefaultValue = false)]
        public long CPURealtimePeriod { get; set; }

        /// <summary>
        /// The length of a CPU real-time runtime in microseconds. Set to 0 to allocate no time allocated to real-time tasks.
        /// </summary>
        [DataMember(Name = "CpuRealtimeRuntime", EmitDefaultValue = false)]
        public long CPURealtimeRuntime { get; set; }

        /// <summary>
        /// CPUs in which to allow execution (e.g., 0-3, 0,1)
        /// </summary>
        [DataMember(Name = "CpusetCpus", EmitDefaultValue = false)]
        public string CpusetCpus { get; set; }

        /// <summary>
        /// Memory nodes (MEMs) in which to allow execution (0-3, 0,1). Only effective on NUMA systems.
        /// </summary>
        [DataMember(Name = "CpusetMems", EmitDefaultValue = false)]
        public string CpusetMems { get; set; }

        /// <summary>
        /// A list of devices to add to the container.
        /// </summary>
        [DataMember(Name = "Devices", EmitDefaultValue = false)]
        public IList<DeviceMapping> Devices { get; set; }

        /// <summary>
        /// A list of cgroup rules to apply to the container
        /// </summary>
        [DataMember(Name = "DeviceCgroupRules", EmitDefaultValue = false)]
        public IList<string> DeviceCgroupRules { get; set; }

        /// <summary>
        /// Disk limit, in bytes.
        /// </summary>
        [DataMember(Name = "DiskQuota", EmitDefaultValue = false)]
        public long DiskQuota { get; set; }

        /// <summary>
        /// Kernel memory limit, in bytes.
        /// </summary>
        [DataMember(Name = "KernelMemory", EmitDefaultValue = false)]
        public long KernelMemory { get; set; }

        /// <summary>
        /// Memory soft limit, in bytes.
        /// </summary>
        [DataMember(Name = "MemoryReservation", EmitDefaultValue = false)]
        public long MemoryReservation { get; set; }

        /// <summary>
        /// Total memory limit (memory + swap), in bytes. Set as -1 to enable unlimited swap.
        /// </summary>
        [DataMember(Name = "MemorySwap", EmitDefaultValue = false)]
        public long MemorySwap { get; set; }

        /// <summary>
        /// Tune a container's memory swappiness behavior. Accepts an integer between 0 and 100.
        /// </summary>
        [DataMember(Name = "MemorySwappiness", EmitDefaultValue = false)]
        public long? MemorySwappiness { get; set; }

        /// <summary>
        /// Disable OOM Killer for the container.
        /// </summary>
        [DataMember(Name = "OomKillDisable", EmitDefaultValue = false)]
        public bool? OomKillDisable { get; set; }

        /// <summary>
        /// Tune a container's pids limit (maximum number of processes). Set -1 for unlimited.
        /// </summary>
        [DataMember(Name = "PidsLimit", EmitDefaultValue = false)]
        public long PidsLimit { get; set; }

        /// <summary>
        /// A list of resource limits to set in the container. For example: {"Name": "nofile", "Soft": 1024, "Hard": 2048}
        /// </summary>
        [DataMember(Name = "Ulimits", EmitDefaultValue = false)]
        public IList<Ulimit> Ulimits { get; set; }

        /// <summary>
        /// The number of usable CPUs (Windows only).
        /// On Windows Server containers, the processor resource controls are mutually exclusive.
        /// The order of precedence is CPUCount first, then CPUShares, and CPUPercent last.
        /// </summary>
        [DataMember(Name = "CpuCount", EmitDefaultValue = false)]
        public long CPUCount { get; set; }

        /// <summary>
        /// The usable percentage of the available CPUs (Windows only).
        /// On Windows Server containers, the processor resource controls are mutually exclusive.
        /// The order of precedence is CPUCount first, then CPUShares, and CPUPercent last.
        /// </summary>
        [DataMember(Name = "CpuPercent", EmitDefaultValue = false)]
        public long CPUPercent { get; set; }

        /// <summary>
        /// Maximum IOps for the container system drive (Windows only).
        /// </summary>
        [DataMember(Name = "IOMaximumIOps", EmitDefaultValue = false)]
        public ulong IOMaximumIOps { get; set; }

        /// <summary>
        /// Maximum IO in bytes per second for the container system drive (Windows only).
        /// </summary>
        [DataMember(Name = "IOMaximumBandwidth", EmitDefaultValue = false)]
        public ulong IOMaximumBandwidth { get; set; }

        [DataMember(Name = "Mounts", EmitDefaultValue = false)]
        public IList<Mount> Mounts { get; set; }

        /// <summary>
        /// Run an init inside the container that forwards signals and reaps processes. 
        /// This field is omitted if empty, and the default (as configured on the daemon) is used.
        /// </summary>
        [DataMember(Name = "Init", EmitDefaultValue = false)]
        public bool? Init { get; set; }

        [DataMember(Name = "InitPath", EmitDefaultValue = false)]
        public string InitPath { get; set; }

        /// <summary>
        /// The list of host paths to be masked inside the container (this overrides the default set of paths)
        /// </summary>
        [DataMember(Name = "MaskedPaths", EmitDefaultValue = false)]
        public IList<string> MaskedPaths { get; set; }

        /// <summary>
        /// The list of host paths to be set as read-only inside the container (this overrides the default set of paths)
        /// </summary>
        [DataMember(Name = "ReadonlyPaths", EmitDefaultValue = false)]
        public IList<string> ReadonlyPaths { get; set; }
    }
}
