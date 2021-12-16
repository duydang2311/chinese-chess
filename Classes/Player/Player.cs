namespace ChineseChess {
    using System.Timers;
    partial class Player {
        public const uint DefaultMiliseconds = 10 * 60 * 1000;
        public const uint DefaultIntervalMs = 50;
        private string name;
        private bool isAI;
        private uint milisecond;
        private Timer timer;
        public Player(string name, bool isAI, uint milisecond = Player.DefaultMiliseconds) {
            this.name = name;
            this.isAI = isAI;
            this.milisecond = milisecond;
            this.timer = new Timer(Player.DefaultIntervalMs);
            this.timer.Elapsed += this.OnTimerElapsed;
            this.timer.Enabled = false;
            this.timer.AutoReset = true;
        }
        public string Name {
            get => this.name;
            set { this.name = value; }
        }
        public uint Milisecond {
            get => this.milisecond;
            set { this.milisecond = value; }
        }
        public uint Second {
            get => this.milisecond / 1000;
            set { this.milisecond = value * 1000; }
        }
        public uint Minute {
            get => this.milisecond / 1000 / 60;
            set { this.milisecond = value * 1000 * 60; }
        }
        public Timer Timer {
            get => this.timer;
        }
    }
}