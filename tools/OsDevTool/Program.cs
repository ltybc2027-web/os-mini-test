using System;
using System.Runtime.InteropServices;

Console.WriteLine("=== OS Dev Tool ===");
Console.WriteLine($"Operating System: {RuntimeInformation.OSDescription}");
Console.WriteLine($"Architecture: {RuntimeInformation.OSArchitecture}");
Console.WriteLine($".NET Version: {Environment.Version}");
Console.WriteLine();

string[] requiredTools =
{
    "make",
    "nasm",
    "g++",
    "qemu-system-i386"
};

int installedCount = 0;

Console.WriteLine("=== Tool Check ===");

foreach (string tool in requiredTools)
{
    bool isInstalled = ToolChecker.IsInstalled(tool);

    string status = isInstalled ? "Installed" : "Missing";

    Console.WriteLine($"{tool}: {status}");

    if (isInstalled)
        installedCount++;
}

Console.WriteLine();
Console.WriteLine($"Installed: {installedCount}/{requiredTools.Length}");
