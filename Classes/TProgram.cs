using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer2 {
	// TProgram is a list of tasks, wonder how am i going to structure this
	// maybe is houldn't this guy responsible on the GUI, instead it give orders to generate them

	public class TProgram {
		public List<TaskTabR> TaskTabRAr = new List<TaskTabR>();
		
		public string TPName = "", TPDDS ="";

		public TProgram (string ProgramName, string ProgramDescription = "") { 
			TPName = ProgramName; TPDDS = ProgramDescription;
			// Maybe create the default tabs: daily, weekly, etc, ToDo
			TaskTabRAr.Add(new TaskTabR("ToDo", "ToDo", "default task bar"));
		}

		public TProgram (string TProgramData) {
			int k = 0, z =0; string TabData = "", CurTab = "";
			TPName = TK.Token(TProgramData, ref k, '\u0FF0'); 
			TPDDS = TK.Token(TProgramData, ref k, '\u0FF0'); 

			TabData = TK.Token(TProgramData, ref k, '\u0FED'); z = 0;
            while ((CurTab = TK.Token(TabData, ref z, '\u0FE0')) != "") {
				TaskTabRAr.Add(new TaskTabR(CurTab));

			}
		}

		public string Save() {
			StringBuilder SB = new StringBuilder();
			SB.Append(TPName + '\u0FF0' + TPDDS + '\u0FF0');

			for (int i = 0; i < TaskTabRAr.Count; i++) 
				SB.Append(TaskTabRAr[i].Save() + '\u0FE0');

			SB.Append('\u0FED');
			return SB.ToString();
		}
		
		public static TProgram LoadFromFile (string Location = "") {
			string TPData;
			if (!File.Exists(Location)) { System.Diagnostics.Debug.Write("The file location:"+Location+" Doesn't exists"); return null; }
 
			using (StreamReader SR = new StreamReader(Location)) { TPData = SR.ReadToEnd(); }
			return new TProgram(TPData);
		}

		public void SaveToFile (string FileName, string Location = "") {
			if (FileName=="") return;
			if (!Directory.Exists(Location)) {System.Diagnostics.Debug.Write("The file location:"+Location+" Doesn't exists"); return; }
			
			//if (!File.Exists(Location)) { System.Diagnostics.Debug.Write("The file location:"+Location+" Doesn't exists"); return; }

			using (StreamWriter SW = new StreamWriter(Location + "\\" + FileName)) { SW.Write(Save()); }
			
		}
	}
}
