using System;
using System.Linq;
using System.Text.RegularExpressions;

static class LogLine
{
    public static string Message(string logLine)
    {
        var message = Regex.Replace(logLine, @"(\[(.+?)\]\:)", "");
        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        var matches = Regex.Matches(logLine, @"(\[(.+?)\]\:)");
        var type = matches.Select(n => n.Groups).FirstOrDefault()?.Values.ElementAt(2).Value;
        return type?.ToLower();
    }

    public static string Reformat(string logLine)
    {
        return Message(logLine) + " (" + LogLevel(logLine) + ")";
    }
}