namespace MyGit
{
    /// <summary>
    /// VCS Initialization command.
    /// </summary>
    public class InitCommand : IVcsCommand
    {
        /// <inheritdoc/>
        public void Execute(IVersionControlSystem vcs)
        {
            vcs.Init();
        }
    }
}
