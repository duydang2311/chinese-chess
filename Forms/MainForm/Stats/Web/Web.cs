namespace ChineseChess {
	using System.Drawing;
    using System.Windows.Forms;
    using Google.Apis.YouTube.v3.Data;
	using CefSharp.WinForms;
	using CefSharp;
	public partial class MainForm : Form {
		private const float WebWidthRatio = 560f / 315f;
		private Panel webPanel;
		private ChromiumWebBrowser web;
		public void InitWeb() {
			if(this.web is not null) {
				this.web.Dispose();
				if(this.webPanel is not null) {
					this.webPanel.Controls.Clear();
					this.panelStats.Controls.Remove(this.webPanel);
					this.webPanel.Dispose();
				}
			}
			this.webPanel = new Panel();
			this.web = new ChromiumWebBrowser("about:blank");
			this.web.LoadingStateChanged += Web_OnLoadingStateChanged;
			this.web.Dock = DockStyle.Fill;
			this.panelStats.Controls.Add(this.webPanel);
			this.webPanel.Controls.Add(this.web);
			this.web.Visible = false;
			this.OrganizeWebPanel();
		}
		public void OrganizeWebPanel() {
			if(this.webPanel is null) {
				return;
			}
			this.webPanel.Size = new Size(this.panelStats.Width, this.StatsCellHeight);
			this.webPanel.Location = new Point(0, this.StatsCellHeight + this.StatsCellGap);
		}
		public async void PlayYouTube(string q) {
			SearchListResponse res = await YouTube.Search(q);
			if(res.Items.Count == 0) {
				return;
			}
			string html = @"
				<html>
					<body style='margin: 0; padding: 0;'>
						<iframe style='display: block; margin: 0 auto; height: 100vh; width: calc(100vh / 0.5625);' src='https://www.youtube.com/embed/" + res.Items[0].Id.VideoId + @"' title='YouTube video player' frameborder='0' allow='accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture' allowfullscreen></iframe>
					</body>
				</html>
			";
			this.web.LoadHtml(html);
			// this.web.Focus();
		}
	}
}