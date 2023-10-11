namespace Popova.Views
{
    partial class AddProduct
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
            Add_Btn = new Button();
            Price_Tb = new TextBox();
            Name_Tb = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Add_Btn
            // 
            Add_Btn.Location = new Point(481, 23);
            Add_Btn.Name = "Add_Btn";
            Add_Btn.Size = new Size(118, 33);
            Add_Btn.TabIndex = 9;
            Add_Btn.Text = "Добавить";
            Add_Btn.UseVisualStyleBackColor = true;
            Add_Btn.Click += Add_Btn_Click;
            // 
            // Price_Tb
            // 
            Price_Tb.Location = new Point(232, 44);
            Price_Tb.Name = "Price_Tb";
            Price_Tb.Size = new Size(243, 34);
            Price_Tb.TabIndex = 8;
            // 
            // Name_Tb
            // 
            Name_Tb.Location = new Point(232, 6);
            Name_Tb.Name = "Name_Tb";
            Name_Tb.Size = new Size(243, 34);
            Name_Tb.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 47);
            label2.Name = "label2";
            label2.Size = new Size(136, 26);
            label2.TabIndex = 6;
            label2.Text = "Цена товара:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(178, 26);
            label1.TabIndex = 5;
            label1.Text = "Название товара:";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(13F, 26F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 87);
            Controls.Add(Add_Btn);
            Controls.Add(Price_Tb);
            Controls.Add(Name_Tb);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 4, 5, 4);
            Name = "AddProduct";
            Text = "Добавить продукт";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Add_Btn;
        private TextBox Price_Tb;
        private TextBox Name_Tb;
        private Label label2;
        private Label label1;
    }
}