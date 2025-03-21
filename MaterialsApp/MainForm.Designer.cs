namespace MaterialsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			panelTop = new Panel();
			buttonAdd = new Button();
			tableLayoutPanel = new TableLayoutPanel();
			panelTop.SuspendLayout();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.BackColor = Color.White;
			panelTop.BorderStyle = BorderStyle.FixedSingle;
			panelTop.Controls.Add(buttonAdd);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(16);
			panelTop.Size = new Size(487, 74);
			panelTop.TabIndex = 0;
			// 
			// buttonAdd
			// 
			buttonAdd.BackColor = Color.FromArgb(244, 232, 211);
			buttonAdd.Dock = DockStyle.Left;
			buttonAdd.Location = new Point(16, 16);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(167, 40);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "Добавить поставщика";
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AutoScroll = true;
			tableLayoutPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			tableLayoutPanel.BackColor = Color.White;
			tableLayoutPanel.ColumnCount = 1;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 74);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 1;
			tableLayoutPanel.RowStyles.Add(new RowStyle());
			tableLayoutPanel.Size = new Size(487, 395);
			tableLayoutPanel.TabIndex = 1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(487, 469);
			Controls.Add(tableLayoutPanel);
			Controls.Add(panelTop);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Список поставщиков";
			Load += MainForm_Load;
			panelTop.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
		private Button buttonAdd;
		private TableLayoutPanel tableLayoutPanel;
	}
}
