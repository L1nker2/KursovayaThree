using Popova.Models;
using System.Data;
namespace Popova.Views
{
    public partial class ClientList : Form
    {
        public void LoadData()
        {
            using (ClientDbContext context = new ClientDbContext())
            {
                var Clients = context.Clients.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер Клиента", typeof(int));
                dataTable.Columns.Add("ФИО Клиента", typeof(string));
                dataTable.Columns.Add("Контакт Клиента", typeof(string));
                dataTable.Columns.Add("Адрес Клиента", typeof(string));
                foreach (var client in Clients)
                {
                    dataTable.Rows.Add(client.Client_Id, client.Client_FIO, client.Client_Contact, client.Client_Address);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public static int Id;
        public ClientList()
        {
            InitializeComponent();
            LoadData();
        }
        private void ClientList_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void FormEdit_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                panel1.Visible = true;
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string fieldValue = selectedRow.Cells["Номер Клиента"].Value.ToString();
                Id = int.Parse(fieldValue);
                using (ClientDbContext context = new ClientDbContext())
                {
                    var client = context.Clients.Find(int.Parse(fieldValue));
                    Fio_Tb.Text = client.Client_FIO;
                    Address_Tb.Text = client.Client_Address;
                    Contact_Tb.Text = client.Client_Contact;
                }
            }
            else
            {
                MessageBox.Show("Необходимо выбрать объект!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Id = row.Cells["Номер Клиента"].Value.ToString();
                ClientWork.DeleteClient(int.Parse(Id));
                MessageBox.Show("Удаление прошло успешно!");
                LoadData();
            }
        }
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            ClientWork.EditClient(Id, Fio_Tb.Text, Address_Tb.Text, Contact_Tb.Text);
            MessageBox.Show("Изменение прошло успешно!");
            panel1.Visible = false;
            LoadData();
        }
    }
}
