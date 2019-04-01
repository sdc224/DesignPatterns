// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IMediaPlayer.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the IMediaPlayer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    /// <summary>
    /// The MediaPlayer interface.
    /// </summary>
    public interface IMediaPlayer
    {
        /// <summary>
        /// The play.
        /// </summary>
        /// <param name="audioType">
        /// The audio type.
        /// </param>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        void Play(string audioType, string fileName);
    }
}