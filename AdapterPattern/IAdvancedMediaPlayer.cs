// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IAdvancedMediaPlayer.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the IAdvancedMediaPlayer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    /// <summary>
    /// The AdvancedMediaPlayer interface.
    /// </summary>
    public interface IAdvancedMediaPlayer
    {
        /// <summary>
        /// The play VLC.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        void PlayVlc(string fileName);

        /// <summary>
        /// The play MP4.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        void PlayMp4(string fileName);
    }
}