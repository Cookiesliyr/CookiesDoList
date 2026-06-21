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
	public partial class CreateNewTask: Form {
		Task STask;

		public CreateNewTask() { InitializeComponent(); }

		private void CreateNewTask_Load(object sender, EventArgs e) { }
		private void CreateNewTask_FormClosing(object sender, FormClosingEventArgs e) { if (e.CloseReason==CloseReason.UserClosing) { e.Cancel=true; Hide(); Timer2.MainTimer.Enabled=true; } else base.OnFormClosing(e); }

		public void Clear () {
			CheckList.Items.Clear(); CounterList.Items.Clear(); TimerList.Items.Clear();
			CheckRB1.Checked=TimerRB1.Checked=TimerRB3.Checked =true;
			CheckText.Text=CheckDDS.Text=CounterName.Text=CounterDDS.Text=TimerName.Text=TimerDDS.Text="";
		}

		private void TaskOk_Click(object sender, EventArgs e) {

		}

		private void TaskCancel_Click(object sender, EventArgs e) {

		}

		#region Check region
		private void CheckList_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void CheckAdd_Click(object sender, EventArgs e) {

		}

		private void CheckSave_Click(object sender, EventArgs e) {

		}

		private void CheckDel_Click(object sender, EventArgs e) {

		}
		#endregion

		#region Counter region
		private void CounterList_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void CounterAdd_Click(object sender, EventArgs e) {

		}

		private void CounterSave_Click(object sender, EventArgs e) {

		}

		private void CounterDel_Click(object sender, EventArgs e) {

		}
		#endregion

		#region Timer region
		private void TimerList_SelectedIndexChanged(object sender, EventArgs e) {

		}

		private void TimerAdd_Click(object sender, EventArgs e) {

		}

		private void TimerSave_Click(object sender, EventArgs e) {

		}

		private void TimerDel_Click(object sender, EventArgs e) {

		}
		#endregion



		
	}
}
