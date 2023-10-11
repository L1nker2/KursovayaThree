using Popova.Models;
using System.Data;
namespace Popova.Views
{
    public partial class ManagerList : Form
    {
        public void LoadData()
        {
            using (ManagerDbContext context = new ManagerDbContext())
            {
                var managers = context.Managers.ToList();
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("Номер Менеджера", typeof(int));
                dataTable.Columns.Add("ФИО Менеджера", typeof(string));
                dataTable.Columns.Add("Телефон Менеджера", typeof(string));
                foreach (var manager in managers)
                {
                    dataTable.Rows.Add(manager.Manager_Id, manager.Manager_FIO, manager.Manager_Phone);
                }
                dataGridView1.DataSource = dataTable;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dataGridView1.RowHeadersVisible = false;
            }
        }
        public ManagerList()
        {
            InitializeComponent();
            LoadData();
            panel1.Visible = false;
        }
        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ManagerId;
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int.TryParse(row.Cells["Номер Менеджера"].Value.ToString(), out ManagerId);
                ManagerWork.DeleteManager(ManagerId);
            }
            else
            {
                MessageBox.Show("Ошибка", "Необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormEdit_Btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                string Fio = row.Cells["ФИО Менеджера"].Value.ToString();
                string Phone = row.Cells["Телефон Менеджера"].Value.ToString();
                Fio_Tb.Text = Fio;
                Phone_Tb.Text = Phone;
            }
            else
            {
                MessageBox.Show("Ошибка", "Необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int ManagerId;
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                int.TryParse(row.Cells["Номер Менеджера"].Value.ToString(), out ManagerId);
                string ManagerFio = Fio_Tb.Text;
                string ManagerPhone = Phone_Tb.Text;
                if (ManagerFio == "" || ManagerPhone == "")
                {
                    MessageBox.Show("Ошибка", "Необходимо заполнить поля!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ManagerWork.EditManager(ManagerId, ManagerFio, ManagerPhone);
                MessageBox.Show("Изменение прошло успешно!");
            }
            else
            {
                MessageBox.Show("Ошибка", "Необходимо выбрать запись!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
