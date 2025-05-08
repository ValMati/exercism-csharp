using System.Text.RegularExpressions;

static class LogLine
{
    private const string REGULAR_EXPRESSION = @"\[(.*?)\]:\s*(.*)";

    public static string Message(string logLine)
    {
        Match match = Regex.Match(logLine, REGULAR_EXPRESSION);

        return match.Groups[2].Value.Trim();
    }

    public static string LogLevel(string logLine)
    {
        Match match = Regex.Match(logLine, REGULAR_EXPRESSION);

        return match.Groups[1].Value.ToLower();
    }

    public static string Reformat(string logLine) =>
        $"{Message(logLine)} ({LogLevel(logLine)})";
}
