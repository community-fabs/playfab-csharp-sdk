namespace CommunityFabs.NET.Sdk.Models.Sweepstakes;

/// <summary>
/// Given a title entity token and sweepstake details, will create a new sweepstake for the title.
/// </summary>
public class CreateSweepstakeRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public required DateTime DrawingDate { get; set; }
    public required DateTime EndDate { get; set; }
    public int MaxNumberOfWinners { get; set; }
    public required string Name { get; set; }
    public string? RewardId { get; set; }
    public required DateTime StartDate { get; set; }
}

public class CreateSweepstakeResponse : PlayFabResultCommon {
    public string? Name { get; set; }
}

/// <summary>
/// Given a title entity token and sweepstake name, will return the sweepstakes of that title.
/// </summary>
public class GetSweepstakeRequest : PlayFabRequestCommon {
    public Dictionary<string, string>? CustomTags { get; set; }
    public string? Name { get; set; }
}

public class GetSweepstakeResponse : PlayFabResultCommon {
    public List<Sweepstake>? Sweepstakes { get; set; }
}

public class Sweepstake {
    public required DateTime DrawingDate { get; set; }
    public required DateTime EndDate { get; set; }
    public int MaxNumberOfWinners { get; set; }
    public string? Name { get; set; }
    public string? RewardId { get; set; }
    public required DateTime StartDate { get; set; }
    public string? TitleId { get; set; }
}

