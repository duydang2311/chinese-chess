namespace ChineseChess {
    using System.Drawing;
    using System.Collections.Generic;
    partial class Guide {
        private Board board;
        private List<Direction> points;
        public Guide(Board board) {
            this.board = board;
            this.points = new List<Direction>();
        }
        public Guide(Board board, List<Direction> points) {
            this.board = board;
            this.points = points;
        }
        public List<Direction> Points {
            get => this.points;
            set { this.points = value; }
        }
        public void Clear() {
            if(this.points != null) {
                this.points.Clear();
            }
        }
        public void Add(params Direction[] points) {
            foreach(Direction point in points) {
                this.points.Add(point);
            }
        }
        public void Draw(Graphics graphics) {
            using(Brush brush = new SolidBrush(Color.FromArgb(150, 255, 0, 0))) {
                PointF location;
                foreach(Direction point in this.points) {
                    location = BoardHelper.GetLocation(this.board, point.X, point.Y);
                    graphics.FillEllipse(brush, location.X - 10, location.Y - 10, 20, 20);
                }
            }
        }
    }
}