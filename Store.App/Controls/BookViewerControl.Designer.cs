namespace Store.App.Controls
{
	partial class BookViewerControl
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
			BookViewerBox = new GroupBox();
			UpdateButton = new Button();
			BookDataView = new DataGridView();
			BookViewerBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)BookDataView).BeginInit();
			SuspendLayout();
			// 
			// BookViewerBox
			// 
			BookViewerBox.Controls.Add(BookDataView);
			BookViewerBox.Controls.Add(UpdateButton);
			BookViewerBox.Dock = DockStyle.Fill;
			BookViewerBox.Location = new Point(0, 0);
			BookViewerBox.Name = "BookViewerBox";
			BookViewerBox.Size = new Size(617, 373);
			BookViewerBox.TabIndex = 0;
			BookViewerBox.TabStop = false;
			BookViewerBox.Text = "Перегляд книг";
			// 
			// UpdateButton
			// 
			UpdateButton.Dock = DockStyle.Top;
			UpdateButton.Location = new Point(3, 19);
			UpdateButton.Name = "UpdateButton";
			UpdateButton.Size = new Size(611, 32);
			UpdateButton.TabIndex = 0;
			UpdateButton.Text = "Оновити";
			UpdateButton.UseVisualStyleBackColor = true;
			UpdateButton.Click += UpdateButton_Click;
			// 
			// BookDataView
			// 
			BookDataView.AllowUserToAddRows = false;
			BookDataView.AllowUserToDeleteRows = false;
			BookDataView.AllowUserToOrderColumns = true;
			BookDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BookDataView.Dock = DockStyle.Fill;
			BookDataView.Location = new Point(3, 51);
			BookDataView.Name = "BookDataView";
			BookDataView.ReadOnly = true;
			BookDataView.Size = new Size(611, 319);
			BookDataView.TabIndex = 1;
			// 
			// BookViewerControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(BookViewerBox);
			Name = "BookViewerControl";
			Size = new Size(617, 373);
			BookViewerBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)BookDataView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox BookViewerBox;
		private Button UpdateButton;
		private DataGridView BookDataView;
	}
}
