namespace Timer2 {
	partial class About {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
			Icon=new Label();
			label1=new Label();
			label2=new Label();
			textBox1=new TextBox();
			SuspendLayout();
			// 
			// Icon
			// 
			Icon.Image=(Image)resources.GetObject("Icon.Image");
			Icon.Location=new Point(378, 9);
			Icon.Name="Icon";
			Icon.Size=new Size(99, 84);
			Icon.TabIndex=0;
			// 
			// label1
			// 
			label1.Location=new Point(391, 116);
			label1.Name="label1";
			label1.Size=new Size(100, 23);
			label1.TabIndex=2;
			label1.Text="Version 1.0.0";
			// 
			// label2
			// 
			label2.Location=new Point(391, 93);
			label2.Name="label2";
			label2.Size=new Size(100, 23);
			label2.TabIndex=3;
			label2.Text="Timer 2";
			// 
			// textBox1
			// 
			textBox1.BorderStyle=BorderStyle.FixedSingle;
			textBox1.ImeMode=ImeMode.NoControl;
			textBox1.Location=new Point(12, 6);
			textBox1.Multiline=true;
			textBox1.Name="textBox1";
			textBox1.ReadOnly=true;
			textBox1.ScrollBars=ScrollBars.Horizontal;
			textBox1.Size=new Size(360, 368);
			textBox1.TabIndex=4;
			textBox1.Text=resources.GetString("textBox1.Text");
			// 
			// About
			// 
			AutoScaleDimensions=new SizeF(7F, 15F);
			AutoScaleMode=AutoScaleMode.Font;
			ClientSize=new Size(489, 386);
			Controls.Add(textBox1);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(Icon);
			Name="About";
			StartPosition=FormStartPosition.CenterScreen;
			Text="Help & About";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label Icon;
		private Label label1;
		private Label label2;
		public TextBox textBox1;
	}
}