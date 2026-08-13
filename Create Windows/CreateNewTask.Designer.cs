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
			label12=new Label();
			CounterToVal=new NumericUpDown();
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
			TimerSS=new NumericUpDown();
			TimerMM=new NumericUpDown();
			TimerHH=new NumericUpDown();
			groupBox4=new GroupBox();
			TimerWavPath=new Label();
			TimerWav3=new RadioButton();
			TimerWav2=new RadioButton();
			TimerWav1=new RadioButton();
			TimerValueLabel=new Label();
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
			TaskColor=new Button();
			label13=new Label();
			TaskDDS=new TextBox();
			WFD=new OpenFileDialog();
			TaskExpireDP=new DateTimePicker();
			label14=new Label();
			panel3=new Panel();
			TaskResetDay7=new CheckBox();
			TaskResetDay6=new CheckBox();
			TaskResetDay5=new CheckBox();
			TaskResetDay4=new CheckBox();
			TaskResetDP=new DateTimePicker();
			TaskResetDay3=new CheckBox();
			TaskResetDay2=new CheckBox();
			TaskResetDay1=new CheckBox();
			TaskResetRB2=new RadioButton();
			TaskResetRB1=new RadioButton();
			TC.SuspendLayout();
			tabPage1.SuspendLayout();
			groupBox3.SuspendLayout();
			tabPage2.SuspendLayout();
			groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)CounterToVal).BeginInit();
			tabPage3.SuspendLayout();
			groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)TimerSS).BeginInit();
			((System.ComponentModel.ISupportInitialize)TimerMM).BeginInit();
			((System.ComponentModel.ISupportInitialize)TimerHH).BeginInit();
			groupBox4.SuspendLayout();
			panel2.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)TimerValue).BeginInit();
			panel3.SuspendLayout();
			SuspendLayout();
			// 
			// TC
			// 
			TC.Controls.Add(tabPage1);
			TC.Controls.Add(tabPage2);
			TC.Controls.Add(tabPage3);
			TC.Location=new Point(12, 147);
			TC.Name="TC";
			TC.SelectedIndex=0;
			TC.Size=new Size(571, 371);
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
			tabPage1.Size=new Size(563, 343);
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
			CheckRB2.Location=new Point(92, 17);
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
			CheckRB1.Location=new Point(156, 17);
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
			tabPage2.Size=new Size(563, 343);
			tabPage2.TabIndex=1;
			tabPage2.Text="Counters";
			tabPage2.UseVisualStyleBackColor=true;
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add(label12);
			groupBox2.Controls.Add(CounterToVal);
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
			// label12
			// 
			label12.AutoSize=true;
			label12.Location=new Point(6, 109);
			label12.Name="label12";
			label12.Size=new Size(77, 15);
			label12.TabIndex=23;
			label12.Text="Counter Goal";
			// 
			// CounterToVal
			// 
			CounterToVal.Location=new Point(6, 128);
			CounterToVal.Maximum=new decimal(new int[] { 9001, 0, 0, 0 });
			CounterToVal.Name="CounterToVal";
			CounterToVal.Size=new Size(181, 23);
			CounterToVal.TabIndex=22;
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
			tabPage3.Size=new Size(563, 343);
			tabPage3.TabIndex=2;
			tabPage3.Text="Timers";
			tabPage3.UseVisualStyleBackColor=true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(TimerSS);
			groupBox1.Controls.Add(TimerMM);
			groupBox1.Controls.Add(TimerHH);
			groupBox1.Controls.Add(groupBox4);
			groupBox1.Controls.Add(TimerValueLabel);
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
			// TimerSS
			// 
			TimerSS.Location=new Point(308, 212);
			TimerSS.Maximum=new decimal(new int[] { -1, int.MaxValue, 0, 0 });
			TimerSS.Name="TimerSS";
			TimerSS.Size=new Size(55, 23);
			TimerSS.TabIndex=28;
			TimerSS.Value=new decimal(new int[] { 10, 0, 0, 0 });
			TimerSS.Leave+=TimerHH_Leave;
			// 
			// TimerMM
			// 
			TimerMM.Location=new Point(251, 212);
			TimerMM.Maximum=new decimal(new int[] { -1, int.MaxValue, 0, 0 });
			TimerMM.Name="TimerMM";
			TimerMM.Size=new Size(48, 23);
			TimerMM.TabIndex=27;
			TimerMM.Leave+=TimerHH_Leave;
			// 
			// TimerHH
			// 
			TimerHH.Location=new Point(177, 212);
			TimerHH.Maximum=new decimal(new int[] { -1, int.MaxValue, 0, 0 });
			TimerHH.Name="TimerHH";
			TimerHH.Size=new Size(68, 23);
			TimerHH.TabIndex=26;
			TimerHH.Leave+=TimerHH_Leave;
			// 
			// groupBox4
			// 
			groupBox4.Controls.Add(TimerWavPath);
			groupBox4.Controls.Add(TimerWav3);
			groupBox4.Controls.Add(TimerWav2);
			groupBox4.Controls.Add(TimerWav1);
			groupBox4.Location=new Point(9, 241);
			groupBox4.Name="groupBox4";
			groupBox4.Size=new Size(363, 74);
			groupBox4.TabIndex=25;
			groupBox4.TabStop=false;
			groupBox4.Text="Alarm setting";
			// 
			// TimerWavPath
			// 
			TimerWavPath.AutoSize=true;
			TimerWavPath.Location=new Point(6, 25);
			TimerWavPath.Name="TimerWavPath";
			TimerWavPath.Size=new Size(33, 15);
			TimerWavPath.TabIndex=8;
			TimerWavPath.Text="Beep";
			TimerWavPath.MouseClick+=TimerWav3_MouseClick;
			// 
			// TimerWav3
			// 
			TimerWav3.AutoSize=true;
			TimerWav3.Location=new Point(130, 49);
			TimerWav3.Name="TimerWav3";
			TimerWav3.Size=new Size(67, 19);
			TimerWav3.TabIndex=7;
			TimerWav3.Text="Wav file";
			TimerWav3.UseVisualStyleBackColor=true;
			TimerWav3.MouseClick+=TimerWav3_MouseClick;
			// 
			// TimerWav2
			// 
			TimerWav2.AutoSize=true;
			TimerWav2.Checked=true;
			TimerWav2.Location=new Point(73, 49);
			TimerWav2.Name="TimerWav2";
			TimerWav2.Size=new Size(51, 19);
			TimerWav2.TabIndex=6;
			TimerWav2.TabStop=true;
			TimerWav2.Text="Beep";
			TimerWav2.UseVisualStyleBackColor=true;
			TimerWav2.CheckedChanged+=TimerWav2_CheckedChanged;
			// 
			// TimerWav1
			// 
			TimerWav1.AutoSize=true;
			TimerWav1.Location=new Point(6, 49);
			TimerWav1.Name="TimerWav1";
			TimerWav1.Size=new Size(54, 19);
			TimerWav1.TabIndex=5;
			TimerWav1.Text="None";
			TimerWav1.UseVisualStyleBackColor=true;
			TimerWav1.CheckedChanged+=TimerWav1_CheckedChanged;
			// 
			// TimerValueLabel
			// 
			TimerValueLabel.AutoSize=true;
			TimerValueLabel.Location=new Point(9, 194);
			TimerValueLabel.Name="TimerValueLabel";
			TimerValueLabel.Size=new Size(315, 15);
			TimerValueLabel.TabIndex=24;
			TimerValueLabel.Text="Timer Start Value (in seconds) = HH :               MM :          SS";
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
			TimerRB4.Click+=TimerRB4_Click;
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
			TimerRB3.Click+=TimerRB3_Click;
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
			TimerValue.Maximum=new decimal(new int[] { -1, int.MaxValue, 0, 0 });
			TimerValue.Minimum=new decimal(new int[] { 10, 0, 0, 0 });
			TimerValue.Name="TimerValue";
			TimerValue.Size=new Size(162, 23);
			TimerValue.TabIndex=0;
			TimerValue.Value=new decimal(new int[] { 10, 0, 0, 0 });
			TimerValue.ValueChanged+=TimerValue_ValueChanged;
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
			TaskOk.Location=new Point(449, 520);
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
			TaskCancel.Location=new Point(12, 520);
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
			TaskName.Size=new Size(453, 23);
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
			// TaskColor
			// 
			TaskColor.Location=new Point(558, 11);
			TaskColor.Name="TaskColor";
			TaskColor.Size=new Size(39, 23);
			TaskColor.TabIndex=21;
			TaskColor.Text="Color";
			TaskColor.UseVisualStyleBackColor=true;
			TaskColor.Click+=TaskColor_Click;
			// 
			// label13
			// 
			label13.AutoSize=true;
			label13.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label13.Location=new Point(12, 44);
			label13.Name="label13";
			label13.Size=new Size(74, 17);
			label13.TabIndex=23;
			label13.Text="Description";
			// 
			// TaskDDS
			// 
			TaskDDS.Location=new Point(99, 41);
			TaskDDS.Name="TaskDDS";
			TaskDDS.Size=new Size(453, 23);
			TaskDDS.TabIndex=22;
			// 
			// WFD
			// 
			WFD.FileName="Wave Files";
			WFD.Filter="Wave files(*.wav)|*.wav";
			// 
			// TaskExpireDP
			// 
			TaskExpireDP.Checked=false;
			TaskExpireDP.Location=new Point(121, 121);
			TaskExpireDP.Name="TaskExpireDP";
			TaskExpireDP.ShowCheckBox=true;
			TaskExpireDP.Size=new Size(212, 23);
			TaskExpireDP.TabIndex=24;
			// 
			// label14
			// 
			label14.AutoSize=true;
			label14.Font=new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label14.Location=new Point(12, 125);
			label14.Name="label14";
			label14.Size=new Size(103, 17);
			label14.TabIndex=25;
			label14.Text="Task Expire date";
			// 
			// panel3
			// 
			panel3.Controls.Add(TaskResetDay7);
			panel3.Controls.Add(TaskResetDay6);
			panel3.Controls.Add(TaskResetDay5);
			panel3.Controls.Add(TaskResetDay4);
			panel3.Controls.Add(TaskResetDP);
			panel3.Controls.Add(TaskResetDay3);
			panel3.Controls.Add(TaskResetDay2);
			panel3.Controls.Add(TaskResetDay1);
			panel3.Controls.Add(TaskResetRB2);
			panel3.Controls.Add(TaskResetRB1);
			panel3.Location=new Point(10, 64);
			panel3.Name="panel3";
			panel3.Size=new Size(587, 56);
			panel3.TabIndex=26;
			// 
			// TaskResetDay7
			// 
			TaskResetDay7.AutoSize=true;
			TaskResetDay7.Location=new Point(513, 7);
			TaskResetDay7.Name="TaskResetDay7";
			TaskResetDay7.Size=new Size(72, 19);
			TaskResetDay7.TabIndex=9;
			TaskResetDay7.Text="Saturday";
			TaskResetDay7.UseVisualStyleBackColor=true;
			// 
			// TaskResetDay6
			// 
			TaskResetDay6.AutoSize=true;
			TaskResetDay6.Location=new Point(457, 7);
			TaskResetDay6.Name="TaskResetDay6";
			TaskResetDay6.Size=new Size(58, 19);
			TaskResetDay6.TabIndex=7;
			TaskResetDay6.Text="Friday";
			TaskResetDay6.UseVisualStyleBackColor=true;
			// 
			// TaskResetDay5
			// 
			TaskResetDay5.AutoSize=true;
			TaskResetDay5.Location=new Point(385, 7);
			TaskResetDay5.Name="TaskResetDay5";
			TaskResetDay5.Size=new Size(74, 19);
			TaskResetDay5.TabIndex=6;
			TaskResetDay5.Text="Thursday";
			TaskResetDay5.UseVisualStyleBackColor=true;
			// 
			// TaskResetDay4
			// 
			TaskResetDay4.AutoSize=true;
			TaskResetDay4.Location=new Point(301, 7);
			TaskResetDay4.Name="TaskResetDay4";
			TaskResetDay4.Size=new Size(87, 19);
			TaskResetDay4.TabIndex=4;
			TaskResetDay4.Text="Wednesday";
			TaskResetDay4.UseVisualStyleBackColor=true;
			// 
			// TaskResetDP
			// 
			TaskResetDP.CustomFormat="hh:mm tt";
			TaskResetDP.Format=DateTimePickerFormat.Custom;
			TaskResetDP.Location=new Point(104, 26);
			TaskResetDP.Name="TaskResetDP";
			TaskResetDP.ShowUpDown=true;
			TaskResetDP.Size=new Size(109, 23);
			TaskResetDP.TabIndex=8;
			TaskResetDP.Value=new DateTime(2026, 7, 29, 10, 0, 0, 0);
			// 
			// TaskResetDay3
			// 
			TaskResetDay3.AutoSize=true;
			TaskResetDay3.Location=new Point(234, 7);
			TaskResetDay3.Name="TaskResetDay3";
			TaskResetDay3.Size=new Size(69, 19);
			TaskResetDay3.TabIndex=5;
			TaskResetDay3.Text="Tuesday";
			TaskResetDay3.UseVisualStyleBackColor=true;
			// 
			// TaskResetDay2
			// 
			TaskResetDay2.AutoSize=true;
			TaskResetDay2.Location=new Point(168, 7);
			TaskResetDay2.Name="TaskResetDay2";
			TaskResetDay2.Size=new Size(70, 19);
			TaskResetDay2.TabIndex=3;
			TaskResetDay2.Text="Monday";
			TaskResetDay2.UseVisualStyleBackColor=true;
			// 
			// TaskResetDay1
			// 
			TaskResetDay1.AutoSize=true;
			TaskResetDay1.Location=new Point(104, 7);
			TaskResetDay1.Name="TaskResetDay1";
			TaskResetDay1.Size=new Size(65, 19);
			TaskResetDay1.TabIndex=2;
			TaskResetDay1.Text="Sunday";
			TaskResetDay1.UseVisualStyleBackColor=true;
			// 
			// TaskResetRB2
			// 
			TaskResetRB2.AutoSize=true;
			TaskResetRB2.Checked=true;
			TaskResetRB2.Location=new Point(7, 30);
			TaskResetRB2.Name="TaskResetRB2";
			TaskResetRB2.Size=new Size(72, 19);
			TaskResetRB2.TabIndex=1;
			TaskResetRB2.TabStop=true;
			TaskResetRB2.Text="No Reset";
			TaskResetRB2.UseVisualStyleBackColor=true;
			// 
			// TaskResetRB1
			// 
			TaskResetRB1.AutoSize=true;
			TaskResetRB1.Location=new Point(6, 6);
			TaskResetRB1.Name="TaskResetRB1";
			TaskResetRB1.Size=new Size(95, 19);
			TaskResetRB1.TabIndex=0;
			TaskResetRB1.Text="Task Reset on";
			TaskResetRB1.UseVisualStyleBackColor=true;
			// 
			// CreateNewTask
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(603, 578);
			Controls.Add(panel3);
			Controls.Add(label14);
			Controls.Add(TaskExpireDP);
			Controls.Add(label13);
			Controls.Add(TaskDDS);
			Controls.Add(TaskColor);
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
			((System.ComponentModel.ISupportInitialize)CounterToVal).EndInit();
			tabPage3.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)TimerSS).EndInit();
			((System.ComponentModel.ISupportInitialize)TimerMM).EndInit();
			((System.ComponentModel.ISupportInitialize)TimerHH).EndInit();
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)TimerValue).EndInit();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
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
		private Label label12;
		private NumericUpDown CounterToVal;
		private Label TimerValueLabel;
		private Button TaskColor;
		private Label label13;
		private TextBox TaskDDS;
		private GroupBox groupBox4;
		private RadioButton TimerWav3;
		private RadioButton TimerWav2;
		private RadioButton TimerWav1;
		private Label TimerWavPath;
		private OpenFileDialog WFD;
		private DateTimePicker TaskExpireDP;
		private Label label14;
		private Panel panel3;
		private RadioButton TaskResetRB1;
		private DateTimePicker dateTimePicker1;
		private CheckBox TaskResetDay6;
		private CheckBox TaskResetDay5;
		private CheckBox TaskResetDay3;
		private CheckBox TaskResetDay4;
		private CheckBox TaskResetDay2;
		private CheckBox TaskResetDay1;
		private RadioButton TaskResetRB2;
		public DateTimePicker TaskResetDP;
		private CheckBox TaskResetDay7;
		private NumericUpDown TimerSS;
		private NumericUpDown TimerMM;
		private NumericUpDown TimerHH;
	}
}