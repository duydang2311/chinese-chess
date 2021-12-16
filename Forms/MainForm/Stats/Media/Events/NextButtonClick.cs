namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using NAudio.Wave;
    public partial class MainForm : Form {
        private void PlayerNextButton_OnClicked(object sender, EventArgs e) {
            if(this.player is null || this.playlist is null || this.playlist.Count == 0) return;
            this.currentSong = ++this.currentSong % this.playlist.Count;
            this.player.Play(this.playlist[this.currentSong]);
        }
    }
}