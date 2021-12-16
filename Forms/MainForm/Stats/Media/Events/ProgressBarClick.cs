namespace ChineseChess {
    using System.Windows.Forms;
    public partial class MainForm : Form {
        private void PlayerProgressBar_OnMouseClicked(object sender, MouseEventArgs e) {
            if(this.player.Reader is null) return;
            this.player.Reader.Position = (long)((float)e.Location.X / this.playerProgressBar.Size.Width * this.player.Reader.Length);
        }
    }
}