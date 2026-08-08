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
		public static int CurTaskBar = 0, CurTaskN = 0;

		TPTask STask;

		public CreateNewTask() { InitializeComponent(); }

		private void CreateNewTask_Load(object sender, EventArgs e) { }
		private void CreateNewTask_FormClosing(object sender, FormClosingEventArgs e) { if (e.CloseReason==CloseReason.UserClosing) { e.Cancel=true; Hide(); Timer2.ReturnToTimer(); } else base.OnFormClosing(e); }

		public void Clear(bool newTask = false) {
			CheckList.Items.Clear(); CounterList.Items.Clear(); TimerList.Items.Clear();
			TaskName.BackColor=Color.White; TaskResetRB2.Checked=true;
			CheckRB1.Checked=TimerRB1.Checked=TimerRB3.Checked=true;
			TaskResetDay1.Checked=TaskResetDay2.Checked=TaskResetDay3.Checked=TaskResetDay4.Checked=TaskResetDay5.Checked=TaskResetDay6.Checked=TaskResetDay7.Checked=false;
			TaskResetDP.Value =new DateTime(DateTime.Today.Add(new TimeSpan(10,0,0)).Ticks);
			TaskExpireDP.Checked=false; TaskExpireDP.Value = DateTime.Today;

			TaskName.Text=TaskDDS.Text=CheckText.Text=CheckDDS.Text=CounterName.Text=CounterDDS.Text=TimerName.Text=TimerDDS.Text="";
			if (newTask) STask=new TPTask();
		}

		public void EditTask(TPTask TargetTask) {
			Clear(); STask=TargetTask.Clone(); TaskOk.Text="Edit";
			TaskResetDay1.Checked=(STask.Days&1)==1; TaskResetDay2.Checked=(STask.Days&2)==2; TaskResetDay3.Checked=(STask.Days&4)==4; TaskResetDay4.Checked=(STask.Days&8)==8; TaskResetDay5.Checked=(STask.Days&16)==16; TaskResetDay6.Checked=(STask.Days&32)==32; TaskResetDay7.Checked=(STask.Days&64)==64;
			TaskResetDP.Value = new DateTime(DateTime.Today.Add(new TimeSpan(STask.ResetTime.Item1,STask.ResetTime.Item2, 0)).Ticks);
			TaskResetRB1.Checked=(STask.Days>=0);

			TaskName.Text=STask.ID; TaskDDS.Text=STask.DDS; TaskName.BackColor=STask.TaskColor;
			TaskExpireDP.Checked = STask.Expire.HasValue; if (STask.Expire.HasValue) TaskExpireDP.Value=STask.Expire.Value;

			foreach (string C in STask.CheckData)    { CheckList.Items.Add(C.Substring(1)); }
			foreach (string C in STask.CountersName) { CounterList.Items.Add(C.Substring(C.IndexOf('_')+1)); }
			foreach (string C in STask.TimersName)   { TimerList.Items.Add(C.Substring(2)); }

		}

		// This should add or edit the Task in the selected TaskTab
		private void TaskOk_Click(object sender, EventArgs e) {
			if (TaskName.Text=="") { TaskName.BackColor=Color.Red; return; }
			STask.DDS=TaskDDS.Text;
			STask.Days = (TaskResetRB1.Checked ? (byte) ((TaskResetDay1.Checked? 1 : 0) + (TaskResetDay2.Checked ? 2 : 0) + (TaskResetDay3.Checked ? 4 : 0) + (TaskResetDay4.Checked ? 8 : 0) + (TaskResetDay5.Checked ? 16 : 0) + (TaskResetDay6.Checked ? 32 : 0) + (TaskResetDay7.Checked ? 64 : 0)) : (byte)0 );
			STask.ResetTime = (TaskResetDP.Value.Hour, TaskResetDP.Value.Minute);
			STask.Expire = (TaskExpireDP.Checked ? (DateTime?)TaskExpireDP.Value : null);

			if (TaskOk.Text=="OK") {
				Timer2.CurTProgra.TaskTabRAr[CurTaskBar].TaskAr.Add(STask.Clone(TaskName.Text));
				Timer2.MainTimer.GenerateTaskGUI(CurTaskBar, Timer2.CurTProgra.TaskTabRAr[CurTaskBar].TaskAr.Count-1);
			} else if (TaskOk.Text=="Edit") {
				// seems i need to delete the groupbox with all what's in it and create a new one, wonder if i should add it in same order, and how
				Timer2.CurTProgra.TaskTabRAr[CurTaskBar][CurTaskN]=STask.Clone();
				Timer2.MainTimer.DeleteTaskGUI(CurTaskBar, CurTaskN);
				Timer2.MainTimer.GenerateTaskGUI(CurTaskBar, CurTaskN);
			}

			Timer2.MainTimer.EnterEditMode();
			Hide(); Clear(); Timer2.ReturnToTimer();
		}

		private void TaskCancel_Click(object sender, EventArgs e) {
			Hide(); Clear(); Timer2.ReturnToTimer();
		}

		private void TaskColor_Click(object sender, EventArgs e) {
			if (Timer2.MainTimer.ColorD.ShowDialog()==DialogResult.OK) {
				TaskName.BackColor=Timer2.MainTimer.ColorD.Color;
				STask.TaskColor=Timer2.MainTimer.ColorD.Color;
			}
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
			STask.CheckData.Add((CheckRB1.Checked ? "0" : "1")+CheckText.Text);
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
			CounterName.Text=TK.Token(STask.CountersName[CounterList.SelectedIndex], ref k, '\r');
			CounterDDS.Text=STask.CountersDDS[CounterList.SelectedIndex];
		}

		private void CounterAdd_Click(object sender, EventArgs e) {
			if (CounterName.Text=="") { CounterName.BackColor=Color.Red; return; }
			STask.CountersValue.Add(0);
			STask.CountersName.Add(CounterToVal.Value.ToString()+"_"+CounterName.Text);
			STask.CountersDDS.Add(CounterDDS.Text);
			CounterList.Items.Add(CounterName.Text);
			CounterReinitalize();
		}

		private void CounterSave_Click(object sender, EventArgs e) {
			if (CounterList.SelectedIndex<0) return;
			STask.CountersName[CounterList.SelectedIndex]=CounterToVal.Value.ToString()+"_"+CounterName.Text;
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
		private void TimerRB3_Click(object sender, EventArgs e) { TimerValLabelUpdate(); }
		private void TimerRB4_Click(object sender, EventArgs e) { TimerValLabelUpdate(); }

		private void TimerWav1_CheckedChanged(object sender, EventArgs e) { if (TimerWav1.Checked) { TimerWavPath.Text=""; } }
		private void TimerWav2_CheckedChanged(object sender, EventArgs e) { if (TimerWav2.Checked) { TimerWavPath.Text="Beep"; } }
		private void TimerWav3_MouseClick(object sender, MouseEventArgs e) { if (WFD.ShowDialog()==DialogResult.OK) { TimerWavPath.Text=WFD.FileName; } }


		private void TimerList_SelectedIndexChanged(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			TimerValue.Value=(STask.DefaultTimersValue[TimerList.SelectedIndex]/1000);
			TimerName.Text=STask.TimersName[TimerList.SelectedIndex].Substring(2);
			TimerDDS.Text=STask.TimersDDS[TimerList.SelectedIndex];
			int TimerType = int.Parse(STask.TimersName[TimerList.SelectedIndex][0].ToString());
			if ((TimerType&1)==1) TimerRB2.Checked=true; else TimerRB1.Checked=true;
			if ((TimerType&2)==2) TimerRB4.Checked=true; else TimerRB3.Checked=true;
			TimerValLabelUpdate();
		}

		private void TimerAdd_Click(object sender, EventArgs e) {
			if (TimerName.Text=="") { TimerName.BackColor=Color.Red; return; }

			System.Diagnostics.Debug.WriteLine("Time Val = "+Convert.ToInt64(TimerValue.Value));
			STask.TimersValue.Add(0);
			STask.DefaultTimersValue.Add(Convert.ToInt64(TimerValue.Value)*1000);
			STask.TimersWavPath.Add(TimerWavPath.Text);
			STask.TimersName.Add(((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2))+"_"+TimerName.Text);
			STask.TimersDDS.Add(TimerDDS.Text);
			//STask.TimeType.Add((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2)); // hmmm fix it
			TimerList.Items.Add(TimerName.Text);
			TimerReinitalize();
		}

		private void TimerSave_Click(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			STask.DefaultTimersValue[TimerList.SelectedIndex]=(Convert.ToInt64(TimerValue.Value)*1000);
			STask.TimersName[TimerList.SelectedIndex]=((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2))+"_"+TimerName.Text;
			STask.TimersDDS[TimerList.SelectedIndex]=TimerDDS.Text;
			STask.TimersWavPath[TimerList.SelectedIndex]=TimerWavPath.Text;
			//STask.TimeType[TimerList.SelectedIndex]= (TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2);

			TimerReinitalize();
		}

		private void TimerDel_Click(object sender, EventArgs e) {
			if (TimerList.SelectedIndex<0) return;
			STask.DefaultTimersValue.RemoveAt(TimerList.SelectedIndex);
			STask.TimersValue.RemoveAt(TimerList.SelectedIndex);
			STask.TimersName.RemoveAt(TimerList.SelectedIndex);
			STask.TimersDDS.RemoveAt(TimerList.SelectedIndex);
			STask.TimersWavPath.RemoveAt(TimerList.SelectedIndex);
			//STask.TimeType.RemoveAt(TimerList.SelectedIndex);
			TimerList.Items.RemoveAt(TimerList.SelectedIndex);
			TimerReinitalize();

		}

		private void TimerReinitalize() {
			TimerList.SelectedIndex=-1; TimerName.Text=TimerDDS.Text=""; TimerRB1.Checked=TimerRB3.Checked=true; TimerName.BackColor=Color.White;
		}

		private void TimerValLabelUpdate() {
			TimerValueLabel.Text=(TimerRB3.Checked ? "Timer Start Value (in seconds)" : "Timer Cap Value (in seconds)");
		}
		#endregion
	}
}
