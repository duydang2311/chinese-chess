namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using NAudio.Wave;
    public partial class MainForm : Form {
        private void PlayerPlayButton_OnClicked(object sender, EventArgs e) {
            if(this.player is null) return;
            if(this.player.OutputDevice.PlaybackState == PlaybackState.Paused) {
                this.player.Play();
                return;
            }
            if(this.player.OutputDevice.PlaybackState == PlaybackState.Stopped) {
                if(this.playlist is not null && this.playlist.Count > 0) {
                    this.player.Play(this.playlist[0]);
                }
                return;
            }
            if(this.player.OutputDevice.PlaybackState == PlaybackState.Playing) {
                this.player.Pause();
                return;
            }
        }
    }
}