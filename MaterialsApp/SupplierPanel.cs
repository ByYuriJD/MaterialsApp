using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialsApp.Models;

namespace MaterialsApp {
	public partial class SupplierPanel : UserControl {
		private Supplier supplier;
		private MainForm main;
		private ColorConverter colorConverter;
		private int supplierIndex;

		public SupplierPanel(MainForm main, Supplier supplier,int supplierIndex) {
			InitializeComponent();

			Dock = DockStyle.Fill;

			this.main = main;
			this.supplier = supplier;
			this.colorConverter = new ColorConverter();
			this.supplierIndex = supplierIndex;

			updateView();
		}
		private void updateView() {
			labelSupplier.Text = "[#" + supplierIndex + "] " + supplier.NameOfSupplier;
			labelType.Text = supplier.IdOfTypeNavigation.TypeOfPartner;
			labelInn.Text = supplier.Inn;


			if (supplier.MaterialDeliveries.Any()) {
				float deliveryQuality = 0;
				foreach (MaterialDelivery delivery in supplier.MaterialDeliveries) {
					deliveryQuality += delivery.QualityOfDelivery;
				}
				deliveryQuality /= supplier.MaterialDeliveries.Count;
				labelMeanQuality.Text = "Среднее качество поставок: " + deliveryQuality.ToString();
			} else { 
				labelMeanQuality.Text = "Отсутствуют поставки";
				buttonHistory.Enabled = false;
			}

			buttonActive.Text = supplier.IsActive ? "Действующий" : "Не действующий";
			buttonActive.BackColor = supplier.IsActive ? (Color)colorConverter.ConvertFromString("#67BA80") : (Color)colorConverter.ConvertFromString("#FFFFFF");
		}

		private void Active_Click(object sender, EventArgs e) {
			supplier.IsActive = !supplier.IsActive;

			main.saveSupplier(supplier);

			updateView();
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данного поставщика?",
				"Поставщики",
				MessageBoxButtons.OKCancel);
			if (result == DialogResult.OK) {
				main.deleteSupplier(supplier);
				MessageBox.Show("Поставщик удален");
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e) {
			FormEditSupplier editSupplier = new FormEditSupplier(main.db.OrganizationTypes.ToArray(), supplier);
			DialogResult result = editSupplier.ShowDialog();

			if (result == DialogResult.Cancel)
				return;
			supplier.NameOfSupplier = editSupplier.textBoxName.Text;
			supplier.Inn = editSupplier.textBoxInn.Text;
			supplier.IdOfType = main.db.OrganizationTypes.FirstOrDefault(
				e => e.TypeOfPartner == editSupplier.comboBoxType.Text).Id;
			main.saveSupplier(supplier);
			updateView();

			MessageBox.Show("Поставщик обновлен", "Поставщики", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void buttonHistory_Click(object sender, EventArgs e) {
			FormDeliveries formDeliveries = new FormDeliveries(supplier);
			formDeliveries.ShowDialog();
		}
	}
}
