
using System.IO;

namespace Timer2 {
	public partial class Timer2: Form {
		public static Timer2 MainTimer;
		public static CreateNewProgramFile NewTPFMenu = new CreateNewProgramFile();
		public static TaskTabsEditor TTEMenu = new TaskTabsEditor();
		public static CreateNewTask NewTaskMenu = new CreateNewTask();

		public static TProgram CurTProgra;
		static System.Media.SoundPlayer AlarmPlayer = new System.Media.SoundPlayer();

		public static bool EditMode = false, TabClearEdit = false; static int FirePerMin = 0;

		// ============= GUI
		public static List<Panel> TabGRAr = new List<Panel>();
		//public static List<VScrollBar> TabSBAr = new List<VScrollBar>();

		// Todo: figure out a better way to order them ... might need double key?
		// This works fine but deleting tasks would be a pain ... wonder how would i do the cleanup 
		// one way is to keep increment the tasks numbers even when i delete them, and keep that position as a placeholder, but when the program save and load it should regenerate only the real ones, which would re-order them automatically

		public static Dictionary<(int, int), GroupBox> GBAr = new Dictionary<(int, int), GroupBox>();
		public static Dictionary<(int, int), FlowLayoutPanel> FPAr = new Dictionary<(int, int), FlowLayoutPanel>();
		public static Dictionary<(int, int), Button> TDDSAr = new Dictionary<(int, int), Button>();
		//public static Dictionary<(int, int), VScrollBar> SBAr = new Dictionary<(int, int), VScrollBar>();

		public static Dictionary<(int, int), List<CheckBox>> ChAr = new Dictionary<(int, int), List<CheckBox>>();
		public static Dictionary<(int, int), List<Button>> CBuAr = new Dictionary<(int, int), List<Button>>();
		public static Dictionary<(int, int), List<Label>> CLAr = new Dictionary<(int, int), List<Label>>();

		public static Dictionary<(int, int), List<Button>> TSBuAr = new Dictionary<(int, int), List<Button>>();
		public static Dictionary<(int, int), List<Button>> TPBuAr = new Dictionary<(int, int), List<Button>>();
		public static Dictionary<(int, int), List<ProgressBar>> TPBAr = new Dictionary<(int, int), List<ProgressBar>>();
		public static Dictionary<(int, int), List<Label>> TNAr = new Dictionary<(int, int), List<Label>>();
		public static Dictionary<(int, int), List<Label>> TLAr = new Dictionary<(int, int), List<Label>>();

		// ===== Track which task can expire or need reset
		public static Dictionary<(int, int), bool> TaskCheckTimeAr = new Dictionary<(int, int), bool>();

		public Timer2() {
			MainTimer=this; 
			InitializeComponent(); NewTaskButt.Width=TC.Width-52;
			
			if (File.Exists("Autoload.txt")) {
				string TPFN;
				using (StreamReader SR = new StreamReader("Autoload.txt")) { TPFN = SR.ReadToEnd(); }
				if (File.Exists(TPFN)) {
					CurTProgra=TProgram.LoadFromFile(TPFN);
					LoadCurProgram(); Timer1.Enabled=true; FirePerMin= 600 - DateTime.Now.Second*10; return;
				}
			}
			
			if (CurTProgra==null) {
				CurTProgra=new TProgram("Timer2 Def", "The Default program");
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab1", "Daily", "A task collection that represent Daily Tasks."));
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab2", "Weekly", "A task collection that represent Weekly Tasks."));
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab3", "Extra", "A task collection that represent Additional Tasks."));
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab4", "ToDo", "A task collection that represent Todo tasks."));

				for (int i = 0; i<4; i++) {
					TabGRAr.Add(new Panel { Location=new Point(3, 3), Size=new Size(Width-35, Height-100), AutoSize=true, AutoScroll=true, Dock=DockStyle.Fill });
					//TabSBAr.Add(new VScrollBar { });
					TC.TabPages[i].Controls.Add(TabGRAr[i]); //TC.TabPages[i].Controls.Add(TabSBAr[i]);
															 //TabSBAr[i].Location=new Point( TC.Width - 30, 5); TabSBAr[i].Height=TC.Height-40; TabSBAr[i].BringToFront();
				}
			}

			/* ======== An attempt to make tooltip draw multiple lines, unfortunately it crushe
			ToolTip.OwnerDraw = true;
			ToolTip.Draw += (s, e) => {
				e.DrawBackground();
				e.DrawBorder();
				using (var f = new Font("Segoe UI", 9))
				using (Brush brush = Brushes.Black)
					e.Graphics.DrawString(e.ToolTipText, f, brush, new RectangleF(e.Bounds.X, e.Bounds.Y, e.Bounds.Width, e.Bounds.Height));
				
			};

			ToolTip.Popup += (s, e) => {
				// optionally measure text and set size
				var sz = TextRenderer.MeasureText(ToolTip.GetToolTip(e.AssociatedControl), new Font("Segoe UI", 9), new Size(300, 0), TextFormatFlags.WordBreak);
				e.ToolTipSize = sz;
			};
			*/
			
			Timer1.Enabled=true; 
			FirePerMin= 600 - DateTime.Now.Second*10;
		}

		public static void ReturnToTimer () { MainTimer.Enabled=true; Timer2.MainTimer.Enabled=true; MainTimer.TopMost=true; MainTimer.TopMost=false; }

		#region Events 
		/*public void Task_GB_SB_ScrollAction (object Sender, ScrollEventArgs e) { 
			int k = 0, TabN, TaskN; VScrollBar SB = (VScrollBar) Sender;
			TK.Token(SB.Name, ref k, '_'); TabN=int.Parse(TK.Token(SB.Name, ref k, '_')); TaskN=int.Parse(TK.Token(SB.Name, ref k, '_'));
			FPAr[(TabN, TaskN)].Location=new Point(FPAr[(TabN, TaskN)].Location.X, -SB.Value);
		}*/

		public void CheckChecked (object sender, EventArgs e) { ((CheckBox)sender).BackColor = ((CheckBox)sender).Checked ? Color.Green : Color.LightGray; }
		public void Counter_MouseDown(object Sender, MouseEventArgs e) {
			int k = 0, TabN, TaskN, Bi, BVal; Button CB = (Button)Sender;
			TK.Token(CB.Name, ref k, '_'); TabN=int.Parse(TK.Token(CB.Name, ref k, '_')); TaskN=int.Parse(TK.Token(CB.Name, ref k, '_')); Bi=int.Parse(TK.Token(CB.Name, ref k, '_'));
			k=0; string BConTo = TK.Token(CurTProgra.TaskTabRAr[TabN][TaskN].CountersName[Bi], ref k, '_');
			BVal=CurTProgra.TaskTabRAr[TabN][TaskN].CountersValue[Bi];

			if (e.Button==MouseButtons.Left) { BVal++; } else if (e.Button==MouseButtons.Right) { BVal--; if (BVal<0) BVal=0; }
			CurTProgra.TaskTabRAr[TabN][TaskN].CountersValue[Bi]=BVal;

			if (int.Parse(BConTo)>BVal) { CB.BackColor=Color.LightGray; CB.ForeColor=Color.Black; } else { CB.BackColor=Color.Green; CB.ForeColor=Color.White; }
			CB.Text=BVal+" \\ "+BConTo;
		}

		public void Timer_StopButt(object Sender, MouseEventArgs e) {
			int k = 0, TabN, TaskN, Ti; Button TSB = (Button)Sender;
			TK.Token(TSB.Name, ref k, '_'); TabN=int.Parse(TK.Token(TSB.Name, ref k, '_')); TaskN=int.Parse(TK.Token(TSB.Name, ref k, '_')); Ti=int.Parse(TK.Token(TSB.Name, ref k, '_'));

			CurTProgra.TaskTabRAr[TabN][TaskN].TimersValue[Ti]=(CurTProgra.TaskTabRAr[TabN][TaskN].TimersType[Ti] ? CurTProgra.TaskTabRAr[TabN][TaskN].DefaultTimersValue[Ti] : 0);
			TPBAr[(TTTabN, TTTaskN)][Ti].Value=(CurTProgra.TaskTabRAr[TabN][TaskN].TimersType[Ti] ? 100 : 0);
			TLAr[(TTTabN, TTTaskN)][Ti].Text=TimeSpan.FromMilliseconds(CurTProgra.TaskTabRAr[TabN][TaskN].TimersValue[Ti]).ToString(@"hh\:mm\:ss");
			
			if (e.Button==MouseButtons.Left) {
				CurTProgra.TaskTabRAr[TabN][TaskN].TimersRunning[Ti]=false;
				TPBuAr[(TTTabN, TTTaskN)][Ti].Text="\u25B6";
			}

			CurTProgra.TaskTabRAr[TabN][TaskN].TimersDone[Ti]=false; StopWav();
			TPBuAr[(TTTabN, TTTaskN)][Ti].BackColor=SystemColors.Control; TLAr[(TTTabN, TTTaskN)][Ti].ForeColor=Color.Black;
			// TSBuAr for play = 25B6, for pause = 23F8 
		}

		public void Timer_PlayButt(object Sender, MouseEventArgs e) {
			int k = 0, TabN, TaskN, Ti, TVal; Button TSB = (Button)Sender;
			TK.Token(TSB.Name, ref k, '_'); TabN=int.Parse(TK.Token(TSB.Name, ref k, '_')); TaskN=int.Parse(TK.Token(TSB.Name, ref k, '_')); Ti=int.Parse(TK.Token(TSB.Name, ref k, '_'));
			if (CurTProgra.TaskTabRAr[TabN][TaskN].TimersDone[Ti]) return;
			CurTProgra.TaskTabRAr[TabN][TaskN].TimersRunning[Ti]=!CurTProgra.TaskTabRAr[TabN][TaskN].TimersRunning[Ti];
			TSB.Text=(CurTProgra.TaskTabRAr[TabN][TaskN].TimersRunning[Ti] ? "\u23F8" : "\u25B6");
			StopWav();
		}

		public void TaskEdit (object Sender, MouseEventArgs e) {
			if (EditMode) {
				int k = 0, TabN, TaskN, Ti; Button TSB = (Button)Sender;
				TK.Token(TSB.Name, ref k, '_'); TabN=int.Parse(TK.Token(TSB.Name, ref k, '_')); TaskN=int.Parse(TK.Token(TSB.Name, ref k, '_'));
				CreateNewTask.CurTaskBar=TabN; CreateNewTask.CurTaskN=TaskN;
				NewTaskMenu.EditTask(CurTProgra.TaskTabRAr[TabN][TaskN]); NewTaskMenu.Show();
			}
		}

		#endregion

		#region TProgram Region
		private void SMCreate_Click(object sender, EventArgs e) {
			NewTPFMenu.Show(); Enabled=false;
		}

		private void SMSave_Click(object sender, EventArgs e) {
			if (SFD.ShowDialog()==DialogResult.OK)
				CurTProgra.SaveToFile(Path.GetFileName(SFD.FileName)??"", Path.GetDirectoryName(SFD.FileName)??"");

		}

		private void SMLoad_Click(object sender, EventArgs e) {
			if (LFD.ShowDialog()==DialogResult.OK) {
				NukeTasksGUI();
				CurTProgra=TProgram.LoadFromFile(LFD.FileName);
				LoadCurProgram();
			}
		}

		private void SMAuto_Click(object sender, EventArgs e) {
			if (LFD.ShowDialog()==DialogResult.OK) {
				using (StreamWriter SW = new StreamWriter("Autoload.txt")) { SW.Write(LFD.FileName); }
			}
		}

		public void LoadCurProgram() {
			TabClearEdit=true; 

			TC.TabPages.Clear(); TabClearEdit=false; FPAr.Clear(); TabGRAr.Clear(); BringToFront();
			Text=CurTProgra.TPName;
			
			for (int i = 0; i<CurTProgra.TaskTabRAr.Count; i++) {
				TabGRAr.Add(new Panel { Location=new Point(3, 3), Size=new Size(Width-35, Height-100), AutoSize=true, AutoScroll=true, Dock=DockStyle.Fill });
				TC.TabPages.Add(new TabPage { Name="Tab"+i, Text=CurTProgra.TaskTabRAr[i].ID, BackColor=Color.White });
				TC.TabPages[i].Controls.Add(TabGRAr[i]);
				for (int j = 0; j<CurTProgra.TaskTabRAr[i].TaskAr.Count; j++) GenerateTaskGUI(i, j);
			}

		}

		
		#endregion

		#region Edit Region
		private void SMEdit_Click(object sender, EventArgs e) {
			EnterEditMode();
		}

		// this function will turn Edit Mode on\off
		public void EnterEditMode() {
			MoveNTB(TC.SelectedIndex); 
			EditMode=!EditMode;
			EditMTabs.Visible=NewTaskButt.Visible=EditMode;

			foreach (KeyValuePair<(int, int), Button> TDD in TDDSAr) TDD.Value.Text = (EditMode?"✎":"?");
		}


		private void EditMTabs_Click(object sender, EventArgs e) {
			if (CurTProgra==null) { return; }
			TTEMenu.Show(); TTEMenu.TabsINI(); Enabled=false;
		}

		// To resize TaskTabControl and all the tasks groups inside on Windows Resize
		private void Timer2_ResizeEnd(object sender, EventArgs e) {
			TC.Width=Width-22; TC.Height=Height-70; NewTaskButt.Width=TC.Width-52;

			for (int i = 0; i<TC.TabPages.Count; i++) {
				TabGRAr[i].Size=new Size(Width-35, Height-100);
				//TabSBAr[i].Location=new Point( TC.Width - 30, 5); TabSBAr[i].Height=TC.Height-40;

				// need to resize all Grouboxes for existing tasks in all tabs
				foreach (KeyValuePair<(int, int), GroupBox> GB in GBAr) TaskTabR.FrameResize(GB.Value);
			}
		}


		private void TC_TabIndexChanged(object sender, EventArgs e) {
			// todo: need to move NewTaskButt below the last task
			if (TabClearEdit) return;
			MoveNTB(TC.SelectedIndex);

		}

		public void MoveNTB (int tab) {
			Timer2.MainTimer.NewTaskButt.Parent?.Controls.Remove(Timer2.MainTimer.NewTaskButt);
			Timer2.TabGRAr[tab].Controls.Add(Timer2.MainTimer.NewTaskButt);
			Timer2.MainTimer.NewTaskButt.Location=new Point(6, (Timer2.CurTProgra.TaskTabRAr[tab].TaskAr.Count == 0? 6 : Timer2.GBAr[(tab, Timer2.CurTProgra.TaskTabRAr[tab].TaskAr.Count-1)].Location.Y+Timer2.GBAr[(tab, Timer2.CurTProgra.TaskTabRAr[tab].TaskAr.Count-1)].Height+6));
		}

		private void NewTaskButt_Click(object sender, EventArgs e) {
			if (CurTProgra==null) return;
			CreateNewTask.CurTaskBar=TC.SelectedIndex; NewTaskMenu.Clear(true); NewTaskMenu.Show();


		}

		// later on i need to add 3 functions to add a check, a counter or timer, and let this function use those
		public void GenerateTaskGUI(int TabN, int TaskN) {
			if (CurTProgra==null||CurTProgra.TaskTabRAr.Count<TabN||CurTProgra.TaskTabRAr[TabN].TaskAr.Count<TaskN) { System.Diagnostics.Debug.WriteLine("The given TabNumber or TaskNumber doesn't exists!"); return; }
			if (FPAr.ContainsKey((TabN, TaskN))) { System.Diagnostics.Debug.WriteLine("The Task Gui seems already exists, what went wrong?"); return; }
			TPTask CurTask = CurTProgra.TaskTabRAr[TabN][TaskN];

			// Initalize the Lists
			GBAr.Add((TabN, TaskN), new GroupBox { Name=("GP_"+TabN+"_"+TaskN), Text=CurTask.ID, Size=new Size(TC.Width-52, CurTask.GH), Location=new Point(6, 6+(TaskN >0? GBAr[(TabN, TaskN-1)].Location.Y + GBAr[(TabN, TaskN-1)].Height : 0)), BackColor=CurTask.TaskColor });
			FPAr.Add((TabN, TaskN), new FlowLayoutPanel { Name=("FGP_"+TabN+"_"+TaskN), AutoSize=true, AutoScroll=true, Dock=DockStyle.Fill, Padding=new Padding(10) });
			TDDSAr.Add((TabN, TaskN), new Button { Name=("TaskDDS_"+TabN+"_"+TaskN), Text="?", Size = new Size(19, 23), Location = new Point(GBAr[(TabN, TaskN)].Width - 21, 2), TextAlign=ContentAlignment.MiddleCenter, BackColor = SystemColors.ControlDark });
			
			//SBAr.Add((TabN, TaskN), new VScrollBar	{ Name=("SB_"+TabN+"_"+TaskN), Maximum = 10, Visible = false  });
			ChAr.Add((TabN, TaskN), new List<CheckBox>());
			CBuAr.Add((TabN, TaskN), new List<Button>());
			CLAr.Add((TabN, TaskN), new List<Label>());

			TNAr.Add((TabN, TaskN), new List<Label>());
			TSBuAr.Add((TabN, TaskN), new List<Button>());
			TPBuAr.Add((TabN, TaskN), new List<Button>());
			TPBAr.Add((TabN, TaskN), new List<ProgressBar>());
			TLAr.Add((TabN, TaskN), new List<Label>());

			// ========= Groupbox setting
			GBAr[(TabN, TaskN)].Controls.Add(FPAr[(TabN, TaskN)]);
			//GBAr[(TabN, TaskN)].Controls.Add(SBAr[(TabN, TaskN)]);
			//SBAr[(TabN, TaskN)].Location=new Point( GBAr[(TabN, TaskN)].Size.Width - 20, 10);
			//SBAr[(TabN, TaskN)].Height = GBAr[(TabN, TaskN)].Size.Height-10;
			//SBAr[(TabN, TaskN)].BringToFront();

			FlowLayoutPanel TGP = FPAr[(TabN, TaskN)];
			//SBAr[(TabN, TaskN)].Scroll+=Task_GB_SB_ScrollAction;

			// =========== Generate the Todo
			for (int i = 0; i<CurTask.CheckData.Count; i++) {
				ChAr[(TabN, TaskN)].Add(new CheckBox { Text=CurTask.CheckData[i].Substring(1), AutoSize = true, TextAlign=ContentAlignment.MiddleCenter, FlatStyle = FlatStyle.Popup, BackColor = SystemColors.ControlDark });
				if (CurTask.CheckData[i][0]=='0') { ChAr[(TabN, TaskN)][i].Appearance=Appearance.Button; ChAr[(TabN, TaskN)][i].CheckedChanged+=CheckChecked; }
				ToolTip.SetToolTip(ChAr[(TabN, TaskN)][i], CurTask.CheckDDS[i]);
				TGP.Controls.Add(ChAr[(TabN, TaskN)][i]);
				if (i==CurTask.CheckData.Count-1) TGP.SetFlowBreak(ChAr[(TabN, TaskN)][i], true);
			}

			// =========== Generate the Counter
			for (int i = 0; i<CurTask.CountersName.Count; i++) {
				int k = 0; string ConTo = TK.Token(CurTask.CountersName[i], ref k, '_');
				string ConName = TK.Token(CurTask.CountersName[i], ref k, '\r');
				string ConDDS = CurTask.CountersDDS[i];

				CLAr[(TabN, TaskN)].Add(new Label { Text=ConName, TextAlign=ContentAlignment.MiddleCenter });
				CBuAr[(TabN, TaskN)].Add(new Button { Name=("CB_"+TabN+"_"+TaskN+"_"+i), Text="0\\"+ConTo, TextAlign=ContentAlignment.MiddleCenter, BackColor = SystemColors.ControlDark});

				CBuAr[(TabN, TaskN)][i].MouseDown+=Counter_MouseDown;
				TGP.Controls.Add(CLAr[(TabN, TaskN)][i]); TGP.Controls.Add(CBuAr[(TabN, TaskN)][i]);
				if (i==CurTask.CheckData.Count-1) TGP.SetFlowBreak(CBuAr[(TabN, TaskN)][i], true);

			}

			// =========== Generate the Timers
			for (int i = 0; i<CurTask.TimersName.Count; i++) {
				long TVal = CurTask.DefaultTimersValue[i];
				string TName = CurTask.TimersName[i].Substring(2);
				string TDDS = CurTask.TimersDDS[i];
				int TimerType = int.Parse(CurTask.TimersName[i][0].ToString());
				bool TF1 = ((TimerType&1)==1), TF2 = ((TimerType&2)==2); // digit\bar and down\up
				TSBuAr[(TabN, TaskN)].Add(new Button { Name=("TSB_"+TabN+"_"+TaskN+"_"+i), Text="\u23F9", Width=30, TextAlign=ContentAlignment.MiddleCenter, BackColor = SystemColors.ControlDark });
				TPBuAr[(TabN, TaskN)].Add(new Button { Name=("TPB_"+TabN+"_"+TaskN+"_"+i), Text="\u25B6", Width=30, TextAlign=ContentAlignment.MiddleCenter, BackColor = SystemColors.ControlDark });

				// guess will change the progress bar values into 0 to 100, to avoid problems, and make the events handle the rest
				TPBAr[(TabN, TaskN)].Add(new ProgressBar { Value=(TF2 ? 100 : 0), Visible=TF1 });
				TNAr[(TabN, TaskN)].Add(new Label { Text=TName, Visible=TF1, TextAlign=ContentAlignment.MiddleCenter });
				TLAr[(TabN, TaskN)].Add(new Label { Text=(TF2 ? TimeSpan.FromMilliseconds(TVal).ToString(@"hh\:mm\:ss") : TimeSpan.FromMilliseconds(0).ToString(@"hh\:mm\:ss")), Visible=!TF1, TextAlign=ContentAlignment.MiddleCenter, Font=new Font("Segoe UI", 14, FontStyle.Bold) });
				TGP.Controls.Add(TSBuAr[(TabN, TaskN)][i]); TGP.Controls.Add(TPBuAr[(TabN, TaskN)][i]); TGP.Controls.Add(TPBAr[(TabN, TaskN)][i]); TGP.Controls.Add(TLAr[(TabN, TaskN)][i]);
				// i could add some kind of a tag to add a new line or not
				//TGP.SetFlowBreak( (TF1? TLAr[(TabN, TaskN)][i]:TPBAr[(TabN, TaskN)][i]) , true);

				ToolTip.SetToolTip(TSBuAr[(TabN, TaskN)][i], "Reset the time " + (TF2? " to ": " of ") + TimeSpan.FromMilliseconds(TVal).ToString(@"hh\:mm\:ss")); ToolTip.SetToolTip(TPBuAr[(TabN, TaskN)][i], "Play\\Pause the timer");
				ToolTip.SetToolTip(TPBAr[(TabN, TaskN)][i], TName); ToolTip.SetToolTip(TNAr[(TabN, TaskN)][i], TName); ToolTip.SetToolTip(TLAr[(TabN, TaskN)][i], TName);

				// Add events
				TSBuAr[(TabN, TaskN)][i].MouseDown+=Timer_StopButt; TPBuAr[(TabN, TaskN)][i].MouseDown+=Timer_PlayButt;

				if (TF1) { } else { }
				if (TF2) { CurTask.TimersValue[i]=TVal;  }

			}

			// =========== add it to the list to Check reset or expire
			TaskCheckTimeAr.Add((TabN, TaskN), false);

			// =========== Add Controls
			GBAr[(TabN, TaskN)].Controls.Add ( TDDSAr[(TabN, TaskN)] );
			ToolTip.SetToolTip(TDDSAr[(TabN, TaskN)], (CurTask.DDS != ""? CurTask.DDS: "This task have no description"));
			TabGRAr[TabN].Controls.Add(GBAr[(TabN, TaskN)]);

			// i could later work on making groub boxes free in the page, where you can change their position or have more than one groub box in the row
			ControlResizer.Init(GBAr[(TabN, TaskN)], 2, TaskTabR.FrameResize);
			TDDSAr[(TabN, TaskN)].BringToFront(); TDDSAr[(TabN, TaskN)].MouseDown+=TaskEdit;
		}
		
		public void NukeTasksGUI () {
			TaskCheckTimeAr.Clear();
			foreach (KeyValuePair<(int, int), GroupBox> GB in GBAr) { DeleteTaskGUI(GB.Key.Item1, GB.Key.Item2); }
		}

		public void DeleteTaskGUI (int TabN, int TaskN) {
			if (!GBAr.ContainsKey((TabN, TaskN))) { System.Diagnostics.Debug.WriteLine("The given TabNumber or TaskNumber doesn't exists!"); return; }
			FPAr[(TabN, TaskN)].Controls.Clear(); FPAr[(TabN, TaskN)].Dispose();
			GBAr[(TabN, TaskN)].Controls.Clear(); GBAr[(TabN, TaskN)].Dispose();
			TDDSAr[(TabN, TaskN)].Dispose();
			GBAr.Remove((TabN, TaskN)); FPAr.Remove((TabN, TaskN)); TDDSAr.Remove((TabN, TaskN));
			ChAr.Remove((TabN, TaskN)); CBuAr.Remove((TabN, TaskN)); CLAr.Remove((TabN, TaskN));
			TNAr.Remove((TabN, TaskN)); TSBuAr.Remove((TabN, TaskN)); TPBuAr.Remove((TabN, TaskN)); TPBAr.Remove((TabN, TaskN)); TLAr.Remove((TabN, TaskN));
			System.Diagnostics.Debug.WriteLine("Task GUI Deleted: Tab= "+TabN+" Task= "+TaskN);
		}

		#endregion

		public static int TTTabN = 0, TTTaskN = 0;
		private void Timer1_Tick(object sender, EventArgs e) {
			if (CurTProgra==null) { Timer1.Enabled=false; return; }

			foreach (TaskTabR TBK in CurTProgra.TaskTabRAr) {

				foreach (TPTask TK in TBK.TaskAr) {
					for (int i = 0; i<TK.TimersValue.Count; i++) {
						if (!TK.TimersRunning[i]) continue;
						TK.TimersValue[i]+=(TK.TimersType[i] ? -100 : 100);

						if (TPBAr[(TTTabN, TTTaskN)][i].Visible) {
							TPBAr[(TTTabN, TTTaskN)][i].Value=Math.Max(0, Math.Min(100, (int)(TK.TimersValue[i]/(TK.DefaultTimersValue[i]*0.01))));
							ToolTip.SetToolTip(TPBAr[(TTTabN, TTTaskN)][i], TK.TimersName[i].Substring(2)+": "+TimeSpan.FromMilliseconds(TK.TimersValue[i]).ToString(@"hh\:mm\:ss"));
						}
						TLAr[(TTTabN, TTTaskN)][i].Text=TimeSpan.FromMilliseconds(TK.TimersValue[i]).ToString(@"hh\:mm\:ss");

						// when the timer is done
						if ((TK.TimersType[i]&&TK.TimersValue[i]<=0)||(!TK.TimersType[i]&&TK.TimersValue[i]>=TK.DefaultTimersValue[i])) {
							TK.TimersDone[i]=true; TK.TimersRunning[i]=false; TPBuAr[(TTTabN, TTTaskN)][i].BackColor=Color.Green; TPBuAr[(TTTabN, TTTaskN)][i].Text="\u25B6";
							ToolTip.SetToolTip(TPBAr[(TTTabN, TTTaskN)][i], "Done!"); TLAr[(TTTabN, TTTaskN)][i].ForeColor=Color.Green;
						
							// either play a beep or a wave file
							if (TK.TimersWavPath[i] !="") {
								if (TK.TimersWavPath[i] =="Beep") System.Media.SystemSounds.Beep.Play();
								else if (File.Exists(TK.TimersWavPath[i])) PlayWavFile(TK.TimersWavPath[i]);
							}  
							
						}
					}
					TTTaskN++;
				}

				TTTabN++; TTTaskN=0;
			}
			TTTabN=TTTaskN=0;

			FirePerMin--; System.Diagnostics.Debug.WriteLine("FirePerMin: "+FirePerMin);
			if (FirePerMin<=0) { 
				FirePerMin=600; 
				System.Diagnostics.Debug.WriteLine("Expire time check!");
				foreach ( KeyValuePair <(int, int), bool> CD in TaskCheckTimeAr ) {
					if (CD.Value!=true) continue; 
					if (CurTProgra.TaskTabRAr[CD.Key.Item1].TaskAr[CD.Key.Item2].Days > 0) {

					}

					if (CurTProgra.TaskTabRAr[CD.Key.Item1].TaskAr[CD.Key.Item2].Expire != null) {

					}
				}
			}
		}

		private void PlayWavFile(string path) {
			AlarmPlayer.Stop();
			AlarmPlayer.SoundLocation=path; 
			AlarmPlayer.Play(); // PlaySync() blocks, PlayLooping() loops
		}

		private void StopWav() { AlarmPlayer.Stop(); }

		}
}
