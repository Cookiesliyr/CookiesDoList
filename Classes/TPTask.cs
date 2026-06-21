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
		public string ID = "", TabName = "", DDS = "";
		public List <TPTask> TaskAr = new List<TPTask>();

		public TaskTabR (string id, string tabName, string description) { ID=id; TabName=tabName; DDS=description; }
		
		public TaskTabR (string TaskTabRData) {
			int k = 0, z =0; string TasksData = "", CurTask = "";
			ID=TK.Token(TaskTabRData, ref k, '\u0FF0'); 
			TabName=TK.Token(TaskTabRData, ref k, '\u0FF0');
			DDS=TK.Token(TaskTabRData, ref k, '\u0FF0'); 

			TasksData = TK.Token(TaskTabRData, ref k, '\u0FF1'); z = 0;

            while ((CurTask = TK.Token(TasksData, ref z, '\u0EF0')) != "") 
				TaskAr.Add(new TPTask(CurTask));
			
		}

		public string Save() { 
			StringBuilder SB = new StringBuilder();
			SB.Append(ID+'\u0FF0'+TabName+'\u0FF0'+DDS+'\u0FF0');
			for (int i = 0; i<TaskAr.Count; i++) SB.Append(TaskAr[i].Save() +'\u0EF0');		
			SB.Append('\u0EF1');

			return SB.ToString();
		}

	}


	public class TPTask {
		public string ID { get; set; } public string DDS { get; set; }
		public long TaskResetTime = -1; // in seconds?
		
		// i Could replace the data with classes: Check, Counter and Timer. Structs are immuniable
		public List <string> CheckData = new List <string>();
			public List <string> CheckDDS = new List <string>();
			public List <string> CountersName = new List <string>();
			public List <string> CountersDDS = new List <string>();
		public List <int> CountersValue = new List <int>();
		public List <long> TimersValue = new List <long>();
		public List <long> DefaultTimersValue = new List <long>();
		public List <int> TimeType = new List <int>(); // Time up\down, Progressbar up\down
			public List <string> TimersName = new List <string>();
			public List <string> TimersDDS = new List <string>();

		public TPTask(string id, string description, long ResetTime, List<string> CheckList, List<string> CheckDDSList, List<string> CountersNameList, List <string> CountersDDSList, List <int> CountersValList, List <long> TimersList, List <long> TimersDefaultList, List <int> TimeTypeList, List<string> TimersNameList, List<string> TimersDDSList) {
			ID=id; DDS =description; TaskResetTime=ResetTime;
			foreach (string CD in CheckList) CheckData.Add(CD);
				foreach (string CD in CheckDDSList) CheckDDS.Add(CD);
				foreach (string CD in CountersNameList) CountersName.Add(CD);
				foreach (string CD in CountersDDSList) CountersDDS.Add(CD);
				
			foreach (int CD in CountersValList) CountersValue.Add(CD);
			foreach (long CD in TimersList) TimersValue.Add(CD);
			foreach (long CD in TimersDefaultList) DefaultTimersValue.Add(CD);
			foreach (int TTD in TimeTypeList) TimeType.Add(TTD);
				foreach (string CD in TimersNameList) TimersName.Add(CD);
				foreach (string CD in TimersDDSList) TimersDDS.Add(CD);
		}

		public TPTask (string TaskData) { 
			int k = 0, z =0; 
			ID  =TK.Token(TaskData, ref k, '\u0FF0'); 
			DDS =TK.Token(TaskData, ref k, '\u0FF0'); 
			TaskResetTime = long.Parse( TK.Token(TaskData, ref k, '\u0FF0'));

			CheckData=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
				CheckDDS=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
				CountersName=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
				CountersDDS=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
			CountersValue =TK.TokenIntList(TaskData, ref k, '\u0FF0', '\u0FF1');
			TimersValue =TK.TokenLongList(TaskData, ref k, '\u0FF0', '\u0FF1');
			DefaultTimersValue =TK.TokenLongList(TaskData, ref k, '\u0FF0', '\u0FF1');
			TimeType =TK.TokenIntList(TaskData, ref k, '\u0FF0', '\u0FF1');
				TimersName=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
				TimersDDS=TK.TokenStringList(TaskData, ref k, '\u0FF0', '\u0FF1');
		}

		public string Save(string NewID = "") {
			StringBuilder SB = new StringBuilder();
			SB.Append( (NewID==""?ID:NewID)+'\u0FF0'+DDS+'\u0FF0'+TaskResetTime+'\u0FF0');

			foreach (string CD in CheckData)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
				foreach (string CD in CheckDDS)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
				foreach (string CD in CountersName)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
				foreach (string CD in CountersDDS)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');

			foreach (int CD in CountersValue) SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
			foreach (long CD in TimersValue)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
			foreach (long CD in DefaultTimersValue) SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
			foreach (int CD in TimeType)		    SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
				foreach (string CD in TimersName)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
				foreach (string CD in TimersDDS)  SB.Append(CD+'\u0FF0'); SB.Append('\u0FF1');
			SB.Append('\u0FF2');
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
