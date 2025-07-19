namespace CommunityFabs.NET.Generator;

internal class CommandArguments
{
    public required string OutputDirectory { get; set; }
    public required string BuildSuffix { get; set; }

    public static CommandArguments Parse(string[] args)
    {
        var commandArgs = new CommandArguments() {
            OutputDirectory = string.Empty,
            BuildSuffix = string.Empty
        };

        foreach (var arg in args)
        {
            if (arg.StartsWith("--out="))
            {
                commandArgs.OutputDirectory = arg.Substring("--out=".Length);
            } else if (arg.StartsWith("--suffix="))
            {
                commandArgs.BuildSuffix = arg.Substring("--suffix=".Length);
            }
        }
        if (string.IsNullOrEmpty(commandArgs.OutputDirectory))
        {
            commandArgs.OutputDirectory = Path.Combine(Utils.GetProjectRoot(), "..");
        }
        return commandArgs;
    }
}
