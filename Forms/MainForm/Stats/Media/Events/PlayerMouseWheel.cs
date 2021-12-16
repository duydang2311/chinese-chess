namespace ChineseChess {
    using System.Windows.Forms;
    using System.Drawing;
    using System;
    public partial class MainForm : Form {
        private Label volumeHelpLabel;
        private System.Timers.Timer volumeHelpTimer;
        private long lastWheelTime;
        private void Player_OnMouseWheel(object sender, MouseEventArgs e) {
            if(this.player is null) return;
            float volume = this.player.OutputDevice.Volume;
            if(e.Delta > 0) {
                volume += 0.05f;
                if(volume > 1.0f) {
                    volume = 1.0f;
                }
            } else if(e.Delta < 0) {
                volume -= 0.05f;
                if(volume < 0.0f) {
                    volume = 0.0f;
                }
            }
            this.player.OutputDevice.Volume = volume;
            if(this.volumeHelpLabel is null) {
                this.volumeHelpLabel = new Label();
                // this.volumeHelpLabel.Size = new Size(this.StatsCellHeight / 8, this.StatsCellHeight / 8);
                this.volumeHelpLabel.Location = new Point(this.panelStats.Width / 2 + this.StatsCellHeight / 16 + 5, this.StatsCellHeight + this.StatsCellGap + this.StatsCellHeight / 2 + this.StatsCellHeight / 8 + 5 + 5);
                this.panelStats.Controls.Add(this.volumeHelpLabel);
                this.volumeHelpTimer = new System.Timers.Timer(1000);
                this.volumeHelpTimer.AutoReset = true;
                this.volumeHelpTimer.Elapsed += this.VolumeHelpTimerElapsed;
                this.volumeHelpTimer.Enabled = true;
                this.volumeHelpTimer.Start();
            }
            this.volumeHelpLabel.Text = ((int)((this.player.OutputDevice.Volume + 0.001) * 100)).ToString();
            this.lastWheelTime = DateTime.Now.ToFileTime();
        }
        private void VolumeHelpTimerElapsed(object sender, System.Timers.ElapsedEventArgs e) {
            if(DateTime.Now.ToFileTime() - this.lastWheelTime > 10000000) {
                this.panelStats.Controls.Remove(this.volumeHelpLabel);
                this.volumeHelpTimer.Enabled = false;
                this.volumeHelpLabel.Dispose();
                this.volumeHelpTimer.Dispose();
                this.volumeHelpLabel = null;
                this.volumeHelpTimer = null;
            }
        }
    }
}