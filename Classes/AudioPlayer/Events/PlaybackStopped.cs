namespace ChineseChess {
    using NAudio.Wave;
    partial class AudioPlayer {
        private void OnPlaybackStopped(object sender, StoppedEventArgs e) {
            if(!this.stop) {
                this.stop = true;
                return;
            }
            this.outputDevice.Dispose();
            this.reader.Dispose();
            this.outputDevice = null;
            this.reader = null;
            this.progressTimer.Enabled = false;
            this.PlaybackStateUpdate(this, new PlayerPlaybackStateEventArgs(PlaybackState.Stopped));
        }
    }
}