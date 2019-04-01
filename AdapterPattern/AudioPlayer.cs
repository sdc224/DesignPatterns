// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AudioPlayer.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the AudioPlayer type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The audio player.
    /// </summary>
    public class AudioPlayer : IMediaPlayer
    {
        /// <summary>
        /// The media adapter.
        /// </summary>
        private MediaAdapter mediaAdapter;

        /// <inheritdoc />
        /// <summary>
        /// The play.
        /// </summary>
        /// <param name="audioType">
        /// The audio type.
        /// </param>
        /// <param name="fileName">
        /// The file name.
        /// </param>
        public void Play(string audioType, string fileName)
        {
            if (string.Compare("mp3", audioType, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                Console.WriteLine($"Playing mp3 file -- {fileName}");
            }
            else if (string.Compare("vlc", audioType, StringComparison.CurrentCultureIgnoreCase) == 0 || string.Compare(
                         "mp4",
                         audioType,
                         StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                this.mediaAdapter = new MediaAdapter(audioType);
                this.mediaAdapter.Play(audioType, fileName);
            }
            else
            {
                Console.WriteLine($"Invalid Media... Cannot play -- {fileName}");
            }
        }
    }
}