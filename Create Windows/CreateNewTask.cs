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
		TPTask STask;

		public CreateNewTask() { InitializeComponent(); }

		private void CreateNewTask_Load(object sender, EventArgs e) { }
		private void CreateNewTask_FormClosing(object sender, FormClosingEventArgs e) { if (e.CloseReason==CloseReason.UserClosing) { e.Cancel=true; Hide(); Timer2.MainTimer.Enabled=true; } else base.OnFormClosing(e); }

		public void Clear (bool newTask = false) {
			CheckList.Items.Clear(); CounterList.Items.Clear(); TimerList.Items.Clear();
			CheckRB1.Checked=TimerRB1.Checked=TimerRB3.Checked =true;
			CheckText.Text=CheckDDS.Text=CounterName.Text=CounterDDS.Text=TimerName.Text=TimerDDS.Text="";
			if (newTask) STask=new TPTask();
		}

		public void EditTask (TPTask TargetTask) {
			Clear(); STask= TargetTask.Clone();
			// Todo: need to make the Ok button do editing instead of adding a new task
			// might need to add an update function to TPTask instead of replace it with new object
		}

		private void TaskOk_Click(object sender, EventArgs e) {

		}

		private void TaskCancel_Click(object sender, EventArgs e) {

		}

		#region Check region
		private void CheckList_SelectedIndexChanged(object sender, EventArgs e) {
			if (CheckList.SelectedIndex<0) return;
			char R = STask.CheckData[CheckList.SelectedIndex][0];
			CheckText.Text=STask.CheckData[CheckList.SelectedIndex].Substring(1);
			CheckDDS.Text=STask.CheckDDS[CheckList.SelectedIndex];
		}

		private void CheckAdd_Click(object sender, EventArgs e) {
			if (CheckText.Text=="") { CheckText.BackColor=Color.Red; return; }
			STask.CheckData.Add((CheckRB1.Checked? "0":"1") + CheckText.Text);
			STask.CheckDDS.Add(CheckDDS.Text);
			CheckList.Items.Add(CheckText.Text);
			CheckReinitalize();
		}

		private void CheckSave_Click(object sender, EventArgs e) {
			if (CheckList.SelectedIndex<0) return;
			STask.CheckData[CheckList.SelectedIndex]=(CheckRB1.Checked ? "0" : "1")+CheckText.Text;
			STask.CheckDDS[CheckList.SelectedIndex]=CheckText.Text;
			CheckReinitalize();
		}

		private void CheckDel_Click(object sender, EventArgs e) {
			if (CheckList.SelectedIndex<0) return;
			STask.CheckData.RemoveAt(CheckList.SelectedIndex);
			STask.CheckDDS.RemoveAt(CheckList.SelectedIndex);
			CheckReinitalize();
		}

		private void CheckReinitalize() {
			CheckList.SelectedIndex=-1; CheckRB1.Checked=true; CheckText.Text=CheckDDS.Text=""; CheckText.BackColor=Color.White;
		}

		#endregion

		#region Counter region
		private void CounterList_SelectedIndexChanged(object sender, EventArgs e) {
			if (CounterList.SelectedIndex<0) return;
			CounterName.Text = STask.CountersName[CounterList.SelectedIndex];
			CounterDDS.Text = STask.CountersDDS[CounterList.SelectedIndex];
		}

		private void CounterAdd_Click(object sender, EventArgs e) {
			if (CounterName.Text=="") { CounterName.BackColor=Color.Red; return; }
			STask.CountersValue.Add(0);
			STask.CountersName.Add(CounterName.Text);
			STask.CountersDDS.Add(CounterDDS.Text);
			CounterList.Items.Add(CounterName.Text);
			CounterReinitalize();
		}

		private void CounterSave_Click(object sender, EventArgs e) {
			if (CounterList.SelectedIndex<0) return;
			STask.CountersName[CounterList.SelectedIndex]=CounterName.Text;
			STask.CountersDDS[CounterList.SelectedIndex]=CounterDDS.Text;
			CounterReinitalize();
		}

		private void CounterDel_Click(object sender, EventArgs e) {
			if (CounterList.SelectedIndex<0) return;
			STask.CountersName.RemoveAt(CounterList.SelectedIndex);
			STask.CountersDDS.RemoveAt(CounterList.SelectedIndex);
			CounterList.Items.RemoveAt(CounterList.SelectedIndex);
			CounterReinitalize();
		}

		private void CounterReinitalize() {
			CounterList.SelectedIndex=-1; CounterName.Text=CounterDDS.Text=""; CounterName.BackColor=Color.White;
		}
		#endregion

		#region Timer region
		private void TimerList_SelectedIndexChanged(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			TimerValue.Value = STask.TimersValue[TimerList.SelectedIndex];
			TimerName.Text = STask.TimersName[TimerList.SelectedIndex];
			TimerDDS.Text = STask.TimersDDS[TimerList.SelectedIndex];
			// TimerRB1.Checked = (STask.TimeType[TimerList.SelectedIndex] & 1);
			// TimerRB3.Checked = (STask.TimeType[TimerList.SelectedIndex] & 2);
		}

		private void TimerAdd_Click(object sender, EventArgs e) {
			if (TimerName.Text=="") return;
			//STask.TimersValue= long.Parse( TimerValue.Value); // find a way to cast it <_<;
			STask.TimersName.Add(TimerName.Text);
			STask.TimersDDS.Add(TimerDDS.Text);
			STask.TimeType.Add((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2)); // hmmm fix it
			TimerReinitalize();
		}

		private void TimerSave_Click(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			//STask.TimersValue[TimerList.SelectedIndex]=TimerValue.Value;
			STask.TimersName[TimerList.SelectedIndex]=TimerName.Text;
			STask.TimersDDS[TimerList.SelectedIndex]=TimerDDS.Text;
			STask.TimeType[TimerList.SelectedIndex]= (TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2);

			TimerReinitalize();
		}

		private void TimerDel_Click(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			STask.TimersValue.RemoveAt(TimerList.SelectedIndex);
			STask.TimersName.RemoveAt(TimerList.SelectedIndex);
			STask.TimersDDS.RemoveAt(TimerList.SelectedIndex);
			STask.TimeType.RemoveAt(TimerList.SelectedIndex);
			TimerList.Items.RemoveAt(TimerList.SelectedIndex);
			TimerReinitalize();

		}

		private void TimerReinitalize() {
			TimerList.SelectedIndex=-1; TimerName.Text=TimerDDS.Text=""; TimerRB1.Checked=TimerRB3.Checked=true;
		}

		#endregion



		
	}
}
