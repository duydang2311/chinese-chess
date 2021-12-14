namespace ChineseChess {
    using System.Collections.Generic;
    static class CannonRule {
        private static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            int x = piece.Location.X;
            int y = piece.Location.Y;
            Piece jumpPiece = null;
            Direction jump = new Direction(Board.Rows, Board.Cols);
            Direction block = null;
            Direction temp;
            foreach(Piece p in pieces) {
                temp = new Direction(p.Location.X - x, p.Location.Y - y);
                if(DirectionHelper.Compare(direction.Normalized, temp.Normalized)) {
                    if(temp.Length < jump.Length) {
                        if(jumpPiece is null || jumpPiece.Side != piece.Side) {
                            block = jump;
                        }
                        jump = temp;
                        jumpPiece = p;
                    } else if(temp.Length < block.Length) {
                        block = temp;
                    }
                }
            }
            temp = direction;
            while(steps-- != 0 && DirectionHelper.Validate(piece, temp) && !DirectionHelper.Compare(temp, jump)) {
                moves.Add(temp);
                temp += direction;
            }
            if(block is not null && !DirectionHelper.Compare(block, jump) && DirectionHelper.Validate(piece, block)) {
                moves.Add(block);
            }
            return moves;
        }
        public static List<Direction> GetMoves(Piece piece, List<Piece> pieces) {
            List<Direction> list = new List<Direction>();
            Direction[] directions = new Direction[4];
            for(int i = 0; i != 4; ++i) {
                directions[i] = Direction.Get(piece.Side, (Directions)i);
                list.AddRange(CannonRule.GetMoves(piece, pieces, directions[i]));
            }
            return list;
        }
    }
}