using Popova.Models;
using System.Data;
namespace Popova.Views
{
    public partial class DealList : Form
    {
        public void LoadData()
        {
            using (DealDbContext context = new DealDbContext())
            {
                var Deals = context.Deals.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер Сделки", typeof(int));
                dataTable.Columns.Add("Менеджер", typeof(string));
                dataTable.Columns.Add("Клиент", typeof(string));
                dataTable.Columns.Add("Продукт", typeof(string));
                dataTable.Columns.Add("Количество", typeof(int));
                dataTable.Columns.Add("Сделка Завершена", typeof(bool));
                foreach (var deal in Deals)
                {
                    using (ManagerDbContext context1 = new ManagerDbContext())
                    {
                        using (ClientDbContext context2 = new ClientDbContext())
                        {
                            using (ProductDbContext context3 = new ProductDbContext())
                            {
                                var manager = context1.Managers.FirstOrDefault(el => el.Manager_Id == deal.Manager_Id);
                                var client = context2.Clients.FirstOrDefault(el => el.Client_Id == deal.Client_Id);
                                var product = context3.Products.FirstOrDefault(el => el.Product_Id == deal.Product_Id);
                                if(deal.Manager_Id == null || deal.Client_Id == null || deal.Product_Id == null)
                                {
                                    MessageBox.Show("ОШИБКА", "Отсутствует какое то значение, данная сделка будет удалена!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    DealWork.DeleteDeal(deal.Deal_Id);
                                }
                                dataTable.Rows.Add(deal.Deal_Id, manager.Manager_FIO, client.Client_FIO, product.Product_Name, deal.Product_Count, deal.Deal_Is_Finished);
                            }
                        }
                    }
                }
                using(ManagerDbContext context1 = new ManagerDbContext())
                {
                    using(ClientDbContext context2 = new ClientDbContext())
                    {
                        using(ProductDbContext context3 = new ProductDbContext())
                        {
                            var managers = context1.Managers.ToList();
                            var clients = context2.Clients.ToList();
                            var products = context3.Products.ToList();
                            foreach (var el in managers)
                            {
                                Manager_Cb.Items.Add(el.Manager_FIO);
                            }
                            foreach (var el in clients)
                            {
                                Client_Cb.Items.Add(el.Client_FIO);
                            }
                            foreach (var el in products)
                            {
                                Product_Cb.Items.Add(el.Product_Name);
                            }
                        }
                    }
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public DealList()
        {
            InitializeComponent();
            LoadData();
            panel1.Visible = false;
        }
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            string ManagerFio = Manager_Cb.SelectedText;
            string ClientFio = Client_Cb.SelectedText;
            string ProductName = Product_Cb.SelectedText;
            int ProductCount = 0, ManagerId = 0, ClientId = 0, ProductId = 0, DealId = 0;
            int.TryParse(Count_Tb.Text, out ProductCount);
            bool DealIsFinished;
            if (checkBox1.Checked)
            {
                DealIsFinished = true;
            }
            else
            {
                DealIsFinished = false;
            }
            using (ManagerDbContext context = new ManagerDbContext())
            {
                var manager = context.Managers.FirstOrDefault(el => el.Manager_FIO == ManagerFio);
                if (manager != null)
                {
                    ManagerId = manager.Manager_Id;
                }
            }
            using (ClientDbContext context = new ClientDbContext())
            {
                var client = context.Clients.FirstOrDefault(el => el.Client_FIO == ClientFio);
                if (client != null)
                {
                    ClientId = client.Client_Id;
                }
            }
            using (ProductDbContext context = new ProductDbContext())
            {
                var product = context.Products.FirstOrDefault(el => el.Product_Name == ProductName);
                if (product != null)
                {
                    ProductId = product.Product_Id;
                }
            }
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int.TryParse(row.Cells["Номер Сделки"].Value.ToString(), out DealId);
                DealWork.EditDeal(DealId, ManagerId, ClientId, ProductId, ProductCount, DealIsFinished);
                MessageBox.Show("Изменение прошло успешно!");
                LoadData();
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("Ошибка", "Для редактирования необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер Сделки"].Value.ToString();
                DealWork.DeleteDeal(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Ошибка", "Для удаления необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormEdit_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Visible = true;
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string count = row.Cells["Количество"].Value.ToString();
                string isfinish = row.Cells["Сделка Завершена"].Value.ToString();
                Count_Tb.Text = count;
                if (isfinish == "True")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}
