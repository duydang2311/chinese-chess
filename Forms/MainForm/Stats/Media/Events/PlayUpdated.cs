namespace ChineseChess {
    using System.Windows.Forms;
    public partial class MainForm : Form {
        private void Player_OnPlayUpdated(object sender, PlayerPlayEventArgs e) {
            if(this.player is null) return;
            this.playerTrackNameLabel.Text = e.Name;
        }
    }
}