namespace ChineseChess {
    using System;
    public class GuideClickEventArgs : EventArgs {
        private int x;
        private int y;
        public GuideClickEventArgs(int x, int y) : base() {
            this.x = x;
            this.y = y;
        }
        public int X {
            get => this.x;
        }
        public int Y {
            get => this.y;
        }
    }
    partial class Guide {
        public event EventHandler<GuideClickEventArgs> GuideClickEvent;
        public void OnMouseClick(float x, float y) {
            float cellX = this.board.Width / (Board.Cols - 1);
            float cellY = this.board.Height / (Board.Rows - 1);
            int col = (int)Math.Round((x - this.board.Location.X) / cellX);
            int row = (int)Math.Round((y - this.board.Location.Y) / cellY);
            foreach(Direction point in this.points) {
                if(col == point.X && row == point.Y) {
                    GuideClickEventArgs args = new GuideClickEventArgs(col, row);
                    this.GuideClickEvent(this, args);
                }
            }
            this.points.Clear();
        }
    }
}