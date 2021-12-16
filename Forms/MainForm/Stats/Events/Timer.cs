namespace ChineseChess {
    using System.Timers;
    using System.Windows.Forms;
	public partial class MainForm : Form {
        private void OnTopTimerElapsed(object sender, ElapsedEventArgs e) {
            if(this.game is null) return;
            this.topTimeLabel.Text = this.game.SidePlayers[(int)Side.Top].Minute.ToString().PadLeft(2, '0') + ":" + (this.game.SidePlayers[(int)Side.Top].Second % 60).ToString().PadLeft(2, '0');
        }
        private void OnBottomTimerElapsed(object sender, ElapsedEventArgs e) {
            if(this.game is null) return;
            this.bottomTimeLabel.Text = this.game.SidePlayers[(int)Side.Bottom].Minute.ToString().PadLeft(2, '0') + ":" + (this.game.SidePlayers[(int)Side.Bottom].Second % 60).ToString().PadLeft(2, '0');
        }
	}
}
