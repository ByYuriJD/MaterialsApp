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
			labelInn = new Label();
			labelHeaderInn = new Label();
			labelType = new Label();
			labelHeaderType = new Label();
			buttonHistory = new Button();
			buttonActive = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			buttonEdit = new Button();
			buttonDelete = new Button();
			panel1.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			SuspendLayout();
			// 
			// labelHeaderSupplier
			// 
			labelHeaderSupplier.Dock = DockStyle.Top;
			labelHeaderSupplier.Location = new Point(0, 0);
			labelHeaderSupplier.Name = "labelHeaderSupplier";
			labelHeaderSupplier.Size = new Size(211, 19);
			labelHeaderSupplier.TabIndex = 0;
			labelHeaderSupplier.Text = "Поставщик:";
			// 
			// labelSupplier
			// 
			labelSupplier.Dock = DockStyle.Top;
			labelSupplier.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
			labelSupplier.Location = new Point(0, 19);
			labelSupplier.Name = "labelSupplier";
			labelSupplier.Size = new Size(211, 23);
			labelSupplier.TabIndex = 1;
			labelSupplier.Text = "label2";
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.Controls.Add(labelMeanQuality);
			panel1.Controls.Add(labelInn);
			panel1.Controls.Add(labelHeaderInn);
			panel1.Controls.Add(labelType);
			panel1.Controls.Add(labelHeaderType);
			panel1.Controls.Add(labelSupplier);
			panel1.Controls.Add(labelHeaderSupplier);
			panel1.Dock = DockStyle.Fill;
			panel1.Location = new Point(5, 5);
			panel1.Name = "panel1";
			panel1.Size = new Size(211, 141);
			panel1.TabIndex = 3;
			// 
			// labelMeanQuality
			// 
			labelMeanQuality.Dock = DockStyle.Top;
			labelMeanQuality.Location = new Point(0, 115);
			labelMeanQuality.Name = "labelMeanQuality";
			labelMeanQuality.Size = new Size(211, 18);
			labelMeanQuality.TabIndex = 6;
			labelMeanQuality.Text = "Среднее качество поставок:";
			// 
			// labelInn
			// 
			labelInn.Dock = DockStyle.Top;
			labelInn.Location = new Point(0, 97);
			labelInn.Name = "labelInn";
			labelInn.Size = new Size(211, 18);
			labelInn.TabIndex = 5;
			labelInn.Text = "111111111";
			// 
			// labelHeaderInn
			// 
			labelHeaderInn.Dock = DockStyle.Top;
			labelHeaderInn.Location = new Point(0, 79);
			labelHeaderInn.Name = "labelHeaderInn";
			labelHeaderInn.Size = new Size(211, 18);
			labelHeaderInn.TabIndex = 4;
			labelHeaderInn.Text = "ИНН поставщика:";
			// 
			// labelType
			// 
			labelType.Dock = DockStyle.Top;
			labelType.Location = new Point(0, 60);
			labelType.Name = "labelType";
			labelType.Size = new Size(211, 19);
			labelType.TabIndex = 3;
			labelType.Text = "АБВ";
			// 
			// labelHeaderType
			// 
			labelHeaderType.Dock = DockStyle.Top;
			labelHeaderType.Location = new Point(0, 42);
			labelHeaderType.Name = "labelHeaderType";
			labelHeaderType.Size = new Size(211, 18);
			labelHeaderType.TabIndex = 2;
			labelHeaderType.Text = "Тип Поставщика:";
			// 
			// buttonHistory
			// 
			buttonHistory.BackColor = Color.FromArgb(244, 232, 211);
			buttonHistory.Location = new Point(2, 104);
			buttonHistory.Margin = new Padding(2);
			buttonHistory.Name = "buttonHistory";
			buttonHistory.Size = new Size(132, 30);
			buttonHistory.TabIndex = 3;
			buttonHistory.Text = "История поставок";
			buttonHistory.UseVisualStyleBackColor = false;
			buttonHistory.Click += buttonHistory_Click;
			// 
			// buttonActive
			// 
			buttonActive.BackColor = Color.White;
			buttonActive.Location = new Point(2, 2);
			buttonActive.Margin = new Padding(2);
			buttonActive.Name = "buttonActive";
			buttonActive.Size = new Size(132, 30);
			buttonActive.TabIndex = 0;
			buttonActive.Text = "Действующий";
			buttonActive.UseVisualStyleBackColor = false;
			buttonActive.Click += Active_Click;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = Color.White;
			flowLayoutPanel1.Controls.Add(buttonActive);
			flowLayoutPanel1.Controls.Add(buttonEdit);
			flowLayoutPanel1.Controls.Add(buttonDelete);
			flowLayoutPanel1.Controls.Add(buttonHistory);
			flowLayoutPanel1.Dock = DockStyle.Right;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(216, 5);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(137, 141);
			flowLayoutPanel1.TabIndex = 2;
			// 
			// buttonEdit
			// 
			buttonEdit.BackColor = Color.FromArgb(244, 232, 211);
			buttonEdit.Location = new Point(2, 36);
			buttonEdit.Margin = new Padding(2);
			buttonEdit.Name = "buttonEdit";
			buttonEdit.Size = new Size(132, 30);
			buttonEdit.TabIndex = 2;
			buttonEdit.Text = "Редактировать";
			buttonEdit.UseVisualStyleBackColor = false;
			buttonEdit.Click += buttonEdit_Click;
			// 
			// buttonDelete
			// 
			buttonDelete.BackColor = Color.FromArgb(244, 232, 211);
			buttonDelete.Location = new Point(2, 70);
			buttonDelete.Margin = new Padding(2);
			buttonDelete.Name = "buttonDelete";
			buttonDelete.Size = new Size(132, 30);
			buttonDelete.TabIndex = 1;
			buttonDelete.Text = "Удалить";
			buttonDelete.UseVisualStyleBackColor = false;
			buttonDelete.Click += buttonDelete_Click;
			// 
			// SupplierPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.White;
			Controls.Add(panel1);
			Controls.Add(flowLayoutPanel1);
			Name = "SupplierPanel";
			Padding = new Padding(5);
			Size = new Size(358, 151);
			panel1.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion
		private Label labelHeaderSupplier;
		private Label labelSupplier;
		private Panel panel1;
		private Label labelType;
		private Label labelHeaderType;
		private Button buttonHistory;
		private Button buttonActive;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonDelete;
		private Button buttonEdit;
		private Label labelMeanQuality;
		private Label labelInn;
		private Label labelHeaderInn;
	}
}
