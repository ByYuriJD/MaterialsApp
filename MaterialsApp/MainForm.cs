using System.ComponentModel;
using MaterialsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialsApp {
	public partial class MainForm : Form {
		public PartnersContext? db;
		public MainForm() {

			InitializeComponent();
		}
		public void MainForm_Load(object sender, EventArgs e) {
			db = new PartnersContext();
			db.Suppliers.Load();
			db.OrganizationTypes.Load();
			db.MaterialDeliveries.Load();
			db.Materials.Load();
			
			dataGridView.DataSource = db.Suppliers.Local.ToArray();

			dataGridView.Columns["Id"].Visible = false;
			dataGridView.Columns["IdOfType"].Visible = false;
			dataGridView.Columns["IdOfTypeNavigation"].Visible = false;
			dataGridView.Columns["MaterialDeliveries"].Visible = false;
			dataGridView.Columns["NameOfSupplier"].DisplayIndex = 1;
			dataGridView.Columns["NameOfSupplier"].HeaderText = "Наименование поставщика";
			dataGridView.Columns["Inn"].DisplayIndex = 2;
			dataGridView.Columns["Inn"].HeaderText = "Инн";
			dataGridView.Columns["IsActive"].DisplayIndex = 3;
			dataGridView.Columns["IsActive"].HeaderText = "Действующий";

			DataGridViewTextBoxColumn columnType = new DataGridViewTextBoxColumn();
			columnType.Name = "Тип поставщика";
			columnType.DisplayIndex = 0;
			dataGridView.Columns.Add(columnType);

			DataGridViewTextBoxColumn columnRating = new DataGridViewTextBoxColumn();
			columnRating.Name = "Среднее качество поставок";
			columnRating.DisplayIndex = 4;
			dataGridView.Columns.Add(columnRating);

			updateView();
		}
		private void updateView() {
			Supplier[] suppliers = db.Suppliers.Local.ToArray();

			dataGridView.DataSource = suppliers;
			dataGridView.Refresh();

			for (int i = 0; i < dataGridView.RowCount; i++) {
				DataGridViewRow row = dataGridView.Rows[i];
				Supplier supplier = suppliers[i];
				row.Cells["Тип поставщика"].Value = supplier.IdOfTypeNavigation.TypeOfPartner;


				if (supplier.MaterialDeliveries.Any()) {
					float deliveryQuality = 0;
					foreach (MaterialDelivery delivery in supplier.MaterialDeliveries) {
						deliveryQuality += delivery.QualityOfDelivery;
					}
					deliveryQuality /= supplier.MaterialDeliveries.Count;
					row.Cells["Среднее качество поставок"].Value = deliveryQuality.ToString();
				} else
					row.Cells["Среднее качество поставок"].Value = "Отсутствуют доставки";
			}
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);
			this.db?.Dispose();
			this.db = null;
		}
		public void saveSupplier(Supplier supplier) {
			db.Suppliers.Update(supplier);
			db.SaveChanges();
			updateView();
		}
		public void deleteSupplier(Supplier supplier) {
			db.Suppliers.Remove(supplier);
			db.SaveChanges();
		}

		private void buttonAdd_Click(object sender, EventArgs e) {
			FormEditSupplier newSupplierForm = new FormEditSupplier(db.OrganizationTypes.ToArray());

			DialogResult result = newSupplierForm.ShowDialog(this);
			if (result == DialogResult.Cancel) {
				return;
			}
			Supplier newSupplier = new Supplier {
				Inn = newSupplierForm.textBoxInn.Text,
				NameOfSupplier = newSupplierForm.textBoxName.Text,
				IsActive = newSupplierForm.checkBoxActive.Checked,
				IdOfType = db.OrganizationTypes.FirstOrDefault(
						e => e.TypeOfPartner == newSupplierForm.comboBoxType.Text).Id
			};

			db.Suppliers.Add(newSupplier);
			db.SaveChanges();
			updateView();
			MessageBox.Show("Поставщик создан", "Поставщики", MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count == 0) return;
			Supplier supplier = db.Suppliers.FirstOrDefault(e => e.Id == (short)dataGridView.SelectedRows[0].Cells["Id"].Value);

			DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данного поставщика?",
				"Поставщики",
				MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK) {
				deleteSupplier(supplier);
				MessageBox.Show("Поставщик удален");
			}
			updateView();
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count == 0) return;
			Supplier supplier = db.Suppliers.FirstOrDefault(e => e.Id == (short)dataGridView.SelectedRows[0].Cells["Id"].Value);

			FormEditSupplier editSupplier = new FormEditSupplier(db.OrganizationTypes.ToArray(), supplier);
			DialogResult result = editSupplier.ShowDialog();

			if (result == DialogResult.Cancel)
				return;
			supplier.NameOfSupplier = editSupplier.textBoxName.Text;
			supplier.Inn = editSupplier.textBoxInn.Text;
			supplier.IsActive = editSupplier.checkBoxActive.Checked;
			supplier.IdOfType = db.OrganizationTypes.FirstOrDefault(
				e => e.TypeOfPartner == editSupplier.comboBoxType.Text).Id;
			saveSupplier(supplier);
			updateView();

			MessageBox.Show("Поставщик обновлен", "Поставщики", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonHistory_Click(object sender, EventArgs e) {
			if (dataGridView.SelectedRows.Count == 0) return;

			Supplier supplier = db.Suppliers.FirstOrDefault(e => e.Id == (short)dataGridView.SelectedRows[0].Cells["Id"].Value);

			FormDeliveries formDeliveries = new FormDeliveries(db.MaterialDeliveries.Local.Where(e=>e.IdOfSupplier==supplier.Id).ToArray());
			formDeliveries.ShowDialog();
		}
	}
}
