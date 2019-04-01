// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="SDCWORLD">
//   Sourodeep Chatterjee
// </copyright>
// <summary>
//   Defines the Program type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace AdapterPattern
{
    using System;

    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var audioPlayer = new AudioPlayer();

            // Files that support
            audioPlayer.Play("mp3", "Chirodini tumi je amar");
            audioPlayer.Play("vlc", "Uri - The surgical strike");
            audioPlayer.Play("mp4", "CSGO how to practice strafe shooting");

            // Files that don't support
            audioPlayer.Play("mkv", "3 idiots");
        }
    }
}
