using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Docker.DotNet.Models;

namespace Docker.DotNet
{
    public interface IConfigsOperations
    {
        /// <summary>
        /// List configs
        /// </summary>
        /// <remarks>
        /// 200 - No error.
        /// 500 - Server error.
        /// </remarks>
        Task<IList<SwarmConfig>> ListAsync(CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a config
        /// </summary>
        /// <remarks>
        /// 201 - No error.
        /// 406 - Server error or node is not part of a swarm.
        /// 409 - Name conflicts with an existing object.
        /// 500 - Server error.
        /// </remarks>
        Task<SecretOrConfigCreateResponse> CreateAsync(ConfigSpec body, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Inspect a config
        /// </summary>
        /// <remarks>
        /// 200 - No error.
        /// 404 - Secret not found.
        /// 406 - Node is not part of a swarm.
        /// 500 - Server error.
        /// </remarks>
        /// <param name="id">ID of the secret.</param>
        Task<SwarmConfig> InspectAsync(string id, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a config
        /// </summary>
        /// <remarks>
        /// 204 - No error.
        /// 404 - Secret not found.
        /// 500 - Server error.
        /// </remarks>
        /// <param name="id">ID of the secret.</param>
        Task DeleteAsync(string id, CancellationToken cancellationToken = default(CancellationToken));
    }
}