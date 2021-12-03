using System.Collections.Generic;

namespace ChineseChess {
    static class SoldierRule {
        public static List<Direction> GetMoves(Side side, Piece piece) {
            List<Direction> list = new List<Direction>();
            Direction direction = Direction.Forward(side);
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            if((side == Side.Top && piece.Location.Y > (int)(Board.Rows / 2))
            || (side == Side.Bottom && piece.Location.Y < (int)(Board.Rows / 2))) {
                direction = Direction.Left(side);
                if(DirectionHelper.Validate(piece, direction)) {
                    list.Add(direction);
                }
                direction = Direction.Right(side);
                if(DirectionHelper.Validate(piece, direction)) {
                    list.Add(direction);
                }
            }
            return list;
        }
    }
}