namespace ChineseChess {
	using System.Windows.Forms;
    public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
			this.menuItemGame_New.Click += Game_OnNew;
			this.mediaFromLocalMenuItem.Click += MediaFromLocal_OnClick;
			this.mediaFromYouTubeMenuItem.Click += MediaFromYouTube_OnClick;
			this.Resize += MainForm_OnResize;
			this.panelStats.SizeChanged += PanelStats_OnSizeChanged;
		}
	}
}
