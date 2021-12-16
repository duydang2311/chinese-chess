namespace ChineseChess {
    using System;
    public class PlayerProgressEventArgs : EventArgs {
        private int progress;
        public PlayerProgressEventArgs(int progress) : base() {
            this.progress = progress;
        }
        public int Progress {
            get => this.progress;
        }
    }
    partial class AudioPlayer {
        public event EventHandler<PlayerProgressEventArgs> ProgressUpdate;
    }
}