using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Timer2 {
	// tasks can have: time limt(day\week\month).
	// Repeat forever or count,
	// has counter, weight
	// public interface ITPTASK {
	// string ID { get; set; } string DDS {get; set;}
	// public string Save();
	// }

	public class TaskTabR {
		
		public static int STabN = 0, STaskN = 0;
		public static Action<Control> FrameResize => (GB) => {
			if (TaskTabR.STabN<=-1) return;
			if (Timer2.TReAr.ContainsKey((TaskTabR.STabN, TaskTabR.STaskN))) Timer2.TReAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location.X+12, Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location.Y+Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Height-8);
			if (Timer2.TExAr.ContainsKey((TaskTabR.STabN, TaskTabR.STaskN))) Timer2.TExAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location.X+Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Width-Timer2.TExAr[(TaskTabR.STabN, TaskTabR.STaskN)].Width-5, Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location.Y+Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Height-8);
		};
	
		public static Action<Control> FrameResizeBegin => (GB) => {
			int k = 0; string GBName = ((GroupBox)GB).Name;
			TK.Token(GBName, ref k, '_'); STabN=int.Parse(TK.Token(GBName, ref k, '_')); STaskN=int.Parse(TK.Token(GBName, ref k, '_'));  
		};

		public static Action<Control> FrameResizeEnd => (GB) => {
			int k = 0; string GBName = ((GroupBox)GB).Name;
			TK.Token(GBName, ref k, '_'); STabN=int.Parse(TK.Token(GBName, ref k, '_')); STaskN=int.Parse(TK.Token(GBName, ref k, '_'));  

			Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Width=Timer2.MainTimer.TC.Width-52;
			int MinH = Math.Max(70, Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Height);
			Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Height=MinH;
			Timer2.CurTProgra.TaskTabRAr[TaskTabR.STabN].TaskAr[TaskTabR.STaskN].GH=MinH;

			/*Timer2.SBAr[(TabN, TaskN)].Location=new Point( Timer2.GBAr[(TabN, TaskN)].Size.Width - 20, 10);
			//Timer2.SBAr[(TabN, TaskN)].Height = Timer2.GBAr[(TabN, TaskN)].Size.Height-10;

			// Alright, now i need to find the bottom control in the Gr to find is location, so i can decide what's the scrollbar max
			//int BottomLoc = Math.Max((Timer2.ChAr[(TabN, TaskN)].LastOrDefault()?.Location.Y)??0, Math.Max((Timer2.CBuAr[(TabN, TaskN)].LastOrDefault()?.Location.Y)??0, (Timer2.TLAr[(TabN, TaskN)].LastOrDefault()?.Location.Y)??0));//Timer2.TLAr[(TabN, TaskN)].Last().Location.Y));
			//Timer2.SBAr[(TabN, TaskN)].Value=0;
			//Timer2.SBAr[(TabN, TaskN)].Maximum= Math.Max(10, BottomLoc+25 - Timer2.GBAr[(TabN, TaskN)].Height);
			//System.Diagnostics.Debug.WriteLine(BottomLoc+20);*/

			if (Timer2.TReAr.ContainsKey((TaskTabR.STabN, 0))) Timer2.TReAr[(TaskTabR.STabN, 0)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, 0)].Location.X +	12, Timer2.GBAr[(TaskTabR.STabN, 0)].Location.Y+ Timer2.GBAr[(TaskTabR.STabN, 0)].Height-8);
			if (Timer2.TExAr.ContainsKey((TaskTabR.STabN, 0))) Timer2.TExAr[(TaskTabR.STabN, 0)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, 0)].Location.X + Timer2.GBAr[(TaskTabR.STabN, 0)].Width-Timer2.TExAr[(TaskTabR.STabN, 0)].Width-5,Timer2.GBAr[(TaskTabR.STabN, 0)].Location.Y+Timer2.GBAr[(TaskTabR.STabN, 0)].Height-8);

			for (int i = 1; i < Timer2.CurTProgra.TaskTabRAr[TaskTabR.STabN].TaskAr.Count; i++) {
				Timer2.GBAr[(TaskTabR.STabN, i)].Location = new Point( 6, Timer2.GBAr[(TaskTabR.STabN, i-1)].Location.Y+Timer2.GBAr[(TaskTabR.STabN, i-1)].Height + 12);
				if (Timer2.TReAr.ContainsKey((TaskTabR.STabN, i))) Timer2.TReAr[(TaskTabR.STabN, i)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, i)].Location.X +	12, Timer2.GBAr[(TaskTabR.STabN, i)].Location.Y+ Timer2.GBAr[(TaskTabR.STabN, i)].Height-8);
				if (Timer2.TExAr.ContainsKey((TaskTabR.STabN, i))) Timer2.TExAr[(TaskTabR.STabN, i)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, i)].Location.X + Timer2.GBAr[(TaskTabR.STabN, i)].Width-Timer2.TExAr[(TaskTabR.STabN, i)].Width-5,Timer2.GBAr[(TaskTabR.STabN, i)].Location.Y+Timer2.GBAr[(TaskTabR.STabN, i)].Height-8);
			}
			Timer2.TDDSAr[(TaskTabR.STabN, TaskTabR.STaskN)].Location=new Point(Timer2.GBAr[(TaskTabR.STabN, TaskTabR.STaskN)].Width-21, -2);
			
			Timer2.MainTimer.MoveNTB(TaskTabR.STabN); TaskTabR.STabN=TaskTabR.STaskN=-1;
			
		};

		public string ID = "", TabName = "", DDS = "";
		public List <TPTask> TaskAr = new List<TPTask>();

		public TaskTabR (string id, string tabName, string description) { ID=id; TabName=tabName; DDS=description; }
		
		public TaskTabR (string TaskTabRData) {
			int k = 0, z =0; string TasksData = "", CurTask = "";
			ID=TK.Token(TaskTabRData, ref k, '\u0FF0'); 
			TabName=TK.Token(TaskTabRData, ref k, '\u0FF0');
			DDS=TK.Token(TaskTabRData, ref k, '\u0FF0'); 

			TasksData = TK.Token(TaskTabRData, ref k, '\u0EF1'); z = 0;

            while ((CurTask = TK.Token(TasksData, ref z, '\u0EF0')) != "") 
				TaskAr.Add(new TPTask(CurTask));
			
		}

		public string Save() { 
			StringBuilder SB = new StringBuilder();
			SB.Append(ID+"\u0FF0"+TabName+"\u0FF0"+DDS+"\u0FF0");
			for (int i = 0; i<TaskAr.Count; i++) SB.Append(TaskAr[i].Save() +"\u0EF0");		
			SB.Append("\u0EF1");

			return SB.ToString();
		}

		public virtual TPTask this[int index] { get { return TaskAr[index]; } set { TaskAr[index] = value; } }
	
	}


	public class TPTask {
		public string ID, DDS; public int GH = 100;
		public byte Days; public (int, int) ResetTime; // HH:MM
		public DateTime? Expire = null, ExpectedNextReset; public DateTime LastCheckedTime = DateTime.Now;
		public Color TaskColor = Color.FromArgb(255, 255, 255);
		public bool HasExpired = false;

		// i Could replace the data with classes: Check, Counter and Timer. Structs are immuniable
		public List <string> CheckData = new List <string>();	 // [0:1Type]
		public List <string> CheckDDS = new List <string>();
		public List <string> CountersName = new List <string>(); // [0:1Type Button|UpDown]_DefaultValue_GoalValue_Name
		public List <string> CountersDDS = new List <string>();
		public List <int> CountersValue = new List <int>();
		public List <long> TimersValue = new List <long>();
		public List <long> DefaultTimersValue = new List <long>();
		public List <string> TimersName = new List <string>(); // 0:1 Digit\Progressbar 0:2 Down\Up
		public List <string> TimersDDS = new List <string>();
		public List <string> TimersWavPath = new List <string>();

		public List <bool> TimersRunning = new List <bool>();
		public List <bool> TimersType    = new List <bool>();
		public List <bool> TimersDone    = new List <bool>();


		public TPTask () { }

		public TPTask(string id, string description, byte ResetDays, (int, int) ResetTime, DateTime? TaskExpire, int GUIHeight, string Taskcolor, List<string> CheckList, List<string> CheckDDSList, List<string> CountersNameList, List <string> CountersDDSList, List <int> CountersValList, List <long> TimersList, List <long> TimersDefaultList, List <string> TimersWAVPaths, List <int> TimeTypeList, List<string> TimersNameList, List<string> TimersDDSList) {
			ID=id; DDS =description; GH=GUIHeight; TaskColor = Color.FromArgb(int.Parse(Taskcolor));
			Days = ResetDays; this.ResetTime = ResetTime; Expire = TaskExpire;
			foreach (string CD in CheckList) CheckData.Add(CD);
			foreach (string CD in CheckDDSList) CheckDDS.Add(CD);
			foreach (string CD in CountersNameList) CountersName.Add(CD);
			foreach (string CD in CountersDDSList) CountersDDS.Add(CD);
				
			foreach (int CD in CountersValList) CountersValue.Add(CD);
			foreach (long CD in TimersList) TimersValue.Add(CD);
			foreach (long CD in TimersDefaultList) DefaultTimersValue.Add(CD);
			foreach (string CD in TimersWAVPaths) TimersWavPath.Add(CD);
			//foreach (int TTD in TimeTypeList) TimeType.Add(TTD);
			foreach (string CD in TimersNameList) { TimersName.Add(CD); TimersRunning.Add(false); }
			foreach (string CD in TimersDDSList) TimersDDS.Add(CD);
			GetNextResetTime();
		}

		public TPTask (string TaskData) { 
			int k = 0, z =0; 
			ID  =TK.Token(TaskData, ref k, '\u0FF0'); 
			DDS =TK.Token(TaskData, ref k, '\u0FF0');
			Days = byte.Parse( TK.Token(TaskData, ref k, '\u0FF0'));
			ResetTime = (int.Parse(TK.Token(TaskData, ref k, ',')), int.Parse(TK.Token(TaskData, ref k, '\u0FF0')));
			string ED = TK.Token(TaskData, ref k, '\u0FF0');
			Expire = ED =="-1" ? null : DateTime.Parse(ED);
			GH = int.Parse( TK.Token(TaskData, ref k, '\u0FF0'));
			TaskColor = Color.FromArgb(int.Parse(TK.Token(TaskData, ref k, '\u0FF0')));

			CheckData=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			CheckDDS=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			CountersName=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			CountersDDS=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			CountersValue =TK.TokenIntList(TaskData, ref k, '\u0FF0', '\u0FF1');
			TimersValue =TK.TokenLongList(TaskData, ref k, '\u0FF0', '\u0FF1');
			DefaultTimersValue =TK.TokenLongList(TaskData, ref k, '\u0FF0', '\u0FF1');
			TimersWavPath=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			//TimeType =TK.TokenIntList(TaskData, ref k, '\u0FF0', '\u0FF1');
			TimersName=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			TimersDDS=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			for (int i = 0; i<TimersName.Count; i++) {
				TimersRunning.Add(false); TimersDone.Add(false);
				bool ttb = ((int)(TimersName[i][0])&2)==2;
				TimersType.Add(ttb);
			}

			GetNextResetTime();
		}

		public string Save(string NewID = "") {
			StringBuilder SB = new StringBuilder();
			SB.Append((NewID=="" ? ID : NewID)+"\u0FF0"+DDS+"\u0FF0"+Days+"\u0FF0"+ResetTime.Item1+","+ResetTime.Item2+"\u0FF0"+(Expire.HasValue ? Expire.Value.ToString() : "-1")+"\u0FF0"+GH+"\u0FF0"+TaskColor.ToArgb().ToString()+"\u0FF0"  );

			foreach (string CD in CheckData)     SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in CheckDDS)      SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in CountersName)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in CountersDDS)   SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");

			foreach (int CD in CountersValue) SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (long CD in TimersValue)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (long CD in DefaultTimersValue) SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in TimersWavPath)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			//foreach (int CD in TimeType)	  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in TimersName) SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in TimersDDS)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			SB.Append("\u0FF2");
			return SB.ToString();
		}

		public TPTask Clone(string NewID = "") { return new TPTask(Save(NewID)); }

		/// <summary> This function register the next date to reset the task, it should be called only when the current time is higher than ExpectedNextReset time cause it doesn't do an inner check for that  </summary>
		/// <param name="TestDT"> This parameter is used to test the function instead of using the current time</param>
		// ExpectedNextReset = The time where the task would reset next. LastCheckedTime = Last time that the task got reseted. CheckedDay = the pivot of the day of the week to seek which day would task will be reseted. NextReset = The pivot with the registered task reset time of the day.
		public void GetNextResetTime(DateTime? TestDT = null) {
			if (Days==0) { ExpectedNextReset = null; return; }
			DateTime CheckedDay = TestDT??DateTime.Now;
			for (int i = 0; i < 15; i++) {		
				System.Diagnostics.Debug.WriteLine("Days [" + i + "] Check: " + CheckedDay.DayOfWeek+" "+(Days&(1<<(int)CheckedDay.DayOfWeek)));
				if ((Days & (1 << (int)CheckedDay.DayOfWeek)) == 0) {CheckedDay = CheckedDay.Date.AddDays(1); continue; }
				DateTime? NextReset = new DateTime(CheckedDay.Year, CheckedDay.Month, CheckedDay.Day, ResetTime.Item1, ResetTime.Item2, 0);
				if (NextReset<=CheckedDay) { CheckedDay = CheckedDay.Date.AddDays(1); continue; } // if the day of reset is correct but not the time is right yet
				LastCheckedTime=DateTime.Now; ExpectedNextReset = NextReset; // it was LastCheckedTime=ExpectedNextReset??DateTime.Now;
				System.Diagnostics.Debug.WriteLine("Last Check Date: " + LastCheckedTime + " Next Expected reset date: " + ExpectedNextReset); return;
			}
			System.Diagnostics.Debug.WriteLine("No days has been found, this shouldn' happen! did the world ends?");

		}

	}

}
