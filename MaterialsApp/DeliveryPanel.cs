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
	public partial class DeliveryPanel : UserControl {
		public DeliveryPanel(MaterialDelivery delivery) {
			InitializeComponent();
			Material material = delivery.IdOfMaterialNavigation;
			labelName.Text = "[" + delivery.Id + "] " + material.NameOfMaterial;
			labelDescription.Text = material.Description;
			labelDate.Text = "Дата поставки: " + delivery.DateOfDelivery.ToString();
			labelInPackage.Text = "Кол-во в упаковке: " + delivery.AmountInPackage.ToString();
			labelAmmount.Text = "Кол-во упаковок: " + delivery.PackageCount.ToString();
			labelPrice.Text = "Цена за упаковку: " + delivery.PriceForPackage.ToString();
		}
	}
}
