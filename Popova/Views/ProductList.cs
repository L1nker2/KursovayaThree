using Popova.Models;
using System.Data;
namespace Popova.Views
{
    public partial class ProductList : Form
    {
        public void LoadData()
        {
            using (ProductDbContext context = new ProductDbContext())
            {
                var products = context.Products.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер Продукта", typeof(int));
                dataTable.Columns.Add("Название Продукта", typeof(string));
                dataTable.Columns.Add("Цена Продукта", typeof(string));
                foreach (var product in products)
                {
                    dataTable.Rows.Add(product.Product_Id, product.Product_Name, product.Product_Price);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public ProductList()
        {
            InitializeComponent();
            panel1.Visible = false;
            LoadData();
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int ProductId;
                int.TryParse(row.Cells["Номер Продукта"].Value.ToString(), out ProductId);
                ProductWork.DeleteProduct(ProductId);
            }
            else
            {
                MessageBox.Show("Ошибка", "Необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormEdit_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Visible = true;
            }
            else
            {
                MessageBox.Show("Ошибка", "Необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            int id;
            int.TryParse(row.Cells["Номер Продукта"].Value.ToString(), out id);
            string name = Name_Tb.Text, price = Price_Tb.Text;
            if (name == "" || price == "")
            {
                MessageBox.Show("Ошибка", "Необходимо заполнить все поля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ProductWork.EditProduct(id, name, price);
            MessageBox.Show("Изменение прошло успешно!");
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
