using System.Text.Json.Serialization;

namespace Salad.Cloud.SDK.Models;

/// <summary>A Container Group Instance represents a running instance of a container group on a specific machine. It provides information about the execution state, readiness, and version of the deployed container group.</summary>
public class ContainerGroupInstance
{
    /// <value>The container group instance identifier.</value>
    [JsonPropertyName("id")]
    public string Id { get; init; }

    /// <value>The container group machine identifier.</value>
    [JsonPropertyName("machine_id")]
    public string MachineId { get; init; }

    /// <value>The state of the container group instance</value>
    [JsonPropertyName("state")]
    public TheContainerGroupInstanceState State { get; init; }

    /// <value>The UTC timestamp when the container group instance last changed its state. This helps track the lifecycle and state transitions of the instance.</value>
    [JsonPropertyName("update_time")]
    public string UpdateTime { get; init; }

    /// <value>The version of the container group definition currently running on this instance. Used to track deployment and update progress across the container group fleet.</value>
    [JsonPropertyName("version")]
    public long Version { get; init; }

    /// <value>The percentage of CPU used by this container group instance. This is updated every minute.</value>
    [JsonPropertyName("cpu_percent"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public double? CpuPercent { get; init; }

    /// <value>The total CPU usage in seconds for this container group instance. This is updated every minute.</value>
    [JsonPropertyName("cpu_usage"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? CpuUsage { get; init; }

    /// <value>The total CPU usage in seconds for this container group instance since it was started. This is updated every minute.</value>
    [
        JsonPropertyName("cpu_usage_total"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public long? CpuUsageTotal { get; init; }

    /// <value>The cost of deleting the container group instance</value>
    [
        JsonPropertyName("deletion_cost"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public long? DeletionCost { get; init; }

    /// <value>The memory usage in MB for this container group instance. This is updated every minute.</value>
    [
        JsonPropertyName("memory_usage_mb"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public double? MemoryUsageMb { get; init; }

    /// <value>The percentage of memory used by this container group instance. This is updated every minute.</value>
    [
        JsonPropertyName("memory_usage_percent"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public double? MemoryUsagePercent { get; init; }

    /// <value>The progress percentage of pulling the container image. This is only relevant when the instance state is 'downloading'.</value>
    [
        JsonPropertyName("pulling_progress"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public double? PullingProgress { get; init; }

    /// <value>Indicates whether the container group instance is currently passing its readiness checks and is able to receive traffic or perform its intended function. If no readiness probe is defined, this will be true once the instance is fully started.</value>
    [JsonPropertyName("ready"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Ready { get; init; }

    /// <value>The SSH host key fingerprint of the container group instance</value>
    [
        JsonPropertyName("ssh_host_key_fingerprint"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
    public string? SshHostKeyFingerprint { get; init; }

    /// <value>The SSH IP address of the container group instance</value>
    [JsonPropertyName("ssh_ip"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? SshIp { get; init; }

    /// <value>The SSH port of the container group instance</value>
    [JsonPropertyName("ssh_port"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public long? SshPort { get; init; }

    /// <value>Indicates whether the container group instance has successfully completed its startup sequence and passed any configured startup probes. This will always be true when no startup probe is defined for the container group.</value>
    [JsonPropertyName("started"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public bool? Started { get; init; }

    // Constructor with defaults applied
    public ContainerGroupInstance(
        string id,
        string machine_id,
        TheContainerGroupInstanceState state,
        string update_time,
        long version,
        double? cpu_percent = null,
        long? cpu_usage = null,
        long? cpu_usage_total = null,
        long? deletion_cost = null,
        double? memory_usage_mb = null,
        double? memory_usage_percent = null,
        double? pulling_progress = null,
        bool? ready = null,
        string? ssh_host_key_fingerprint = null,
        string? ssh_ip = null,
        long? ssh_port = null,
        bool? started = null
    ) { }

    public override string ToString()
    {
        return $"{nameof(ContainerGroupInstance)} {{Id = {Id}, MachineId = {MachineId}, State = {State}, UpdateTime = {UpdateTime}, Version = {Version}, CpuPercent = {CpuPercent}, CpuUsage = {CpuUsage}, CpuUsageTotal = {CpuUsageTotal}, DeletionCost = {DeletionCost}, MemoryUsageMb = {MemoryUsageMb}, MemoryUsagePercent = {MemoryUsagePercent}, PullingProgress = {PullingProgress}, Ready = {Ready}, SshHostKeyFingerprint = {SshHostKeyFingerprint}, SshIp = {SshIp}, SshPort = {SshPort}, Started = {Started}}}";
    }
}
