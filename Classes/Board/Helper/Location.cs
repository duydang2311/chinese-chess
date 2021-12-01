using System.Drawing;
namespace ChineseChess {
    partial class BoardHelper {
        public static PointF GetLocation(Board board, int row, int col) {
            float cellX = board.Width / (col - 1);
            float cellY = board.Height / (row - 1);
            return new PointF(board.Location.X + cellX * col, board.Location.Y + cellY * row);
        }
    }
}