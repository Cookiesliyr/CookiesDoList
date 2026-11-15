using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Timer2 {

	public partial class QuickEdit: Form {
		public static int TabN, TaskN, ControlN;
		public static TPTask STask;
		private static bool TabChangeFlag = false;

		public QuickEdit() { InitializeComponent(); }
		private void TabMaster_Selecting(object sender, TabControlCancelEventArgs e) { if (!TabChangeFlag) e.Cancel=true; }

		public void Show(int TabIndex, int TabN, int TaskN, int ControlN = -1) {
			STask=Timer2.CurTProgra.TaskTabRAr[TabN][TaskN];
			TabChangeFlag=true; TabMaster.SelectedIndex=TabIndex; TabChangeFlag=false; QuickEdit.TabN=TabN; QuickEdit.TaskN=TaskN; QuickEdit.ControlN=ControlN;
			Location=new Point(Timer2.MainTimer.Location.X-Width-10, Timer2.MainTimer.Location.Y);
			
			switch (TabIndex) {
				case 0:  // Task
				TaskResetDay1.Checked=(STask.Days&1)==1; TaskResetDay2.Checked=(STask.Days&2)==2; TaskResetDay3.Checked=(STask.Days&4)==4; TaskResetDay4.Checked=(STask.Days&8)==8; TaskResetDay5.Checked=(STask.Days&16)==16; TaskResetDay6.Checked=(STask.Days&32)==32; TaskResetDay7.Checked=(STask.Days&64)==64;
				TaskResetDP.Value=new DateTime(DateTime.Today.Add(new TimeSpan(STask.ResetTime.Item1, STask.ResetTime.Item2, 0)).Ticks);
				TaskResetRB1.Checked=(STask.Days>0); TaskResetRB2.Checked=(STask.Days==0);

				TaskName.Text=STask.ID; TaskDDS.Text=STask.DDS; TaskName.BackColor=STask.TaskColor;
				TaskExpireDP.Checked=STask.Expire.HasValue; if (STask.Expire.HasValue) TaskExpireDP.Value=STask.Expire.Value;

				break;

				case 1:  // Todo
				char R = STask.CheckData[ControlN][1];
				if (R=='0') CheckRB1.Checked=true; else CheckRB2.Checked=true;
				CheckText.Text=STask.CheckData[ControlN].Substring(2);
				CheckDDS.Text=STask.CheckDDS[ControlN];
				break;

				case 2:  // Counter
				int k = 0, CounterType = int.Parse(TK.Token(STask.CountersName[ControlN], ref k, '_'));
				if (CounterType==0) CounterRB1.Checked=true; else CounterRB2.Checked=true;
				CounterStartVal.Value=int.Parse(TK.Token(STask.CountersName[ControlN], ref k, '_'));
				CounterToVal.Value=int.Parse(TK.Token(STask.CountersName[ControlN], ref k, '_'));
				CounterName.Text=TK.Token(STask.CountersName[ControlN], ref k, '\r');
				CounterDDS.Text=STask.CountersDDS[ControlN];
				CounterStartVal.Value=STask.CountersValue[ControlN];
				break;

				case 3:  // Timer
				TimerValue.Value=(STask.DefaultTimersValue[ControlN]/1000);
				TimerName.Text=STask.TimersName[ControlN].Substring(2);
				TimerDDS.Text=STask.TimersDDS[ControlN];
				int TimerType = int.Parse(STask.TimersName[ControlN][0].ToString());
				if ((TimerType&1)==1) TimerRB2.Checked=true; else TimerRB1.Checked=true;
				if ((TimerType&2)==2) TimerRB4.Checked=true; else TimerRB3.Checked=true;
				break;
			}
			Show(); Timer2.QuickEditFlag=false;
		}

		private void TaskOk_Click(object sender, EventArgs e) {
			switch (TabMaster.SelectedIndex) {
				case 0:  // Task
				STask.ID=TaskName.Text;
				STask.DDS=TaskDDS.Text;
				STask.Days=(TaskResetRB1.Checked ? (byte)((TaskResetDay1.Checked ? 1 : 0)+(TaskResetDay2.Checked ? 2 : 0)+(TaskResetDay3.Checked ? 4 : 0)+(TaskResetDay4.Checked ? 8 : 0)+(TaskResetDay5.Checked ? 16 : 0)+(TaskResetDay6.Checked ? 32 : 0)+(TaskResetDay7.Checked ? 64 : 0)) : (byte)0);
				STask.ResetTime=(TaskResetDP.Value.Hour, TaskResetDP.Value.Minute);
				STask.Expire=(TaskExpireDP.Checked ? (DateTime?)TaskExpireDP.Value : null);

				Timer2.GBAr[(TabN, TaskN)].Text=TaskName.Text;
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.TDDSAr[(TabN, TaskN)], (TaskDDS.Text!="" ? TaskDDS.Text : "This task have no description"));

				break;

				case 1:  // Todo
				STask.CheckData[ControlN]="0"+(CheckRB1.Checked ? "0" : "1")+CheckText.Text;
				STask.CheckDDS[ControlN]=CheckDDS.Text;

				// Change the button, and flip visiblity 
				if (CheckRB1.Checked) { Timer2.ChAr[(TabN, TaskN)][ControlN].Appearance=Appearance.Button; Timer2.ChAr[(TabN, TaskN)][ControlN].BackColor=Timer2.ChAr[(TabN, TaskN)][ControlN].Checked ? Color.Green : Color.LightGray; } else { Timer2.ChAr[(TabN, TaskN)][ControlN].Appearance=Appearance.Normal; Timer2.ChAr[(TabN, TaskN)][ControlN].BackColor=SystemColors.ControlDark; }
				Timer2.ChAr[(TabN, TaskN)][ControlN].Text=CheckText.Text;
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.ChAr[(TabN, TaskN)][ControlN], CheckDDS.Text);

				break;

				case 2:  // Check
				STask.CountersName[ControlN]=(CounterRB1.Checked ? 0 : 1)+"_"+CounterStartVal.Value+"_"+CounterToVal.Value.ToString()+"_"+CounterName.Text;
				STask.CountersDDS[ControlN]=CounterDDS.Text;
				if (CounterToVal.Value<CounterStartVal.Value) CounterStartVal.Value=CounterToVal.Value;
				Timer2.CBuAr[(TabN, TaskN)][ControlN].Visible=CounterRB1.Checked;
				Timer2.CNUDAr[(TabN, TaskN)][ControlN].Visible=CounterRB2.Checked;

				Timer2.CNUDAr[(TabN, TaskN)][ControlN].Maximum=CounterToVal.Value;
				Timer2.CNUDAr[(TabN, TaskN)][ControlN].Value=CounterStartVal.Value;

				Timer2.CLAr[(TabN, TaskN)][ControlN].Text=CounterName.Text;
				Timer2.CBuAr[(TabN, TaskN)][ControlN].Text=STask.CountersValue[ControlN]+"\\"+CounterToVal.Value.ToString();
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.CBuAr[(TabN, TaskN)][ControlN], "Goal: "+CounterToVal.Value.ToString());
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.CLAr[(TabN, TaskN)][ControlN], CounterName.Text+": "+CounterDDS.Text);
				break;

				case 3:  // Timer
				STask.TimersValue[ControlN]=(TimerRB4.Checked ? Convert.ToInt64(TimerValue.Value)*1000 : 0);
				STask.DefaultTimersValue[ControlN]=(Convert.ToInt64(TimerValue.Value)*1000);
				STask.TimersName[ControlN]=((TimerRB1.Checked ? 0 : 1)+(TimerRB3.Checked ? 0 : 2))+"_"+TimerName.Text;
				STask.TimersDDS[ControlN]=TimerDDS.Text;
				STask.TimersType[ControlN]=TimerRB4.Checked;

				STask.TimersWavPath[ControlN]=TimerWavPath.Text;
				System.Diagnostics.Debug.WriteLine(STask.TimersName[ControlN]);
				// Todo: Make timer value interactive
				// Make audio file selectable

				Timer2.TPBAr[(TabN, TaskN)][ControlN].Visible=TimerRB2.Checked; Timer2.TNAr[(TabN, TaskN)][ControlN].Visible=TimerRB2.Checked;
				Timer2.TLAr[(TabN, TaskN)][ControlN].Visible=TimerRB1.Checked;

				Timer2.TPBAr[(TabN, TaskN)][ControlN].Value=Math.Max(0, Math.Min(100, (int)(STask.TimersValue[ControlN]/(STask.DefaultTimersValue[ControlN]*0.01))));
				Timer2.TNAr[(TabN, TaskN)][ControlN].Text=TimerName.Text;
				Timer2.TLAr[(TabN, TaskN)][ControlN].Text=Text=TimeSpan.FromMilliseconds(STask.TimersValue[ControlN]).ToString(@"hh\:mm\:ss");

				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.TSBuAr[(TabN, TaskN)][ControlN], "Reset the time "+(TimerRB3.Checked ? " to " : " of ")+TimeSpan.FromMilliseconds(STask.DefaultTimersValue[ControlN]).ToString(@"hh\:mm\:ss")+" - "+TimerDDS.Text);
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.TPBAr[(TabN, TaskN)][ControlN], TimerName.Text+": "+TimeSpan.FromMilliseconds(STask.TimersValue[ControlN]).ToString(@"hh\:mm\:ss"));
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.TNAr[(TabN, TaskN)][ControlN], TimerName.Text);
				Timer2.MainTimer.ToolTip.SetToolTip(Timer2.TLAr[(TabN, TaskN)][ControlN], TimerName.Text);
				break;
			}
			Hide(); Clear();
		}

		private void TaskCancel_Click(object sender, EventArgs e) {
			Hide(); Clear();
		}

		public void Clear(bool newTask = false) {
			TaskName.BackColor=Color.White; TaskResetRB2.Checked=true;
			CheckRB1.Checked=TimerRB1.Checked=TimerRB3.Checked=true;
			TaskResetDay1.Checked=TaskResetDay2.Checked=TaskResetDay3.Checked=TaskResetDay4.Checked=TaskResetDay5.Checked=TaskResetDay6.Checked=TaskResetDay7.Checked=false;
			TaskResetDP.Value=new DateTime(DateTime.Today.Add(new TimeSpan(10, 0, 0)).Ticks);
			TaskExpireDP.Checked=false; TaskExpireDP.Value=DateTime.Today;

			TaskName.Text=TaskDDS.Text=CheckText.Text=CheckDDS.Text=CounterName.Text=CounterDDS.Text=TimerName.Text=TimerDDS.Text="";
			if (newTask) STask=new TPTask();
			Timer2.QuickEditFlag=false;
		}

		#region Timer 
		private void TimerRB3_Click(object sender, EventArgs e) { TimerValLabelUpdate(); }
		private void TimerRB4_Click(object sender, EventArgs e) { TimerValLabelUpdate(); }

		private void TimerWav1_CheckedChanged(object sender, EventArgs e) { if (TimerWav1.Checked) { TimerWavPath.Text=""; } }
		private void TimerWav2_CheckedChanged(object sender, EventArgs e) { if (TimerWav2.Checked) { TimerWavPath.Text="Beep"; } }
		private void TimerWav3_MouseClick(object sender, MouseEventArgs e) { if (WFD.ShowDialog()==DialogResult.OK) { TimerWavPath.Text=WFD.FileName; } }
		private void TimerValLabelUpdate() {
			TimerValueLabel.Text=(TimerRB3.Checked ? "Timer Start Value (in seconds)" : "Timer Cap Value (in seconds)");
		}

		private void TimerValue_ValueChanged(object sender, EventArgs e) { TimerValueHelper(); }

		private void TimerValueHelper() {
			TimerHH.Value=(int)(TimerValue.Value/3600);
			TimerMM.Value=(int)((TimerValue.Value%3600)/60);
			TimerSS.Value=(int)(TimerValue.Value%60);
		}

		private void TimerHH_Leave(object sender, EventArgs e) {
			TimerValue.Value=TimerHH.Value*3600+TimerMM.Value*60+TimerSS.Value;
		}
		#endregion

	}
}
