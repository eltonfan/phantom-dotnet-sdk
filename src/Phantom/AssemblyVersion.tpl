using System.Reflection;

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: AssemblyCompany("Elton FAN")]
[assembly: AssemblyProduct("Phantom.NET")]
[assembly: AssemblyCopyright("\u00A9 2014 Elton FAN. http://elton.io/")]
[assembly: AssemblyTrademark("Elton FAN")]

[assembly: AssemblyVersion("1.0.0.$REV$")]
[assembly: AssemblyFileVersion("1.0.0.$REV$")]
[assembly: AssemblyInformationalVersion("v1.0.0 Alpha")]
[assembly: AssemblyDefaultAlias("$HASH$ $DATE$")]