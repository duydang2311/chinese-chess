using System.Collections.Generic;

namespace ChineseChess {
    static class HorseRule {
        public static List<Direction> GetMoves(Side side, Piece piece) {
            List<Direction> list = new List<Direction>();
            Direction direction = Direction.Forward(side) * 2 + Direction.Left(side);
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = direction.Opposite;
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = Direction.Forward(side) * 2 + Direction.Right(side);
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = direction.Opposite;
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = Direction.Left(side) * 2 + Direction.Forward(side);
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = direction.Opposite;
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = Direction.Left(side) * 2 + Direction.Backward(side);
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            direction = direction.Opposite;
            if(DirectionHelper.Validate(piece, direction)) {
                list.Add(direction);
            }
            return list;
        }
    }
}