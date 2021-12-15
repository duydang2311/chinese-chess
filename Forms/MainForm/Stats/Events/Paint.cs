namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using System.Drawing;
	public partial class MainForm : Form {
        private int CalculateStatsAvatarHeight(Size size) {
            if(size.Height > size.Width / 2) {
                return (size.Width / 2);
            }
            return size.Height;
        }
        private void TopPictureBox_OnPaint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            if(this.game is null || this.topPictureBox is null) {
                return;
            }
            int height = this.CalculateStatsAvatarHeight(this.topPictureBox.Size);
            int y = (this.topPictureBox.Height - height) / 2;
            e.Graphics.DrawImage(ChineseChess.Properties.Resources.avatar_1, 0, y, height, height);
        }
        private void BottomPictureBox_OnPaint(object sender, PaintEventArgs e) {
            base.OnPaint(e);
            if(this.game is null || this.bottomPictureBox is null) {
                return;
            }
            int height = this.CalculateStatsAvatarHeight(this.bottomPictureBox.Size);
            int y = (this.bottomPictureBox.Height - height) / 2;
            e.Graphics.DrawImage(ChineseChess.Properties.Resources.avatar_1, 0, y, height, height);
        }
	}
}
