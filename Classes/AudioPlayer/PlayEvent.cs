namespace ChineseChess {
    using System;
    public class PlayerPlayEventArgs : EventArgs {
        private string name;
        public PlayerPlayEventArgs(string name) : base() {
            this.name = name;
        }
        public string Name {
            get => this.name;
        }
    }
    partial class AudioPlayer {
        public event EventHandler<PlayerPlayEventArgs> PlayUpdate;
    }
}