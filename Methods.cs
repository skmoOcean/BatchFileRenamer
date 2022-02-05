using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace BatchFileRenamer {
	public class Methods {


		public void ProcessAction(int action, String dir, bool recursive, String findText, String replaceText, String setText) {

			SearchOption searchOp;

			// Is it a recursive action?
			if (recursive) {
				searchOp = SearchOption.AllDirectories;
			} else {
				searchOp = SearchOption.TopDirectoryOnly;
			}

			String[] files = Directory.GetFiles(dir, "*", searchOp);

			switch (action) {
				case 0:
					System.Windows.Forms.MessageBox.Show("No action selected!", "Error");
					break;

				case 1:
					String newFileName1 = "";
					int fileCounter1 = 0;

					foreach (string curFile in files) {
						string curFileName = Path.GetFileName(curFile);
						string curDir = Path.GetDirectoryName(curFile);

						if (curFileName.Contains(findText)) {
							newFileName1 = curFileName.Replace(findText, replaceText);
							fileCounter1++;
						}

						File.Move(curDir + "\\" + curFileName, curDir + "\\" + newFileName1);
					}

					System.Windows.Forms.MessageBox.Show("(" + fileCounter1 + ") items modified.");
					break;

				case 2:
					String newFileName2 = "";
					int fileCounter2 = 0;

					foreach (string curFile in files) {
						string curFileName = Path.GetFileName(curFile);
						string curDir = Path.GetDirectoryName(curFile);
						String curFileExension = Path.GetExtension(curFileName);
						String curFileNameNoExtension = Path.GetFileNameWithoutExtension(curFileName);

						if (curFileExension != findText)
							continue;

						newFileName2 = curFileNameNoExtension + replaceText;

						File.Move(curDir + "\\" + curFileName, curDir + "\\" + newFileName2);
						fileCounter2++;
					}

					System.Windows.Forms.MessageBox.Show("(" + fileCounter2 + ") items modified.");
					break;

				case 3:
					String newFileName3 = "";
					int fileCounter3 = 0;
					int counter = 0;

					foreach (string curFile in files) {
						string curFileName = Path.GetFileName(curFile);
						string curDir = Path.GetDirectoryName(curFile);
						String curFileExension = Path.GetExtension(curFileName);

						newFileName3 = setText + "_" + counter.ToString("D5") + curFileExension;

						File.Move(curDir + "\\" + curFileName, curDir + "\\" + newFileName3);
						counter++;
						fileCounter3++;
					}

					System.Windows.Forms.MessageBox.Show("(" + fileCounter3 + ") items modified.");
					break;

				case 4:
					String newFileName4 = "";
					int fileCounter4 = 0;

					foreach (string curFile in files) {
						string curFileName = Path.GetFileName(curFile);
						string curDir = Path.GetDirectoryName(curFile);
						String curFileNameNoExension = Path.GetFileNameWithoutExtension(curFileName);

						newFileName4 = curFileNameNoExension + setText;

						File.Move(curDir + "\\" + curFileName, curDir + "\\" + newFileName4);
						fileCounter4++;
					}

					System.Windows.Forms.MessageBox.Show("(" + fileCounter4 + ") items modified.");
					break;
			}


		}

	}
}
