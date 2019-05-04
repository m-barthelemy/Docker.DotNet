using System.Runtime.Serialization;

namespace Docker.DotNet.Models
{
    //* v1.39 checked 2019/05/04
    [DataContract]
    public class RaftConfig // (swarm.RaftConfig)
    {
        /// <summary>
        /// The number of log entries between snapshots.
        /// </summary>
        [DataMember(Name = "SnapshotInterval", EmitDefaultValue = false)]
        public ulong SnapshotInterval { get; set; }

        /// <summary>
        /// The number of snapshots to keep beyond the current snapshot.
        /// </summary>
        [DataMember(Name = "KeepOldSnapshots", EmitDefaultValue = false)]
        public ulong? KeepOldSnapshots { get; set; }

        /// <summary>
        /// The number of log entries to keep around to sync up slow followers after a snapshot is created.
        /// </summary>
        [DataMember(Name = "LogEntriesForSlowFollowers", EmitDefaultValue = false)]
        public ulong LogEntriesForSlowFollowers { get; set; }

        /// <summary>
        /// The number of ticks that a follower will wait for a message from the leader before becoming a candidate and 
        /// starting an election. ElectionTick must be greater than HeartbeatTick.
        ///  A tick currently defaults to one second, but thid might change in the future.
        /// </summary>
        [DataMember(Name = "ElectionTick", EmitDefaultValue = false)]
        public long ElectionTick { get; set; }

        /// <summary>
        /// The number of ticks between heartbeats. Every HeartbeatTick ticks, the leader will send a heartbeat to the 
        /// followers.
        ///  A tick currently defaults to one second, but thid might change in the future.
        /// </summary>
        [DataMember(Name = "HeartbeatTick", EmitDefaultValue = false)]
        public long HeartbeatTick { get; set; }
    }
}
