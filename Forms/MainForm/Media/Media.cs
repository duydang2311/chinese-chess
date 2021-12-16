namespace ChineseChess {
    using System.Windows.Forms;
    using System.Collections.Generic;
    public partial class MainForm : Form {
        private AudioPlayer player;
        private List<string> playlist;
        private int currentSong;
        private void InitPlayer() {
            this.TerminatePlayer();
            this.playlist = new List<string>();
            this.player = new AudioPlayer();
            this.currentSong = 0;
            this.player.ProgressUpdate += this.Player_OnProgressUpdated;
            this.player.PlaybackStateUpdate += this.Player_OnPlaybackStateUpdated;
            this.player.PlayUpdate += this.Player_OnPlayUpdated;
            this.TerminateWeb();
            this.CreatePlayerControls();
        }
        private void TerminatePlayer() {
            if(this.playlist is not null) {
                this.playlist.Clear();
                this.playlist = null;
            }
            if(this.player is not null) {
                this.player.Stop();
                this.player = null;
            }
        }
    }
}