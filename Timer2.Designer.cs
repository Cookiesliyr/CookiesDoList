namespace Timer2
{
    partial class Timer2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components=new System.ComponentModel.Container();
			menuStrip1=new MenuStrip();
			SMFile=new ToolStripMenuItem();
			SMCreate=new ToolStripMenuItem();
			SMSave=new ToolStripMenuItem();
			SMLoad=new ToolStripMenuItem();
			SMAuto=new ToolStripMenuItem();
			SMEdit=new ToolStripMenuItem();
			SMReport=new ToolStripMenuItem();
			EditMTabs=new Button();
			TC=new TabControl();
			TCTab1=new TabPage();
			TCTab2=new TabPage();
			TCTab3=new TabPage();
			TCTab4=new TabPage();
			NewTaskButt=new Button();
			ToolTip=new ToolTip(components);
			Timer1=new System.Windows.Forms.Timer(components);
			SFD=new SaveFileDialog();
			LFD=new OpenFileDialog();
			ColorD=new ColorDialog();
			menuStrip1.SuspendLayout();
			TC.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { SMFile, SMEdit, SMReport });
			menuStrip1.Location=new Point(0, 0);
			menuStrip1.Name="menuStrip1";
			menuStrip1.Size=new Size(595, 24);
			menuStrip1.TabIndex=0;
			menuStrip1.Text="menuStrip1";
			// 
			// SMFile
			// 
			SMFile.DropDownItems.AddRange(new ToolStripItem[] { SMCreate, SMSave, SMLoad, SMAuto });
			SMFile.Name="SMFile";
			SMFile.Size=new Size(37, 20);
			SMFile.Text="File";
			// 
			// SMCreate
			// 
			SMCreate.Name="SMCreate";
			SMCreate.Size=new Size(184, 22);
			SMCreate.Text="Create New Program";
			SMCreate.Click+=SMCreate_Click;
			// 
			// SMSave
			// 
			SMSave.Name="SMSave";
			SMSave.Size=new Size(184, 22);
			SMSave.Text="Save Program";
			SMSave.Click+=SMSave_Click;
			// 
			// SMLoad
			// 
			SMLoad.Name="SMLoad";
			SMLoad.Size=new Size(184, 22);
			SMLoad.Text="Load Program";
			SMLoad.Click+=SMLoad_Click;
			// 
			// SMAuto
			// 
			SMAuto.Name="SMAuto";
			SMAuto.Size=new Size(184, 22);
			SMAuto.Text="Set default program";
			SMAuto.Click+=SMAuto_Click;
			// 
			// SMEdit
			// 
			SMEdit.Name="SMEdit";
			SMEdit.Size=new Size(39, 20);
			SMEdit.Text="Edit";
			SMEdit.Click+=SMEdit_Click;
			// 
			// SMReport
			// 
			SMReport.Name="SMReport";
			SMReport.Size=new Size(54, 20);
			SMReport.Text="Report";
			// 
			// EditMTabs
			// 
			EditMTabs.Location=new Point(561, 26);
			EditMTabs.Name="EditMTabs";
			EditMTabs.Size=new Size(21, 22);
			EditMTabs.TabIndex=0;
			EditMTabs.Text="✎";
			EditMTabs.UseVisualStyleBackColor=true;
			EditMTabs.Visible=false;
			EditMTabs.Click+=EditMTabs_Click;
			// 
			// TC
			// 
			TC.Controls.Add(TCTab1);
			TC.Controls.Add(TCTab2);
			TC.Controls.Add(TCTab3);
			TC.Controls.Add(TCTab4);
			TC.Location=new Point(0, 27);
			TC.Name="TC";
			TC.SelectedIndex=0;
			TC.Size=new Size(595, 275);
			TC.TabIndex=1;
			TC.SelectedIndexChanged+=TC_TabIndexChanged;
			// 
			// TCTab1
			// 
			TCTab1.Location=new Point(4, 24);
			TCTab1.Name="TCTab1";
			TCTab1.Size=new Size(587, 247);
			TCTab1.TabIndex=0;
			TCTab1.Text="Daily";
			TCTab1.UseVisualStyleBackColor=true;
			// 
			// TCTab2
			// 
			TCTab2.Location=new Point(4, 24);
			TCTab2.Name="TCTab2";
			TCTab2.Size=new Size(587, 247);
			TCTab2.TabIndex=1;
			TCTab2.Text="Weekly";
			TCTab2.UseVisualStyleBackColor=true;
			// 
			// TCTab3
			// 
			TCTab3.Location=new Point(4, 24);
			TCTab3.Name="TCTab3";
			TCTab3.Size=new Size(587, 247);
			TCTab3.TabIndex=2;
			TCTab3.Text="Extra";
			TCTab3.UseVisualStyleBackColor=true;
			// 
			// TCTab4
			// 
			TCTab4.Location=new Point(4, 24);
			TCTab4.Name="TCTab4";
			TCTab4.Size=new Size(587, 247);
			TCTab4.TabIndex=3;
			TCTab4.Text="ToDo";
			TCTab4.UseVisualStyleBackColor=true;
			// 
			// NewTaskButt
			// 
			NewTaskButt.Font=new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
			NewTaskButt.Location=new Point(12, 61);
			NewTaskButt.Name="NewTaskButt";
			NewTaskButt.Size=new Size(565, 75);
			NewTaskButt.TabIndex=0;
			NewTaskButt.Text="Add Task";
			NewTaskButt.UseVisualStyleBackColor=true;
			NewTaskButt.Visible=false;
			NewTaskButt.Click+=NewTaskButt_Click;
			// 
			// Timer1
			// 
			Timer1.Tick+=Timer1_Tick;
			// 
			// SFD
			// 
			SFD.Filter="Task save file(*.tsk)|*.tsk";
			// 
			// LFD
			// 
			LFD.Filter="Task save file(*.tsk)|*.tsk";
			// 
			// Timer2
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(595, 304);
			Controls.Add(NewTaskButt);
			Controls.Add(EditMTabs);
			Controls.Add(menuStrip1);
			Controls.Add(TC);
			MainMenuStrip=menuStrip1;
			Name="Timer2";
			StartPosition=FormStartPosition.CenterScreen;
			Text="Timer 2";
			ResizeEnd+=Timer2_ResizeEnd;
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			TC.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem SMFile;
		private ToolStripMenuItem SMCreate;
		private ToolStripMenuItem SMLoad;
		private ToolStripMenuItem SMReport;
		private ToolStripMenuItem SMEdit;
		public Button EditMTabs;
		private TabPage TCTab1;
		private TabPage TCTab2;
		private TabPage TCTab3;
		private TabPage TCTab4;
		public TabControl TC;
		private ToolTip ToolTip;
		private System.Windows.Forms.Timer Timer1;
		private ToolStripMenuItem SMSave;
		private SaveFileDialog SFD;
		private OpenFileDialog LFD;
		private ToolStripMenuItem SMAuto;
		public Button NewTaskButt;
		public ColorDialog ColorD;
	}
}
