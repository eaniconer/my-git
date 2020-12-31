namespace MyGit
{
    using System.Collections.Generic;

    /// <summary>
    /// Interface of VCS.
    /// </summary>
    public interface IVersionControlSystem
    {
        /// <summary>
        /// Create an empty repository or reinitialize an existing one.
        /// </summary>
        void Init();

        /// <summary>
        /// Returns collection of local branches.
        /// </summary>
        /// <returns> Collection of local branches. </returns>
        IEnumerable<Branch> Branches();
    }
}
