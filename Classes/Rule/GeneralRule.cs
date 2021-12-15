namespace ChineseChess {
    using System.Collections.Generic;
    static class GeneralRule {
        private static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            int x = piece.Location.X;
            int y = piece.Location.Y;
            Piece blockPiece = null;
            Direction block = new Direction(11, 11);
            Direction temp;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - x, p.Location.Y - y);
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
            Direction min = new Direction(Board.Cols / 2 - 1, (Board.Rows - 7) * (int)piece.Side);
            Direction max = new Direction(Board.Cols / 2 + 1, (Board.Rows - 3) * (int)piece.Side + 2);
            while(steps-- != 0 && DirectionHelper.Validate(piece, temp, min, max) && !DirectionHelper.Compare(temp, block)) {
                moves.Add(temp);
                temp += direction;
            }
            return moves;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            list.AddRange(GeneralRule.GetMoves(piece, pieces, Direction.Forward(piece.Side), 1));
            list.AddRange(GeneralRule.GetMoves(piece, pieces, Direction.Backward(piece.Side), 1));
            list.AddRange(GeneralRule.GetMoves(piece, pieces, Direction.Left(piece.Side), 1));
            list.AddRange(GeneralRule.GetMoves(piece, pieces, Direction.Right(piece.Side), 1));
            return list;
        }
    }
}