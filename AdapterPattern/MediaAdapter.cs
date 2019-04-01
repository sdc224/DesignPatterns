// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MediaAdapter.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the MediaAdapter type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The media adapter.
    /// </summary>
    public class MediaAdapter : IMediaPlayer
    {
        /// <summary>
        /// The advanced media player.
        /// </summary>
        private readonly IAdvancedMediaPlayer advancedMediaPlayer;

        /// <summary>
        /// Initializes a new instance of the <see cref="MediaAdapter"/> class.
        /// </summary>
        /// <param name="audioType">
        /// The audio type.
        /// </param>
        public MediaAdapter(string audioType)
        {
            if (string.Compare("vlc", audioType, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                this.advancedMediaPlayer = new VlcPlayer();
            }
            else if (string.Compare("mp4", audioType, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                this.advancedMediaPlayer = new Mp4Player();
            }
        }

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
            if (string.Compare("vlc", audioType, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                this.advancedMediaPlayer.PlayVlc(fileName);
            }
            else if (string.Compare("mp4", audioType, StringComparison.CurrentCultureIgnoreCase) == 0)
            {
                this.advancedMediaPlayer.PlayMp4(fileName);
            }
        }
    }
}