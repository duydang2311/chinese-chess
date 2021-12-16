namespace ChineseChess {
    using System.Windows.Forms;
    public partial class MainForm : Form {
        private void Player_OnProgressUpdated(object sender, PlayerProgressEventArgs e) {
            if(this.player is null) return;
            if(e.Progress < this.playerProgressBar.Maximum) {
                this.playerProgressBar.Value = e.Progress + 1;
                this.playerProgressBar.Value = e.Progress;
            } else {
                this.playerProgressBar.Value = e.Progress - 1;
                this.playerProgressBar.Value = e.Progress;
            }
        }
    }
}