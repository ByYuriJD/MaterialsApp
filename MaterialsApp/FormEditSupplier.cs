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
	public partial class FormEditSupplier : Form {

		public FormEditSupplier(OrganizationType[] types, Supplier? supplier = null) {
			InitializeComponent();

			foreach (OrganizationType type in types) {
				comboBoxType.Items.Add(type.TypeOfPartner);
			}

			if (supplier != null) {
				textBoxInn.Text = supplier.Inn.ToString();
				textBoxName.Text = supplier.NameOfSupplier;
				comboBoxType.Text = supplier.IdOfTypeNavigation.TypeOfPartner;
				checkBoxActive.Checked = supplier.IsActive;
			}else {
				comboBoxType.SelectedIndex=0;
				panelActive.Visible = false;
			}

			checkIsValid(null, null);
		}


		private void buttonConfirm_Click(object sender, EventArgs e) {

		}
		protected void checkIsValid(object sender, EventArgs e) {
			if (textBoxInn.Text.Length == 0 || textBoxName.Text.Length == 0) {
				errorProvider.SetError(buttonConfirm,"Не все поля заполнены");
				buttonConfirm.Enabled = false;
				return;
			}
			errorProvider.Clear();
			buttonConfirm.Enabled = true;
		}
	}
}
