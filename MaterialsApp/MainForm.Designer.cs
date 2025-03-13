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
			panelTop = new Panel();
			buttonHistory = new Button();
			button3 = new Button();
			buttonEdit = new Button();
			buttonAdd = new Button();
			panelFill = new Panel();
			dataGridView = new DataGridView();
			panelTop.SuspendLayout();
			panelFill.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.Controls.Add(buttonHistory);
			panelTop.Controls.Add(button3);
			panelTop.Controls.Add(buttonEdit);
			panelTop.Controls.Add(buttonAdd);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(16);
			panelTop.Size = new Size(584, 74);
			panelTop.TabIndex = 0;
			// 
			// buttonHistory
			// 
			buttonHistory.Dock = DockStyle.Fill;
			buttonHistory.Location = new Point(315, 16);
			buttonHistory.Name = "buttonHistory";
			buttonHistory.Size = new Size(253, 42);
			buttonHistory.TabIndex = 3;
			buttonHistory.Text = "История поставок";
			buttonHistory.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			button3.Dock = DockStyle.Left;
			button3.Location = new Point(231, 16);
			button3.Name = "button3";
			button3.Size = new Size(84, 42);
			button3.TabIndex = 2;
			button3.Text = "Удалить";
			button3.UseVisualStyleBackColor = true;
			// 
			// buttonEdit
			// 
			buttonEdit.Dock = DockStyle.Left;
			buttonEdit.Location = new Point(116, 16);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(115, 42);
			buttonEdit.TabIndex = 1;
			buttonEdit.Text = "Редактировать";
			buttonEdit.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			buttonAdd.Dock = DockStyle.Left;
			buttonAdd.Location = new Point(16, 16);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(100, 42);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "Добавить";
			buttonAdd.UseVisualStyleBackColor = true;
			// 
			// panelFill
			// 
			panelFill.Controls.Add(dataGridView);
			panelFill.Dock = DockStyle.Fill;
			panelFill.Location = new Point(0, 74);
			panelFill.Name = "panelFill";
			panelFill.Padding = new Padding(16);
			panelFill.Size = new Size(584, 387);
			panelFill.TabIndex = 1;
			// 
			// dataGridView
			// 
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.Location = new Point(16, 16);
			dataGridView.Name = "dataGridView";
			dataGridView.Size = new Size(552, 355);
			dataGridView.TabIndex = 0;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 461);
			Controls.Add(panelFill);
			Controls.Add(panelTop);
			Name = "MainForm";
			Load += MainForm_Load;
			panelTop.ResumeLayout(false);
			panelFill.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
		private Button buttonHistory;
		private Button button3;
		private Button buttonEdit;
		private Button buttonAdd;
		private Panel panelFill;
		private DataGridView dataGridView;
	}
}
