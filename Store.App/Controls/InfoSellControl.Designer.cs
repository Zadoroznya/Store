namespace Store.App.Controls
{
	partial class InfoSellControl
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
			panel2 = new Panel();
			LiteratureDataView = new DataGridView();
			panel1 = new Panel();
			UpdateButton = new Button();
			UserListBox = new ComboBox();
			label1 = new Label();
			groupBox1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)LiteratureDataView).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(panel2);
			groupBox1.Controls.Add(panel1);
			groupBox1.Dock = DockStyle.Fill;
			groupBox1.Location = new Point(0, 0);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(594, 377);
			groupBox1.TabIndex = 0;
			groupBox1.TabStop = false;
			groupBox1.Text = "Перегляд придбаної літератури";
			// 
			// panel2
			// 
			panel2.Controls.Add(LiteratureDataView);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(3, 68);
			panel2.Name = "panel2";
			panel2.Size = new Size(588, 306);
			panel2.TabIndex = 1;
			// 
			// LiteratureDataView
			// 
			LiteratureDataView.AllowUserToAddRows = false;
			LiteratureDataView.AllowUserToDeleteRows = false;
			LiteratureDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			LiteratureDataView.Dock = DockStyle.Fill;
			LiteratureDataView.Location = new Point(0, 0);
			LiteratureDataView.Name = "LiteratureDataView";
			LiteratureDataView.ReadOnly = true;
			LiteratureDataView.Size = new Size(588, 306);
			LiteratureDataView.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(UpdateButton);
			panel1.Controls.Add(UserListBox);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(3, 19);
			panel1.Name = "panel1";
			panel1.Size = new Size(588, 49);
			panel1.TabIndex = 0;
			// 
			// UpdateButton
			// 
			UpdateButton.Location = new Point(175, 3);
			UpdateButton.Name = "UpdateButton";
			UpdateButton.Size = new Size(180, 38);
			UpdateButton.TabIndex = 2;
			UpdateButton.Text = "Оновити";
			UpdateButton.UseVisualStyleBackColor = true;
			UpdateButton.Click += UpdateButton_Click;
			// 
			// UserListBox
			// 
			UserListBox.AutoCompleteMode = AutoCompleteMode.Suggest;
			UserListBox.AutoCompleteSource = AutoCompleteSource.ListItems;
			UserListBox.FormattingEnabled = true;
			UserListBox.Location = new Point(3, 18);
			UserListBox.Name = "UserListBox";
			UserListBox.Size = new Size(166, 23);
			UserListBox.TabIndex = 1;
			UserListBox.SelectedIndexChanged += UserListBox_SelectedIndexChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 0);
			label1.Name = "label1";
			label1.Size = new Size(100, 15);
			label1.TabIndex = 0;
			label1.Text = "Список покупців";
			// 
			// InfoSellControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox1);
			Name = "InfoSellControl";
			Size = new Size(594, 377);
			groupBox1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)LiteratureDataView).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Panel panel2;
		private DataGridView LiteratureDataView;
		private Panel panel1;
		private ComboBox UserListBox;
		private Label label1;
		private Button UpdateButton;
	}
}
