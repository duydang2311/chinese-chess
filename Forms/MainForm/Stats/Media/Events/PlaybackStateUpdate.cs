namespace ChineseChess {
    using System.Windows.Forms;
    using NAudio.Wave;
    using System.Threading.Tasks;
    public partial class MainForm : Form {
        private void Player_OnPlaybackStateUpdated(object sender, PlayerPlaybackStateEventArgs e) {
            if(this.player is null) return;
            if(e.PlaybackState == PlaybackState.Stopped) {
                this.currentSong = (++this.currentSong) % this.playlist.Count;
                this.player.Play(this.playlist[this.currentSong]);
                return;
            }
            if(e.PlaybackState == PlaybackState.Paused) {
                this.playerPlayButton.BackgroundImage = ChineseChess.Properties.Resources.play;
                return;
            }
            this.playerPlayButton.BackgroundImage = ChineseChess.Properties.Resources.pause;
        }
    }
}