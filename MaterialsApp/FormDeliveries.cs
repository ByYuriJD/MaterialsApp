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
		MaterialDelivery[] deliveries;
		public FormDeliveries(MaterialDelivery[] deliveries) {
			this.deliveries = deliveries;

			InitializeComponent();
		}

		private void FormDeliveries_Load(object sender, EventArgs e) {

			dataGridView1.DataSource = deliveries;
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.Columns["IdOfMaterialNavigation"].Visible = false;
			dataGridView1.Columns["IdOfSupplierNavigation"].Visible = false;
			dataGridView1.Columns["IdOfSupplier"].Visible = false;
			dataGridView1.Columns["IdOfMaterial"].Visible = false;


			{
				dataGridView1.Columns["AmountInPackage"].HeaderText = "Количество в упаковке";
				dataGridView1.Columns["AmountInPackage"].DisplayIndex = 1;
				dataGridView1.Columns["AmountInPackage"].DefaultCellStyle.Alignment =
					DataGridViewContentAlignment.MiddleCenter;
				dataGridView1.Columns["PackageCount"].HeaderText = "Количство упаковок, куб.м.";
				dataGridView1.Columns["PackageCount"].DisplayIndex = 2;
				dataGridView1.Columns["PackageCount"].DefaultCellStyle.Alignment =
					DataGridViewContentAlignment.MiddleCenter;
				dataGridView1.Columns["DateOfDelivery"].HeaderText = "Дата доставки";
				dataGridView1.Columns["DateOfDelivery"].DisplayIndex = 3;
				dataGridView1.Columns["DateOfDelivery"].DefaultCellStyle.Alignment =
					DataGridViewContentAlignment.MiddleCenter;
				dataGridView1.Columns["PriceForPackage"].HeaderText = "Цена за упаковку";
				dataGridView1.Columns["PriceForPackage"].DisplayIndex = 4;
				dataGridView1.Columns["PriceForPackage"].DefaultCellStyle.Alignment =
					DataGridViewContentAlignment.MiddleCenter;
				dataGridView1.Columns["QualityOfDelivery"].HeaderText = "Качество поставки";
				dataGridView1.Columns["QualityOfDelivery"].DisplayIndex = 5;
				dataGridView1.Columns["QualityOfDelivery"].DefaultCellStyle.Alignment =
					DataGridViewContentAlignment.MiddleCenter;
			}

			DataGridViewTextBoxColumn columnNames = new DataGridViewTextBoxColumn();
			columnNames.Name = "MaterialName";
			columnNames.HeaderText = "Наименование материала";
			columnNames.DisplayIndex = 0;
			columnNames.ReadOnly = false;
			dataGridView1.Columns.Insert(0, columnNames);
			dataGridView1.Columns["MaterialName"].ValueType = typeof(String);



			for (int i = 0; i < dataGridView1.RowCount; i++) {
				DataGridViewRow row = dataGridView1.Rows[i];
				row.Cells["MaterialName"] = new DataGridViewTextBoxCell();
				row.Cells["MaterialName"].Value = deliveries[i].IdOfMaterialNavigation.NameOfMaterial;
			}
		}
	}
}
