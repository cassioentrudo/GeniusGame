using System;
using System.Runtime.InteropServices;
using System.Media;

namespace GeniusGame
{
    static class NativeMethods
    {
        [DllImport("winmm.dll", EntryPoint = "waveOutSetVolume")]
        public static extern int WaveOutSetVolume(IntPtr hwo, uint dwVolume);

        [DllImport("winmm.dll", SetLastError = true)]
        public static extern bool PlaySound(string pszSound, IntPtr hmod, uint fdwSound);
    }

    public class Song
    {
        private SoundPlayer soundPLayer = null;

        public Song()
        {
            this.soundPLayer = new SoundPlayer();
        }

        public void Mute(bool mute)
        {
            if (mute)
            {
                NativeMethods.WaveOutSetVolume(IntPtr.Zero, 50);
            }
            else
            {
                // Calculate the volume that's being set
                int NewVolume = ((ushort.MaxValue / 10) * 100);
                // Set the same volume for both the left and the right channels
                uint NewVolumeAllChannels = (((uint)NewVolume & 0x0000ffff) | ((uint)NewVolume << 16));
                // Set the volume
                NativeMethods.WaveOutSetVolume(IntPtr.Zero, NewVolumeAllChannels);
            }
            
        }

        public void Play(string path)
        {
            this.soundPLayer.SoundLocation = path;
            this.soundPLayer.Play();
        }

        public void Stop()
        {
            this.soundPLayer.Stop();
        }
    }
}