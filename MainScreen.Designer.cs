
namespace BatchFileRenamer {
	partial class MainScreen {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && ( components != null )) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.textDir = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.action4 = new System.Windows.Forms.RadioButton();
			this.action0 = new System.Windows.Forms.RadioButton();
			this.action1 = new System.Windows.Forms.RadioButton();
			this.action3 = new System.Windows.Forms.RadioButton();
			this.action2 = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.textFind = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textReplace = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.checkBoxRecursive = new System.Windows.Forms.CheckBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textSet = new System.Windows.Forms.TextBox();
			this.actionDesc = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.toolTipRecursive = new System.Windows.Forms.ToolTip(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(246, 56);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 0;
			this.btnBrowse.Text = "Browse...";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// textDir
			// 
			this.textDir.Location = new System.Drawing.Point(12, 58);
			this.textDir.Name = "textDir";
			this.textDir.Size = new System.Drawing.Size(228, 20);
			this.textDir.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Select or enter a directory:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.action4);
			this.groupBox1.Controls.Add(this.action0);
			this.groupBox1.Controls.Add(this.action1);
			this.groupBox1.Controls.Add(this.action3);
			this.groupBox1.Controls.Add(this.action2);
			this.groupBox1.Location = new System.Drawing.Point(12, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 209);
			this.groupBox1.TabIndex = 5;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Action:";
			// 
			// action4
			// 
			this.action4.AutoSize = true;
			this.action4.Location = new System.Drawing.Point(6, 110);
			this.action4.Name = "action4";
			this.action4.Size = new System.Drawing.Size(105, 17);
			this.action4.TabIndex = 2;
			this.action4.Text = "Set file extension";
			this.action4.UseVisualStyleBackColor = true;
			this.action4.CheckedChanged += new System.EventHandler(this.action4_CheckedChanged);
			// 
			// action0
			// 
			this.action0.AutoSize = true;
			this.action0.Checked = true;
			this.action0.Location = new System.Drawing.Point(6, 19);
			this.action0.Name = "action0";
			this.action0.Size = new System.Drawing.Size(55, 17);
			this.action0.TabIndex = 19;
			this.action0.TabStop = true;
			this.action0.Text = "(none)";
			this.action0.UseVisualStyleBackColor = true;
			this.action0.CheckedChanged += new System.EventHandler(this.action0_CheckedChanged);
			// 
			// action1
			// 
			this.action1.AutoSize = true;
			this.action1.Location = new System.Drawing.Point(6, 42);
			this.action1.Name = "action1";
			this.action1.Size = new System.Drawing.Size(135, 17);
			this.action1.TabIndex = 0;
			this.action1.Text = "Find/Replace file name";
			this.action1.UseVisualStyleBackColor = true;
			this.action1.CheckedChanged += new System.EventHandler(this.action1_CheckedChanged);
			// 
			// action3
			// 
			this.action3.AutoSize = true;
			this.action3.Location = new System.Drawing.Point(6, 87);
			this.action3.Name = "action3";
			this.action3.Size = new System.Drawing.Size(86, 17);
			this.action3.TabIndex = 15;
			this.action3.Text = "Set file name";
			this.action3.UseVisualStyleBackColor = true;
			this.action3.CheckedChanged += new System.EventHandler(this.action3_CheckedChanged);
			// 
			// action2
			// 
			this.action2.AutoSize = true;
			this.action2.Location = new System.Drawing.Point(6, 64);
			this.action2.Name = "action2";
			this.action2.Size = new System.Drawing.Size(154, 17);
			this.action2.TabIndex = 1;
			this.action2.Text = "Find/Replace file extension";
			this.action2.UseVisualStyleBackColor = true;
			this.action2.CheckedChanged += new System.EventHandler(this.action2_CheckedChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(108, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(194, 25);
			this.label2.TabIndex = 6;
			this.label2.Text = "Easy File Renamer";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textFind
			// 
			this.textFind.Location = new System.Drawing.Point(18, 312);
			this.textFind.Name = "textFind";
			this.textFind.Size = new System.Drawing.Size(156, 20);
			this.textFind.TabIndex = 8;
			this.textFind.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(15, 296);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Find:";
			this.label3.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 341);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(50, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Replace:";
			this.label4.Visible = false;
			// 
			// textReplace
			// 
			this.textReplace.Location = new System.Drawing.Point(18, 357);
			this.textReplace.Name = "textReplace";
			this.textReplace.Size = new System.Drawing.Size(156, 20);
			this.textReplace.TabIndex = 11;
			this.textReplace.Visible = false;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(311, 415);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 13;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// checkBoxRecursive
			// 
			this.checkBoxRecursive.AutoSize = true;
			this.checkBoxRecursive.Location = new System.Drawing.Point(18, 383);
			this.checkBoxRecursive.Name = "checkBoxRecursive";
			this.checkBoxRecursive.Size = new System.Drawing.Size(74, 17);
			this.checkBoxRecursive.TabIndex = 14;
			this.checkBoxRecursive.Text = "Recursive";
			this.toolTipRecursive.SetToolTip(this.checkBoxRecursive, "When checked, will parse sub-directories of the specified directory.");
			this.checkBoxRecursive.UseVisualStyleBackColor = true;
			this.checkBoxRecursive.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(215, 296);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(26, 13);
			this.label5.TabIndex = 16;
			this.label5.Text = "Set:";
			this.label5.Visible = false;
			// 
			// textSet
			// 
			this.textSet.Location = new System.Drawing.Point(218, 312);
			this.textSet.Name = "textSet";
			this.textSet.Size = new System.Drawing.Size(156, 20);
			this.textSet.TabIndex = 15;
			this.textSet.Visible = false;
			// 
			// actionDesc
			// 
			this.actionDesc.Location = new System.Drawing.Point(6, 21);
			this.actionDesc.Name = "actionDesc";
			this.actionDesc.Size = new System.Drawing.Size(156, 185);
			this.actionDesc.TabIndex = 17;
			this.actionDesc.Text = "Select an action to perform.";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.actionDesc);
			this.groupBox2.Location = new System.Drawing.Point(218, 84);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(168, 209);
			this.groupBox2.TabIndex = 18;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Action Description";
			// 
			// MainScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(398, 450);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textSet);
			this.Controls.Add(this.checkBoxRecursive);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textReplace);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textFind);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textDir);
			this.Controls.Add(this.btnBrowse);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainScreen";
			this.Text = "EasyFileRenamer";
			this.Load += new System.EventHandler(this.MainScreen_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.TextBox textDir;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton action2;
		private System.Windows.Forms.RadioButton action1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textFind;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textReplace;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.CheckBox checkBoxRecursive;
		private System.Windows.Forms.RadioButton action4;
		private System.Windows.Forms.RadioButton action3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textSet;
		private System.Windows.Forms.RadioButton action0;
		private System.Windows.Forms.Label actionDesc;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ToolTip toolTipRecursive;
	}
}

