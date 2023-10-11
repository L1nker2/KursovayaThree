namespace Popova.Views
{
    partial class DealList
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
            dataGridView1 = new DataGridView();
            Delete_Btn = new Button();
            FormEdit_Btn = new Button();
            panel1 = new Panel();
            Cancel_Btn = new Button();
            Edit_Btn = new Button();
            checkBox1 = new CheckBox();
            Count_Tb = new TextBox();
            label4 = new Label();
            Product_Cb = new ComboBox();
            label3 = new Label();
            Client_Cb = new ComboBox();
            label2 = new Label();
            Manager_Cb = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(982, 466);
            dataGridView1.TabIndex = 0;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Delete_Btn.Location = new Point(12, 666);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(103, 43);
            Delete_Btn.TabIndex = 1;
            Delete_Btn.Text = "Удалить";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // FormEdit_Btn
            // 
            FormEdit_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FormEdit_Btn.Location = new Point(121, 666);
            FormEdit_Btn.Name = "FormEdit_Btn";
            FormEdit_Btn.Size = new Size(118, 43);
            FormEdit_Btn.TabIndex = 2;
            FormEdit_Btn.Text = "Изменить";
            FormEdit_Btn.UseVisualStyleBackColor = true;
            FormEdit_Btn.Click += FormEdit_Btn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(Cancel_Btn);
            panel1.Controls.Add(Edit_Btn);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(Count_Tb);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Product_Cb);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(Client_Cb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Manager_Cb);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(251, 484);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 225);
            panel1.TabIndex = 3;
            // 
            // Cancel_Btn
            // 
            Cancel_Btn.Location = new Point(623, 49);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(117, 36);
            Cancel_Btn.TabIndex = 12;
            Cancel_Btn.Text = "Отмена";
            Cancel_Btn.UseVisualStyleBackColor = true;
            Cancel_Btn.Click += Cancel_Btn_Click;
            // 
            // Edit_Btn
            // 
            Edit_Btn.Location = new Point(623, 9);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.Size = new Size(117, 36);
            Edit_Btn.TabIndex = 11;
            Edit_Btn.Text = "Изменить";
            Edit_Btn.UseVisualStyleBackColor = true;
            Edit_Btn.Click += Edit_Btn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(138, 169);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(211, 30);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Сделка завершена";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // Count_Tb
            // 
            Count_Tb.Location = new Point(138, 126);
            Count_Tb.Name = "Count_Tb";
            Count_Tb.Size = new Size(472, 34);
            Count_Tb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 129);
            label4.Name = "label4";
            label4.Size = new Size(133, 26);
            label4.TabIndex = 6;
            label4.Text = "Количество:";
            // 
            // Product_Cb
            // 
            Product_Cb.FormattingEnabled = true;
            Product_Cb.Location = new Point(138, 86);
            Product_Cb.Name = "Product_Cb";
            Product_Cb.Size = new Size(472, 34);
            Product_Cb.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 89);
            label3.Name = "label3";
            label3.Size = new Size(75, 26);
            label3.TabIndex = 4;
            label3.Text = "Товар:";
            // 
            // Client_Cb
            // 
            Client_Cb.FormattingEnabled = true;
            Client_Cb.Location = new Point(138, 46);
            Client_Cb.Name = "Client_Cb";
            Client_Cb.Size = new Size(472, 34);
            Client_Cb.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 49);
            label2.Name = "label2";
            label2.Size = new Size(88, 26);
            label2.TabIndex = 2;
            label2.Text = "Клиент:";
            // 
            // Manager_Cb
            // 
            Manager_Cb.FormattingEnabled = true;
            Manager_Cb.Location = new Point(138, 6);
            Manager_Cb.Name = "Manager_Cb";
            Manager_Cb.Size = new Size(472, 34);
            Manager_Cb.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(119, 26);
            label1.TabIndex = 0;
            label1.Text = "Менеджер:";
            // 
            // DealList
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 721);
            Controls.Add(panel1);
            Controls.Add(FormEdit_Btn);
            Controls.Add(Delete_Btn);
            Controls.Add(dataGridView1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "DealList";
            Text = "Список Сделок";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Delete_Btn;
        private Button FormEdit_Btn;
        private Panel panel1;
        private Label label1;
        private ComboBox Client_Cb;
        private Label label2;
        private ComboBox Manager_Cb;
        private ComboBox Product_Cb;
        private Label label3;
        private Label label4;
        private TextBox Count_Tb;
        private CheckBox checkBox1;
        private Button Edit_Btn;
        private Button Cancel_Btn;
    }
}