namespace MyGit
{
    using System;

    /// <summary>
    /// VSC `branch` command.
    /// </summary>
    public class BranchCommand : IVcsCommand
    {
        /// <inheritdoc/>
        public void Execute(IVersionControlSystem vcs)
        {
            foreach (var branch in vcs.Branches())
            {
                Console.WriteLine(branch.Name);
            }
        }
    }
}
