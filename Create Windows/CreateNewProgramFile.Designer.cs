namespace Timer2 {
	partial class CreateNewProgramFile {
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
			groupBox1=new GroupBox();
			label3=new Label();
			TPDDS=new TextBox();
			label2=new Label();
			TPName=new TextBox();
			label1=new Label();
			PFCreate=new Button();
			PFCancel=new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(TPDDS);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(TPName);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(PFCreate);
			groupBox1.Controls.Add(PFCancel);
			groupBox1.Location=new Point(5, 1);
			groupBox1.Name="groupBox1";
			groupBox1.Size=new Size(310, 301);
			groupBox1.TabIndex=0;
			groupBox1.TabStop=false;
			groupBox1.Text="Program Info";
			// 
			// label3
			// 
			label3.AutoSize=true;
			label3.Location=new Point(7, 176);
			label3.Name="label3";
			label3.Size=new Size(275, 15);
			label3.TabIndex=6;
			label3.Text="More options later on, but i don't think it is needed";
			// 
			// TPDDS
			// 
			TPDDS.Location=new Point(7, 85);
			TPDDS.Multiline=true;
			TPDDS.Name="TPDDS";
			TPDDS.ScrollBars=ScrollBars.Vertical;
			TPDDS.Size=new Size(290, 78);
			TPDDS.TabIndex=5;
			// 
			// label2
			// 
			label2.AutoSize=true;
			label2.Location=new Point(7, 67);
			label2.Name="label2";
			label2.Size=new Size(173, 15);
			label2.TabIndex=4;
			label2.Text="Program Description (Optional)";
			// 
			// TPName
			// 
			TPName.Location=new Point(7, 37);
			TPName.Name="TPName";
			TPName.Size=new Size(290, 23);
			TPName.TabIndex=3;
			// 
			// label1
			// 
			label1.AutoSize=true;
			label1.Location=new Point(7, 19);
			label1.Name="label1";
			label1.Size=new Size(143, 15);
			label1.TabIndex=2;
			label1.Text="The New Program name *";
			// 
			// PFCreate
			// 
			PFCreate.BackColor=Color.LimeGreen;
			PFCreate.FlatStyle=FlatStyle.Flat;
			PFCreate.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PFCreate.Location=new Point(167, 251);
			PFCreate.Name="PFCreate";
			PFCreate.Size=new Size(130, 44);
			PFCreate.TabIndex=1;
			PFCreate.Text="OK";
			PFCreate.UseVisualStyleBackColor=false;
			PFCreate.Click+=PFCreate_Click;
			// 
			// PFCancel
			// 
			PFCancel.BackColor=Color.LimeGreen;
			PFCancel.FlatStyle=FlatStyle.Flat;
			PFCancel.Font=new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			PFCancel.Location=new Point(7, 251);
			PFCancel.Name="PFCancel";
			PFCancel.Size=new Size(130, 44);
			PFCancel.TabIndex=0;
			PFCancel.Text="Cancel";
			PFCancel.UseVisualStyleBackColor=false;
			PFCancel.Click+=PFCancel_Click;
			// 
			// CreateNewProgramFile
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(328, 312);
			Controls.Add(groupBox1);
			Name="CreateNewProgramFile";
			Text="Create New Program";
			FormClosing+=CreateNewProgramFile_FormClosing;
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private TextBox TPName;
		private Label label1;
		private Button PFCreate;
		private Button PFCancel;
		private Label label3;
		private TextBox TPDDS;
		private Label label2;
	}
}