namespace ChineseChess {
    using System.Windows.Forms;
	using CefSharp;
	public partial class MainForm : Form {
        private void Web_OnLoadingStateChanged(object sender, LoadingStateChangedEventArgs e) {
            if(e.IsLoading) {
                this.web.Visible = false;
            } else {
                this.web.Visible = true;
            }
        }
    }
}