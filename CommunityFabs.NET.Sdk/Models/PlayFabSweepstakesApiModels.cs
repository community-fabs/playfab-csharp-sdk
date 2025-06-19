namespace CommunityFabs.NET.Sdk.Models.Sweepstakes;

/// <summary>
/// Given a title entity token and sweepstake details, will create a new sweepstake for the title.
/// </summary>
public class CreateSweepstakeRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The date the winner will be chosen.
    /// </summary>
    public required DateTime DrawingDate { get; set; }
    /// <summary>
    /// The last day users can enter tickets.
    /// </summary>
    public required DateTime EndDate { get; set; }
    /// <summary>
    /// The number of winners possible for the sweepstake.
    /// </summary>
    public int MaxNumberOfWinners { get; set; }
    /// <summary>
    /// Unique name of the sweepstake.
    /// </summary>
    public required string Name { get; set; }
    /// <summary>
    /// The unique reward that will be given to winner(s).
    /// </summary>
    public string? RewardId { get; set; }
    /// <summary>
    /// The start date for participants to enter tickets.
    /// </summary>
    public required DateTime StartDate { get; set; }
}

public class CreateSweepstakeResponse : PlayFabResultCommon {
    /// <summary>
    /// The name of the sweepstake.
    /// </summary>
    public string? Name { get; set; }
}

/// <summary>
/// Given a title entity token and sweepstake name, will return the sweepstakes of that title.
/// </summary>
public class GetSweepstakeRequest : PlayFabRequestCommon {
    /// <summary>
    /// The optional custom tags associated with the request (e.g. build number, external trace identifiers, etc.).
    /// </summary>
    public Dictionary<string, string>? CustomTags { get; set; }
    /// <summary>
    /// The name of the sweepstake.
    /// </summary>
    public string? Name { get; set; }
}

public class GetSweepstakeResponse : PlayFabResultCommon {
    /// <summary>
    /// The list of the sweepstakes for the associated title.
    /// </summary>
    public List<Sweepstake>? Sweepstakes { get; set; }
}

public class Sweepstake {
    /// <summary>
    /// The date the winner will be chosen.
    /// </summary>
    public required DateTime DrawingDate { get; set; }
    /// <summary>
    /// The last day users can enter tickets.
    /// </summary>
    public required DateTime EndDate { get; set; }
    /// <summary>
    /// The number of winners possible for the sweepstake.
    /// </summary>
    public int MaxNumberOfWinners { get; set; }
    /// <summary>
    /// Unique name of the sweepstake.
    /// </summary>
    public string? Name { get; set; }
    /// <summary>
    /// The unique reward that will be given to winner(s).
    /// </summary>
    public string? RewardId { get; set; }
    /// <summary>
    /// The start date for participants to enter tickets.
    /// </summary>
    public required DateTime StartDate { get; set; }
    /// <summary>
    /// The unique TitleId associated with the sweepstake.
    /// </summary>
    public string? TitleId { get; set; }
}

