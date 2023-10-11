using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using Popova.Views;
using System;

namespace Popova
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void AddDeal_Btn_Click(object sender, EventArgs e)
        {
            AddDeal f = new AddDeal();
            f.Show();
        }
        private void AddClient_Btn_Click(object sender, EventArgs e)
        {
            AddClient f = new AddClient();
            f.Show();
        }
        private void AddProduct_Btn_Click(object sender, EventArgs e)
        {
            AddProduct f = new AddProduct();
            f.Show();
        }
        private void AddManager_Btn_Click(object sender, EventArgs e)
        {
            AddManager f = new AddManager();
            f.Show();
        }
        private void Deals_Btn_Click(object sender, EventArgs e)
        {
            DealList f = new DealList();
            f.Show();
        }
        private void Clients_Btn_Click(object sender, EventArgs e)
        {
            ClientList f = new ClientList();
            f.Show();
        }
        private void Products_Btn_Click(object sender, EventArgs e)
        {
            ProductList f = new ProductList();
            f.Show();
        }
        private void Managers_Btn_Click(object sender, EventArgs e)
        {
            ManagerList f = new ManagerList();
            f.Show();
        }
        private void Info_Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа разработана студентом группы 404-ИС\nПопова Анастасия Дмитриевна");
        }
    }
}
