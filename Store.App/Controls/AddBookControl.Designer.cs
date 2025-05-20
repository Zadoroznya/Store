namespace Store.App.Controls
{
	partial class AddBookControl
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
			AddBookBox = new GroupBox();
			ClearButton = new Button();
			SaveButton = new Button();
			PriceBox = new NumericUpDown();
			PriceLabel = new Label();
			PagesBox = new NumericUpDown();
			PagesLabel = new Label();
			LanguageBox = new ComboBox();
			LanguageLabel = new Label();
			PublisherBox = new TextBox();
			PublisherLabel = new Label();
			YearBox = new NumericUpDown();
			YearLabel = new Label();
			TopicBox = new TextBox();
			TopicLabel = new Label();
			AuthorBox = new TextBox();
			AuthorLabel = new Label();
			NameBox = new TextBox();
			NameLabel = new Label();
			AddBookBox.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)PriceBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)PagesBox).BeginInit();
			((System.ComponentModel.ISupportInitialize)YearBox).BeginInit();
			SuspendLayout();
			// 
			// AddBookBox
			// 
			AddBookBox.Controls.Add(ClearButton);
			AddBookBox.Controls.Add(SaveButton);
			AddBookBox.Controls.Add(PriceBox);
			AddBookBox.Controls.Add(PriceLabel);
			AddBookBox.Controls.Add(PagesBox);
			AddBookBox.Controls.Add(PagesLabel);
			AddBookBox.Controls.Add(LanguageBox);
			AddBookBox.Controls.Add(LanguageLabel);
			AddBookBox.Controls.Add(PublisherBox);
			AddBookBox.Controls.Add(PublisherLabel);
			AddBookBox.Controls.Add(YearBox);
			AddBookBox.Controls.Add(YearLabel);
			AddBookBox.Controls.Add(TopicBox);
			AddBookBox.Controls.Add(TopicLabel);
			AddBookBox.Controls.Add(AuthorBox);
			AddBookBox.Controls.Add(AuthorLabel);
			AddBookBox.Controls.Add(NameBox);
			AddBookBox.Controls.Add(NameLabel);
			AddBookBox.Dock = DockStyle.Fill;
			AddBookBox.Location = new Point(0, 0);
			AddBookBox.Name = "AddBookBox";
			AddBookBox.Size = new Size(563, 483);
			AddBookBox.TabIndex = 0;
			AddBookBox.TabStop = false;
			AddBookBox.Text = "Додавання книги";
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
			PagesBox.Location = new Point(6, 301);
			PagesBox.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			PagesBox.Name = "PagesBox";
			PagesBox.Size = new Size(160, 23);
			PagesBox.TabIndex = 13;
			// 
			// PagesLabel
			// 
			PagesLabel.AutoSize = true;
			PagesLabel.Location = new Point(6, 283);
			PagesLabel.Name = "PagesLabel";
			PagesLabel.Size = new Size(107, 15);
			PagesLabel.TabIndex = 12;
			PagesLabel.Text = "Кількість сторінок";
			// 
			// LanguageBox
			// 
			LanguageBox.DropDownStyle = ComboBoxStyle.DropDownList;
			LanguageBox.FormattingEnabled = true;
			LanguageBox.Location = new Point(6, 257);
			LanguageBox.Name = "LanguageBox";
			LanguageBox.Size = new Size(160, 23);
			LanguageBox.TabIndex = 11;
			// 
			// LanguageLabel
			// 
			LanguageLabel.AutoSize = true;
			LanguageLabel.Location = new Point(6, 239);
			LanguageLabel.Name = "LanguageLabel";
			LanguageLabel.Size = new Size(37, 15);
			LanguageLabel.TabIndex = 10;
			LanguageLabel.Text = "Мова";
			// 
			// PublisherBox
			// 
			PublisherBox.Location = new Point(6, 213);
			PublisherBox.Name = "PublisherBox";
			PublisherBox.Size = new Size(160, 23);
			PublisherBox.TabIndex = 9;
			// 
			// PublisherLabel
			// 
			PublisherLabel.AutoSize = true;
			PublisherLabel.Location = new Point(6, 195);
			PublisherLabel.Name = "PublisherLabel";
			PublisherLabel.Size = new Size(78, 15);
			PublisherLabel.TabIndex = 8;
			PublisherLabel.Text = "Видавництво";
			// 
			// YearBox
			// 
			YearBox.Location = new Point(6, 169);
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
			YearLabel.Location = new Point(6, 151);
			YearLabel.Name = "YearLabel";
			YearLabel.Size = new Size(23, 15);
			YearLabel.TabIndex = 6;
			YearLabel.Text = "Рік";
			// 
			// TopicBox
			// 
			TopicBox.Location = new Point(6, 125);
			TopicBox.Name = "TopicBox";
			TopicBox.Size = new Size(160, 23);
			TopicBox.TabIndex = 5;
			// 
			// TopicLabel
			// 
			TopicLabel.AutoSize = true;
			TopicLabel.Location = new Point(6, 107);
			TopicLabel.Name = "TopicLabel";
			TopicLabel.Size = new Size(59, 15);
			TopicLabel.TabIndex = 4;
			TopicLabel.Text = "Тематика";
			// 
			// AuthorBox
			// 
			AuthorBox.Location = new Point(6, 81);
			AuthorBox.Name = "AuthorBox";
			AuthorBox.Size = new Size(160, 23);
			AuthorBox.TabIndex = 3;
			// 
			// AuthorLabel
			// 
			AuthorLabel.AutoSize = true;
			AuthorLabel.Location = new Point(6, 63);
			AuthorLabel.Name = "AuthorLabel";
			AuthorLabel.Size = new Size(40, 15);
			AuthorLabel.TabIndex = 2;
			AuthorLabel.Text = "Автор";
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
			// AddBookControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoScroll = true;
			Controls.Add(AddBookBox);
			Name = "AddBookControl";
			Size = new Size(563, 483);
			AddBookBox.ResumeLayout(false);
			AddBookBox.PerformLayout();
			((System.ComponentModel.ISupportInitialize)PriceBox).EndInit();
			((System.ComponentModel.ISupportInitialize)PagesBox).EndInit();
			((System.ComponentModel.ISupportInitialize)YearBox).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox AddBookBox;
		private TextBox NameBox;
		private Label NameLabel;
		private TextBox AuthorBox;
		private Label AuthorLabel;
		private TextBox PublisherBox;
		private Label PublisherLabel;
		private NumericUpDown YearBox;
		private Label YearLabel;
		private TextBox TopicBox;
		private Label TopicLabel;
		private ComboBox LanguageBox;
		private Label LanguageLabel;
		private NumericUpDown PriceBox;
		private Label PriceLabel;
		private NumericUpDown PagesBox;
		private Label PagesLabel;
		private Button ClearButton;
		private Button SaveButton;
	}
}
