namespace ChineseChess {
    using System.Collections.Generic;
    static class ElephantRule {
        private static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, Direction restricted, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            int x = piece.Location.X;
            int y = piece.Location.Y;
            Piece blockPiece = null;
            Direction block = new Direction(11, 11);
            Direction temp;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - x, p.Location.Y - y);
                if(DirectionHelper.Compare(temp, restricted)) {
                    return moves;
                }
                if(DirectionHelper.Compare(direction.Normalized, temp.Normalized)) {
                    if(temp.Length < block.Length) {
                        block = temp;
                        blockPiece = p;
                    }
                }
            }
            if(blockPiece is not null && blockPiece.Side != piece.Side) {
                block += direction;
            }
            temp = direction;
            Direction min = new Direction(0, (Board.Rows - 5) * (int)piece.Side);
            Direction max = new Direction(Board.Cols + 1, (Board.Rows - 5) * (int)piece.Side + 5);
            while(steps-- != 0 && DirectionHelper.Validate(piece, temp, min, max) && !DirectionHelper.Compare(temp, block)) {
                moves.Add(temp);
                temp += direction;
            }
            return moves;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction fl = Direction.Forward(piece.Side) + Direction.Left(piece.Side);
            Direction fr = Direction.Forward(piece.Side) + Direction.Right(piece.Side);
            Direction bl = Direction.Backward(piece.Side) + Direction.Left(piece.Side);
            Direction br = Direction.Backward(piece.Side) + Direction.Right(piece.Side);
            list.AddRange(ElephantRule.GetMoves(piece, pieces, fl * 2, fl, 1));
            list.AddRange(ElephantRule.GetMoves(piece, pieces, fr * 2, fr, 1));
            list.AddRange(ElephantRule.GetMoves(piece, pieces, bl * 2, bl, 1));
            list.AddRange(ElephantRule.GetMoves(piece, pieces, br * 2, br, 1));
            return list;
        }
    }
}