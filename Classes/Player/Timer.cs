namespace ChineseChess {
    using System.Timers;
    partial class Player {
        private void OnTimerElapsed(object sender, ElapsedEventArgs e) {
            uint interval = (uint)this.timer.Interval;
            if(interval > this.milisecond) {
                this.milisecond = 0;
                this.game.End();
            } else {
                this.milisecond -= interval;
            }
        }
    }
}
