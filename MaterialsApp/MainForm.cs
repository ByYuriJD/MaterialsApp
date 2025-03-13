using System.ComponentModel;
using MaterialsApp.Models;
using Microsoft.EntityFrameworkCore;

namespace MaterialsApp {
    public partial class MainForm : Form {
		private PartnersContext? db;
		public MainForm() {

            InitializeComponent();
        }
        public void MainForm_Load(object sender, EventArgs e) {
            db = new PartnersContext();
            db.Suppliers.Load();

            dataGridView.DataSource = db.Suppliers.Local.ToBindingList();

            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["IdOfTypeNavigation"].Visible = false;
            dataGridView.Columns["MaterialDeliveries"].Visible = false;
			dataGridView.Columns["IdOfType"].Visible = false;

			dataGridView.Columns["IdOfType"].HeaderText = "Тип поставщика";
			dataGridView.Columns["IdOfType"].Width = 120;
			dataGridView.Columns["IdOfType"].DisplayIndex = 0;

			dataGridView.Columns["NameOfSupplier"].HeaderText = "Наименование";
			dataGridView.Columns["NameOfSupplier"].Width = 120;
			dataGridView.Columns["NameOfSupplier"].DisplayIndex = 1;

			dataGridView.Columns["Inn"].HeaderText = "ИНН";
			dataGridView.Columns["Inn"].Width = 80;
			dataGridView.Columns["Inn"].DisplayIndex = 2;

			dataGridView.Columns["IsActive"].HeaderText = "Действующий";
			dataGridView.Columns["IsActive"].Width = 90;
			dataGridView.Columns["IsActive"].DisplayIndex = 3;


		}
		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);
            this.db?.Dispose();
            this.db = null;
		}

	}
}
