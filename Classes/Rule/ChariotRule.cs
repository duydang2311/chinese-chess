namespace ChineseChess {
    using System.Collections.Generic;
    static class ChariotRule {
        public static List<Direction> GetMoves(Side side, Piece piece) {
            List<Direction> list = new List<Direction>();
            Direction direction = Direction.Forward(side);
            while(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
                direction = direction + Direction.Forward(side);
            }
            direction = Direction.Backward(side);
            while(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
                direction = direction + Direction.Backward(side);
            }
            direction = Direction.Left(side);
            while(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
                direction = direction + Direction.Left(side);
            }
            direction = Direction.Right(side);
            while(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
                direction = direction + Direction.Right(side);
            }
            return list;
        }
    }
}