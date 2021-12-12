namespace ChineseChess {
    using System;
    static class DirectionHelper {
        public static bool Validate(Piece piece, Direction direction) {
            int x = piece.Location.X + direction.X;
            int y = piece.Location.Y + direction.Y;
            return (x >= 0 && x < Board.Cols) && (y >= 0 && y < Board.Rows);
        }
        public static bool Compare(Direction a, Direction b) {
            return (a.X == b.X && a.Y == b.Y);
        }
        public static Direction Normalize(int x, int y) {
            float length = (float)Math.Sqrt(x * x + y * y);
            x = (int)(x / length);
            y = (int)(y / length);
            return new Direction(x, y);
        }
    }
}