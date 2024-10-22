using System;

using R5T.T0142;


namespace D8S.L0014.T000
{
    /// <summary>
    /// Source type for instances (Nuget package, or project?).
    /// </summary>
    [DataTypeMarker]
    public enum InstanceSourceType
    {
        // Default.
        NugetPackage = 0,

        ProjectFile = 1,
    }


    /// <summary>
    /// Source type for instances (Nuget package, or project?).
    /// </summary>
    [DataTypeMarker]
    public enum InstanceSourceType_WithUnknown
    {
        // Default.
        Unknown = 0,

        NugetPackage = 1,

        ProjectFile = 2,
    }
}
