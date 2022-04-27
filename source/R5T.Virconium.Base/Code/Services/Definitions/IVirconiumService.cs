using System;
using System.IO;

using R5T.T0064;


namespace R5T.Virconium
{
    [ServiceDefinitionMarker]
    public interface IVirconiumService : IServiceDefinition
    {
        /// <summary>
        /// Determine all recursive dependencies of all project references in a solution, and add those dependencies to the solution if missing.
        /// </summary>
        void AddMissingProjectDependencies(string solutionFilePath, TextWriter writer, bool dryRun = true);
        /// <summary>
        /// Determine all recursive dependencies of the non-dependency project references in a solution, and remove any dependencies that are not on that list.
        /// </summary>
        void RemoveExtraneousDependencies(string solutionFilePath, TextWriter writer, bool dryRun = true);
    }
}
