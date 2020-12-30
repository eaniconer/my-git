namespace MyGit
{
    /// <summary>
    /// Interface of VCS.
    /// </summary>
    public interface IVersionControlSystem
    {
        /// <summary>
        /// Create an empty repository or reinitialize an existing one.
        /// </summary>
        void Init();
    }
}
