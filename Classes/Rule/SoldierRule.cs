using System.Collections.Generic;

namespace ChineseChess {
    static class SoldierRule {
        public static List<Direction> GetMoves(Piece piece) {
            List<Direction> list = new List<Direction>();
            Direction direction = Direction.Forward(piece.Side);
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            if((piece.Side == Side.Top && piece.Location.Y >= (int)(Board.Rows / 2))
            || (piece.Side == Side.Bottom && piece.Location.Y < (int)(Board.Rows / 2))) {
                direction = Direction.Left(piece.Side);
                if(DirectionHelper.Validate(piece, direction)) {
                    list.Add(direction);
                }
                direction = Direction.Right(piece.Side);
                if(DirectionHelper.Validate(piece, direction)) {
                    list.Add(direction);
                }
            }
            return list;
        }
    }
}