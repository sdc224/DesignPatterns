// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VlcPlayer.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the VlcPlayer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The VLC player.
    /// </summary>
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        /// <inheritdoc />
        /// <summary>
        /// The play VLC.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public void PlayVlc(string fileName)
        {
            Console.WriteLine($"Playing vlc file -- {fileName}");
        }

        /// <inheritdoc />
        /// <summary>
        /// The play MP4.
        /// </summary>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        /// <exception cref="T:System.NotImplementedException">
        /// Throw if Not implemented
        /// </exception>
        public void PlayMp4(string fileName)
        {
            throw new System.NotImplementedException();
        }
    }
}