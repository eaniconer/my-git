namespace MyGit
{
    /// <summary>
    /// Interface for commands that can be executed on given VCS.
    /// </summary>
    public interface IVcsCommand
    {
        /// <summary>
        /// Executes command on given instance of VCS.
        /// </summary>
        /// <param name="vcs"> Version control system. </param>
        void Execute(IVersionControlSystem vcs);
    }
}
