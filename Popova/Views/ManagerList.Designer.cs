namespace Popova.Views
{
    partial class ManagerList
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
            Fio_Tb = new TextBox();
            Phone_Tb = new TextBox();
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
            dataGridView1.Size = new Size(982, 463);
            dataGridView1.TabIndex = 0;
            // 
            // Delete_Btn
            // 
            Delete_Btn.Location = new Point(12, 673);
            Delete_Btn.Name = "Delete_Btn";
            Delete_Btn.Size = new Size(104, 36);
            Delete_Btn.TabIndex = 1;
            Delete_Btn.Text = "Удалить";
            Delete_Btn.UseVisualStyleBackColor = true;
            Delete_Btn.Click += Delete_Btn_Click;
            // 
            // FormEdit_Btn
            // 
            FormEdit_Btn.Location = new Point(122, 673);
            FormEdit_Btn.Name = "FormEdit_Btn";
            FormEdit_Btn.Size = new Size(116, 36);
            FormEdit_Btn.TabIndex = 2;
            FormEdit_Btn.Text = "Изменить";
            FormEdit_Btn.UseVisualStyleBackColor = true;
            FormEdit_Btn.Click += FormEdit_Btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(Cancel_Btn);
            panel1.Controls.Add(Edit_Btn);
            panel1.Controls.Add(Fio_Tb);
            panel1.Controls.Add(Phone_Tb);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 481);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 186);
            panel1.TabIndex = 3;
            // 
            // Cancel_Btn
            // 
            Cancel_Btn.Location = new Point(227, 97);
            Cancel_Btn.Name = "Cancel_Btn";
            Cancel_Btn.Size = new Size(124, 34);
            Cancel_Btn.TabIndex = 5;
            Cancel_Btn.Text = "Отменить";
            Cancel_Btn.UseVisualStyleBackColor = true;
            Cancel_Btn.Click += Cancel_Btn_Click;
            // 
            // Edit_Btn
            // 
            Edit_Btn.Location = new Point(425, 97);
            Edit_Btn.Name = "Edit_Btn";
            Edit_Btn.Size = new Size(124, 34);
            Edit_Btn.TabIndex = 4;
            Edit_Btn.Text = "Изменить";
            Edit_Btn.UseVisualStyleBackColor = true;
            Edit_Btn.Click += Edit_Btn_Click;
            // 
            // Fio_Tb
            // 
            Fio_Tb.Location = new Point(227, 9);
            Fio_Tb.Name = "Fio_Tb";
            Fio_Tb.Size = new Size(322, 34);
            Fio_Tb.TabIndex = 3;
            // 
            // Phone_Tb
            // 
            Phone_Tb.Location = new Point(227, 50);
            Phone_Tb.Name = "Phone_Tb";
            Phone_Tb.Size = new Size(322, 34);
            Phone_Tb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 53);
            label2.Name = "label2";
            label2.Size = new Size(218, 26);
            label2.TabIndex = 1;
            label2.Text = "Телефон Менеджера:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 26);
            label1.TabIndex = 0;
            label1.Text = "ФИО Менеджера:";
            // 
            // ManagerList
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
            Name = "ManagerList";
            Text = "Список Менеджеров";
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
        private TextBox Fio_Tb;
        private TextBox Phone_Tb;
        private Label label2;
        private Label label1;
        private Button Cancel_Btn;
    }
}