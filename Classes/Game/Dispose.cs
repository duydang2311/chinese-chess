
using System.Windows.Forms;

namespace ChineseChess {
    partial class Game : PictureBox {
		protected override void Dispose(bool disposing) {
			if(disposing) {
				this.panel.Controls.Remove(this);
				this.panel.Resize -= this.Panel_Resize;
				this.panel = null;
                this.sidePlayers = null;
                this.sideColors = null;
                this.board = null;
			}
			base.Dispose(disposing);
		}
    }
}