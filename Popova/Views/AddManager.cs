using Popova.Models;
namespace Popova.Views
{
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            ManagerWork.AddManager(FIO_Tb.Text, Contact_Tb.Text);
            MessageBox.Show("Добавление прошло успешно!");
        }
    }
}
