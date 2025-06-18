namespace CommunityFabs.NET.Sdk.Models.Experimentation;

public enum AnalysisTaskState {
    Waiting,
    ReadyForSubmission,
    SubmittingToPipeline,
    Running,
    Completed,
    Failed,
    Canceled,
}

/// <summary>
/// Given a title entity token and exclusion group details, will create a new exclusion group for the title.
/// </summary>
public class CreateExclusionGroupRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public required string Name { get; set; }
}

public class CreateExclusionGroupResult {
    public string? ExclusionGroupId { get; set; }
}

/// <summary>
/// Given a title entity token and experiment details, will create a new experiment for the title.
/// </summary>
public class CreateExperimentRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public UInt32? Duration { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ExclusionGroupId { get; set; }
    public UInt32? ExclusionGroupTrafficAllocation { get; set; }
    public ExperimentType? ExperimentType { get; set; }
    public required string Name { get; set; }
    public string? SegmentId { get; set; }
    public required DateTime StartDate { get; set; }
    public List<string>? TitlePlayerAccountTestIds { get; set; }
    public required List<Variant> Variants { get; set; }
}

public class CreateExperimentResult {
    public string? ExperimentId { get; set; }
}

/// <summary>
/// Given an entity token and an exclusion group ID this API deletes the exclusion group.
/// </summary>
public class DeleteExclusionGroupRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ExclusionGroupId { get; set; }
}

/// <summary>
/// Given an entity token and an experiment ID this API deletes the experiment. A running experiment must be stopped before it can be deleted.
/// </summary>
public class DeleteExperimentRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ExperimentId { get; set; }
}

public class EmptyResponse {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    public required string Id { get; set; }
    public string? Type { get; set; }
    public string? TypeString { get; set; }
}

public class ExclusionGroupTrafficAllocation {
    public string? ExperimentId { get; set; }
    public UInt32 TrafficAllocation { get; set; }
}

public class Experiment {
    public string? Description { get; set; }
    public UInt32? Duration { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ExclusionGroupId { get; set; }
    public UInt32? ExclusionGroupTrafficAllocation { get; set; }
    public ExperimentType? ExperimentType { get; set; }
    public string? Id { get; set; }
    public string? Name { get; set; }
    public string? SegmentId { get; set; }
    public required DateTime StartDate { get; set; }
    public ExperimentState? State { get; set; }
    public List<string>? TitlePlayerAccountTestIds { get; set; }
    public List<Variant>? Variants { get; set; }
}

public class ExperimentExclusionGroup {
    public string? Description { get; set; }
    public string? ExclusionGroupId { get; set; }
    public string? Name { get; set; }
}

public enum ExperimentState {
    New,
    Started,
    Stopped,
    Deleted,
}

public enum ExperimentType {
    Active,
    Snapshot,
}

/// <summary>
/// Given a title entity token will return the list of all exclusion groups for a title.
/// </summary>
public class GetExclusionGroupsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetExclusionGroupsResult {
    public List<ExperimentExclusionGroup>? ExclusionGroups { get; set; }
}

/// <summary>
/// Given a title entity token and an exclusion group ID, will return the list of traffic allocations for the exclusion group.
/// </summary>
public class GetExclusionGroupTrafficRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ExclusionGroupId { get; set; }
}

public class GetExclusionGroupTrafficResult {
    public List<ExclusionGroupTrafficAllocation>? TrafficAllocations { get; set; }
}

/// <summary>
/// Given a title entity token will return the list of all experiments for a title, including scheduled, started, stopped or completed experiments.
/// </summary>
public class GetExperimentsRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetExperimentsResult {
    public List<Experiment>? Experiments { get; set; }
}

/// <summary>
/// Given a title entity token and experiment details, will return the latest available scorecard.
/// </summary>
public class GetLatestScorecardRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? ExperimentId { get; set; }
}

public class GetLatestScorecardResult {
    public Scorecard? Scorecard { get; set; }
}

/// <summary>
/// Given a title player or a title entity token, returns the treatment variants and variables assigned to the entity across all running experiments
/// </summary>
public class GetTreatmentAssignmentRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public EntityKey? Entity { get; set; }
}

public class GetTreatmentAssignmentResult {
    public TreatmentAssignment? TreatmentAssignment { get; set; }
}

public class MetricData {
    public required double ConfidenceIntervalEnd { get; set; }
    public required double ConfidenceIntervalStart { get; set; }
    public required float DeltaAbsoluteChange { get; set; }
    public required float DeltaRelativeChange { get; set; }
    public string? InternalName { get; set; }
    public string? Movement { get; set; }
    public string? Name { get; set; }
    public required float PMove { get; set; }
    public required float PValue { get; set; }
    public required float PValueThreshold { get; set; }
    public string? StatSigLevel { get; set; }
    public required float StdDev { get; set; }
    public required float Value { get; set; }
}

public class Scorecard {
    public string? DateGenerated { get; set; }
    public string? Duration { get; set; }
    public required double EventsProcessed { get; set; }
    public string? ExperimentId { get; set; }
    public string? ExperimentName { get; set; }
    public AnalysisTaskState? LatestJobStatus { get; set; }
    public bool SampleRatioMismatch { get; set; }
    public List<ScorecardDataRow>? ScorecardDataRows { get; set; }
}

public class ScorecardDataRow {
    public bool IsControl { get; set; }
    public Dictionary<string, MetricData>? MetricDataRows { get; set; }
    public UInt32 PlayerCount { get; set; }
    public string? VariantName { get; set; }
}

/// <summary>
/// Given a title entity token and an experiment ID, this API starts the experiment.
/// </summary>
public class StartExperimentRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ExperimentId { get; set; }
}

/// <summary>
/// Given a title entity token and an experiment ID, this API stops the experiment if it is running.
/// </summary>
public class StopExperimentRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required string ExperimentId { get; set; }
}

public class TreatmentAssignment {
    public List<Variable>? Variables { get; set; }
    public List<string>? Variants { get; set; }
}

/// <summary>
/// Given an entity token and exclusion group details this API updates the exclusion group.
/// </summary>
public class UpdateExclusionGroupRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public required string ExclusionGroupId { get; set; }
    public required string Name { get; set; }
}

/// <summary>
/// Given a title entity token and experiment details, this API updates the experiment. If an experiment is already running, only the description and duration properties can be updated.
/// </summary>
public class UpdateExperimentRequest {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Description { get; set; }
    public UInt32? Duration { get; set; }
    public DateTime? EndDate { get; set; }
    public string? ExclusionGroupId { get; set; }
    public UInt32? ExclusionGroupTrafficAllocation { get; set; }
    public ExperimentType? ExperimentType { get; set; }
    public required string Id { get; set; }
    public required string Name { get; set; }
    public string? SegmentId { get; set; }
    public required DateTime StartDate { get; set; }
    public List<string>? TitlePlayerAccountTestIds { get; set; }
    public required List<Variant> Variants { get; set; }
}

public class Variable {
    public required string Name { get; set; }
    public string? Value { get; set; }
}

public class Variant {
    public string? Description { get; set; }
    public string? Id { get; set; }
    public bool IsControl { get; set; }
    public required string Name { get; set; }
    public string? TitleDataOverrideId { get; set; }
    public string? TitleDataOverrideLabel { get; set; }
    public UInt32 TrafficPercentage { get; set; }
    public List<Variable>? Variables { get; set; }
}

