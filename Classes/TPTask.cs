using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		
		public static Action<Control> FrameResize => (GB) => {
			int k = 0, TabN, TaskN;
			TK.Token(GB.Name, ref k, '_'); TabN=int.Parse(TK.Token(GB.Name, ref k, '_')); TaskN=int.Parse(TK.Token(GB.Name, ref k, '_'));  
			Timer2.GBAr[(TabN, TaskN)].Width=Timer2.MainTimer.TC.Width-52;
			Timer2.CurTProgra.TaskTabRAr[TabN].TaskAr[TaskN].GH=Timer2.GBAr[(TabN, TaskN)].Height;
			//Timer2.SBAr[(TabN, TaskN)].Location=new Point( Timer2.GBAr[(TabN, TaskN)].Size.Width - 20, 10);
			//Timer2.SBAr[(TabN, TaskN)].Height = Timer2.GBAr[(TabN, TaskN)].Size.Height-10;

			// Alright, now i need to find the bottom control in the Gr to find is location, so i can decide what's the scrollbar max
			//int BottomLoc = Math.Max((Timer2.ChAr[(TabN, TaskN)].LastOrDefault()?.Location.Y)??0, Math.Max((Timer2.CBuAr[(TabN, TaskN)].LastOrDefault()?.Location.Y)??0, (Timer2.TLAr[(TabN, TaskN)].LastOrDefault()?.Location.Y)??0));//Timer2.TLAr[(TabN, TaskN)].Last().Location.Y));
			//Timer2.SBAr[(TabN, TaskN)].Value=0;
			//Timer2.SBAr[(TabN, TaskN)].Maximum= Math.Max(10, BottomLoc+25 - Timer2.GBAr[(TabN, TaskN)].Height);
			//System.Diagnostics.Debug.WriteLine(BottomLoc+20);

			for (int i = 1; i < Timer2.CurTProgra.TaskTabRAr[TabN].TaskAr.Count; i++) 
				Timer2.GBAr[(TabN, i)].Location = new Point( 6, Timer2.GBAr[(TabN, i-1)].Location.Y+Timer2.GBAr[(TabN, i-1)].Height + 6);

			Timer2.MainTimer.MoveNTB(TabN);
			
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
		public DateTime? Expire = null;
		public Color TaskColor = Color.FromArgb(255, 255, 255);

		// i Could replace the data with classes: Check, Counter and Timer. Structs are immuniable
		public List <string> CheckData = new List <string>();
		public List <string> CheckDDS = new List <string>();
		public List <string> CountersName = new List <string>();
		public List <string> CountersDDS = new List <string>();
		public List <int> CountersValue = new List <int>();
		public List <long> TimersValue = new List <long>();
		public List <long> DefaultTimersValue = new List <long>();
		//public List <int> TimeType = new List <int>(); // Time up\down, Progressbar up\down
		public List <string> TimersName = new List <string>(); // i could integrate the type in the name
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

		}

		public string Save(string NewID = "") {
			StringBuilder SB = new StringBuilder();
			SB.Append((NewID=="" ? ID : NewID)+"\u0FF0"+DDS+"\u0FF0"+Days+"\u0FF0"+ResetTime.Item1+","+ResetTime.Item2+"\u0FF0"+(Expire.HasValue ? Expire.Value.ToString() : "-1")+"\u0FF0"+GH+"\u0FF0"+TaskColor.ToArgb().ToString()+"\u0FF0"  );

			foreach (string CD in CheckData)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in CheckDDS)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in CountersName)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");
			foreach (string CD in CountersDDS)  SB.Append(CD+"\u0FF0"); SB.Append("\u0FF1");

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
		// public void SaveToFile (string Location = "") {}
	}

	/*
	public class TPTDaily: TPTask {
		byte ResetTime = 0; // like in hours, should i add a minute like 3:30 am?
		public TPTDaily() : base() {

		}

		public TPTDaily(string TaskData) : base(TaskData) {

		}
	}

	public class TPTWeekly: TPTask {
		byte ResetTime = 0; // like in hours, should i add a minute like 3:30 am?
		public TPTWeekly() : base() {

		}

		public TPTWeekly(string TaskData) : base(TaskData) {

		}
	}

	public class TPTToDo: TPTask {
		byte ResetTime = 0; // like in hours, should i add a minute like 3:30 am?
		public TPTToDo() : base() {

		}

		public TPTToDo(string TaskData) : base(TaskData) {

		}
	} 
	*/

}
