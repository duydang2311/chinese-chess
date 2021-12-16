namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    public partial class MainForm : Form {
        private void MediaFromYouTube_OnClick(object sender, EventArgs e) {
            using(YouTubeSearchForm form = new YouTubeSearchForm()) {
                switch(form.ShowDialog(this)) {
                    case DialogResult.OK: {
                        if(this.web is null || this.web.IsDisposed) {
                            this.InitWeb();
                        }
                        this.PlayYouTube(form.SearchText);
                        break;
                    }
                }
            }
        }
    }
}