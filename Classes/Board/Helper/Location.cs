using System.Drawing;
namespace ChineseChess {
    partial class BoardHelper {
        public static PointF GetLocation(Board board, int row, int col) {
            float cellX = board.Width / (Board.Cols - 1);
            float cellY = board.Height / (Board.Rows - 1);
            return new PointF(board.Location.X + cellX * col, board.Location.Y + cellY * row);
        }
    }
}