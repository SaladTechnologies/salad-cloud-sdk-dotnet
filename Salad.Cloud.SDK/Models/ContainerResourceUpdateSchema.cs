using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>Defines the resource specifications that can be modified for a container group, including CPU, memory, GPU classes, and storage allocations.</summary>
public class ContainerResourceUpdateSchema
{
    /// <value>The number of CPU cores to allocate to the container (between 1 and 1024).</value>
    [JsonPropertyName("cpu")]
    public long? Cpu { get; init; }

    /// <value>List of GPU class identifiers that the container can use, specified as UUIDs.</value>
    [JsonPropertyName("gpu_classes")]
    public List<string>? GpuClasses { get; init; }

    /// <value>The amount of memory to allocate to the container in megabytes (between 1024 and 1073741824).</value>
    [JsonPropertyName("memory")]
    public long? Memory { get; init; }

    /// <value>The amount of shared memory to allocate to the container via `/dev/shm` in megabytes (between 64 and 1073741824). If not specified, defaults to 64 MB.</value>
    [JsonPropertyName("shm_size")]
    public long? ShmSize { get; init; }

    /// <value>The amount of storage to allocate to the container in bytes (between 1 GB and 1 PB).</value>
    [JsonPropertyName("storage_amount")]
    public long? StorageAmount { get; init; }

    // Constructor with defaults applied
    public ContainerResourceUpdateSchema(
        long? cpu = null,
        List<string>? gpu_classes = null,
        long? memory = null,
        long? shm_size = null,
        long? storage_amount = null
    ) { }

    public override string ToString()
    {
        return $"{nameof(ContainerResourceUpdateSchema)} {{Cpu = {Cpu}, GpuClasses = {GpuClasses}, Memory = {Memory}, ShmSize = {ShmSize}, StorageAmount = {StorageAmount}}}";
    }
}
