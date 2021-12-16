namespace ChineseChess {
    using System.Windows.Forms;
    using System.Drawing;
	public partial class MainForm : Form {
        private PictureBox topPictureBox;
        private Label topNameLabel;
        private Label topTimeLabel;
        private PictureBox bottomPictureBox;
        private Label bottomNameLabel;
        private Label bottomTimeLabel;
        private const float StatsCellHeightPercent = 0.3f;
        private const float StatsPadding = 0.02f;
        private const float StatsCellGapPercent = 0.05f;
        public int StatsCellHeight {
			get => (int)(this.panelStats.Height * MainForm.StatsCellHeightPercent);
        }
        public int StatsCellGap {
			get => (int)(this.panelStats.Height * MainForm.StatsCellGapPercent);
        }
        private void InitStatsControls() {
            if(this.game is null) return;
            this.topPictureBox = new PictureBox();
            this.topPictureBox.Paint += TopPictureBox_OnPaint;
            this.topNameLabel = new Label();
            this.topNameLabel.Text = this.game.SidePlayers[(int)Side.Top].Name;
            this.topNameLabel.TextAlign = ContentAlignment.TopLeft;
            this.topTimeLabel = new Label();
            this.topTimeLabel.Text = "09:59";
            this.topTimeLabel.TextAlign = ContentAlignment.BottomLeft;

            this.bottomPictureBox = new PictureBox();
            this.bottomPictureBox.Paint += BottomPictureBox_OnPaint;
            this.bottomNameLabel = new Label();
            this.bottomNameLabel.Text = this.game.SidePlayers[(int)Side.Bottom].Name;
            this.bottomNameLabel.TextAlign = ContentAlignment.TopLeft;
            this.bottomTimeLabel = new Label();
            this.bottomTimeLabel.Text = "10:00";
            this.bottomTimeLabel.TextAlign = ContentAlignment.BottomLeft;

            this.panelStats.Controls.Add(this.topNameLabel);
            this.panelStats.Controls.Add(this.topTimeLabel);
            this.panelStats.Controls.Add(this.topPictureBox);
            this.panelStats.Controls.Add(this.bottomNameLabel);
            this.panelStats.Controls.Add(this.bottomTimeLabel);
            this.panelStats.Controls.Add(this.bottomPictureBox);
            this.OrganizeStatsControls();
        }
        private void OrganizeStatsControls() {
            if(this.game is null) return;
            int width = this.panelStats.Size.Width;
            int height = this.panelStats.Size.Height;
            int paddingWidth = (int)(width * MainForm.StatsPadding);
            int paddingHeight = 0;
            Size size;
            using(Font jhengHeiName = new Font("Microsoft JhengHei UI", Util.Max(height * 0.035f, 0.25f), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point),
                jhengHeiTime = new Font("Microsoft JhengHei UI", Util.Max(height * 0.025f, 0.25f), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)) {
                this.topNameLabel.Font = this.bottomNameLabel.Font = jhengHeiName;
                this.topTimeLabel.Font = this.bottomTimeLabel.Font = jhengHeiTime;
            }
            this.topPictureBox.Size = new Size(width - 2 * paddingWidth, this.StatsCellHeight);
            this.topPictureBox.Location = new Point(paddingWidth, paddingHeight);
            this.topNameLabel.Size = new Size(this.topPictureBox.Width / 2, this.topPictureBox.Height / 2);
            this.topTimeLabel.Size = new Size(this.topPictureBox.Width / 2, this.topPictureBox.Height / 2);

            size = TextRenderer.MeasureText(this.topNameLabel.Text, this.topNameLabel.Font);
            size.Height += (size.Height * (int)(size.Width / (this.topNameLabel.Size.Width + 1)));
            size += TextRenderer.MeasureText(this.topTimeLabel.Text, this.topTimeLabel.Font, this.topTimeLabel.Size);

            this.topNameLabel.Location = new Point(
                paddingWidth + this.CalculateStatsAvatarHeight(this.topPictureBox.Size),
                this.topPictureBox.Location.Y + this.topPictureBox.Height / 2 - size.Height / 3
            );
            this.topTimeLabel.Location = new Point(
                paddingWidth + this.CalculateStatsAvatarHeight(this.topPictureBox.Size),
                this.topPictureBox.Location.Y - size.Height / 3
            );

            this.bottomPictureBox.Size = new Size(width - 2 * paddingWidth, this.StatsCellHeight);
            this.bottomPictureBox.Location = new Point(paddingWidth, 2 * (this.StatsCellHeight + this.StatsCellGap));
            this.bottomNameLabel.Size = new Size(this.bottomPictureBox.Width / 2, this.bottomPictureBox.Height / 2);
            this.bottomTimeLabel.Size = new Size(this.bottomPictureBox.Width / 2, this.bottomPictureBox.Height / 2);

            size = TextRenderer.MeasureText(this.bottomNameLabel.Text, this.bottomNameLabel.Font);
            size.Height += (size.Height * (int)(size.Width / (this.bottomNameLabel.Size.Width + 1)));
            // size += TextRenderer.MeasureText(this.bottomTimeLabel.Text, this.bottomTimeLabel.Font, this.bottomTimeLabel.Size);

            this.bottomNameLabel.Location = new Point(
                paddingWidth + this.CalculateStatsAvatarHeight(this.bottomPictureBox.Size),
                this.bottomPictureBox.Location.Y + this.bottomPictureBox.Height / 2 - size.Height / 3
            );
            this.bottomTimeLabel.Location = new Point(
                paddingWidth + this.CalculateStatsAvatarHeight(this.bottomPictureBox.Size),
                this.bottomPictureBox.Location.Y - size.Height / 3
            );
        }
        private void InitStats() {
            if(this.game is null) return;
            this.ClearStatsControls();
            this.game.SidePlayers[(int)Side.Top].Timer.Elapsed += OnTopTimerElapsed;
            this.game.SidePlayers[(int)Side.Bottom].Timer.Elapsed += OnBottomTimerElapsed;
            this.InitStatsControls();
        }
        private void ClearStatsControls() {
            this.panelStats.SuspendLayout();
            if(this.topPictureBox is not null) {
                this.panelStats.Controls.Remove(this.topPictureBox);
                this.topPictureBox = null;
            }
            if(this.topNameLabel is not null) {
                this.panelStats.Controls.Remove(this.topNameLabel);
                this.topNameLabel = null;
            }
            if(this.topTimeLabel is not null) {
                this.panelStats.Controls.Remove(this.topTimeLabel);
                this.topTimeLabel = null;
            }
            if(this.bottomPictureBox is not null) {
                this.panelStats.Controls.Remove(this.bottomPictureBox);
                this.bottomPictureBox = null;
            }
            if(this.bottomNameLabel is not null) {
                this.panelStats.Controls.Remove(this.bottomNameLabel);
                this.bottomNameLabel = null;
            }
            if(this.bottomTimeLabel is not null) {
                this.panelStats.Controls.Remove(this.bottomTimeLabel);
                this.bottomTimeLabel = null;
            }
            this.panelStats.ResumeLayout();
        }
	}
}
