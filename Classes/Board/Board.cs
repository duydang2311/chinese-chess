namespace ChineseChess {
    using System;
    using System.Drawing;
    using System.Collections.Generic;
    partial class Board {
        public const float WidthHeightRatio = 1.125F;
        public const int Rows = 10;
        public const int Cols = 9;
        private float size;
        private PointF location;
        private List<Piece>[] sides;
        private List<Piece>[] captured;
        private Image image;
        private Guide guide;
        private Game game;
        public Board(Image image, float size, PointF location) {
            int length = System.Enum.GetNames(typeof(Side)).Length;
            this.size = size;
            this.location = location;
            this.sides = new List<Piece>[length];
            this.captured = new List<Piece>[length];
            this.image = new Bitmap(image, (int)(790 / Board.WidthHeightRatio), 790);
            this.guide = new Guide(this);
            for(int i = 0; i != length; ++i) {
                this.sides[i] = new List<Piece>();
                this.captured[i] = new List<Piece>();
            }
            this.guide.GuideClickEvent += this.OnGuideClick;
        }
        public float Width {
            get => this.size;
            set { this.size = value; }
        }
        public float Height {
            get => this.size * Board.WidthHeightRatio;
            set { this.size = value / Board.WidthHeightRatio; }
        }
        public List<Piece>[] Sides {
            get => this.sides;
        }
        public PointF Location {
            get => this.location;
            set { this.location = value; }
        }
        public Game Game {
            get => this.game;
            set { this.game = value; }
        }
        public void Setup() {
            int i = 0;
            foreach(List<Piece> list in sides) {
                list.Clear();
                list.Add(new Piece(this, Pieces.General, (Side)i, new Direction((int)(Board.Cols / 2), i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Guard, (Side)i, new Direction((int)(Board.Cols / 2) - 1, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Guard, (Side)i, new Direction((int)(Board.Cols / 2) + 1, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Elephant, (Side)i, new Direction((int)(Board.Cols / 2) - 2, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Elephant, (Side)i, new Direction((int)(Board.Cols / 2) + 2, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Horse, (Side)i, new Direction((int)(Board.Cols / 2) - 3, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Horse, (Side)i, new Direction((int)(Board.Cols / 2) + 3, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Chariot, (Side)i, new Direction((int)(Board.Cols / 2) - 4, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Chariot, (Side)i, new Direction((int)(Board.Cols / 2) + 4, i * (Board.Rows - 1))));
                list.Add(new Piece(this, Pieces.Cannon, (Side)i, new Direction((int)(Board.Cols / 2) - 3, i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 2)));
                list.Add(new Piece(this, Pieces.Cannon, (Side)i, new Direction((int)(Board.Cols / 2) + 3, i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 2)));
                list.Add(new Piece(this, Pieces.Soldier, (Side)i, new Direction((int)(Board.Cols / 2) - 4, i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3)));
                list.Add(new Piece(this, Pieces.Soldier, (Side)i, new Direction((int)(Board.Cols / 2) - 2, i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3)));
                list.Add(new Piece(this, Pieces.Soldier, (Side)i, new Direction((int)(Board.Cols / 2), i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3)));
                list.Add(new Piece(this, Pieces.Soldier, (Side)i, new Direction((int)(Board.Cols / 2) + 2, i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3)));
                list.Add(new Piece(this, Pieces.Soldier, (Side)i, new Direction((int)(Board.Cols / 2) + 4, i * (Board.Rows - 1) + ((i == 0) ? 1 : -1) * 3)));
                ++i;
            }
        }
        public void AddPiece(Side side, Piece piece) {
            this.sides[(int)side].Add(piece);
        }
        public void RemovePiece(Side side, Piece piece) {
            int index = this.sides[(int)side].IndexOf(piece);
            if(index == -1) return;
            this.sides[(int)side].RemoveAt(index);
        }
        public void Draw(SideColor[] colors, Graphics graphics) {
            graphics.DrawImage(this.image, this.location.X, this.location.Y, this.Width, this.Height);
            for(int i = 0 ; i != this.sides.Length; ++i) {
                foreach(Piece piece in this.sides[i]) {
                    piece.Draw(colors[i], graphics);
                }
            }
            this.guide.Draw(graphics);
        }
        public void DrawCaptured(SideColor[] colors, Graphics graphics, int shift = 0, bool vertical = true) {
            int offset = 0;
            if(vertical) {
                for(int i = 0 ; i != this.sides.Length; ++i) {
                    int index = 0;
                    foreach(Piece piece in this.captured[i]) {
                        piece.Location = new Direction(Board.Cols + shift + i + offset, index++);
                        if(index == Board.Rows - 1) {
                            ++offset;
                            index = 0;
                        }
                        piece.Draw(colors[i], graphics);
                    }
                }
            } else {
                for(int i = 0 ; i != this.sides.Length; ++i) {
                    int index = 0;
                    foreach(Piece piece in this.captured[i]) {
                        piece.Location = new Direction(index++, Board.Rows + shift + i + offset);
                        if(index == Board.Cols - 1) {
                            ++offset;
                            index = 0;
                        }
                        piece.Draw(colors[i], graphics);
                    }
                }
            }
        }
    }
}
