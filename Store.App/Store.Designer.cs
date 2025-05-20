namespace Store.App
{
	partial class Store
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			MainContainer = new SplitContainer();
			MainTreeView = new TreeView();
			MainPanel = new Panel();
			((System.ComponentModel.ISupportInitialize)MainContainer).BeginInit();
			MainContainer.Panel1.SuspendLayout();
			MainContainer.Panel2.SuspendLayout();
			MainContainer.SuspendLayout();
			SuspendLayout();
			// 
			// MainContainer
			// 
			MainContainer.Dock = DockStyle.Fill;
			MainContainer.FixedPanel = FixedPanel.Panel1;
			MainContainer.Location = new Point(0, 0);
			MainContainer.Name = "MainContainer";
			// 
			// MainContainer.Panel1
			// 
			MainContainer.Panel1.AutoScroll = true;
			MainContainer.Panel1.Controls.Add(MainTreeView);
			MainContainer.Panel1MinSize = 200;
			// 
			// MainContainer.Panel2
			// 
			MainContainer.Panel2.AutoScroll = true;
			MainContainer.Panel2.Controls.Add(MainPanel);
			MainContainer.Panel2MinSize = 500;
			MainContainer.Size = new Size(884, 461);
			MainContainer.SplitterDistance = 293;
			MainContainer.TabIndex = 0;
			// 
			// MainTreeView
			// 
			MainTreeView.Cursor = Cursors.Hand;
			MainTreeView.Dock = DockStyle.Fill;
			MainTreeView.Location = new Point(0, 0);
			MainTreeView.Name = "MainTreeView";
			MainTreeView.Size = new Size(293, 461);
			MainTreeView.TabIndex = 0;
			MainTreeView.AfterSelect += MainTreeView_AfterSelect;
			// 
			// MainPanel
			// 
			MainPanel.AutoScroll = true;
			MainPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			MainPanel.Dock = DockStyle.Fill;
			MainPanel.Location = new Point(0, 0);
			MainPanel.Name = "MainPanel";
			MainPanel.Size = new Size(587, 461);
			MainPanel.TabIndex = 0;
			// 
			// Store
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(884, 461);
			Controls.Add(MainContainer);
			Name = "Store";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Магазин";
			MainContainer.Panel1.ResumeLayout(false);
			MainContainer.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)MainContainer).EndInit();
			MainContainer.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer MainContainer;
		private Panel MainPanel;
		private TreeView MainTreeView;
	}
}