namespace Store.App.Controls
{
	partial class AddMagazineControl
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
			AddMagazineBox = new GroupBox();
			NumberBox = new NumericUpDown();
			NumberLabel = new Label();
			PerYearBox = new NumericUpDown();
			PerYearLabel = new Label();
			ClearButton = new Button();
			SaveButton = new Button();
			PriceBox = new NumericUpDown();
			PriceLabel = new Label();
			PagesBox = new NumericUpDown();
			PagesLabel = new Label();
			LanguageBox = new ComboBox();
			LanguageLabel = new Label();
			YearBox = new NumericUpDown();
			YearLabel = new Label();
			TopicBox = new TextBox();
			TopicLabel = new Label();
			NameBox = new TextBox();
			NameLabel = new Label();
			AddMagazineBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)NumberBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)PerYearBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)PriceBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)PagesBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)YearBox).BeginInit();
			SuspendLayout();
			// 
			// AddMagazineBox
			// 
			AddMagazineBox.Controls.Add(NumberBox);
			AddMagazineBox.Controls.Add(NumberLabel);
			AddMagazineBox.Controls.Add(PerYearBox);
			AddMagazineBox.Controls.Add(PerYearLabel);
			AddMagazineBox.Controls.Add(ClearButton);
			AddMagazineBox.Controls.Add(SaveButton);
			AddMagazineBox.Controls.Add(PriceBox);
			AddMagazineBox.Controls.Add(PriceLabel);
			AddMagazineBox.Controls.Add(PagesBox);
			AddMagazineBox.Controls.Add(PagesLabel);
			AddMagazineBox.Controls.Add(LanguageBox);
			AddMagazineBox.Controls.Add(LanguageLabel);
			AddMagazineBox.Controls.Add(YearBox);
			AddMagazineBox.Controls.Add(YearLabel);
			AddMagazineBox.Controls.Add(TopicBox);
			AddMagazineBox.Controls.Add(TopicLabel);
			AddMagazineBox.Controls.Add(NameBox);
			AddMagazineBox.Controls.Add(NameLabel);
			AddMagazineBox.Dock = DockStyle.Fill;
			AddMagazineBox.Location = new Point(0, 0);
			AddMagazineBox.Name = "AddMagazineBox";
			AddMagazineBox.Size = new Size(580, 500);
			AddMagazineBox.TabIndex = 1;
			AddMagazineBox.TabStop = false;
			AddMagazineBox.Text = "Додавання журналу";
			// 
			// NumberBox
			// 
			NumberBox.Location = new Point(6, 169);
			NumberBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			NumberBox.Name = "NumberBox";
			NumberBox.Size = new Size(160, 23);
			NumberBox.TabIndex = 21;
			// 
			// NumberLabel
			// 
			NumberLabel.AutoSize = true;
			NumberLabel.Location = new Point(6, 151);
			NumberLabel.Name = "NumberLabel";
			NumberLabel.Size = new Size(45, 15);
			NumberLabel.TabIndex = 20;
			NumberLabel.Text = "Номер";
			// 
			// PerYearBox
			// 
			PerYearBox.Location = new Point(6, 125);
			PerYearBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			PerYearBox.Name = "PerYearBox";
			PerYearBox.Size = new Size(160, 23);
			PerYearBox.TabIndex = 19;
			// 
			// PerYearLabel
			// 
			PerYearLabel.AutoSize = true;
			PerYearLabel.Location = new Point(6, 107);
			PerYearLabel.Name = "PerYearLabel";
			PerYearLabel.Size = new Size(179, 15);
			PerYearLabel.TabIndex = 18;
			PerYearLabel.Text = "Періодичність (випусків на рік)";
			// 
			// ClearButton
			// 
			ClearButton.Location = new Point(6, 412);
			ClearButton.Name = "ClearButton";
			ClearButton.Size = new Size(160, 32);
			ClearButton.TabIndex = 17;
			ClearButton.Text = "Очистити";
			ClearButton.UseVisualStyleBackColor = true;
			ClearButton.Click += ClearButton_Click;
			// 
			// SaveButton
			// 
			SaveButton.Location = new Point(6, 374);
			SaveButton.Name = "SaveButton";
			SaveButton.Size = new Size(160, 32);
			SaveButton.TabIndex = 16;
			SaveButton.Text = "Зберегти";
			SaveButton.UseVisualStyleBackColor = true;
			SaveButton.Click += SaveButton_Click;
			// 
			// PriceBox
			// 
			PriceBox.Location = new Point(6, 345);
			PriceBox.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			PriceBox.Name = "PriceBox";
			PriceBox.Size = new Size(160, 23);
			PriceBox.TabIndex = 15;
			// 
			// PriceLabel
			// 
			PriceLabel.AutoSize = true;
			PriceLabel.Location = new Point(6, 327);
			PriceLabel.Name = "PriceLabel";
			PriceLabel.Size = new Size(32, 15);
			PriceLabel.TabIndex = 14;
			PriceLabel.Text = "Ціна";
			// 
			// PagesBox
			// 
			PagesBox.Location = new Point(6, 213);
			PagesBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			PagesBox.Name = "PagesBox";
			PagesBox.Size = new Size(160, 23);
			PagesBox.TabIndex = 13;
			// 
			// PagesLabel
			// 
			PagesLabel.AutoSize = true;
			PagesLabel.Location = new Point(6, 195);
			PagesLabel.Name = "PagesLabel";
			PagesLabel.Size = new Size(107, 15);
			PagesLabel.TabIndex = 12;
			PagesLabel.Text = "Кількість сторінок";
			// 
			// LanguageBox
			// 
			LanguageBox.DropDownStyle = ComboBoxStyle.DropDownList;
			LanguageBox.FormattingEnabled = true;
			LanguageBox.Location = new Point(6, 301);
			LanguageBox.Name = "LanguageBox";
			LanguageBox.Size = new Size(160, 23);
			LanguageBox.TabIndex = 11;
			// 
			// LanguageLabel
			// 
			LanguageLabel.AutoSize = true;
			LanguageLabel.Location = new Point(6, 283);
			LanguageLabel.Name = "LanguageLabel";
			LanguageLabel.Size = new Size(37, 15);
			LanguageLabel.TabIndex = 10;
			LanguageLabel.Text = "Мова";
			// 
			// YearBox
			// 
			YearBox.Location = new Point(6, 257);
			YearBox.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
			YearBox.Minimum = new decimal(new int[] { 1950, 0, 0, 0 });
			YearBox.Name = "YearBox";
			YearBox.Size = new Size(160, 23);
			YearBox.TabIndex = 7;
			YearBox.Value = new decimal(new int[] { 1950, 0, 0, 0 });
			// 
			// YearLabel
			// 
			YearLabel.AutoSize = true;
			YearLabel.Location = new Point(6, 239);
			YearLabel.Name = "YearLabel";
			YearLabel.Size = new Size(23, 15);
			YearLabel.TabIndex = 6;
			YearLabel.Text = "Рік";
			// 
			// TopicBox
			// 
			TopicBox.Location = new Point(6, 81);
			TopicBox.Name = "TopicBox";
			TopicBox.Size = new Size(160, 23);
			TopicBox.TabIndex = 5;
			// 
			// TopicLabel
			// 
			TopicLabel.AutoSize = true;
			TopicLabel.Location = new Point(6, 63);
			TopicLabel.Name = "TopicLabel";
			TopicLabel.Size = new Size(59, 15);
			TopicLabel.TabIndex = 4;
			TopicLabel.Text = "Тематика";
			// 
			// NameBox
			// 
			NameBox.Location = new Point(6, 37);
			NameBox.Name = "NameBox";
			NameBox.Size = new Size(160, 23);
			NameBox.TabIndex = 1;
			// 
			// NameLabel
			// 
			NameLabel.AutoSize = true;
			NameLabel.Location = new Point(6, 19);
			NameLabel.Name = "NameLabel";
			NameLabel.Size = new Size(39, 15);
			NameLabel.TabIndex = 0;
			NameLabel.Text = "Назва";
			// 
			// AddMagazineControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(AddMagazineBox);
			Name = "AddMagazineControl";
			Size = new Size(580, 500);
			AddMagazineBox.ResumeLayout(false);
			AddMagazineBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)NumberBox).EndInit();
			((System.ComponentModel.ISupportInitialize)PerYearBox).EndInit();
			((System.ComponentModel.ISupportInitialize)PriceBox).EndInit();
			((System.ComponentModel.ISupportInitialize)PagesBox).EndInit();
			((System.ComponentModel.ISupportInitialize)YearBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox AddMagazineBox;
		private Button ClearButton;
		private Button SaveButton;
		private NumericUpDown PriceBox;
		private Label PriceLabel;
		private NumericUpDown PagesBox;
		private Label PagesLabel;
		private ComboBox LanguageBox;
		private Label LanguageLabel;
		private NumericUpDown YearBox;
		private Label YearLabel;
		private TextBox TopicBox;
		private Label TopicLabel;
		private TextBox NameBox;
		private Label NameLabel;
		private NumericUpDown PerYearBox;
		private Label PerYearLabel;
		private NumericUpDown NumberBox;
		private Label NumberLabel;
	}
}
