namespace MyGit
{
    using System;
    using System.IO;

    /// <summary>
    /// Main implementation of VCS.
    /// </summary>
    public class VersionControlSystem : IVersionControlSystem
    {
        private readonly string repoPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="VersionControlSystem"/> class.
        /// </summary>
        /// <param name="repoPath">Absolute path to repository.</param>
        public VersionControlSystem(string repoPath)
        {
            this.repoPath = repoPath;
        }

        /// <summary>
        /// Gets name of directory that contains all information for version constrol system.
        /// </summary>
        private static string VcsRootDirectoryName
        {
            get { return ".mygit"; }
        }

        /// <inheritdoc/>
        public void Init()
        {
            var vcsRootPath = Path.Combine(this.repoPath, VcsRootDirectoryName);
            if (Directory.Exists(vcsRootPath))
            {
                Console.WriteLine("Reinitialize existing repository...");
            }
            else
            {
                Console.WriteLine("Initialize an empty repository...");

                try
                {
                    Directory.CreateDirectory(vcsRootPath);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failed to initialize repository. Error message: {e.Message}");
                }
            }
        }
    }
}
