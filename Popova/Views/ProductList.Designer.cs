namespace Popova.Views
{
    partial class ProductList
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
            Edit_Btn = new Button();
            textBox1 = new TextBox();
            Price_Tb = new TextBox();
            Cancel_Btn = new Button();
            Name_Tb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(982, 449);
            dataGridView1.TabIndex = 0;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Location = new Point(12, 672);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(123, 37);
            Delete_Btn.TabIndex = 1;
            Delete_Btn.Text = "Удалить";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // FormEdit_Btn
            // 
            FormEdit_Btn.Location = new Point(150, 672);
            FormEdit_Btn.Name = "FormEdit_Btn";
            FormEdit_Btn.Size = new Size(123, 37);
            FormEdit_Btn.TabIndex = 2;
            FormEdit_Btn.Text = "Изменить";
            FormEdit_Btn.UseVisualStyleBackColor = true;
            FormEdit_Btn.Click += FormEdit_Btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Edit_Btn);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(Price_Tb);
            panel1.Controls.Add(Cancel_Btn);
            panel1.Controls.Add(Name_Tb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 467);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 199);
            panel1.TabIndex = 3;
            // 
            // Edit_Btn
            // 
            Edit_Btn.Location = new Point(224, 90);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.Size = new Size(123, 37);
            Edit_Btn.TabIndex = 4;
            Edit_Btn.Text = "Изменить";
            Edit_Btn.UseVisualStyleBackColor = true;
            Edit_Btn.Click += Edit_Btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(556, -532);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(243, 34);
            textBox1.TabIndex = 5;
            // 
            // Price_Tb
            // 
            Price_Tb.Location = new Point(224, 50);
            Price_Tb.Name = "Price_Tb";
            Price_Tb.Size = new Size(243, 34);
            Price_Tb.TabIndex = 3;
            // 
            // Cancel_Btn
            // 
            Cancel_Btn.Location = new Point(368, 90);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(99, 37);
            Cancel_Btn.TabIndex = 4;
            Cancel_Btn.Text = "Отмена";
            Cancel_Btn.UseVisualStyleBackColor = true;
            Cancel_Btn.Click += Cancel_Btn_Click;
            // 
            // Name_Tb
            // 
            Name_Tb.Location = new Point(224, 8);
            Name_Tb.Name = "Name_Tb";
            Name_Tb.Size = new Size(243, 34);
            Name_Tb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(160, 26);
            label2.TabIndex = 1;
            label2.Text = "Цена продукта:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 11);
            label1.Name = "label1";
            label1.Size = new Size(202, 26);
            label1.TabIndex = 0;
            label1.Text = "Название продукта:";
            // 
            // ProductList
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
            Name = "ProductList";
            Text = "Список Продуктов";
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
        private Button Edit_Btn;
        private TextBox textBox1;
        private TextBox Price_Tb;
        private Button Cancel_Btn;
        private TextBox Name_Tb;
        private Label label2;
        private Label label1;
    }
}