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
	public partial class FormDeliveries : Form {
		public FormDeliveries(Supplier supplier) {
			InitializeComponent();

			if (supplier.MaterialDeliveries.Count > 0) {
				int deliveryIndex = 0;
				foreach (MaterialDelivery delivery in supplier.MaterialDeliveries) {
					DeliveryPanel deliveryPanel = new DeliveryPanel(delivery, ++deliveryIndex);
					tableLayoutPanel1.Controls.Add(deliveryPanel);
				}
			} else {
				tableLayoutPanel1.Controls.Add(new Label { Text = "Отсутствуют поставки"});
			}
		}
	}
}
