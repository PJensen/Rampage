namespace Rampage.Core.Interfaces
{
    /// <summary>
    /// ISave
    /// </summary>
    public interface ISave
    {
        /// <summary>
        /// Save
        /// </summary>
        /// <returns>true on success</returns>
        bool Save(string fullPath);
    }
}