using System;
using WMPLib;

namespace GeniusGame
{
    public class Song
    {
        private WindowsMediaPlayer wplayer = null;
        private string filePath = string.Empty;

        public Song()
        {
            this.wplayer = new WindowsMediaPlayer();
        }

        public String FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        public void SetVolume(int vol)
        {
            this.wplayer.settings.volume = vol;
        }

        public void Play()
        {
            this.wplayer.URL = this.filePath;
            this.wplayer.controls.play();
        }
    }
}