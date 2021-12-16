namespace ChineseChess {
    using NAudio.Wave;
    using System.Timers;
    using System.IO;
    partial class AudioPlayer {
        private WaveOutEvent outputDevice;
        private AudioFileReader reader;
        private bool stop;
        private Timer progressTimer;
        public AudioPlayer() {
            this.reader = null;
            this.outputDevice = null;
            this.stop = true;
        }
        public AudioFileReader Reader {
            get => this.reader;
        }
        public WaveOutEvent OutputDevice {
            get => this.outputDevice;
        }
        public void Play() {
            if(this.outputDevice is null) return;
            this.outputDevice.Play();
            this.progressTimer.Enabled = true;
            this.progressTimer.Start();
            this.PlaybackStateUpdate(this, new PlayerPlaybackStateEventArgs(PlaybackState.Playing));
        }
        public void Play(string fileName) {
            if(this.outputDevice is not null) {
                this.stop = false;
                this.outputDevice.Dispose();
            }
            if(this.reader is not null) {
                this.reader.Dispose();
            }
            if(this.progressTimer is null) {
                this.progressTimer = new Timer(200);
                this.progressTimer.Elapsed += HalfSecondTimer_OnElapsed;
                this.progressTimer.AutoReset = true;
            }
            this.outputDevice = new WaveOutEvent();
            this.outputDevice.PlaybackStopped += OnPlaybackStopped;
            this.reader = new AudioFileReader(fileName);
            this.outputDevice.Init(this.reader);
            this.outputDevice.Play();
            this.progressTimer.Enabled = true;
            this.progressTimer.Start();
            this.PlaybackStateUpdate(this, new PlayerPlaybackStateEventArgs(PlaybackState.Playing));
            this.PlayUpdate(this, new PlayerPlayEventArgs(Path.GetFileNameWithoutExtension(fileName)));
        }
        public void Pause() {
            if(this.outputDevice is null) return;
            if(this.outputDevice.PlaybackState != PlaybackState.Playing) return;
            this.outputDevice.Pause();
            this.progressTimer.Enabled = false;
            this.progressTimer.Stop();
            this.PlaybackStateUpdate(this, new PlayerPlaybackStateEventArgs(PlaybackState.Paused));
        }
        public void Stop() {
            if(this.outputDevice is null) return;
            this.outputDevice.Stop();
            this.progressTimer.Enabled = false;
            this.progressTimer.Stop();
            this.PlaybackStateUpdate(this, new PlayerPlaybackStateEventArgs(PlaybackState.Stopped));
        }
    }
}