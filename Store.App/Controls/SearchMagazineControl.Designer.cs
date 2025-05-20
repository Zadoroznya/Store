namespace Store.App.Controls
{
	partial class SearchMagazineControl
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
			BookSearchBox = new GroupBox();
			panel4 = new Panel();
			MagazineDataView = new DataGridView();
			panel2 = new Panel();
			panel3 = new Panel();
			SearchButton = new Button();
			panel1 = new Panel();
			NumberBox = new NumericUpDown();
			AuthorLabel = new Label();
			BookSearchBox.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)MagazineDataView).BeginInit();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)NumberBox).BeginInit();
			SuspendLayout();
			// 
			// BookSearchBox
			// 
			BookSearchBox.Controls.Add(panel4);
			BookSearchBox.Controls.Add(panel2);
			BookSearchBox.Dock = DockStyle.Fill;
			BookSearchBox.Location = new Point(0, 0);
			BookSearchBox.Name = "BookSearchBox";
			BookSearchBox.Size = new Size(872, 521);
			BookSearchBox.TabIndex = 2;
			BookSearchBox.TabStop = false;
			BookSearchBox.Text = "Пошук журналів за номером";
			// 
			// panel4
			// 
			panel4.Controls.Add(MagazineDataView);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(3, 58);
			panel4.Name = "panel4";
			panel4.Size = new Size(866, 460);
			panel4.TabIndex = 6;
			// 
			// MagazineDataView
			// 
			MagazineDataView.AllowUserToAddRows = false;
			MagazineDataView.AllowUserToDeleteRows = false;
			MagazineDataView.AllowUserToOrderColumns = true;
			MagazineDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			MagazineDataView.Dock = DockStyle.Fill;
			MagazineDataView.Location = new Point(0, 0);
			MagazineDataView.Margin = new Padding(3, 100, 3, 3);
			MagazineDataView.Name = "MagazineDataView";
			MagazineDataView.ReadOnly = true;
			MagazineDataView.Size = new Size(866, 460);
			MagazineDataView.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.Controls.Add(panel3);
			panel2.Controls.Add(panel1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(3, 19);
			panel2.Name = "panel2";
			panel2.Padding = new Padding(3);
			panel2.Size = new Size(866, 39);
			panel2.TabIndex = 5;
			// 
			// panel3
			// 
			panel3.Controls.Add(SearchButton);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(279, 3);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(5);
			panel3.Size = new Size(584, 33);
			panel3.TabIndex = 5;
			// 
			// SearchButton
			// 
			SearchButton.Dock = DockStyle.Fill;
			SearchButton.Location = new Point(5, 5);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(574, 23);
			SearchButton.TabIndex = 0;
			SearchButton.Text = "Пошук";
			SearchButton.UseVisualStyleBackColor = true;
			SearchButton.Click += SearchButton_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(NumberBox);
			panel1.Controls.Add(AuthorLabel);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(276, 33);
			panel1.TabIndex = 4;
			// 
			// NumberBox
			// 
			NumberBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			NumberBox.Location = new Point(111, 5);
			NumberBox.Name = "NumberBox";
			NumberBox.Size = new Size(159, 23);
			NumberBox.TabIndex = 3;
			// 
			// AuthorLabel
			// 
			AuthorLabel.AutoSize = true;
			AuthorLabel.Location = new Point(6, 6);
			AuthorLabel.Name = "AuthorLabel";
			AuthorLabel.Size = new Size(99, 15);
			AuthorLabel.TabIndex = 2;
			AuthorLabel.Text = "Номер журналу:";
			// 
			// SearchMagazineControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(BookSearchBox);
			Name = "SearchMagazineControl";
			Size = new Size(872, 521);
			BookSearchBox.ResumeLayout(false);
			panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)MagazineDataView).EndInit();
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)NumberBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox BookSearchBox;
		private Panel panel4;
		private DataGridView MagazineDataView;
		private Panel panel2;
		private Panel panel3;
		private Button SearchButton;
		private Panel panel1;
		private NumericUpDown NumberBox;
		private Label AuthorLabel;
	}
}
