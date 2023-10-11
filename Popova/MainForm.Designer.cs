namespace Popova
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Info_Btn = new Button();
            Managers_Btn = new Button();
            Products_Btn = new Button();
            Clients_Btn = new Button();
            Deals_Btn = new Button();
            AddManager_Btn = new Button();
            AddProduct_Btn = new Button();
            AddClient_Btn = new Button();
            AddDeal_Btn = new Button();
            SuspendLayout();
            // 
            // Info_Btn
            // 
            Info_Btn.AutoSize = true;
            Info_Btn.Location = new Point(14, 449);
            Info_Btn.Margin = new Padding(5, 4, 5, 4);
            Info_Btn.Name = "Info_Btn";
            Info_Btn.Size = new Size(247, 47);
            Info_Btn.TabIndex = 17;
            Info_Btn.Text = "О программе";
            Info_Btn.UseVisualStyleBackColor = true;
            Info_Btn.Click += Info_Btn_Click;
            // 
            // Managers_Btn
            // 
            Managers_Btn.AutoSize = true;
            Managers_Btn.Location = new Point(14, 395);
            Managers_Btn.Margin = new Padding(5, 4, 5, 4);
            Managers_Btn.Name = "Managers_Btn";
            Managers_Btn.Size = new Size(358, 47);
            Managers_Btn.TabIndex = 16;
            Managers_Btn.Text = "Список менеджеров";
            Managers_Btn.UseVisualStyleBackColor = true;
            Managers_Btn.Click += Managers_Btn_Click;
            // 
            // Products_Btn
            // 
            Products_Btn.AutoSize = true;
            Products_Btn.Location = new Point(14, 340);
            Products_Btn.Margin = new Padding(5, 4, 5, 4);
            Products_Btn.Name = "Products_Btn";
            Products_Btn.Size = new Size(289, 47);
            Products_Btn.TabIndex = 15;
            Products_Btn.Text = "Список товаров";
            Products_Btn.UseVisualStyleBackColor = true;
            Products_Btn.Click += Products_Btn_Click;
            // 
            // Clients_Btn
            // 
            Clients_Btn.AutoSize = true;
            Clients_Btn.Location = new Point(14, 286);
            Clients_Btn.Margin = new Padding(5, 4, 5, 4);
            Clients_Btn.Name = "Clients_Btn";
            Clients_Btn.Size = new Size(307, 47);
            Clients_Btn.TabIndex = 14;
            Clients_Btn.Text = "Список клиентов";
            Clients_Btn.UseVisualStyleBackColor = true;
            Clients_Btn.Click += Clients_Btn_Click;
            // 
            // Deals_Btn
            // 
            Deals_Btn.AutoSize = true;
            Deals_Btn.Location = new Point(14, 231);
            Deals_Btn.Margin = new Padding(5, 4, 5, 4);
            Deals_Btn.Name = "Deals_Btn";
            Deals_Btn.Size = new Size(270, 47);
            Deals_Btn.TabIndex = 13;
            Deals_Btn.Text = "Список сделок";
            Deals_Btn.UseVisualStyleBackColor = true;
            Deals_Btn.Click += Deals_Btn_Click;
            // 
            // AddManager_Btn
            // 
            AddManager_Btn.AutoSize = true;
            AddManager_Btn.Location = new Point(14, 176);
            AddManager_Btn.Margin = new Padding(5, 4, 5, 4);
            AddManager_Btn.Name = "AddManager_Btn";
            AddManager_Btn.Size = new Size(370, 47);
            AddManager_Btn.TabIndex = 12;
            AddManager_Btn.Text = "Добавить менеджера";
            AddManager_Btn.UseVisualStyleBackColor = true;
            AddManager_Btn.Click += AddManager_Btn_Click;
            // 
            // AddProduct_Btn
            // 
            AddProduct_Btn.AutoSize = true;
            AddProduct_Btn.Location = new Point(14, 122);
            AddProduct_Btn.Margin = new Padding(5, 4, 5, 4);
            AddProduct_Btn.Name = "AddProduct_Btn";
            AddProduct_Btn.Size = new Size(286, 47);
            AddProduct_Btn.TabIndex = 11;
            AddProduct_Btn.Text = "Добавить товар";
            AddProduct_Btn.UseVisualStyleBackColor = true;
            AddProduct_Btn.Click += AddProduct_Btn_Click;
            // 
            // AddClient_Btn
            // 
            AddClient_Btn.AutoSize = true;
            AddClient_Btn.Location = new Point(14, 67);
            AddClient_Btn.Margin = new Padding(5, 4, 5, 4);
            AddClient_Btn.Name = "AddClient_Btn";
            AddClient_Btn.Size = new Size(327, 47);
            AddClient_Btn.TabIndex = 10;
            AddClient_Btn.Text = "Добавить клиента";
            AddClient_Btn.UseVisualStyleBackColor = true;
            AddClient_Btn.Click += AddClient_Btn_Click;
            // 
            // AddDeal_Btn
            // 
            AddDeal_Btn.AutoSize = true;
            AddDeal_Btn.Location = new Point(14, 13);
            AddDeal_Btn.Margin = new Padding(5, 4, 5, 4);
            AddDeal_Btn.Name = "AddDeal_Btn";
            AddDeal_Btn.Size = new Size(302, 47);
            AddDeal_Btn.TabIndex = 9;
            AddDeal_Btn.Text = "Добавить сделку";
            AddDeal_Btn.UseVisualStyleBackColor = true;
            AddDeal_Btn.Click += AddDeal_Btn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(Info_Btn);
            Controls.Add(Managers_Btn);
            Controls.Add(Products_Btn);
            Controls.Add(Clients_Btn);
            Controls.Add(Deals_Btn);
            Controls.Add(AddManager_Btn);
            Controls.Add(AddProduct_Btn);
            Controls.Add(AddClient_Btn);
            Controls.Add(AddDeal_Btn);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "MainForm";
            Text = "ЖКХ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Info_Btn;
        private Button Managers_Btn;
        private Button Products_Btn;
        private Button Clients_Btn;
        private Button Deals_Btn;
        private Button AddManager_Btn;
        private Button AddProduct_Btn;
        private Button AddClient_Btn;
        private Button AddDeal_Btn;
    }
}