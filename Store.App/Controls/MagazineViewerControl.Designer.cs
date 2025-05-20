namespace Store.App.Controls
{
	partial class MagazineViewerControl
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
			MagazineViewerBox = new GroupBox();
			MagazineDataView = new DataGridView();
			UpdateButton = new Button();
			MagazineViewerBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)MagazineDataView).BeginInit();
			SuspendLayout();
			// 
			// MagazineViewerBox
			// 
			MagazineViewerBox.Controls.Add(MagazineDataView);
			MagazineViewerBox.Controls.Add(UpdateButton);
			MagazineViewerBox.Dock = DockStyle.Fill;
			MagazineViewerBox.Location = new Point(0, 0);
			MagazineViewerBox.Name = "MagazineViewerBox";
			MagazineViewerBox.Size = new Size(150, 150);
			MagazineViewerBox.TabIndex = 1;
			MagazineViewerBox.TabStop = false;
			MagazineViewerBox.Text = "Перегляд журналів";
			// 
			// MagazineDataView
			// 
			MagazineDataView.AllowUserToAddRows = false;
			MagazineDataView.AllowUserToDeleteRows = false;
			MagazineDataView.AllowUserToOrderColumns = true;
			MagazineDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			MagazineDataView.Dock = DockStyle.Fill;
			MagazineDataView.Location = new Point(3, 51);
			MagazineDataView.Name = "MagazineDataView";
			MagazineDataView.ReadOnly = true;
			MagazineDataView.Size = new Size(144, 96);
			MagazineDataView.TabIndex = 1;
			// 
			// UpdateButton
			// 
			UpdateButton.Dock = DockStyle.Top;
			UpdateButton.Location = new Point(3, 19);
			UpdateButton.Name = "UpdateButton";
			UpdateButton.Size = new Size(144, 32);
			UpdateButton.TabIndex = 0;
			UpdateButton.Text = "Оновити";
			UpdateButton.UseVisualStyleBackColor = true;
			UpdateButton.Click += UpdateButton_Click;
			// 
			// MagazineViewerControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(MagazineViewerBox);
			Name = "MagazineViewerControl";
			MagazineViewerBox.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)MagazineDataView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox MagazineViewerBox;
		private DataGridView MagazineDataView;
		private Button UpdateButton;
	}
}
