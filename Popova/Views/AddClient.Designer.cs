namespace Popova.Views
{
    partial class AddClient
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
            Contact_Tb = new TextBox();
            Address_Tb = new TextBox();
            FIO_Tb = new TextBox();
            Add_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(154, 26);
            label1.TabIndex = 0;
            label1.Text = "ФИО Клиента:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 53);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 26);
            label2.TabIndex = 1;
            label2.Text = "Адресс Клиента:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 107);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(183, 26);
            label3.TabIndex = 2;
            label3.Text = "Контакт Клиента:";
            // 
            // Contact_Tb
            // 
            Contact_Tb.Location = new Point(205, 104);
            Contact_Tb.Name = "Contact_Tb";
            Contact_Tb.Size = new Size(305, 34);
            Contact_Tb.TabIndex = 3;
            // 
            // Address_Tb
            // 
            Address_Tb.Location = new Point(205, 50);
            Address_Tb.Name = "Address_Tb";
            Address_Tb.Size = new Size(305, 34);
            Address_Tb.TabIndex = 4;
            // 
            // FIO_Tb
            // 
            FIO_Tb.Location = new Point(205, 6);
            FIO_Tb.Name = "FIO_Tb";
            FIO_Tb.Size = new Size(305, 34);
            FIO_Tb.TabIndex = 5;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(532, 50);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(117, 34);
            Add_Btn.TabIndex = 6;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // AddClient
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 152);
            Controls.Add(Add_Btn);
            Controls.Add(FIO_Tb);
            Controls.Add(Address_Tb);
            Controls.Add(Contact_Tb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddClient";
            Text = "Добавить клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox Contact_Tb;
        private TextBox Address_Tb;
        private TextBox FIO_Tb;
        private Button Add_Btn;
    }
}