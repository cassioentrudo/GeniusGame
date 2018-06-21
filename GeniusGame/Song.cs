using System;
using WMPLib;

namespace GeniusGame
{
    public class Song
    {
        private WindowsMediaPlayer wplayer = null;

        public Song()
        {
            this.wplayer = new WindowsMediaPlayer();
        }

        public void SetVolume(int vol)
        {
            this.wplayer.settings.volume = vol;
        }

        public void Play(string path)
        {
            this.wplayer.URL = path;
            this.wplayer.controls.play();
        }

        public void Stop()
        {
            this.wplayer.controls.stop();
        }
    }
}