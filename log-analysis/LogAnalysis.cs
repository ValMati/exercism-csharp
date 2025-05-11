public static class LogAnalysis
{
    public const string START_PATTERN = "[";
    public const string END_PATTERN = "]: ";

    public static string SubstringAfter(this string logLine, string delimiter) =>
        logLine.Substring(logLine.IndexOf(delimiter) + delimiter.Length);

    public static string SubstringBetween(this string logLine, string before, string after)
    {
        int init = logLine.IndexOf(before) + before.Length;
        int lenght = logLine.IndexOf(after) - init;
        return logLine.Substring(init, lenght);
    }

    public static string Message(this string logLine)
        => logLine.SubstringAfter(END_PATTERN);

    public static string LogLevel(this string logLine) =>
        logLine.SubstringBetween(START_PATTERN, END_PATTERN);
}