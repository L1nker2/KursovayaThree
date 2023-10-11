namespace Popova.Views
{
    partial class AddManager
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
            FIO_Tb = new TextBox();
            Contact_Tb = new TextBox();
            Add_Btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(185, 26);
            label1.TabIndex = 0;
            label1.Text = "ФИО Менеджера:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(214, 26);
            label2.TabIndex = 1;
            label2.Text = "Контакт Менеджера:";
            // 
            // FIO_Tb
            // 
            FIO_Tb.Location = new Point(232, 12);
            FIO_Tb.Name = "FIO_Tb";
            FIO_Tb.Size = new Size(243, 34);
            FIO_Tb.TabIndex = 2;
            // 
            // Contact_Tb
            // 
            Contact_Tb.Location = new Point(232, 50);
            Contact_Tb.Name = "Contact_Tb";
            Contact_Tb.Size = new Size(243, 34);
            Contact_Tb.TabIndex = 3;
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(481, 29);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(118, 33);
            Add_Btn.TabIndex = 4;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // AddManager
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 106);
            Controls.Add(Add_Btn);
            Controls.Add(Contact_Tb);
            Controls.Add(FIO_Tb);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddManager";
            Text = "Добавить менеджера";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FIO_Tb;
        private TextBox Contact_Tb;
        private Button Add_Btn;
    }
}