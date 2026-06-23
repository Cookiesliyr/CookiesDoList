namespace Timer2 {
	partial class CreateNewTask {
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
			TC=new TabControl();
			tabPage1=new TabPage();
			groupBox3=new GroupBox();
			CheckDDS=new TextBox();
			label10=new Label();
			label2=new Label();
			CheckRB2=new RadioButton();
			CheckRB1=new RadioButton();
			CheckText=new TextBox();
			label3=new Label();
			CheckDel=new Button();
			CheckSave=new Button();
			CheckAdd=new Button();
			CheckList=new ListBox();
			tabPage2=new TabPage();
			groupBox2=new GroupBox();
			label9=new Label();
			CounterDDS=new TextBox();
			label1=new Label();
			CounterName=new TextBox();
			CounterDel=new Button();
			CounterSave=new Button();
			CounterAdd=new Button();
			CounterList=new ListBox();
			tabPage3=new TabPage();
			groupBox1=new GroupBox();
			label8=new Label();
			TimerDDS=new TextBox();
			label7=new Label();
			TimerName=new TextBox();
			panel2=new Panel();
			label6=new Label();
			TimerRB4=new RadioButton();
			TimerRB3=new RadioButton();
			panel1=new Panel();
			label4=new Label();
			TimerRB2=new RadioButton();
			TimerRB1=new RadioButton();
			label5=new Label();
			TimerValue=new NumericUpDown();
			TimerDel=new Button();
			TimerSave=new Button();
			TimerAdd=new Button();
			TimerList=new ListBox();
			TaskOk=new Button();
			TaskCancel=new Button();
			TaskName=new TextBox();
			label11=new Label();
			TC.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox3.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox2.SuspendLayout();
			tabPage3.SuspendLayout();
			groupBox1.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)TimerValue).BeginInit();
			SuspendLayout();
			// 
			// TC
			// 
			TC.Controls.Add(tabPage1);
			TC.Controls.Add(tabPage2);
			TC.Controls.Add(tabPage3);
			TC.Location=new Point(12, 40);
			TC.Name="TC";
			TC.SelectedIndex=0;
			TC.Size=new Size(571, 372);
			TC.TabIndex=0;
			// 
			// tabPage1
			// 
			tabPage1.Controls.Add(groupBox3);
			tabPage1.Controls.Add(CheckDel);
			tabPage1.Controls.Add(CheckSave);
			tabPage1.Controls.Add(CheckAdd);
			tabPage1.Controls.Add(CheckList);
			tabPage1.Location=new Point(4, 24);
			tabPage1.Name="tabPage1";
			tabPage1.Padding=new Padding(3);
			tabPage1.Size=new Size(563, 344);
			tabPage1.TabIndex=0;
			tabPage1.Text="Todo";
			tabPage1.UseVisualStyleBackColor=true;
			// 
			// groupBox3
			// 
			groupBox3.Controls.Add(CheckDDS);
			groupBox3.Controls.Add(label10);
			groupBox3.Controls.Add(label2);
			groupBox3.Controls.Add(CheckRB2);
			groupBox3.Controls.Add(CheckRB1);
			groupBox3.Controls.Add(CheckText);
			groupBox3.Controls.Add(label3);
			groupBox3.Location=new Point(182, 6);
			groupBox3.Name="groupBox3";
			groupBox3.Size=new Size(375, 332);
			groupBox3.TabIndex=12;
			groupBox3.TabStop=false;
			groupBox3.Text="Todo setting";
			// 
			// CheckDDS
			// 
			CheckDDS.Location=new Point(6, 205);
			CheckDDS.Multiline=true;
			CheckDDS.Name="CheckDDS";
			CheckDDS.ScrollBars=ScrollBars.Vertical;
			CheckDDS.Size=new Size(363, 116);
			CheckDDS.TabIndex=23;
			// 
			// label10
			// 
			label10.AutoSize=true;
			label10.Location=new Point(6, 187);
			label10.Name="label10";
			label10.Size=new Size(100, 15);
			label10.TabIndex=22;
			label10.Text="ToDo: Description";
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(6, 19);
			label2.Name="label2";
			label2.Size=new Size(69, 15);
			label2.TabIndex=21;
			label2.Text="ToDo Shape";
			// 
			// CheckRB2
			// 
			CheckRB2.AutoSize=true;
			CheckRB2.Location=new Point(181, 19);
			CheckRB2.Name="CheckRB2";
			CheckRB2.Size=new Size(58, 19);
			CheckRB2.TabIndex=20;
			CheckRB2.TabStop=true;
			CheckRB2.Text="Check";
			CheckRB2.UseVisualStyleBackColor=true;
			// 
			// CheckRB1
			// 
			CheckRB1.AutoSize=true;
			CheckRB1.Location=new Point(81, 19);
			CheckRB1.Name="CheckRB1";
			CheckRB1.Size=new Size(61, 19);
			CheckRB1.TabIndex=19;
			CheckRB1.TabStop=true;
			CheckRB1.Text="Button";
			CheckRB1.UseVisualStyleBackColor=true;
			// 
			// CheckText
			// 
			CheckText.Location=new Point(6, 68);
			CheckText.Multiline=true;
			CheckText.Name="CheckText";
			CheckText.ScrollBars=ScrollBars.Vertical;
			CheckText.Size=new Size(363, 116);
			CheckText.TabIndex=18;
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(6, 50);
			label3.Name="label3";
			label3.Size=new Size(66, 15);
			label3.TabIndex=17;
			label3.Text="ToDo: Text*";
			// 
			// CheckDel
			// 
			CheckDel.BackColor=Color.LimeGreen;
			CheckDel.FlatStyle=FlatStyle.Flat;
			CheckDel.Font=new Font("Segoe UI", 9F);
			CheckDel.Location=new Point(6, 301);
			CheckDel.Name="CheckDel";
			CheckDel.Size=new Size(52, 26);
			CheckDel.TabIndex=11;
			CheckDel.Text="Del";
			CheckDel.UseVisualStyleBackColor=false;
			CheckDel.Click+=CheckDel_Click;
			// 
			// CheckSave
			// 
			CheckSave.BackColor=Color.LimeGreen;
			CheckSave.FlatStyle=FlatStyle.Flat;
			CheckSave.Font=new Font("Segoe UI", 9F);
			CheckSave.Location=new Point(64, 301);
			CheckSave.Name="CheckSave";
			CheckSave.Size=new Size(52, 26);
			CheckSave.TabIndex=10;
			CheckSave.Text="Save";
			CheckSave.UseVisualStyleBackColor=false;
			CheckSave.Click+=CheckSave_Click;
			// 
			// CheckAdd
			// 
			CheckAdd.BackColor=Color.LimeGreen;
			CheckAdd.FlatStyle=FlatStyle.Flat;
			CheckAdd.Font=new Font("Segoe UI", 9F);
			CheckAdd.Location=new Point(124, 301);
			CheckAdd.Name="CheckAdd";
			CheckAdd.Size=new Size(52, 26);
			CheckAdd.TabIndex=9;
			CheckAdd.Text="Add";
			CheckAdd.UseVisualStyleBackColor=false;
			CheckAdd.Click+=CheckAdd_Click;
			// 
			// CheckList
			// 
			CheckList.FormattingEnabled=true;
			CheckList.Location=new Point(6, 6);
			CheckList.Name="CheckList";
			CheckList.ScrollAlwaysVisible=true;
			CheckList.Size=new Size(170, 289);
			CheckList.TabIndex=8;
			CheckList.SelectedIndexChanged+=CheckList_SelectedIndexChanged;
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(groupBox2);
			tabPage2.Controls.Add(CounterDel);
			tabPage2.Controls.Add(CounterSave);
			tabPage2.Controls.Add(CounterAdd);
			tabPage2.Controls.Add(CounterList);
			tabPage2.Location=new Point(4, 24);
			tabPage2.Name="tabPage2";
			tabPage2.Padding=new Padding(3);
			tabPage2.Size=new Size(563, 344);
			tabPage2.TabIndex=1;
			tabPage2.Text="Counters";
			tabPage2.UseVisualStyleBackColor=true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label9);
			groupBox2.Controls.Add(CounterDDS);
			groupBox2.Controls.Add(label1);
			groupBox2.Controls.Add(CounterName);
			groupBox2.Location=new Point(182, 6);
			groupBox2.Name="groupBox2";
			groupBox2.Size=new Size(375, 321);
			groupBox2.TabIndex=16;
			groupBox2.TabStop=false;
			groupBox2.Text="Counter setting";
			// 
			// label9
			// 
			label9.AutoSize=true;
			label9.Location=new Point(6, 65);
			label9.Name="label9";
			label9.Size=new Size(113, 15);
			label9.TabIndex=21;
			label9.Text="Counter Description";
			// 
			// CounterDDS
			// 
			CounterDDS.Location=new Point(6, 83);
			CounterDDS.Name="CounterDDS";
			CounterDDS.Size=new Size(363, 23);
			CounterDDS.TabIndex=20;
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Location=new Point(6, 19);
			label1.Name="label1";
			label1.Size=new Size(100, 15);
			label1.TabIndex=19;
			label1.Text="Counter Caption*";
			// 
			// CounterName
			// 
			CounterName.Location=new Point(6, 37);
			CounterName.Name="CounterName";
			CounterName.Size=new Size(363, 23);
			CounterName.TabIndex=18;
			// 
			// CounterDel
			// 
			CounterDel.BackColor=Color.LimeGreen;
			CounterDel.FlatStyle=FlatStyle.Flat;
			CounterDel.Font=new Font("Segoe UI", 9F);
			CounterDel.Location=new Point(6, 301);
			CounterDel.Name="CounterDel";
			CounterDel.Size=new Size(52, 26);
			CounterDel.TabIndex=15;
			CounterDel.Text="Del";
			CounterDel.UseVisualStyleBackColor=false;
			CounterDel.Click+=CounterDel_Click;
			// 
			// CounterSave
			// 
			CounterSave.BackColor=Color.LimeGreen;
			CounterSave.FlatStyle=FlatStyle.Flat;
			CounterSave.Font=new Font("Segoe UI", 9F);
			CounterSave.Location=new Point(64, 301);
			CounterSave.Name="CounterSave";
			CounterSave.Size=new Size(52, 26);
			CounterSave.TabIndex=14;
			CounterSave.Text="Save";
			CounterSave.UseVisualStyleBackColor=false;
			CounterSave.Click+=CounterSave_Click;
			// 
			// CounterAdd
			// 
			CounterAdd.BackColor=Color.LimeGreen;
			CounterAdd.FlatStyle=FlatStyle.Flat;
			CounterAdd.Font=new Font("Segoe UI", 9F);
			CounterAdd.Location=new Point(124, 301);
			CounterAdd.Name="CounterAdd";
			CounterAdd.Size=new Size(52, 26);
			CounterAdd.TabIndex=13;
			CounterAdd.Text="Add";
			CounterAdd.UseVisualStyleBackColor=false;
			CounterAdd.Click+=CounterAdd_Click;
			// 
			// CounterList
			// 
			CounterList.FormattingEnabled=true;
			CounterList.Location=new Point(6, 6);
			CounterList.Name="CounterList";
			CounterList.ScrollAlwaysVisible=true;
			CounterList.Size=new Size(170, 289);
			CounterList.TabIndex=12;
			CounterList.SelectedIndexChanged+=CounterList_SelectedIndexChanged;
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(groupBox1);
			tabPage3.Controls.Add(TimerDel);
			tabPage3.Controls.Add(TimerSave);
			tabPage3.Controls.Add(TimerAdd);
			tabPage3.Controls.Add(TimerList);
			tabPage3.Location=new Point(4, 24);
			tabPage3.Name="tabPage3";
			tabPage3.Size=new Size(563, 344);
			tabPage3.TabIndex=2;
			tabPage3.Text="Timers";
			tabPage3.UseVisualStyleBackColor=true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label8);
			groupBox1.Controls.Add(TimerDDS);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(TimerName);
			groupBox1.Controls.Add(panel2);
			groupBox1.Controls.Add(panel1);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(TimerValue);
			groupBox1.Location=new Point(182, 6);
			groupBox1.Name="groupBox1";
			groupBox1.Size=new Size(378, 321);
			groupBox1.TabIndex=16;
			groupBox1.TabStop=false;
			groupBox1.Text="Timer Setting";
			// 
			// label8
			// 
			label8.AutoSize=true;
			label8.Location=new Point(9, 64);
			label8.Name="label8";
			label8.Size=new Size(100, 15);
			label8.TabIndex=23;
			label8.Text="Timer Description";
			// 
			// TimerDDS
			// 
			TimerDDS.Location=new Point(9, 82);
			TimerDDS.Name="TimerDDS";
			TimerDDS.Size=new Size(363, 23);
			TimerDDS.TabIndex=22;
			// 
			// label7
			// 
			label7.AutoSize=true;
			label7.Location=new Point(9, 20);
			label7.Name="label7";
			label7.Size=new Size(87, 15);
			label7.TabIndex=21;
			label7.Text="Timer Caption*";
			// 
			// TimerName
			// 
			TimerName.Location=new Point(9, 38);
			TimerName.Name="TimerName";
			TimerName.Size=new Size(363, 23);
			TimerName.TabIndex=20;
			// 
			// panel2
			// 
			panel2.Controls.Add(label6);
			panel2.Controls.Add(TimerRB4);
			panel2.Controls.Add(TimerRB3);
			panel2.Location=new Point(9, 153);
			panel2.Name="panel2";
			panel2.Size=new Size(284, 36);
			panel2.TabIndex=6;
			// 
			// label6
			// 
			label6.AutoSize=true;
			label6.Location=new Point(3, 10);
			label6.Name="label6";
			label6.Size=new Size(52, 15);
			label6.TabIndex=1;
			label6.Text="progress";
			// 
			// TimerRB4
			// 
			TimerRB4.AutoSize=true;
			TimerRB4.Location=new Point(123, 8);
			TimerRB4.Name="TimerRB4";
			TimerRB4.Size=new Size(40, 19);
			TimerRB4.TabIndex=4;
			TimerRB4.Text="Up";
			TimerRB4.UseVisualStyleBackColor=true;
			// 
			// TimerRB3
			// 
			TimerRB3.AutoSize=true;
			TimerRB3.Checked=true;
			TimerRB3.Location=new Point(56, 8);
			TimerRB3.Name="TimerRB3";
			TimerRB3.Size=new Size(56, 19);
			TimerRB3.TabIndex=3;
			TimerRB3.TabStop=true;
			TimerRB3.Text="Down";
			TimerRB3.UseVisualStyleBackColor=true;
			// 
			// panel1
			// 
			panel1.Controls.Add(label4);
			panel1.Controls.Add(TimerRB2);
			panel1.Controls.Add(TimerRB1);
			panel1.Location=new Point(9, 111);
			panel1.Name="panel1";
			panel1.Size=new Size(284, 36);
			panel1.TabIndex=5;
			// 
			// label4
			// 
			label4.AutoSize=true;
			label4.Location=new Point(3, 10);
			label4.Name="label4";
			label4.Size=new Size(39, 15);
			label4.TabIndex=1;
			label4.Text="Shape";
			// 
			// TimerRB2
			// 
			TimerRB2.AutoSize=true;
			TimerRB2.Location=new Point(123, 8);
			TimerRB2.Name="TimerRB2";
			TimerRB2.Size=new Size(90, 19);
			TimerRB2.TabIndex=4;
			TimerRB2.Text="Progress bar";
			TimerRB2.UseVisualStyleBackColor=true;
			// 
			// TimerRB1
			// 
			TimerRB1.AutoSize=true;
			TimerRB1.Checked=true;
			TimerRB1.Location=new Point(56, 8);
			TimerRB1.Name="TimerRB1";
			TimerRB1.Size=new Size(50, 19);
			TimerRB1.TabIndex=3;
			TimerRB1.TabStop=true;
			TimerRB1.Text="Digit";
			TimerRB1.UseVisualStyleBackColor=true;
			// 
			// label5
			// 
			label5.AutoSize=true;
			label5.Location=new Point(6, 150);
			label5.Name="label5";
			label5.Size=new Size(76, 15);
			label5.TabIndex=2;
			label5.Text="Default value";
			// 
			// TimerValue
			// 
			TimerValue.Location=new Point(9, 212);
			TimerValue.Name="TimerValue";
			TimerValue.Size=new Size(181, 23);
			TimerValue.TabIndex=0;
			// 
			// TimerDel
			// 
			TimerDel.BackColor=Color.LimeGreen;
			TimerDel.FlatStyle=FlatStyle.Flat;
			TimerDel.Font=new Font("Segoe UI", 9F);
			TimerDel.Location=new Point(7, 301);
			TimerDel.Name="TimerDel";
			TimerDel.Size=new Size(52, 26);
			TimerDel.TabIndex=15;
			TimerDel.Text="Del";
			TimerDel.UseVisualStyleBackColor=false;
			TimerDel.Click+=TimerDel_Click;
			// 
			// TimerSave
			// 
			TimerSave.BackColor=Color.LimeGreen;
			TimerSave.FlatStyle=FlatStyle.Flat;
			TimerSave.Font=new Font("Segoe UI", 9F);
			TimerSave.Location=new Point(65, 301);
			TimerSave.Name="TimerSave";
			TimerSave.Size=new Size(52, 26);
			TimerSave.TabIndex=14;
			TimerSave.Text="Save";
			TimerSave.UseVisualStyleBackColor=false;
			TimerSave.Click+=TimerSave_Click;
			// 
			// TimerAdd
			// 
			TimerAdd.BackColor=Color.LimeGreen;
			TimerAdd.FlatStyle=FlatStyle.Flat;
			TimerAdd.Font=new Font("Segoe UI", 9F);
			TimerAdd.Location=new Point(125, 301);
			TimerAdd.Name="TimerAdd";
			TimerAdd.Size=new Size(52, 26);
			TimerAdd.TabIndex=13;
			TimerAdd.Text="Add";
			TimerAdd.UseVisualStyleBackColor=false;
			TimerAdd.Click+=TimerAdd_Click;
			// 
			// TimerList
			// 
			TimerList.FormattingEnabled=true;
			TimerList.Location=new Point(6, 6);
			TimerList.Name="TimerList";
			TimerList.ScrollAlwaysVisible=true;
			TimerList.Size=new Size(170, 289);
			TimerList.TabIndex=12;
			TimerList.SelectedIndexChanged+=TimerList_SelectedIndexChanged;
			// 
			// TaskOk
			// 
			TaskOk.BackColor=Color.LimeGreen;
			TaskOk.FlatStyle=FlatStyle.Flat;
			TaskOk.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TaskOk.Location=new Point(449, 414);
			TaskOk.Name="TaskOk";
			TaskOk.Size=new Size(130, 44);
			TaskOk.TabIndex=12;
			TaskOk.Text="OK";
			TaskOk.UseVisualStyleBackColor=false;
			TaskOk.Click+=TaskOk_Click;
			// 
			// TaskCancel
			// 
			TaskCancel.BackColor=Color.LimeGreen;
			TaskCancel.FlatStyle=FlatStyle.Flat;
			TaskCancel.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TaskCancel.Location=new Point(16, 419);
			TaskCancel.Name="TaskCancel";
			TaskCancel.Size=new Size(130, 44);
			TaskCancel.TabIndex=11;
			TaskCancel.Text="Cancel";
			TaskCancel.UseVisualStyleBackColor=false;
			TaskCancel.Click+=TaskCancel_Click;
			// 
			// TaskName
			// 
			TaskName.Location=new Point(99, 12);
			TaskName.Name="TaskName";
			TaskName.Size=new Size(484, 23);
			TaskName.TabIndex=19;
			// 
			// label11
			// 
			label11.AutoSize=true;
			label11.Font=new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label11.Location=new Point(12, 15);
			label11.Name="label11";
			label11.Size=new Size(81, 17);
			label11.TabIndex=20;
			label11.Text="Task Name*";
			// 
			// CreateNewTask
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(603, 474);
			Controls.Add(label11);
			Controls.Add(TaskName);
			Controls.Add(TaskOk);
			Controls.Add(TaskCancel);
			Controls.Add(TC);
			Name="CreateNewTask";
			Text="CreateNewTask";
			FormClosing+=CreateNewTask_FormClosing;
			Load+=CreateNewTask_Load;
			TC.ResumeLayout(false);
			tabPage1.ResumeLayout(false);
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			tabPage2.ResumeLayout(false);
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			tabPage3.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)TimerValue).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TabControl TC;
		private TabPage tabPage1;
		private Button CheckDel;
		private Button CheckSave;
		private Button CheckAdd;
		private ListBox CheckList;
		private TabPage tabPage2;
		private TabPage tabPage3;
		private Button CounterDel;
		private Button CounterSave;
		private Button CounterAdd;
		private ListBox CounterList;
		private Button TimerDel;
		private Button TimerSave;
		private Button TimerAdd;
		private ListBox TimerList;
		private Button TaskOk;
		private Button TaskCancel;
		private GroupBox groupBox1;
		private GroupBox groupBox3;
		private Label label2;
		private RadioButton CheckRB2;
		private RadioButton CheckRB1;
		private TextBox CheckText;
		private Label label3;
		private GroupBox groupBox2;
		private Label label1;
		private TextBox CounterName;
		private Panel panel2;
		private Label label6;
		private RadioButton TimerRB4;
		private RadioButton TimerRB3;
		private Panel panel1;
		private Label label4;
		private RadioButton TimerRB2;
		private RadioButton TimerRB1;
		private Label label5;
		private NumericUpDown TimerValue;
		private Label label9;
		private TextBox CounterDDS;
		private Label label8;
		private TextBox TimerDDS;
		private Label label7;
		private TextBox TimerName;
		private TextBox CheckDDS;
		private Label label10;
		private TextBox TaskName;
		private Label label11;
	}
}