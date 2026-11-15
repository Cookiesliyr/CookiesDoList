using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer2 {
	public partial class TaskTabsEditor: Form {
		TProgram TPR, TTPR;

		public TaskTabsEditor() { InitializeComponent(); }

		private void TaskTabsEditor_FormClosing(object sender, FormClosingEventArgs e) { if (e.CloseReason==CloseReason.UserClosing) { e.Cancel=true; Hide(); Timer2.ReturnToTimer(); } else base.OnFormClosing(e); }

		public void TabsINI() {
			TPR=Timer2.CurTProgra; TTPR=TPR.Clone();
			TabList.Items.Clear();
			for (int i = 0; i<TPR.TaskTabRAr.Count; i++) {
				TabList.Items.Add(TPR.TaskTabRAr[i].ID);
			}

		}

		private void TECancel_Click(object sender, EventArgs e) { 
			// to make Cancels works i should make a copy of the TProgram and load the copy if Cancel is clicked
			Timer2.CurTProgra = TTPR.Clone();
			Timer2.MainTimer.LoadCurProgram();
			Hide(); Timer2.ReturnToTimer(); 
		}

		private void TEOK_Click(object sender, EventArgs e) {
			TTPR=null;
			Hide(); Timer2.ReturnToTimer(); 
		}

		#region Edit Tabs
		private void TabList_SelectedIndexChanged(object sender, EventArgs e) {
			if (TabList.SelectedIndex<=-1) return;
			TabID.BackColor = Color.White;
			TabID.Text = TPR.TaskTabRAr[TabList.SelectedIndex].ID;
			TabName.Text = TPR.TaskTabRAr[TabList.SelectedIndex].TabName;
			TabDDS.Text  = TPR.TaskTabRAr[TabList.SelectedIndex].DDS;
		}

		private void TabAdd_Click(object sender, EventArgs e) {
			// should the Tabs name generated or created? and if created should i check for unique?
			TaskTabR R = null;
			if (TabID.Text.Contains(' ')|| (R=TPR.TaskTabRAr.Find(x => x.ID == TabID.Text)) != null) {  TabID.BackColor=Color.Red; return; }
			TPR.TaskTabRAr.Add(new TaskTabR(TabID.Text, TabName.Text, TabDDS.Text));
			TabList.Items.Add(TabID.Text);
			TabPage TTP = new TabPage();
			TTP.Name="TabID.Text"; TTP.Location=new Point(4, 24);TTP.Size=new Size(587, 247); 
			TTP.Text=TabName.Text; TTP.UseVisualStyleBackColor=true; TTP.TabIndex=TabList.Items.Count;
			Timer2.TabGRAr.Add(new Panel { Location=new Point(3, 3), Size=new Size(Width-35, Height-100), AutoSize=true, AutoScroll=true, Dock=DockStyle.Fill });
			Timer2.MainTimer.TC.TabPages.Add(TTP);
			Timer2.MainTimer.TC.TabPages[Timer2.TabGRAr.Count-1].Controls.Add(Timer2.TabGRAr[Timer2.TabGRAr.Count-1]);
			TabsReinitalize();
		}

		private void TabSave_Click(object sender, EventArgs e) {
			if (TabList.SelectedIndex<=-1) return;
			TPR.TaskTabRAr[TabList.SelectedIndex].TabName=Timer2.MainTimer.TC.TabPages[TabList.SelectedIndex].Text=TabName.Text;
			TPR.TaskTabRAr[TabList.SelectedIndex].DDS = TabDDS.Text;
			TabsReinitalize();
		}

		private void TabDel_Click(object sender, EventArgs e) {
			if (TabList.SelectedIndex<=-1) return;
			if (MessageBox.Show("Are you sure you want to delete this Tab and all of its tasks?", "Delete Tab", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
			while (TPR.TaskTabRAr[TabList.SelectedIndex].TaskAr.Count > 0){
				Timer2.MainTimer.DeleteTaskGUI(TabList.SelectedIndex, TPR.TaskTabRAr[TabList.SelectedIndex].TaskAr.Count-1);
				TPR.TaskTabRAr[TabList.SelectedIndex].TaskAr.RemoveAt(TPR.TaskTabRAr[TabList.SelectedIndex].TaskAr.Count-1);
			}

			Timer2.TabGRAr.RemoveAt(TabList.SelectedIndex);
			TPR.TaskTabRAr.RemoveAt(TabList.SelectedIndex);
			Timer2.MainTimer.TC.TabPages.RemoveAt(TabList.SelectedIndex);
			TabList.Items.RemoveAt(TabList.SelectedIndex);
			TabsReinitalize();
		}

		private void TabsReinitalize () {
			TabID.Text = TabName.Text=TabDDS.Text=""; TabList.SelectedIndex=-1; TabID.BackColor = Color.White;
		
		}
		#endregion
		
	}
}
