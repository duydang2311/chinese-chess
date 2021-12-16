namespace ChineseChess {
    using System;
    using NAudio.Wave;
    public class PlayerPlaybackStateEventArgs : EventArgs {
        private PlaybackState playbackState;
        public PlayerPlaybackStateEventArgs(PlaybackState playbackState) {
            this.playbackState = playbackState;
        }
        public PlaybackState PlaybackState {
            get => this.playbackState;
        }
    }
    partial class AudioPlayer {
        public event EventHandler<PlayerPlaybackStateEventArgs> PlaybackStateUpdate;
    }
}