using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer2 {
	public partial class CreateNewProgramFile: Form {
		private void CreateNewProgramFile_FormClosing(object sender, FormClosingEventArgs e) { if (e.CloseReason==CloseReason.UserClosing) { e.Cancel=true; Hide(); Timer2.ReturnToTimer(); } else base.OnFormClosing(e); }

		public CreateNewProgramFile() {
			InitializeComponent();

		}

		private void PFCreate_Click(object sender, EventArgs e) {
			if (TPName.Text == "") { TPName.BackColor=Color.Red; return; }
			Timer2.MainTimer.NukeTasksGUI();
			Timer2.CurTProgra = new TProgram(TPName.Text, TPDDS.Text);
			Hide(); Timer2.MainTimer.LoadCurProgram(); Timer2.ReturnToTimer(); TPName.BackColor=Color.White;
		}

		private void PFCancel_Click(object sender, EventArgs e) { TPName.BackColor=Color.White; Hide(); Timer2.ReturnToTimer(); }

		

	}
}
