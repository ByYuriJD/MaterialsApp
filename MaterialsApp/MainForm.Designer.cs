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
			buttonHistory = new Button();
			buttonDelete = new Button();
			buttonEdit = new Button();
			buttonAdd = new Button();
			dataGridView = new DataGridView();
			panelTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
			SuspendLayout();
			// 
			// panelTop
			// 
			panelTop.BackColor = Color.White;
			panelTop.BorderStyle = BorderStyle.FixedSingle;
			panelTop.Controls.Add(buttonHistory);
			panelTop.Controls.Add(buttonDelete);
			panelTop.Controls.Add(buttonEdit);
			panelTop.Controls.Add(buttonAdd);
			panelTop.Dock = DockStyle.Top;
			panelTop.Location = new Point(0, 0);
			panelTop.Name = "panelTop";
			panelTop.Padding = new Padding(16);
			panelTop.Size = new Size(701, 74);
			panelTop.TabIndex = 0;
			// 
			// buttonHistory
			// 
			buttonHistory.BackColor = Color.FromArgb(244, 232, 211);
			buttonHistory.Dock = DockStyle.Left;
			buttonHistory.Location = new Point(396, 16);
			buttonHistory.Name = "buttonHistory";
			buttonHistory.Size = new Size(167, 40);
			buttonHistory.TabIndex = 3;
			buttonHistory.Text = "История поставок";
			buttonHistory.UseVisualStyleBackColor = false;
			buttonHistory.Click += buttonHistory_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.FromArgb(244, 232, 211);
			buttonDelete.Dock = DockStyle.Left;
			buttonDelete.Location = new Point(274, 16);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(122, 40);
			buttonDelete.TabIndex = 2;
			buttonDelete.Text = "Удалить";
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.BackColor = Color.FromArgb(244, 232, 211);
			buttonEdit.Dock = DockStyle.Left;
			buttonEdit.Location = new Point(153, 16);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(121, 40);
			buttonEdit.TabIndex = 1;
			buttonEdit.Text = "Редактировать";
			buttonEdit.UseVisualStyleBackColor = false;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// buttonAdd
			// 
			buttonAdd.BackColor = Color.FromArgb(244, 232, 211);
			buttonAdd.Dock = DockStyle.Left;
			buttonAdd.Location = new Point(16, 16);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(137, 40);
			buttonAdd.TabIndex = 0;
			buttonAdd.Text = "Добавить поставщика";
			buttonAdd.UseVisualStyleBackColor = false;
			buttonAdd.Click += buttonAdd_Click;
			// 
			// dataGridView
			// 
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.BackgroundColor = Color.White;
			dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView.Dock = DockStyle.Fill;
			dataGridView.Location = new Point(0, 74);
			dataGridView.Name = "dataGridView";
			dataGridView.ReadOnly = true;
			dataGridView.Size = new Size(701, 395);
			dataGridView.TabIndex = 1;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(701, 469);
			Controls.Add(dataGridView);
			Controls.Add(panelTop);
			Icon = (Icon)resources.GetObject("$this.Icon");
			MaximizeBox = false;
			Name = "MainForm";
			Text = "Список поставщиков";
			Load += MainForm_Load;
			panelTop.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelTop;
		private Button buttonAdd;
		private DataGridView dataGridView;
		private Button buttonHistory;
		private Button buttonDelete;
		private Button buttonEdit;
	}
}
