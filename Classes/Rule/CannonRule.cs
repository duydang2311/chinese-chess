namespace ChineseChess {
    using System.Collections.Generic;
    static class CannonRule {
        private static List<Direction> GetMoves(Piece piece, List<Piece> pieces, Direction direction, int steps = -1) {
            List<Direction> moves = new List<Direction>();
            List<Piece> tempPieces = new List<Piece>();
            Piece jumpPiece = null;
            Piece blockPiece = null;
            Direction jump = new Direction(Board.Rows, Board.Cols);
            Direction block = null;
            Direction temp;
            foreach(Piece p in pieces) {
                temp = p.Location - piece.Location;
                if(DirectionHelper.Compare(direction.Normalized, temp.Normalized)) {
                    tempPieces.Add(p);
                    moves.Add(temp);
                    if(temp.Length < jump.Length) {
                        jump = temp;
                        jumpPiece = p;
                    }
                }
            }
            foreach(Piece p in tempPieces) {
                if(p == jumpPiece) {
                    continue;
                }
                if(blockPiece is null) {
                    block = p.Location - piece.Location;
                    blockPiece = p;
                    continue;
                }
                temp = p.Location - piece.Location;
                if(temp.Length < block.Length) {
                    block = temp;
                    blockPiece = p;
                }
            }
            moves.Clear();
            temp = direction;
            while(steps-- != 0 && DirectionHelper.Validate(piece, temp) && !DirectionHelper.Compare(temp, jump)) {
                moves.Add(temp);
                temp += direction;
            }
            if(block is not null && blockPiece is not null && blockPiece.Side != piece.Side && !DirectionHelper.Compare(block, jump) && DirectionHelper.Validate(piece, block)) {
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