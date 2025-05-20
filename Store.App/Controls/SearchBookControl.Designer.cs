namespace Store.App.Controls
{
	partial class SearchBookControl
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
			panel2 = new Panel();
			panel3 = new Panel();
			SearchButton = new Button();
			panel1 = new Panel();
			AuthorLabel = new Label();
			SearchBox = new TextBox();
			BookDataView = new DataGridView();
			panel4 = new Panel();
			BookSearchBox.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)BookDataView).BeginInit();
			panel4.SuspendLayout();
			SuspendLayout();
			// 
			// BookSearchBox
			// 
			BookSearchBox.Controls.Add(panel4);
			BookSearchBox.Controls.Add(panel2);
			BookSearchBox.Dock = DockStyle.Fill;
			BookSearchBox.Location = new Point(0, 0);
			BookSearchBox.Name = "BookSearchBox";
			BookSearchBox.Size = new Size(824, 519);
			BookSearchBox.TabIndex = 1;
			BookSearchBox.TabStop = false;
			BookSearchBox.Text = "Пошук книг за автором";
			// 
			// panel2
			// 
			panel2.Controls.Add(panel3);
			panel2.Controls.Add(panel1);
			panel2.Dock = DockStyle.Top;
			panel2.Location = new Point(3, 19);
			panel2.Name = "panel2";
			panel2.Padding = new Padding(3);
			panel2.Size = new Size(818, 39);
			panel2.TabIndex = 5;
			// 
			// panel3
			// 
			panel3.Controls.Add(SearchButton);
			panel3.Dock = DockStyle.Fill;
			panel3.Location = new Point(279, 3);
			panel3.Name = "panel3";
			panel3.Padding = new Padding(5);
			panel3.Size = new Size(536, 33);
			panel3.TabIndex = 5;
			// 
			// SearchButton
			// 
			SearchButton.Dock = DockStyle.Fill;
			SearchButton.Location = new Point(5, 5);
			SearchButton.Name = "SearchButton";
			SearchButton.Size = new Size(526, 23);
			SearchButton.TabIndex = 0;
			SearchButton.Text = "Пошук";
			SearchButton.UseVisualStyleBackColor = true;
			SearchButton.Click += SearchButton_Click;
			// 
			// panel1
			// 
			panel1.Controls.Add(AuthorLabel);
			panel1.Controls.Add(SearchBox);
			panel1.Dock = DockStyle.Left;
			panel1.Location = new Point(3, 3);
			panel1.Name = "panel1";
			panel1.Size = new Size(276, 33);
			panel1.TabIndex = 4;
			// 
			// AuthorLabel
			// 
			AuthorLabel.AutoSize = true;
			AuthorLabel.Location = new Point(6, 6);
			AuthorLabel.Name = "AuthorLabel";
			AuthorLabel.Size = new Size(43, 15);
			AuthorLabel.TabIndex = 2;
			AuthorLabel.Text = "Автор:";
			// 
			// SearchBox
			// 
			SearchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			SearchBox.Location = new Point(52, 3);
			SearchBox.Name = "SearchBox";
			SearchBox.Size = new Size(221, 23);
			SearchBox.TabIndex = 3;
			// 
			// BookDataView
			// 
			BookDataView.AllowUserToAddRows = false;
			BookDataView.AllowUserToDeleteRows = false;
			BookDataView.AllowUserToOrderColumns = true;
			BookDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BookDataView.Dock = DockStyle.Fill;
			BookDataView.Location = new Point(0, 0);
			BookDataView.Margin = new Padding(3, 100, 3, 3);
			BookDataView.Name = "BookDataView";
			BookDataView.ReadOnly = true;
			BookDataView.Size = new Size(818, 458);
			BookDataView.TabIndex = 1;
			// 
			// panel4
			// 
			panel4.Controls.Add(BookDataView);
			panel4.Dock = DockStyle.Fill;
			panel4.Location = new Point(3, 58);
			panel4.Name = "panel4";
			panel4.Size = new Size(818, 458);
			panel4.TabIndex = 6;
			// 
			// SearchBookControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(BookSearchBox);
			Name = "SearchBookControl";
			Size = new Size(824, 519);
			BookSearchBox.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)BookDataView).EndInit();
			panel4.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private GroupBox BookSearchBox;
		private DataGridView BookDataView;
		private Button SearchButton;
		private TextBox SearchBox;
		private Label AuthorLabel;
		private Panel panel2;
		private Panel panel1;
		private Panel panel3;
		private Panel panel4;
	}
}
