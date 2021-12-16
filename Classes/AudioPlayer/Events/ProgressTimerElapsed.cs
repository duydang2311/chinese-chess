namespace ChineseChess {
    using System.Timers;
    partial class AudioPlayer {
        private void HalfSecondTimer_OnElapsed(object sender, ElapsedEventArgs e) {
            if(this.reader is null) {
                this.ProgressUpdate(this, new PlayerProgressEventArgs(0));
                return;
            }
            this.ProgressUpdate(this, new PlayerProgressEventArgs((int)(this.reader.Position * MainForm.PlayerProgressBarMaximum / this.reader.Length)));
        }
    }
}