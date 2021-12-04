using System.Drawing;
namespace ChineseChess {
    static partial class BoardHelper {
        public static PointF GetLocation(Board board, int col, int row) {
            float cellX = board.Width / (Board.Cols - 1);
            float cellY = board.Height / (Board.Rows - 1);
            return new PointF(board.Location.X + cellX * col, board.Location.Y + cellY * row);
        }
    }
}