using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatchFileRenamer {


	public partial class MainScreen : Form {

		Methods methods;

		public static bool debugMode = false;
		public static int action = 0;

		public MainScreen() {
			InitializeComponent();

			methods = new Methods();

		}

		private void MainScreen_Load(object sender, EventArgs e) {

		}

		private void btnBrowse_Click(object sender, EventArgs e) {
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK) {
				textDir.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void btnStart_Click(object sender, EventArgs e) {

			int curAction = action;
			String dir = textDir.Text;
			bool recursive = checkBoxRecursive.Checked;
			String findText = textFind.Text;
			String replaceText = textReplace.Text;
			String setText = textSet.Text;

			methods.ProcessAction(curAction, dir, recursive, findText, replaceText, setText);
		}

		private void action0_CheckedChanged(object sender, EventArgs e) {
			if (action0.Checked) {
				actionDesc.Text = "Select an action to perform.";
				action = 0;

				// Hide all
				label5.Visible = false;
				textSet.Visible = false;
				label3.Visible = false;
				label4.Visible = false;
				textFind.Visible = false;
				textReplace.Visible = false;
				checkBoxRecursive.Visible = false;
			}
		}

		private void action1_CheckedChanged(object sender, EventArgs e) {
			if (action1.Checked) {
				actionDesc.Text = "Find and replace within a file name.\n\n(Note: File names are case-sensitive)";
				action = 1;

				// Hide "Set"
				label5.Visible = false;
				textSet.Visible = false;

				// Show "Find/Replace"
				label3.Visible = true;
				label4.Visible = true;
				textFind.Visible = true;
				textReplace.Visible = true;
				checkBoxRecursive.Visible = true;
			}
		}

		private void action2_CheckedChanged(object sender, EventArgs e) {
			if (action2.Checked) {
				actionDesc.Text = "Find and replace a file extension, make sure to include the period.\n(Example: .mp4, .jpg, .png)\n\n(Note: This is not a file conversion, file extensions are case-sensitive)";
				action = 2;

				// Hide "Set"
				label5.Visible = false;
				textSet.Visible = false;

				// Show "Find/Replace"
				label3.Visible = true;
				label4.Visible = true;
				textFind.Visible = true;
				textReplace.Visible = true;
				checkBoxRecursive.Visible = true;
			}
		}

		private void action3_CheckedChanged(object sender, EventArgs e) {
			if (action3.Checked) {
				actionDesc.Text = "Sets file name for all files in specified directory (and recursive if selected) and adds incrementing file number.";
				action = 3;

				// Hide "Find/Replace"
				label3.Visible = false;
				label4.Visible = false;
				textFind.Visible = false;
				textReplace.Visible = false;

				// Show "Set"
				label5.Visible = true;
				textSet.Visible = true;
				checkBoxRecursive.Visible = true;
			}
		}

		private void action4_CheckedChanged(object sender, EventArgs e) {
			if (action4.Checked) {
				actionDesc.Text = "Sets file extension for all files in specified directory (and recursive if selected).\n\n(Note: This is not a file conversion)";
				action = 4;

				// Hide "Find/Replace"
				label3.Visible = false;
				label4.Visible = false;
				textFind.Visible = false;
				textReplace.Visible = false;

				// Show "Set"
				label5.Visible = true;
				textSet.Visible = true;
				checkBoxRecursive.Visible = true;
			}
		}
	}
}
