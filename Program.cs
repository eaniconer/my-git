using System;
using System.IO;
using System.Linq;
using Microsoft.Extensions.CommandLineUtils;

namespace my_git
{
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CommandLineApplication
            {
                Name = "my-git",
                Description = "Distributed Version Control System."
            };

            app.HelpOption("-h|--help");

            app.Command("init", command =>
            {
                command.Description = "Creates an empty repository.";
                command.OnExecute(() =>
                {
                    InitRepository();
                    return 0;
                });
            });

            app.Execute(args);
        }

        /// <summary>
        /// Create an empty repository or reinitialize an existing one.
        /// </summary>
        private static void InitRepository()
        {
            var vcsRootPath = VcsRootDirectoryPath;
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

        /// <summary>
        /// Name of directory that contains all information for version constrol system.
        /// </summary>
        private static string VcsRootDirectoryName
        {
            get { return ".mygit"; }
        }

        /// <summary>
        /// Path to directory that contains all information for version control system.
        /// </summary>
        private static string VcsRootDirectoryPath
        {
            get { return Path.Combine(
                Directory.GetCurrentDirectory(), VcsRootDirectoryName);
            }
        }
    }
}
