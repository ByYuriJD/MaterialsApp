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

		public SupplierPanel(MainForm main, Supplier supplier) {
			InitializeComponent();

			Dock = DockStyle.Fill;

			this.main = main;
			this.supplier = supplier;

			updateView();
		}
		private void updateView() {
			labelSupplier.Text = supplier.NameOfSupplier;
			labelTypeInn.Text = supplier.IdOfTypeNavigation.TypeOfPartner + " | " + supplier.Inn;


			if (supplier.MaterialDeliveries.Any()) {
				float deliveryQuality = 0;
				foreach (MaterialDelivery delivery in supplier.MaterialDeliveries) {
					deliveryQuality += delivery.QualityOfDelivery;
				}
				deliveryQuality /= supplier.MaterialDeliveries.Count;
				labelMeanQuality.Text = deliveryQuality.ToString();
			} else
				labelMeanQuality.Text = "Отсутствуют доставки";


			buttonActive.Text = supplier.IsActive ? "Действующий" : "Не действующий";
			buttonActive.BackColor = supplier.IsActive ? SystemColors.ActiveCaption : SystemColors.InactiveCaption;
		}

		private void Active_Click(object sender, EventArgs e) {
			supplier.IsActive = !supplier.IsActive;

			main.saveSupplier(supplier);

			buttonActive.Text = supplier.IsActive ? "Действующий" : "Не действующий";
			buttonActive.BackColor = supplier.IsActive ? SystemColors.ActiveCaption : SystemColors.InactiveCaption;
		}

		private void buttonDelete_Click(object sender, EventArgs e) {
			DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить данного поставщика?",
				"",
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

			MessageBox.Show("Поставщик обнавлен");
		}

		private void buttonHistory_Click(object sender, EventArgs e) {
			FormDeliveries formDeliveries = new FormDeliveries(supplier);
			formDeliveries.ShowDialog();
		}
	}
}
