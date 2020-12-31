namespace MyGit
{
    /// <summary>
    /// Represents branch in VCS.
    /// </summary>
    public class Branch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Branch"/> class.
        /// </summary>
        /// <param name="name"> Branch name. </param>
        public Branch(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Gets branch name.
        /// </summary>
        public string Name { get; }
    }
}
