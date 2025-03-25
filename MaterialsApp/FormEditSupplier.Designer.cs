namespace MaterialsApp {
	partial class FormEditSupplier {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new System.ComponentModel.Container();
			panel1 = new Panel();
			buttonConfirm = new Button();
			buttonCancel = new Button();
			flowLayoutPanel1 = new FlowLayoutPanel();
			panel2 = new Panel();
			textBoxName = new TextBox();
			labelName = new Label();
			panel3 = new Panel();
			textBoxInn = new TextBox();
			labelInn = new Label();
			panel4 = new Panel();
			comboBoxType = new ComboBox();
			labelType = new Label();
			panelActive = new Panel();
			checkBoxActive = new CheckBox();
			labelActive = new Label();
			errorProvider = new ErrorProvider(components);
			panel1.SuspendLayout();
			flowLayoutPanel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panelActive.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.White;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(buttonConfirm);
			panel1.Controls.Add(buttonCancel);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(494, 44);
			panel1.TabIndex = 0;
			// 
			// buttonConfirm
			// 
			buttonConfirm.BackColor = Color.FromArgb(244, 232, 211);
			buttonConfirm.DialogResult = DialogResult.Yes;
			buttonConfirm.Dock = DockStyle.Left;
			buttonConfirm.Location = new Point(127, 0);
			buttonConfirm.Name = "buttonConfirm";
			buttonConfirm.Size = new Size(131, 42);
			buttonConfirm.TabIndex = 0;
			buttonConfirm.Text = "Подтвердить";
			buttonConfirm.UseVisualStyleBackColor = false;
			buttonConfirm.Click += buttonConfirm_Click;
			// 
			// buttonCancel
			// 
			buttonCancel.BackColor = Color.FromArgb(244, 232, 211);
			buttonCancel.DialogResult = DialogResult.Cancel;
			buttonCancel.Dock = DockStyle.Left;
			buttonCancel.Location = new Point(0, 0);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(127, 42);
			buttonCancel.TabIndex = 1;
			buttonCancel.Text = "Отменить";
			buttonCancel.UseVisualStyleBackColor = false;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.BackColor = Color.White;
			flowLayoutPanel1.Controls.Add(panel2);
			flowLayoutPanel1.Controls.Add(panel3);
			flowLayoutPanel1.Controls.Add(panel4);
			flowLayoutPanel1.Controls.Add(panelActive);
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.Location = new Point(0, 44);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(494, 81);
			flowLayoutPanel1.TabIndex = 1;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(244, 232, 211);
			panel2.Controls.Add(textBoxName);
			panel2.Controls.Add(labelName);
			panel2.Location = new Point(3, 3);
			panel2.Name = "panel2";
			panel2.Size = new Size(125, 78);
			panel2.TabIndex = 0;
			// 
			// textBoxName
			// 
			textBoxName.Dock = DockStyle.Fill;
			textBoxName.Location = new Point(0, 23);
			textBoxName.Name = "textBoxName";
			textBoxName.Size = new Size(125, 23);
			textBoxName.TabIndex = 1;
			textBoxName.TextChanged += checkIsValid;
			// 
			// labelName
			// 
			labelName.Dock = DockStyle.Top;
			labelName.Location = new Point(0, 0);
			labelName.Name = "labelName";
			labelName.Size = new Size(125, 23);
			labelName.TabIndex = 0;
			labelName.Text = "Наименование";
			// 
			// panel3
			// 
			panel3.BackColor = Color.FromArgb(244, 232, 211);
			panel3.Controls.Add(textBoxInn);
			panel3.Controls.Add(labelInn);
			panel3.Location = new Point(134, 3);
			panel3.Name = "panel3";
			panel3.Size = new Size(125, 78);
			panel3.TabIndex = 2;
			// 
			// textBoxInn
			// 
			textBoxInn.Dock = DockStyle.Fill;
			textBoxInn.Location = new Point(0, 23);
			textBoxInn.Name = "textBoxInn";
			textBoxInn.Size = new Size(125, 23);
			textBoxInn.TabIndex = 1;
			textBoxInn.TextChanged += checkIsValid;
			// 
			// labelInn
			// 
			labelInn.Dock = DockStyle.Top;
			labelInn.Location = new Point(0, 0);
			labelInn.Name = "labelInn";
			labelInn.Size = new Size(125, 23);
			labelInn.TabIndex = 0;
			labelInn.Text = "Инн";
			// 
			// panel4
			// 
			panel4.BackColor = Color.FromArgb(244, 232, 211);
			panel4.Controls.Add(comboBoxType);
			panel4.Controls.Add(labelType);
			panel4.Location = new Point(265, 3);
			panel4.Name = "panel4";
			panel4.Size = new Size(125, 78);
			panel4.TabIndex = 2;
			// 
			// comboBoxType
			// 
			comboBoxType.Dock = DockStyle.Fill;
			comboBoxType.FormattingEnabled = true;
			comboBoxType.Location = new Point(0, 23);
			comboBoxType.Name = "comboBoxType";
			comboBoxType.Size = new Size(125, 23);
			comboBoxType.TabIndex = 1;
			// 
			// labelType
			// 
			labelType.Dock = DockStyle.Top;
			labelType.Location = new Point(0, 0);
			labelType.Name = "labelType";
			labelType.Size = new Size(125, 23);
			labelType.TabIndex = 0;
			labelType.Text = "Тип";
			// 
			// panelActive
			// 
			panelActive.BackColor = Color.FromArgb(244, 232, 211);
			panelActive.Controls.Add(checkBoxActive);
			panelActive.Controls.Add(labelActive);
			panelActive.Location = new Point(396, 3);
			panelActive.Name = "panelActive";
			panelActive.Size = new Size(94, 78);
			panelActive.TabIndex = 3;
			// 
			// checkBoxActive
			// 
			checkBoxActive.AutoSize = true;
			checkBoxActive.CheckAlign = ContentAlignment.MiddleCenter;
			checkBoxActive.Checked = true;
			checkBoxActive.CheckState = CheckState.Checked;
			checkBoxActive.Dock = DockStyle.Top;
			checkBoxActive.Location = new Point(0, 23);
			checkBoxActive.Name = "checkBoxActive";
			checkBoxActive.Size = new Size(94, 14);
			checkBoxActive.TabIndex = 1;
			checkBoxActive.UseVisualStyleBackColor = true;
			// 
			// labelActive
			// 
			labelActive.Dock = DockStyle.Top;
			labelActive.Location = new Point(0, 0);
			labelActive.Name = "labelActive";
			labelActive.Size = new Size(94, 23);
			labelActive.TabIndex = 0;
			labelActive.Text = "Действующий";
			// 
			// errorProvider
			// 
			errorProvider.ContainerControl = this;
			// 
			// FormEditSupplier
			// 
			AcceptButton = buttonConfirm;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			CancelButton = buttonCancel;
			ClientSize = new Size(494, 125);
			Controls.Add(flowLayoutPanel1);
			Controls.Add(panel1);
			Name = "FormEditSupplier";
			ShowIcon = false;
			Text = "Поставщик";
			panel1.ResumeLayout(false);
			flowLayoutPanel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel4.ResumeLayout(false);
			panelActive.ResumeLayout(false);
			panelActive.PerformLayout();
			((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private FlowLayoutPanel flowLayoutPanel1;
		private Button buttonConfirm;
		private Button buttonCancel;
		private Panel panel2;
		private Label labelName;
		private Panel panel3;
		private Label labelInn;
		private Panel panel4;
		private Label labelType;
		private ErrorProvider errorProvider;
		public TextBox textBoxName;
		public TextBox textBoxInn;
		public ComboBox comboBoxType;
		private Panel panelActive;
		private Label labelActive;
		public CheckBox checkBoxActive;
	}
}