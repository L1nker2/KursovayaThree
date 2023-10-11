namespace Popova.Views
{
    partial class AddDeal
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Manager_Cb = new ComboBox();
            Client_Cb = new ComboBox();
            Product_Cb = new ComboBox();
            Add_Btn = new Button();
            Count_Tb = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 0;
            label1.Text = "Менеджер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 26);
            label2.TabIndex = 1;
            label2.Text = "Клиент:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 100);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 26);
            label3.TabIndex = 2;
            label3.Text = "Товар:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 140);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(217, 26);
            label4.TabIndex = 3;
            label4.Text = "Количество товаров:";
            // 
            // Manager_Cb
            // 
            Manager_Cb.FormattingEnabled = true;
            Manager_Cb.Location = new Point(275, 12);
            Manager_Cb.Name = "Manager_Cb";
            Manager_Cb.Size = new Size(344, 34);
            Manager_Cb.TabIndex = 4;
            // 
            // Client_Cb
            // 
            Client_Cb.FormattingEnabled = true;
            Client_Cb.Location = new Point(275, 52);
            Client_Cb.Name = "Client_Cb";
            Client_Cb.Size = new Size(344, 34);
            Client_Cb.TabIndex = 5;
            // 
            // Product_Cb
            // 
            Product_Cb.FormattingEnabled = true;
            Product_Cb.Location = new Point(275, 92);
            Product_Cb.Name = "Product_Cb";
            Product_Cb.Size = new Size(344, 34);
            Product_Cb.TabIndex = 6;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(625, 73);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(151, 34);
            Add_Btn.TabIndex = 8;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // Count_Tb
            // 
            Count_Tb.Location = new Point(275, 132);
            Count_Tb.Name = "Count_Tb";
            Count_Tb.Size = new Size(344, 34);
            Count_Tb.TabIndex = 9;
            // 
            // AddDeal
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 182);
            Controls.Add(Count_Tb);
            Controls.Add(Add_Btn);
            Controls.Add(Product_Cb);
            Controls.Add(Client_Cb);
            Controls.Add(Manager_Cb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddDeal";
            Text = "Добавить сделку";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Manager_Cb;
        private ComboBox Client_Cb;
        private ComboBox Product_Cb;
        private Button Add_Btn;
        private TextBox Count_Tb;
    }
}