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

			Supplier[] suppliers = db.Suppliers.Local.OrderByDescending(e => e.NameOfSupplier).ToArray();

			foreach (Supplier supplier in suppliers) {
				SupplierPanel supplierPanel = new SupplierPanel(this, supplier);
				tableLayoutPanel.Controls.Add(supplierPanel);
			}
		}
		private void updatePanel() {
			Supplier[] suppliers = db.Suppliers.Local.OrderByDescending(e => e.NameOfSupplier).ToArray();

			tableLayoutPanel.Controls.Clear();
			foreach (Supplier supplier in suppliers) {
				SupplierPanel supplierPanel = new SupplierPanel(this, supplier);
				tableLayoutPanel.Controls.Add(supplierPanel);
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
			updatePanel();
		}
		public void deleteSupplier(Supplier supplier) {
			db.Suppliers.Remove(supplier);
			db.SaveChanges();
			updatePanel();
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
				IsActive = true,
				IdOfType = db.OrganizationTypes.FirstOrDefault(
						e => e.TypeOfPartner == newSupplierForm.comboBoxType.Text).Id
			};

			db.Suppliers.Add(newSupplier);
			db.SaveChanges();
			updatePanel();
			MessageBox.Show("Поставщик создан");
		}
	}
}
