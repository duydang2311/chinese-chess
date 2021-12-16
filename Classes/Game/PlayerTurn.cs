namespace ChineseChess {
    using System;
	using System.Windows.Forms;
	partial class Game : PictureBox {
        private int turnSide = (int)Side.Bottom;
        public Side TurnSide {
            get => (Side)this.turnSide;
            set { this.turnSide = (int)value; }
        }
        public void SwitchTurn() {
            this.sidePlayers[turnSide].Timer.Enabled = false;
            turnSide = (++turnSide) % Enum.GetNames(typeof(Side)).Length;
            this.sidePlayers[turnSide].Timer.Enabled = true;
        }
	}
}
