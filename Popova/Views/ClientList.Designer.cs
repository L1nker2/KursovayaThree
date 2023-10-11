namespace Popova.Views
{
    partial class ClientList
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Address_Tb = new TextBox();
            Fio_Tb = new TextBox();
            Contact_Tb = new TextBox();
            panel1 = new Panel();
            Edit_Btn = new Button();
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
            dataGridView1.Size = new Size(982, 465);
            dataGridView1.TabIndex = 0;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Location = new Point(12, 680);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(102, 35);
            Delete_Btn.TabIndex = 1;
            Delete_Btn.Text = "Удалить";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // FormEdit_Btn
            // 
            FormEdit_Btn.Location = new Point(120, 680);
            FormEdit_Btn.Name = "FormEdit_Btn";
            FormEdit_Btn.Size = new Size(119, 35);
            FormEdit_Btn.TabIndex = 2;
            FormEdit_Btn.Text = "Изменить";
            FormEdit_Btn.UseVisualStyleBackColor = true;
            FormEdit_Btn.Click += FormEdit_Btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 6);
            label1.Name = "label1";
            label1.Size = new Size(154, 26);
            label1.TabIndex = 3;
            label1.Text = "ФИО Клиента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 46);
            label2.Name = "label2";
            label2.Size = new Size(175, 26);
            label2.TabIndex = 4;
            label2.Text = "Адресс Клиента:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 86);
            label3.Name = "label3";
            label3.Size = new Size(183, 26);
            label3.TabIndex = 5;
            label3.Text = "Контакт Клиента:";
            // 
            // Address_Tb
            // 
            Address_Tb.Location = new Point(197, 43);
            Address_Tb.Name = "Address_Tb";
            Address_Tb.Size = new Size(277, 34);
            Address_Tb.TabIndex = 6;
            // 
            // Fio_Tb
            // 
            Fio_Tb.Location = new Point(197, 3);
            Fio_Tb.Name = "Fio_Tb";
            Fio_Tb.Size = new Size(277, 34);
            Fio_Tb.TabIndex = 7;
            // 
            // Contact_Tb
            // 
            Contact_Tb.Location = new Point(197, 83);
            Contact_Tb.Name = "Contact_Tb";
            Contact_Tb.Size = new Size(277, 34);
            Contact_Tb.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(Edit_Btn);
            panel1.Controls.Add(Fio_Tb);
            panel1.Controls.Add(Contact_Tb);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Address_Tb);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 483);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 165);
            panel1.TabIndex = 9;
            // 
            // Edit_Btn
            // 
            Edit_Btn.Location = new Point(8, 115);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.Size = new Size(117, 36);
            Edit_Btn.TabIndex = 9;
            Edit_Btn.Text = "Изменить";
            Edit_Btn.UseVisualStyleBackColor = true;
            Edit_Btn.Click += Edit_Btn_Click;
            // 
            // ClientList
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
            Name = "ClientList";
            Text = "Список Клиентов";
            Load += ClientList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Delete_Btn;
        private Button FormEdit_Btn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Address_Tb;
        private TextBox Fio_Tb;
        private TextBox Contact_Tb;
        private Panel panel1;
        private Button Edit_Btn;
    }
}