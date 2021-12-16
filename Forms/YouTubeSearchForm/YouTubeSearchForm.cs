namespace ChineseChess {
	using System;
	using System.Windows.Forms;
	public partial class YouTubeSearchForm : Form {
		public YouTubeSearchForm() {
			InitializeComponent();
			this.playButton.Click += this.PlayButton_Click;
		}
		public string SearchText {
			get => this.searchTextBox.Text;
		}
		private void PlayButton_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.None;
			if(this.searchTextBox.Text.Length == 0) {
				return;
			}
			this.DialogResult = DialogResult.OK;
		}
	}
}
