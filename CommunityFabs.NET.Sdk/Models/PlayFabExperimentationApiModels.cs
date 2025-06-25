using CommunityFabs.NET.Sdk.Http;

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
public class CreateExclusionGroupRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description of the exclusion group.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Friendly name of the exclusion group.
    /// </summary>
    public required string Name { get; set; }
}

public class CreateExclusionGroupResult : PlayFabResultCommon {
    /// <summary>
    /// Identifier of the exclusion group.
    /// </summary>
    public string? ExclusionGroupId { get; set; }
}

/// <summary>
/// Given a title entity token and experiment details, will create a new experiment for the title.
/// </summary>
public class CreateExperimentRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description of the experiment.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// The duration of the experiment, in days.
    /// </summary>
    public UInt32? Duration { get; set; }
    /// <summary>
    /// When experiment should end.
    /// </summary>
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// Id of the exclusion group.
    /// </summary>
    public string? ExclusionGroupId { get; set; }
    /// <summary>
    /// Percentage of exclusion group traffic that will see this experiment.
    /// </summary>
    public UInt32? ExclusionGroupTrafficAllocation { get; set; }
    /// <summary>
    /// Type of experiment.
    /// </summary>
    public ExperimentType? ExperimentType { get; set; }
    /// <summary>
    /// Friendly name of the experiment.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Id of the segment to which this experiment applies. Defaults to the 'All Players' segment.
    /// </summary>
    public string? SegmentId { get; set; }
    /// <summary>
    /// When experiment should start.
    /// </summary>
    public required DateTime StartDate { get; set; }
    /// <summary>
    /// List of title player account IDs that automatically receive treatments in the experiment, but are not included when
    /// calculating experiment metrics.
    /// </summary>
    public List<string>? TitlePlayerAccountTestIds { get; set; }
    /// <summary>
    /// List of variants for the experiment.
    /// </summary>
    public required List<Variant> Variants { get; set; }
}

public class CreateExperimentResult : PlayFabResultCommon {
    /// <summary>
    /// The ID of the new experiment.
    /// </summary>
    public string? ExperimentId { get; set; }
}

/// <summary>
/// Given an entity token and an exclusion group ID this API deletes the exclusion group.
/// </summary>
public class DeleteExclusionGroupRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the exclusion group to delete.
    /// </summary>
    public required string ExclusionGroupId { get; set; }
}

/// <summary>
/// Given an entity token and an experiment ID this API deletes the experiment. A running experiment must be stopped before
/// it can be deleted.
/// </summary>
public class DeleteExperimentRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the experiment to delete.
    /// </summary>
    public required string ExperimentId { get; set; }
}

public class EmptyResponse : PlayFabResultCommon {
}

/// <summary>
/// Combined entity type and ID structure which uniquely identifies a single entity.
/// </summary>
public class EntityKey {
    /// <summary>
    /// Unique ID of the entity.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Entity type. See https://docs.microsoft.com/gaming/playfab/features/data/entities/available-built-in-entity-types
    /// </summary>
    public string? Type { get; set; }
    /// <summary>
    /// Alternate name for Type.
    /// </summary>
    public string? TypeString { get; set; }
}

public class ExclusionGroupTrafficAllocation {
    /// <summary>
    /// Id of the experiment.
    /// </summary>
    public string? ExperimentId { get; set; }
    /// <summary>
    /// Percentage of exclusion group traffic that will see this experiment.
    /// </summary>
    public UInt32 TrafficAllocation { get; set; }
}

public class Experiment {
    /// <summary>
    /// Description of the experiment.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// The duration of the experiment, in days.
    /// </summary>
    public UInt32? Duration { get; set; }
    /// <summary>
    /// When experiment should end/was ended.
    /// </summary>
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// Id of the exclusion group for this experiment.
    /// </summary>
    public string? ExclusionGroupId { get; set; }
    /// <summary>
    /// Percentage of exclusion group traffic that will see this experiment.
    /// </summary>
    public UInt32? ExclusionGroupTrafficAllocation { get; set; }
    /// <summary>
    /// Type of experiment.
    /// </summary>
    public ExperimentType? ExperimentType { get; set; }
    /// <summary>
    /// Id of the experiment.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Friendly name of the experiment.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// Id of the segment to which this experiment applies. Defaults to the 'All Players' segment.
    /// </summary>
    public string? SegmentId { get; set; }
    /// <summary>
    /// When experiment should start/was started.
    /// </summary>
    public required DateTime StartDate { get; set; }
    /// <summary>
    /// State experiment is currently in.
    /// </summary>
    public ExperimentState? State { get; set; }
    /// <summary>
    /// List of title player account IDs that automatically receive treatments in the experiment, but are not included when
    /// calculating experiment metrics.
    /// </summary>
    public List<string>? TitlePlayerAccountTestIds { get; set; }
    /// <summary>
    /// List of variants for the experiment.
    /// </summary>
    public List<Variant>? Variants { get; set; }
}

public class ExperimentExclusionGroup {
    /// <summary>
    /// Description of the exclusion group.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Id of the exclusion group.
    /// </summary>
    public string? ExclusionGroupId { get; set; }
    /// <summary>
    /// Friendly name of the exclusion group.
    /// </summary>
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
public class GetExclusionGroupsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetExclusionGroupsResult : PlayFabResultCommon {
    /// <summary>
    /// List of exclusion groups for the title.
    /// </summary>
    public List<ExperimentExclusionGroup>? ExclusionGroups { get; set; }
}

/// <summary>
/// Given a title entity token and an exclusion group ID, will return the list of traffic allocations for the exclusion
/// group.
/// </summary>
public class GetExclusionGroupTrafficRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the exclusion group.
    /// </summary>
    public required string ExclusionGroupId { get; set; }
}

public class GetExclusionGroupTrafficResult : PlayFabResultCommon {
    /// <summary>
    /// List of traffic allocations for the exclusion group.
    /// </summary>
    public List<ExclusionGroupTrafficAllocation>? TrafficAllocations { get; set; }
}

/// <summary>
/// Given a title entity token will return the list of all experiments for a title, including scheduled, started, stopped
/// or completed experiments.
/// </summary>
public class GetExperimentsRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
}

public class GetExperimentsResult : PlayFabResultCommon {
    /// <summary>
    /// List of experiments for the title.
    /// </summary>
    public List<Experiment>? Experiments { get; set; }
}

/// <summary>
/// Given a title entity token and experiment details, will return the latest available scorecard.
/// </summary>
public class GetLatestScorecardRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the experiment.
    /// </summary>
    public string? ExperimentId { get; set; }
}

public class GetLatestScorecardResult : PlayFabResultCommon {
    /// <summary>
    /// Scorecard for the experiment of the title.
    /// </summary>
    public Scorecard? Scorecard { get; set; }
}

/// <summary>
/// Given a title player or a title entity token, returns the treatment variants and variables assigned to the entity
/// across all running experiments
/// </summary>
public class GetTreatmentAssignmentRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The optional entity to perform this action on. Defaults to the currently logged in entity.
    /// </summary>
    public EntityKey? Entity { get; set; }
}

public class GetTreatmentAssignmentResult : PlayFabResultCommon {
    /// <summary>
    /// Treatment assignment for the entity.
    /// </summary>
    public TreatmentAssignment? TreatmentAssignment { get; set; }
}

public class MetricData {
    /// <summary>
    /// The upper bound of the confidence interval for the relative delta (Delta.RelativeValue).
    /// </summary>
    public required double ConfidenceIntervalEnd { get; set; }
    /// <summary>
    /// The lower bound of the confidence interval for the relative delta (Delta.RelativeValue).
    /// </summary>
    public required double ConfidenceIntervalStart { get; set; }
    /// <summary>
    /// The absolute delta between TreatmentStats.Average and ControlStats.Average.
    /// </summary>
    public required float DeltaAbsoluteChange { get; set; }
    /// <summary>
    /// The relative delta ratio between TreatmentStats.Average and ControlStats.Average.
    /// </summary>
    public required float DeltaRelativeChange { get; set; }
    /// <summary>
    /// The machine name of the metric.
    /// </summary>
    public string? InternalName { get; set; }
    /// <summary>
    /// Indicates if a movement was detected on that metric.
    /// </summary>
    public string? Movement { get; set; }
    /// <summary>
    /// The readable name of the metric.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The expectation that a movement is real
    /// </summary>
    public required float PMove { get; set; }
    /// <summary>
    /// The p-value resulting from the statistical test run for this metric
    /// </summary>
    public required float PValue { get; set; }
    /// <summary>
    /// The threshold for observing sample ratio mismatch.
    /// </summary>
    public required float PValueThreshold { get; set; }
    /// <summary>
    /// Indicates if the movement is statistically significant.
    /// </summary>
    public string? StatSigLevel { get; set; }
    /// <summary>
    /// Observed standard deviation value of the metric.
    /// </summary>
    public required float StdDev { get; set; }
    /// <summary>
    /// Observed average value of the metric.
    /// </summary>
    public required float Value { get; set; }
}

public class Scorecard {
    /// <summary>
    /// Represents the date the scorecard was generated.
    /// </summary>
    public string? DateGenerated { get; set; }
    /// <summary>
    /// Represents the duration of scorecard analysis.
    /// </summary>
    public string? Duration { get; set; }
    /// <summary>
    /// Represents the number of events processed for the generation of this scorecard
    /// </summary>
    public required double EventsProcessed { get; set; }
    /// <summary>
    /// Id of the experiment.
    /// </summary>
    public string? ExperimentId { get; set; }
    /// <summary>
    /// Friendly name of the experiment.
    /// </summary>
    public string? ExperimentName { get; set; }
    /// <summary>
    /// Represents the latest compute job status.
    /// </summary>
    public AnalysisTaskState? LatestJobStatus { get; set; }
    /// <summary>
    /// Represents the presence of a sample ratio mismatch in the scorecard data.
    /// </summary>
    public bool SampleRatioMismatch { get; set; }
    /// <summary>
    /// Scorecard containing list of analysis.
    /// </summary>
    public List<ScorecardDataRow>? ScorecardDataRows { get; set; }
}

public class ScorecardDataRow {
    /// <summary>
    /// Represents whether the variant is control or not.
    /// </summary>
    public bool IsControl { get; set; }
    /// <summary>
    /// Data of the analysis with the internal name of the metric as the key and an object of metric data as value.
    /// </summary>
    public Dictionary<string, MetricData>? MetricDataRows { get; set; }
    /// <summary>
    /// Represents the player count in the variant.
    /// </summary>
    public UInt32 PlayerCount { get; set; }
    /// <summary>
    /// Name of the variant of analysis.
    /// </summary>
    public string? VariantName { get; set; }
}

/// <summary>
/// Given a title entity token and an experiment ID, this API starts the experiment.
/// </summary>
public class StartExperimentRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the experiment to start.
    /// </summary>
    public required string ExperimentId { get; set; }
}

/// <summary>
/// Given a title entity token and an experiment ID, this API stops the experiment if it is running.
/// </summary>
public class StopExperimentRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The ID of the experiment to stop.
    /// </summary>
    public required string ExperimentId { get; set; }
}

public class TreatmentAssignment {
    /// <summary>
    /// List of the experiment variables.
    /// </summary>
    public List<Variable>? Variables { get; set; }
    /// <summary>
    /// List of the experiment variants.
    /// </summary>
    public List<string>? Variants { get; set; }
}

/// <summary>
/// Given an entity token and exclusion group details this API updates the exclusion group.
/// </summary>
public class UpdateExclusionGroupRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description of the exclusion group.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// The ID of the exclusion group to update.
    /// </summary>
    public required string ExclusionGroupId { get; set; }
    /// <summary>
    /// Friendly name of the exclusion group.
    /// </summary>
    public required string Name { get; set; }
}

/// <summary>
/// Given a title entity token and experiment details, this API updates the experiment. If an experiment is already
/// running, only the description and duration properties can be updated.
/// </summary>
public class UpdateExperimentRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// Description of the experiment.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// The duration of the experiment, in days.
    /// </summary>
    public UInt32? Duration { get; set; }
    /// <summary>
    /// When experiment should end.
    /// </summary>
    public DateTime? EndDate { get; set; }
    /// <summary>
    /// Id of the exclusion group.
    /// </summary>
    public string? ExclusionGroupId { get; set; }
    /// <summary>
    /// Percentage of exclusion group traffic that will see this experiment.
    /// </summary>
    public UInt32? ExclusionGroupTrafficAllocation { get; set; }
    /// <summary>
    /// Type of experiment.
    /// </summary>
    public ExperimentType? ExperimentType { get; set; }
    /// <summary>
    /// Id of the experiment.
    /// </summary>
    public required string Id { get; set; }
    /// <summary>
    /// Friendly name of the experiment.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Id of the segment to which this experiment applies. Defaults to the 'All Players' segment.
    /// </summary>
    public string? SegmentId { get; set; }
    /// <summary>
    /// When experiment should start.
    /// </summary>
    public required DateTime StartDate { get; set; }
    /// <summary>
    /// List of title player account IDs that automatically receive treatments in the experiment, but are not included when
    /// calculating experiment metrics.
    /// </summary>
    public List<string>? TitlePlayerAccountTestIds { get; set; }
    /// <summary>
    /// List of variants for the experiment.
    /// </summary>
    public required List<Variant> Variants { get; set; }
}

public class Variable {
    /// <summary>
    /// Name of the variable.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Value of the variable.
    /// </summary>
    public string? Value { get; set; }
}

public class Variant {
    /// <summary>
    /// Description of the variant.
    /// </summary>
    public string? Description { get; set; }
    /// <summary>
    /// Id of the variant.
    /// </summary>
    public string? Id { get; set; }
    /// <summary>
    /// Specifies if variant is control for experiment.
    /// </summary>
    public bool IsControl { get; set; }
    /// <summary>
    /// Name of the variant.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// Id of the TitleDataOverrideGroup to use with this variant.
    /// </summary>
    public string? TitleDataOverrideId { get; set; }
    /// <summary>
    /// Id of the TitleDataOverride to use with this variant.
    /// </summary>
    public string? TitleDataOverrideLabel { get; set; }
    /// <summary>
    /// Percentage of target audience traffic that will see this variant.
    /// </summary>
    public UInt32 TrafficPercentage { get; set; }
    /// <summary>
    /// Variables returned by this variant.
    /// </summary>
    public List<Variable>? Variables { get; set; }
}

