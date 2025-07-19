namespace CommunityFabs.NET.Generator;

internal class CommandArguments
{
    public required string OutputDirectory { get; set; }
    public required int BuildOffset { get; set; }

    public static CommandArguments Parse(string[] args)
    {
        var commandArgs = new CommandArguments() {
            OutputDirectory = string.Empty,
            BuildOffset = 0
        };

        foreach (var arg in args)
        {
            if (arg.StartsWith("--out="))
            {
                commandArgs.OutputDirectory = arg.Substring("--out=".Length);
            } else if (arg.StartsWith("--offset="))
            {
                var offsetArg = arg.Substring("--offset=".Length);
                if (string.IsNullOrEmpty(offsetArg))
                {
                    continue;
                }
                commandArgs.BuildOffset = int.Parse(offsetArg);
            }
        }
        if (string.IsNullOrEmpty(commandArgs.OutputDirectory))
        {
            commandArgs.OutputDirectory = Path.Combine(Utils.GetProjectRoot(), "..");
        }
        return commandArgs;
    }
}
