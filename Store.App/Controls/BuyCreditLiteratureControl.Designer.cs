namespace Store.App.Controls
{
	partial class BuyCreditLiteratureControl
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
			LiteratureBookView = new DataGridView();
			panel1 = new Panel();
			BuyButton = new Button();
			UsernameBox = new TextBox();
			label1 = new Label();
			RefreshButton = new Button();
			groupBox1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)LiteratureBookView).BeginInit();
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
			groupBox1.Size = new Size(544, 345);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "Купівля літератури в кредит (якщо ціна понад 1000 грн.)";
			// 
			// panel2
			// 
			panel2.Controls.Add(LiteratureBookView);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(3, 104);
			panel2.Name = "panel2";
			panel2.Size = new Size(538, 238);
			panel2.TabIndex = 1;
			// 
			// LiteratureBookView
			// 
			LiteratureBookView.AllowUserToAddRows = false;
			LiteratureBookView.AllowUserToDeleteRows = false;
			LiteratureBookView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			LiteratureBookView.Dock = DockStyle.Fill;
			LiteratureBookView.Location = new Point(0, 0);
			LiteratureBookView.MultiSelect = false;
			LiteratureBookView.Name = "LiteratureBookView";
			LiteratureBookView.ReadOnly = true;
			LiteratureBookView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			LiteratureBookView.Size = new Size(538, 238);
			LiteratureBookView.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.Controls.Add(RefreshButton);
			panel1.Controls.Add(BuyButton);
			panel1.Controls.Add(UsernameBox);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(3, 19);
			panel1.Name = "panel1";
			panel1.Size = new Size(538, 85);
			panel1.TabIndex = 0;
			// 
			// BuyButton
			// 
			BuyButton.Location = new Point(3, 44);
			BuyButton.Name = "BuyButton";
			BuyButton.Size = new Size(328, 31);
			BuyButton.TabIndex = 5;
			BuyButton.Text = "Придбати";
			BuyButton.UseVisualStyleBackColor = true;
			BuyButton.Click += BuyButton_Click;
			// 
			// UsernameBox
			// 
			UsernameBox.Location = new Point(131, 6);
			UsernameBox.Name = "UsernameBox";
			UsernameBox.Size = new Size(200, 23);
			UsernameBox.TabIndex = 4;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 9);
			label1.Name = "label1";
			label1.Size = new Size(122, 15);
			label1.TabIndex = 3;
			label1.Text = "Введіть ім'я покупця:";
			// 
			// RefreshButton
			// 
			RefreshButton.Location = new Point(337, 3);
			RefreshButton.Name = "RefreshButton";
			RefreshButton.Size = new Size(141, 72);
			RefreshButton.TabIndex = 6;
			RefreshButton.Text = "Оновити";
			RefreshButton.UseVisualStyleBackColor = true;
			// 
			// BuyCreditLiteratureControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(groupBox1);
			Name = "BuyCreditLiteratureControl";
			Size = new Size(544, 345);
			groupBox1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)LiteratureBookView).EndInit();
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox groupBox1;
		private Panel panel2;
		private DataGridView LiteratureBookView;
		private Panel panel1;
		private Button BuyButton;
		private TextBox UsernameBox;
		private Label label1;
		private Button RefreshButton;
	}
}
