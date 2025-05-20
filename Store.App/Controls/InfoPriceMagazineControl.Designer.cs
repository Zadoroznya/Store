namespace Store.App.Controls
{
	partial class InfoPriceMagazineControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			groupBox1 = new GroupBox();
			SearchButton = new Button();
			SearchBox = new TextBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(SearchButton);
			groupBox1.Controls.Add(SearchBox);
			groupBox1.Controls.Add(label1);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(346, 261);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Інформація про ціну журналу";
			// 
			// SearchButton
			// 
			SearchButton.Location = new Point(6, 66);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(175, 34);
			SearchButton.TabIndex = 2;
			SearchButton.Text = "Знайти";
			SearchButton.UseVisualStyleBackColor = true;
			SearchButton.Click += SearchButton_Click;
			// 
			// SearchBox
			// 
			SearchBox.Location = new Point(6, 37);
			SearchBox.Name = "SearchBox";
			SearchBox.Size = new Size(175, 23);
			SearchBox.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(6, 19);
			label1.Name = "label1";
			label1.Size = new Size(90, 15);
			label1.TabIndex = 0;
			label1.Text = "Назва журналу";
			// 
			// InfoPriceMagazineControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox1);
			Name = "InfoPriceMagazineControl";
			Size = new Size(346, 261);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Button SearchButton;
		private TextBox SearchBox;
		private Label label1;
	}
}
