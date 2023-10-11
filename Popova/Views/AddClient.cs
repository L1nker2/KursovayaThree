using Popova.Models;
namespace Popova.Views
{
    public partial class AddClient : Form
    {
        public AddClient()
        {
            InitializeComponent();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string Client_Fio = FIO_Tb.Text;
            string Client_Address = Address_Tb.Text;
            string Client_Contact = Contact_Tb.Text;
            ClientWork.AddClient(Client_Fio, Client_Address, Client_Contact);
            MessageBox.Show("Добавление прошло успешно!");
        }
    }
}
