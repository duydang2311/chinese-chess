using System;
using System.Windows.Forms;

namespace ChineseChess {
	public partial class GameForm : Form {
		public GameForm(string redName = "", string blackName = "") {
			InitializeComponent();
			this.textBoxRedName.Text = redName;
			this.textBoxBlackName.Text = blackName;
			this.comboBoxRedSide.SelectedIndex = 0;
			this.comboBoxBlackSide.SelectedIndex = 1;
			this.buttonOk.Click += buttonOk_Click;
			this.comboBoxRedSide.SelectedIndexChanged += comboBoxRedSide_SelectedIndexChanged;
			this.comboBoxBlackSide.SelectedIndexChanged += comboBoxBlackSide_SelectedIndexChanged;
			this.checkboxRedAI.CheckedChanged += checkBoxRedAI_CheckedChanged;
			this.checkboxBlackAI.CheckedChanged += checkBoxBlackAI_CheckedChanged;
		}
		public string RedName {
			get => this.textBoxRedName.Text;
		}
		public Side RedSide {
			get => (Side)this.comboBoxRedSide.SelectedIndex;
		}
		public bool RedIsAI {
			get => this.checkboxRedAI.Checked;
		}
		public string BlackName {
			get => this.textBoxBlackName.Text;
		}
		public Side BlackSide {
			get => (Side)this.comboBoxBlackSide.SelectedIndex;
		}
		public bool BlackIsAI {
			get => this.checkboxBlackAI.Checked;
		}
		private void buttonOk_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.None;
			if(this.textBoxRedName.Text.Length == 0) {
				MessageBox.Show("Red player's name must not be empty");
				return;
			}
			if(this.textBoxBlackName.Text.Length == 0) {
				MessageBox.Show("Black player's name must not be empty");
				return;
			}
			if(this.comboBoxRedSide.SelectedIndex == -1) {
				MessageBox.Show("Choose a side for red player");
				return;
			}
			if(this.comboBoxBlackSide.SelectedIndex == -1) {
				MessageBox.Show("Choose a side for black player");
				return;
			}
			this.DialogResult = DialogResult.OK;
		}
		private void comboBoxRedSide_SelectedIndexChanged(object sender, EventArgs e) {
			if(this.comboBoxRedSide.SelectedIndex == (int)Side.Top) {
				this.comboBoxBlackSide.SelectedIndex = (int)Side.Bottom;
			} else if(this.comboBoxRedSide.SelectedIndex == (int)Side.Bottom) {
				this.comboBoxBlackSide.SelectedIndex = (int)Side.Top;
			}
		}
		private void comboBoxBlackSide_SelectedIndexChanged(object sender, EventArgs e) {
			if(this.comboBoxBlackSide.SelectedIndex == (int)Side.Top) {
				this.comboBoxRedSide.SelectedIndex = (int)Side.Bottom;
			} else if(this.comboBoxBlackSide.SelectedIndex == (int)Side.Bottom) {
				this.comboBoxRedSide.SelectedIndex = (int)Side.Top;
			}
		}
		private void checkBoxRedAI_CheckedChanged(object sender, EventArgs e) {
			if(this.checkboxRedAI.Checked) {
				this.checkboxBlackAI.Checked = false;
			} else {
				this.checkboxBlackAI.Checked = true;
			}
		}
		private void checkBoxBlackAI_CheckedChanged(object sender, EventArgs e) {
			if(this.checkboxBlackAI.Checked) {
				this.checkboxRedAI.Checked = false;
			} else {
				this.checkboxRedAI.Checked = true;
			}
		}
	}
}
