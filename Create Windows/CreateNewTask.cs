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
		public static int CurTaskBar = 0;
		TPTask STask;

		public CreateNewTask() { InitializeComponent(); }

		private void CreateNewTask_Load(object sender, EventArgs e) { }
		private void CreateNewTask_FormClosing(object sender, FormClosingEventArgs e) { if (e.CloseReason==CloseReason.UserClosing) { e.Cancel=true; Hide(); Timer2.MainTimer.Enabled=true; } else base.OnFormClosing(e); }

		public void Clear (bool newTask = false) {
			CheckList.Items.Clear(); CounterList.Items.Clear(); TimerList.Items.Clear();
			TaskName.BackColor=Color.White;
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
			// This should add or edit the Task in the selected TaskTab
			if (TaskName.Text == "") { TaskName.BackColor=Color.Red; return; }
			Timer2.CurTProgra.TaskTabRAr[CurTaskBar].TaskAr.Add(STask.Clone(TaskName.Text));
			Timer2.MainTimer.GenerateTaskGUI(CurTaskBar, Timer2.CurTProgra.TaskTabRAr[CurTaskBar].TaskAr.Count-1);
			Timer2.MainTimer.EnterEditMode();
			Hide();
		}

		private void TaskCancel_Click(object sender, EventArgs e) {
			Hide(); Clear();
		}

		#region Check region
		private void CheckList_SelectedIndexChanged(object sender, EventArgs e) {
			if (CheckList.SelectedIndex<0) return;
			char R = STask.CheckData[CheckList.SelectedIndex][0];
			if (R=='0') CheckRB1.Checked=true; else CheckRB2.Checked=true;
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
			STask.CheckDDS[CheckList.SelectedIndex]=CheckDDS.Text;
			CheckReinitalize();
		}

		private void CheckDel_Click(object sender, EventArgs e) {
			if (CheckList.SelectedIndex<0) return;
			STask.CheckData.RemoveAt(CheckList.SelectedIndex);
			STask.CheckDDS.RemoveAt(CheckList.SelectedIndex);
			CheckList.Items.RemoveAt(CheckList.SelectedIndex);
			CheckReinitalize();
		}

		private void CheckReinitalize() {
			CheckList.SelectedIndex=-1; CheckRB1.Checked=true; CheckText.Text=CheckDDS.Text=""; CheckText.BackColor=Color.White;
		}

		#endregion

		#region Counter region
		private void CounterList_SelectedIndexChanged(object sender, EventArgs e) {
			if (CounterList.SelectedIndex<0) return;
			int k = 0; CounterToVal.Value=int.Parse(TK.Token(STask.CountersName[CounterList.SelectedIndex], ref k, '_'));
			CounterName.Text = TK.Token(STask.CountersName[CounterList.SelectedIndex], ref k, '\r');
			CounterDDS.Text = STask.CountersDDS[CounterList.SelectedIndex];
		}

		private void CounterAdd_Click(object sender, EventArgs e) {
			if (CounterName.Text=="") { CounterName.BackColor=Color.Red; return; }
			STask.CountersValue.Add(0);
			STask.CountersName.Add(CounterToVal.Value.ToString() + "_" + CounterName.Text);
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
			CounterList.SelectedIndex=-1; CounterName.Text=CounterDDS.Text=""; CounterToVal.Value=0; CounterName.BackColor=Color.White;
		}
		#endregion

		#region Timer region
		private void TimerList_SelectedIndexChanged(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			TimerValue.Value = STask.DefaultTimersValue[TimerList.SelectedIndex];
			TimerName.Text   = STask.TimersName[TimerList.SelectedIndex].Substring(2);
			TimerDDS.Text    = STask.TimersDDS[TimerList.SelectedIndex];
			int TimerType = int.Parse(STask.TimersName[TimerList.SelectedIndex][0].ToString());
			if ((TimerType&1)==1) TimerRB2.Checked=true; else TimerRB1.Checked=true;
			if ((TimerType&2)==2) TimerRB4.Checked=true; else TimerRB3.Checked=true;
		}

		private void TimerAdd_Click(object sender, EventArgs e) {
			if (TimerName.Text=="") { TimerName.BackColor=Color.Red; return; }
			System.Diagnostics.Debug.WriteLine("Time Val = "+Convert.ToInt64(TimerValue.Value));
			STask.TimersValue.Add(0);
			STask.DefaultTimersValue.Add(Convert.ToInt64 (TimerValue.Value));

			STask.TimersName.Add( ((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2)) + "_" + TimerName.Text);
			STask.TimersDDS.Add(TimerDDS.Text);
			//STask.TimeType.Add((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2)); // hmmm fix it
			TimerList.Items.Add(TimerName.Text);
			TimerReinitalize();
		}

		private void TimerSave_Click(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			STask.DefaultTimersValue[TimerList.SelectedIndex]=Convert.ToInt64(TimerValue.Value);
			STask.TimersName[TimerList.SelectedIndex]=TimerName.Text;
			STask.TimersDDS[TimerList.SelectedIndex]=TimerDDS.Text;
			//STask.TimeType[TimerList.SelectedIndex]= (TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2);

			TimerReinitalize();
		}

		private void TimerDel_Click(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			STask.DefaultTimersValue.RemoveAt(TimerList.SelectedIndex);
			STask.TimersName.RemoveAt(TimerList.SelectedIndex);
			STask.TimersDDS.RemoveAt(TimerList.SelectedIndex);
			//STask.TimeType.RemoveAt(TimerList.SelectedIndex);
			TimerList.Items.RemoveAt(TimerList.SelectedIndex);
			TimerReinitalize();

		}

		private void TimerReinitalize() {
			TimerList.SelectedIndex=-1; TimerName.Text=TimerDDS.Text=""; TimerRB1.Checked=TimerRB3.Checked=true;TimerName.BackColor=Color.White;
		}

		#endregion
		
	}
}
