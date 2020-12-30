namespace MyGit
{
    using System.IO;
    using Microsoft.Extensions.CommandLineUtils;

    /// <summary>
    /// Entry point class.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point method.
        /// </summary>
        /// <param name="args"> Command line parameters. </param>
        internal static void Main(string[] args)
        {
            var vcs = new VersionControlSystem(Directory.GetCurrentDirectory());
            var command = ParseCommand(args);

            if (command != null)
            {
                command.Execute(vcs);
            }
        }

        /// <summary>
        /// Parses arguments to extract <see cref="IVcsCommand"/>.
        /// </summary>
        /// <param name="args"> Argumetns. </param>
        /// <returns> <see cref="IVcsCommand"/>. </returns>
        internal static IVcsCommand ParseCommand(string[] args)
        {
            IVcsCommand parsedCommand = null;

            var app = new CommandLineApplication
            {
                Name = "my-git",
                Description = "Distributed Version Control System.",
            };

            app.HelpOption("-h|--help");

            app.Command("init", command =>
            {
                command.Description = "Creates an empty repository.";
                command.OnExecute(() =>
                {
                    parsedCommand = new InitCommand();
                    return 0;
                });
            });

            app.Execute(args);

            return parsedCommand;
        }
    }
}
