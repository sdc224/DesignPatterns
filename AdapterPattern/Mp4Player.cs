// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mp4Player.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Mp4Player type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The MP4 player.
    /// </summary>
    public class Mp4Player : IAdvancedMediaPlayer
    {
        /// <inheritdoc />
        /// <summary>
        /// The play VLC.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <exception cref="T:System.NotImplementedException">
        /// Throws if Not Implemented
        /// </exception>
        public void PlayVlc(string fileName)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        /// <summary>
        /// The play MP4.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <exception cref="T:System.NotImplementedException">
        /// Throws if Not Implemented
        /// </exception>
        public void PlayMp4(string fileName)
        {
            Console.WriteLine($"Playing mp4 -- {fileName}");
        }
    }
}