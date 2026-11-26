using System;
using System.IO;

public static class ToolChecker
{
    public static bool IsInstalled(string toolName)
    {
        string? path = Environment.GetEnvironmentVariable("PATH");

        if (string.IsNullOrEmpty(path))
            return false;
        
        foreach (string directory in path.Split(Path.PathSeparator))
        {
            string fullPath = Path.Combine(directory, toolName);

            if (File.Exists(fullPath))
                return true;
        }

        return false;
    }
}

