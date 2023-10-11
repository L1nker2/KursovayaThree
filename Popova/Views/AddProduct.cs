using Popova.Models;
namespace Popova.Views
{
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            ProductWork.AddProduct(Name_Tb.Text, Price_Tb.Text);
            MessageBox.Show("Добавление прошло успешно!");
        }
    }
}
