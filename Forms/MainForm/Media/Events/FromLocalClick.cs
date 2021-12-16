
namespace ChineseChess {
    using System;
    using System.Windows.Forms;
    using System.Threading;
    using System.Threading.Tasks;
    public partial class MainForm : Form {
        private void MediaFromLocal_OnClick(object sender, EventArgs e) {
            using(OpenFileDialog dialog = new OpenFileDialog()) {
                dialog.InitialDirectory = @"F:\archive\duy\";
                dialog.Filter = "audio files (*.mp3,.wav)|*.mp3;*.wav|All files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;
                dialog.Multiselect = true;
                if(dialog.ShowDialog() == DialogResult.OK) {
                    string path = dialog.FileName;
                    if(this.player is null) {
                        this.InitPlayer();
                    } else {
                        this.currentSong = 0;
                    }
                    this.playlist.Clear();
                    this.playlist.AddRange(dialog.FileNames);
                    this.player.Play(this.playlist[0]);
                }
            }
        }
    }
}