namespace CommunityFabs.NET.Generator.Templates;

public static class Utils
{
    public static string[] SplitDescription(string input, int width = 120)
    {
        if (string.IsNullOrEmpty(input))
            return [];

        var lines = new List<string>();
        int pos = 0;
        int len = input.Length;

        while (pos < len)
        {
            // Find the next break point
            int end = Math.Min(pos + width, len);
            int lastSpace = -1;

            for (int i = pos; i < end; i++)
            {
                if (char.IsWhiteSpace(input[i]))
                    lastSpace = i;
            }

            int lineEnd;
            if (end == len)
            {
                lineEnd = len;
            }
            else if (lastSpace > pos)
            {
                lineEnd = lastSpace + 1;
            }
            else
            {
                // No space found, break at width
                lineEnd = end;
            }

            var line = input.Substring(pos, lineEnd - pos).Trim();
            if (line.Length > 0)
                lines.Add(line);

            pos = lineEnd;
        }

        return [.. lines];
    }

}
