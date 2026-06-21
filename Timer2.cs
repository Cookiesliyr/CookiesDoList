
namespace Timer2 {
	public partial class Timer2: Form {
		public static Timer2 MainTimer;
		public static CreateNewProgramFile NewTPFMenu = new CreateNewProgramFile();
		public static TaskTabsEditor TTEMenu = new TaskTabsEditor();
		public static CreateNewTask NewTaskMenu = new CreateNewTask();

		public static TProgram CurTProgra;


		public static bool EditMode = false;

		public Timer2() {
			MainTimer=this;
			// Todo: here we could do autoload if file exists
			// If not exist create a new one with the default taps
			if (CurTProgra==null) {
				CurTProgra=new TProgram("Timer2 Def", "The Default program");
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab1", "Daily", "A task collection that represent Daily Tasks."));
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab2", "Weekly", "A task collection that represent Weekly Tasks."));
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab3", "Extra", "A task collection that represent Additional Tasks."));
				CurTProgra.TaskTabRAr.Add(new TaskTabR("Tab4", "ToDo", "A task collection that represent Todo tasks."));

			}
			InitializeComponent();
		}


		#region TProgram Region
		private void SMCreate_Click(object sender, EventArgs e) {

		}

		private void SMLoad_Click(object sender, EventArgs e) {

		}
		#endregion

		#region Edit Region
		private void SMEdit_Click(object sender, EventArgs e) {
			EnterEditMode();

		}

		// this function will turn Edit Mode on\off
		public void EnterEditMode() {
			EditMode=!EditMode;
			EditMTabs.Visible=NewTaskButt.Visible=EditMode;
		}


		private void EditMTabs_Click(object sender, EventArgs e) {
			if (CurTProgra==null) { return; }
			TTEMenu.Show(); TTEMenu.TabsINI(); Enabled=false;
		}

		// To resize TaskTabControl and all the tasks groups inside on Windows Resize
		private void Timer2_ResizeEnd(object sender, EventArgs e) {
			TC.Width=Width-22; TC.Height=Height-70;
			NewTaskButt.Width=TC.Width-30;
		}

		private void TC_TabIndexChanged(object sender, EventArgs e) {
			// todo: need to move NewTaskButt below the last task

		}

		private void NewTaskButt_Click(object sender, EventArgs e) {
			if (CurTProgra==null) return;
			NewTaskMenu.Show();
		}

		// need to add an event for editing Task by using same NewTaskMenu but for editing
		#endregion



		
	}
}
