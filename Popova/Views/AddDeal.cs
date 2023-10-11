using Popova.Models;
namespace Popova.Views
{
    public partial class AddDeal : Form
    {
        string[] CollectId(string _client, string _manager, string _product)
        {
            string[] arr = new string[3];
            using(ClientDbContext context = new ClientDbContext())
            {
                var client = context.Clients.FirstOrDefault(e => e.Client_FIO == _client);
                arr[0] = client.Client_Id.ToString();
            }
            using(ManagerDbContext context = new ManagerDbContext())
            {
                var manager = context.Managers.FirstOrDefault(e => e.Manager_FIO == _manager);
                arr[1] = manager.Manager_Id.ToString();
            }
            using(ProductDbContext context = new ProductDbContext())
            {
                var product = context.Products.FirstOrDefault(e => e.Product_Name == _product);
                arr[2] = product.Product_Id.ToString();
            }
            return arr;
        }
        public void LoadData()
        {
            using (ClientDbContext context = new ClientDbContext())
            {
                var Clients = context.Clients.ToList();
                foreach (var client in Clients)
                {
                    Client_Cb.Items.Add(client.Client_FIO);
                }
            }
            using (ManagerDbContext context = new ManagerDbContext())
            {
                var Managers = context.Managers.ToList();
                foreach (var manager in Managers)
                {
                    Manager_Cb.Items.Add(manager.Manager_FIO);
                }
            }
            using (ProductDbContext context = new ProductDbContext())
            {
                var Products = context.Products.ToList();
                foreach (var product in Products)
                {
                    Product_Cb.Items.Add(product.Product_Name);
                }
            }
        }
        public AddDeal()
        {
            InitializeComponent();
            LoadData();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string client = Client_Cb.Text;
            string manager = Manager_Cb.Text;
            string product = Product_Cb.Text;
            string[] data = CollectId(client, manager, product);
            int clientId = int.Parse(data[0]);
            int managerId = int.Parse(data[1]);
            int productId = int.Parse(data[2]);
            int count = int.Parse(Count_Tb.Text);
            bool temp = false;
            DealWork.AddDeal(managerId, clientId, productId, count, temp);
            MessageBox.Show("Добавление прошло успешно!");
        }
    }
}
