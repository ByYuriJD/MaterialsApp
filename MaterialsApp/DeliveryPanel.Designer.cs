namespace MaterialsApp {
	partial class DeliveryPanel {
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
			panel1 = new Panel();
			labelDate = new Label();
			labelPrice = new Label();
			labelAmmount = new Label();
			labelInPackage = new Label();
			labelName = new Label();
			labelDescription = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(labelDate);
			panel1.Controls.Add(labelPrice);
			panel1.Controls.Add(labelAmmount);
			panel1.Controls.Add(labelInPackage);
			panel1.Dock = DockStyle.Right;
			panel1.Location = new Point(197, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(165, 100);
			panel1.TabIndex = 0;
			// 
			// labelDate
			// 
			labelDate.Dock = DockStyle.Top;
			labelDate.Location = new Point(0, 69);
			labelDate.Name = "labelDate";
			labelDate.Size = new Size(163, 22);
			labelDate.TabIndex = 3;
			labelDate.Text = "Дата поставки: 2025-01-01";
			// 
			// labelPrice
			// 
			labelPrice.Dock = DockStyle.Top;
			labelPrice.Location = new Point(0, 46);
			labelPrice.Name = "labelPrice";
			labelPrice.Size = new Size(163, 23);
			labelPrice.TabIndex = 2;
			labelPrice.Text = "Цена за упаковку: 100000";
			// 
			// labelAmmount
			// 
			labelAmmount.Dock = DockStyle.Top;
			labelAmmount.Location = new Point(0, 23);
			labelAmmount.Name = "labelAmmount";
			labelAmmount.Size = new Size(163, 23);
			labelAmmount.TabIndex = 1;
			labelAmmount.Text = "Кол-во упаковок: 1000";
			// 
			// labelInPackage
			// 
			labelInPackage.Dock = DockStyle.Top;
			labelInPackage.Location = new Point(0, 0);
			labelInPackage.Name = "labelInPackage";
			labelInPackage.Size = new Size(163, 23);
			labelInPackage.TabIndex = 0;
			labelInPackage.Text = "Кол-во в упаковке: 1000";
			// 
			// labelName
			// 
			labelName.AutoEllipsis = true;
			labelName.Dock = DockStyle.Top;
			labelName.Location = new Point(0, 0);
			labelName.Name = "labelName";
			labelName.Size = new Size(197, 23);
			labelName.TabIndex = 1;
			labelName.Text = "Древесноволокнистая плита 1";
			// 
			// labelDescription
			// 
			labelDescription.AutoEllipsis = true;
			labelDescription.Dock = DockStyle.Fill;
			labelDescription.Location = new Point(0, 23);
			labelDescription.Name = "labelDescription";
			labelDescription.Size = new Size(197, 77);
			labelDescription.TabIndex = 2;
			labelDescription.Text = "Описание";
			// 
			// DeliveryPanel
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BorderStyle = BorderStyle.FixedSingle;
			Controls.Add(labelDescription);
			Controls.Add(labelName);
			Controls.Add(panel1);
			Name = "DeliveryPanel";
			Size = new Size(362, 100);
			panel1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label labelInPackage;
		private Label labelDate;
		private Label labelPrice;
		private Label labelAmmount;
		private Label labelName;
		private Label labelDescription;
	}
}
