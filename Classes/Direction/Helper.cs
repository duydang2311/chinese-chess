namespace ChineseChess {
    using System;
    static class DirectionHelper {
        public static bool Validate(Piece piece, Direction direction) {
            int x = piece.Location.X + direction.X;
            int y = piece.Location.Y + direction.Y;
            return (x >= 0 && x < Board.Cols) && (y >= 0 && y < Board.Rows);
        }
        public static bool Validate(Piece piece, Direction direction, Direction min, Direction max) {
            int x = piece.Location.X + direction.X;
            int y = piece.Location.Y + direction.Y;
            // int leftX = (Board.Cols) / 2 - 1;
            // int rightX = (Board.Cols) / 2 + 1;
            // int topY = ((int)piece.Side * (Board.Rows - 1));
            // int bottomY = ((int)piece.Side * (Board.Rows - 1)) + (Direction.Forward(piece.Side) * 2).Y;
            // return (x >= leftX && x <= rightX && ((y >= topY && y <= bottomY) || y <= topY && y >= bottomY));
            return (x >= min.X && x <= max.X && y >= min.Y && y <= max.Y);
        }
        public static bool Compare(Direction a, Direction b) {
            return (a.X == b.X && a.Y == b.Y);
        }
    }
}