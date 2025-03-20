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

			foreach(MaterialDelivery delivery in supplier.MaterialDeliveries) {
				DeliveryPanel deliveryPanel = new DeliveryPanel(delivery);
				tableLayoutPanel1.Controls.Add(deliveryPanel);
			}
		}
	}
}
