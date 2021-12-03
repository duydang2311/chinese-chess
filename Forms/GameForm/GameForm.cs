using System;
using System.Windows.Forms;

namespace ChineseChess {
	public partial class GameForm : Form {
		private string redName;
		private bool redIsAI;
		private string blackName;
		private bool blackIsAI;
		public GameForm(string redName = "", string blackName = "") {
			this.redName = redName; 
			this.redIsAI = false;
			this.blackName = blackName;
			this.blackIsAI = false;
			InitializeComponent();
			this.comboBoxRedSide.SelectedIndex = 0;
			this.comboBoxBlackSide.SelectedIndex = 1;
			this.buttonOk.Click += buttonOk_Click;
			this.comboBoxRedSide.SelectedIndexChanged += comboBoxRedSide_SelectedIndexChanged;
			this.comboBoxBlackSide.SelectedIndexChanged += comboBoxBlackSide_SelectedIndexChanged;
			this.checkboxRedAI.CheckedChanged += checkBoxRedAI_CheckedChanged;
			this.checkboxBlackAI.CheckedChanged += checkBoxBlackAI_CheckedChanged;
		}
		public string RedName {
			get => this.redName;
		}
		public Side RedSide {
			get => (Side)this.comboBoxRedSide.SelectedIndex;
		}
		public bool RedIsAI {
			get => this.redIsAI;
		}
		public string BlackName {
			get => this.blackName;
		}
		public Side BlackSide {
			get => (Side)this.comboBoxBlackSide.SelectedIndex;
		}
		public bool BlackIsAI {
			get => this.blackIsAI;
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
		public static GameForm Prompt(Form parent) {
			GameForm form = new GameForm();
			form.ShowDialog(parent);
			return form;
		}
	}
}
