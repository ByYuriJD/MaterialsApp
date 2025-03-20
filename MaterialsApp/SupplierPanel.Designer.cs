namespace MaterialsApp {
	partial class SupplierPanel {
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent() {
			labelHeaderSupplier = new Label();
			labelSupplier = new Label();
			panel1 = new Panel();
			labelMeanQuality = new Label();
			labelTypeInn = new Label();
			buttonHistory = new Button();
			buttonActive = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			buttonDelete = new Button();
			buttonEdit = new Button();
			panel1.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// labelHeaderSupplier
			// 
			labelHeaderSupplier.Dock = DockStyle.Top;
			labelHeaderSupplier.Location = new Point(0, 0);
			labelHeaderSupplier.Name = "labelHeaderSupplier";
			labelHeaderSupplier.Size = new Size(205, 19);
			labelHeaderSupplier.TabIndex = 0;
			labelHeaderSupplier.Text = "Поставщик:";
			// 
			// labelSupplier
			// 
			labelSupplier.Dock = DockStyle.Top;
			labelSupplier.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			labelSupplier.Location = new Point(0, 19);
			labelSupplier.Name = "labelSupplier";
			labelSupplier.Size = new Size(205, 23);
			labelSupplier.TabIndex = 1;
			labelSupplier.Text = "label2";
			// 
			// panel1
			// 
			panel1.Controls.Add(labelMeanQuality);
			panel1.Controls.Add(labelTypeInn);
			panel1.Controls.Add(labelSupplier);
			panel1.Controls.Add(buttonHistory);
			panel1.Controls.Add(labelHeaderSupplier);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(5, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(205, 112);
			panel1.TabIndex = 3;
			// 
			// labelMeanQuality
			// 
			labelMeanQuality.Dock = DockStyle.Top;
			labelMeanQuality.Location = new Point(0, 60);
			labelMeanQuality.Name = "labelMeanQuality";
			labelMeanQuality.Size = new Size(205, 19);
			labelMeanQuality.TabIndex = 3;
			labelMeanQuality.Text = "label2";
			// 
			// labelTypeInn
			// 
			labelTypeInn.Dock = DockStyle.Top;
			labelTypeInn.Location = new Point(0, 42);
			labelTypeInn.Name = "labelTypeInn";
			labelTypeInn.Size = new Size(205, 18);
			labelTypeInn.TabIndex = 2;
			labelTypeInn.Text = "label2";
			// 
			// buttonHistory
			// 
			buttonHistory.Dock = DockStyle.Bottom;
			buttonHistory.Location = new Point(0, 89);
			buttonHistory.Margin = new Padding(2);
			buttonHistory.Name = "buttonHistory";
			buttonHistory.Size = new Size(205, 23);
			buttonHistory.TabIndex = 3;
			buttonHistory.Text = "История поставок";
			buttonHistory.UseVisualStyleBackColor = true;
			buttonHistory.Click += buttonHistory_Click;
			// 
			// buttonActive
			// 
			buttonActive.BackColor = SystemColors.Control;
			buttonActive.Location = new Point(3, 12);
			buttonActive.Margin = new Padding(2);
			buttonActive.Name = "buttonActive";
			buttonActive.Size = new Size(137, 26);
			buttonActive.TabIndex = 0;
			buttonActive.Text = "Действующий";
			buttonActive.UseVisualStyleBackColor = false;
			buttonActive.Click += Active_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.Controls.Add(buttonActive);
			flowLayoutPanel1.Controls.Add(buttonDelete);
			flowLayoutPanel1.Controls.Add(buttonEdit);
			flowLayoutPanel1.Dock = DockStyle.Right;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(210, 5);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Padding = new Padding(1, 10, 1, 0);
			flowLayoutPanel1.Size = new Size(143, 112);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// buttonDelete
			// 
			buttonDelete.Location = new Point(3, 42);
			buttonDelete.Margin = new Padding(2);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(137, 23);
			buttonDelete.TabIndex = 1;
			buttonDelete.Text = "Удалить";
			buttonDelete.UseVisualStyleBackColor = true;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// buttonEdit
			// 
			buttonEdit.Location = new Point(3, 69);
			buttonEdit.Margin = new Padding(2);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(137, 40);
			buttonEdit.TabIndex = 2;
			buttonEdit.Text = "Редактировать";
			buttonEdit.UseVisualStyleBackColor = true;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// SupplierPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(panel1);
			Controls.Add(flowLayoutPanel1);
			Name = "SupplierPanel";
			Padding = new Padding(5);
			Size = new Size(358, 122);
			panel1.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Label labelHeaderSupplier;
		private Label labelSupplier;
		private Panel panel1;
		private Label labelMeanQuality;
		private Label labelTypeInn;
		private Button buttonHistory;
		private Button buttonActive;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonDelete;
		private Button buttonEdit;
	}
}
