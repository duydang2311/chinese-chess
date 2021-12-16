namespace ChineseChess {
    using System.Drawing;
    using System.Windows.Forms;
    public partial class MainForm : Form {
        public const int PlayerProgressBarMaximum = 5000;
        private ProgressBar playerProgressBar;
        private Button playerPreviousButton;
        private Button playerNextButton;
        private Button playerPlayButton;
        private Label playerTrackNameLabel;
        private void CreatePlayerControls() {
            this.ClearPlayerControls();
            this.playerProgressBar = new ProgressBar();
            this.playerProgressBar.Style = ProgressBarStyle.Continuous;
            this.playerProgressBar.ForeColor = Color.Red;
            this.playerProgressBar.Maximum = MainForm.PlayerProgressBarMaximum;
            this.playerProgressBar.AutoSize = false;
            this.playerProgressBar.MouseClick += PlayerProgressBar_OnMouseClicked;
            this.playerProgressBar.MouseWheel += Player_OnMouseWheel;
            this.playerPreviousButton = new Button();
            this.playerPreviousButton.AutoSize = false;
            this.playerPreviousButton.TextAlign = ContentAlignment.MiddleCenter;
            this.playerPreviousButton.FlatStyle = FlatStyle.Flat;
            this.playerPreviousButton.BackgroundImage = ChineseChess.Properties.Resources.previous;
            this.playerPreviousButton.BackgroundImageLayout = ImageLayout.Zoom;
            this.playerPreviousButton.BackColor = Color.Empty;
            this.playerPreviousButton.ForeColor = Color.Empty;
            this.playerPreviousButton.FlatAppearance.BorderSize = 0;
            this.playerPreviousButton.Click += PlayerPreviousButton_OnClicked;
            this.playerNextButton = new Button();
            this.playerNextButton.BackgroundImage = ChineseChess.Properties.Resources.next;
            this.playerNextButton.BackgroundImageLayout = ImageLayout.Zoom;
            this.playerNextButton.AutoSize = false;
            this.playerNextButton.TextAlign = ContentAlignment.MiddleCenter;
            this.playerNextButton.FlatStyle = FlatStyle.Flat;
            this.playerNextButton.BackColor = Color.Empty;
            this.playerNextButton.ForeColor = Color.Empty;
            this.playerNextButton.FlatAppearance.BorderSize = 0;
            this.playerNextButton.Click += PlayerNextButton_OnClicked;
            this.playerPlayButton = new Button();
            this.playerPlayButton.BackgroundImage = ChineseChess.Properties.Resources.play;
            this.playerPlayButton.BackgroundImageLayout = ImageLayout.Zoom;
            this.playerPlayButton.AutoSize = false;
            this.playerPlayButton.TextAlign = ContentAlignment.MiddleCenter;
            this.playerPlayButton.FlatStyle = FlatStyle.Flat;
            this.playerPlayButton.BackColor = Color.Empty;
            this.playerPlayButton.ForeColor = Color.Empty;
            this.playerPlayButton.FlatAppearance.BorderSize = 0;
            this.playerPlayButton.Click += PlayerPlayButton_OnClicked;
            this.playerTrackNameLabel = new Label();
            this.playerTrackNameLabel.AutoSize = false;
            this.playerTrackNameLabel.TextAlign = ContentAlignment.BottomCenter;
            this.playerTrackNameLabel.Text = "DaLAB - Thuong Thuong Vay Thoi feat. Bao Han";

            this.panelStats.Controls.Add(this.playerTrackNameLabel);
            this.panelStats.Controls.Add(this.playerPreviousButton);
            this.panelStats.Controls.Add(this.playerNextButton);
            this.panelStats.Controls.Add(this.playerPlayButton);
            this.panelStats.Controls.Add(this.playerProgressBar);
            this.OrganizePlayerControls();
        }
        private void OrganizePlayerControls() {
            if(this.player is null) return;
            using(Font jhengHei = new Font("Microsoft JhengHei UI", Util.Max(this.StatsCellHeight * 0.07f, 0.25f), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)) {
                this.playerTrackNameLabel.Font = jhengHei;
            }
            this.playerProgressBar.Size = new Size((int)(this.panelStats.Width * 0.7f), this.StatsCellHeight / 8);
            this.playerProgressBar.Location = new Point((int)(this.panelStats.Width * 0.15f), this.StatsCellHeight + this.StatsCellGap + this.StatsCellHeight / 2 + 5);
            this.playerPreviousButton.Size = new Size(this.StatsCellHeight / 8, this.StatsCellHeight / 8);
            this.playerPreviousButton.Location = new Point((int)(this.panelStats.Width * 0.15f) - this.StatsCellHeight / 8 - 5, this.StatsCellHeight + this.StatsCellGap + this.StatsCellHeight / 2 + 5);
            this.playerNextButton.Size = new Size(this.StatsCellHeight / 8, this.StatsCellHeight / 8);
            this.playerNextButton.Location = new Point((int)(this.panelStats.Width * 0.85f) + 5, this.StatsCellHeight + this.StatsCellGap + this.StatsCellHeight / 2 + 5);
            this.playerPlayButton.Size = new Size(this.StatsCellHeight / 8, this.StatsCellHeight / 8);
            this.playerPlayButton.Location = new Point(this.panelStats.Width / 2 - this.StatsCellHeight / 16, this.StatsCellHeight + this.StatsCellGap + this.StatsCellHeight / 2 + this.StatsCellHeight / 8 + 5 + 5);
            this.playerTrackNameLabel.Size = new Size((int)(this.panelStats.Width * 0.7f), this.StatsCellHeight / 2);
            this.playerTrackNameLabel.Location = new Point((int)(this.panelStats.Width * 0.15f), this.StatsCellHeight + this.StatsCellGap);
        }
        private void ClearPlayerControls() {
            this.panelStats.Controls.Remove(this.playerProgressBar);
            this.panelStats.Controls.Remove(this.playerNextButton);
            this.panelStats.Controls.Remove(this.playerPreviousButton);
            if(this.playerProgressBar is not null) {
                this.playerProgressBar.Dispose();
                this.playerProgressBar = null;
            }
            if(this.playerNextButton is not null) {
                this.playerNextButton.Dispose();
                this.playerNextButton = null;
            }
            if(this.playerPreviousButton is not null) {
                this.playerPreviousButton.Dispose();
                this.playerPreviousButton = null;
            }
        }
    }
}