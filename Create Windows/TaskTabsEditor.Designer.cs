namespace Timer2 {
	partial class TaskTabsEditor {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing&&(components!=null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			TabList=new ListBox();
			label1=new Label();
			TabAdd=new Button();
			TabSave=new Button();
			TabDel=new Button();
			TabName=new TextBox();
			TabDDS=new TextBox();
			label2=new Label();
			label3=new Label();
			TEOK=new Button();
			TECancel=new Button();
			label4=new Label();
			TabID=new TextBox();
			SuspendLayout();
			// 
			// TabList
			// 
			TabList.FormattingEnabled=true;
			TabList.Location=new Point(12, 25);
			TabList.Name="TabList";
			TabList.ScrollAlwaysVisible=true;
			TabList.Size=new Size(170, 244);
			TabList.TabIndex=0;
			TabList.SelectedIndexChanged+=TabList_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Location=new Point(14, 6);
			label1.Name="label1";
			label1.Size=new Size(30, 15);
			label1.TabIndex=1;
			label1.Text="Tabs";
			// 
			// TabAdd
			// 
			TabAdd.BackColor=Color.LimeGreen;
			TabAdd.FlatStyle=FlatStyle.Flat;
			TabAdd.Font=new Font("Segoe UI", 9F);
			TabAdd.Location=new Point(130, 276);
			TabAdd.Name="TabAdd";
			TabAdd.Size=new Size(52, 26);
			TabAdd.TabIndex=2;
			TabAdd.Text="Add";
			TabAdd.UseVisualStyleBackColor=false;
			TabAdd.Click+=TabAdd_Click;
			// 
			// TabSave
			// 
			TabSave.BackColor=Color.LimeGreen;
			TabSave.FlatStyle=FlatStyle.Flat;
			TabSave.Font=new Font("Segoe UI", 9F);
			TabSave.Location=new Point(70, 276);
			TabSave.Name="TabSave";
			TabSave.Size=new Size(52, 26);
			TabSave.TabIndex=3;
			TabSave.Text="Save";
			TabSave.UseVisualStyleBackColor=false;
			TabSave.Click+=TabSave_Click;
			// 
			// TabDel
			// 
			TabDel.BackColor=Color.LimeGreen;
			TabDel.FlatStyle=FlatStyle.Flat;
			TabDel.Font=new Font("Segoe UI", 9F);
			TabDel.Location=new Point(12, 276);
			TabDel.Name="TabDel";
			TabDel.Size=new Size(52, 26);
			TabDel.TabIndex=4;
			TabDel.Text="Del";
			TabDel.UseVisualStyleBackColor=false;
			TabDel.Click+=TabDel_Click;
			// 
			// TabName
			// 
			TabName.Location=new Point(188, 87);
			TabName.Name="TabName";
			TabName.Size=new Size(192, 23);
			TabName.TabIndex=5;
			// 
			// TabDDS
			// 
			TabDDS.Location=new Point(188, 131);
			TabDDS.Multiline=true;
			TabDDS.Name="TabDDS";
			TabDDS.ScrollBars=ScrollBars.Vertical;
			TabDDS.Size=new Size(192, 138);
			TabDDS.TabIndex=6;
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(188, 113);
			label2.Name="label2";
			label2.Size=new Size(88, 15);
			label2.TabIndex=7;
			label2.Text="Tab Description";
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(188, 69);
			label3.Name="label3";
			label3.Size=new Size(60, 15);
			label3.TabIndex=8;
			label3.Text="Tab Name";
			// 
			// TEOK
			// 
			TEOK.BackColor=Color.LimeGreen;
			TEOK.FlatStyle=FlatStyle.Flat;
			TEOK.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TEOK.Location=new Point(250, 327);
			TEOK.Name="TEOK";
			TEOK.Size=new Size(130, 44);
			TEOK.TabIndex=10;
			TEOK.Text="OK";
			TEOK.UseVisualStyleBackColor=false;
			TEOK.Click+=TEOK_Click;
			// 
			// TECancel
			// 
			TECancel.BackColor=Color.LimeGreen;
			TECancel.FlatStyle=FlatStyle.Flat;
			TECancel.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TECancel.Location=new Point(14, 327);
			TECancel.Name="TECancel";
			TECancel.Size=new Size(130, 44);
			TECancel.TabIndex=9;
			TECancel.Text="Cancel";
			TECancel.UseVisualStyleBackColor=false;
			TECancel.Click+=TECancel_Click;
			// 
			// label4
			// 
			label4.AutoSize=true;
			label4.Location=new Point(188, 25);
			label4.Name="label4";
			label4.Size=new Size(39, 15);
			label4.TabIndex=12;
			label4.Text="Tab ID";
			// 
			// TabID
			// 
			TabID.Location=new Point(188, 43);
			TabID.Name="TabID";
			TabID.Size=new Size(192, 23);
			TabID.TabIndex=11;
			// 
			// TaskTabsEditor
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(392, 382);
			Controls.Add(label4);
			Controls.Add(TabID);
			Controls.Add(TEOK);
			Controls.Add(TECancel);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(TabDDS);
			Controls.Add(TabName);
			Controls.Add(TabDel);
			Controls.Add(TabSave);
			Controls.Add(TabAdd);
			Controls.Add(label1);
			Controls.Add(TabList);
			Name="TaskTabsEditor";
			StartPosition=FormStartPosition.CenterScreen;
			Text="TaskTabsEditor";
			FormClosing+=TaskTabsEditor_FormClosing;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ListBox TabList;
		private Label label1;
		private Button TabAdd;
		private Button TabSave;
		private Button TabDel;
		private TextBox TabName;
		private TextBox TabDDS;
		private Label label2;
		private Label label3;
		private Button TEOK;
		private Button TECancel;
		private Label label4;
		private TextBox TabID;
	}
}