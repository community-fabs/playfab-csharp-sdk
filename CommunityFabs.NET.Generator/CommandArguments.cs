using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunityFabs.NET.Generator;

internal class CommandArguments
{
    public required string OutputDirectory { get; set; }

    public static CommandArguments Parse(string[] args)
    {
        var commandArgs = new CommandArguments() {
            OutputDirectory = string.Empty
        };

        foreach (var arg in args)
        {
            if (arg.StartsWith("--out="))
            {
                commandArgs.OutputDirectory = arg.Substring("--out=".Length);
            }
        }
        if (string.IsNullOrEmpty(commandArgs.OutputDirectory))
        {
            commandArgs.OutputDirectory = Path.Combine(Utils.GetProjectRoot(), "..");
        }
        return commandArgs;
    }
}
