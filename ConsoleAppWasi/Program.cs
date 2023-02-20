
using System.Runtime.InteropServices;

Console.WriteLine($"Hello DotNetFlix from {RuntimeInformation.OSArchitecture}!");

var content = System.IO.File.ReadAllText("/etc/hosts");

Console.WriteLine(content);