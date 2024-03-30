namespace Ascon
{
    partial class AddNewObject
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
            this.type_Label = new System.Windows.Forms.Label();
            this.product_Label = new System.Windows.Forms.Label();
            this.type_textBox = new System.Windows.Forms.TextBox();
            this.product_textBox = new System.Windows.Forms.TextBox();
            this.addNewObject_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // type_Label
            // 
            this.type_Label.AutoSize = true;
            this.type_Label.Location = new System.Drawing.Point(98, 48);
            this.type_Label.Name = "type_Label";
            this.type_Label.Size = new System.Drawing.Size(26, 13);
            this.type_Label.TabIndex = 0;
            this.type_Label.Text = "Тип";
            // 
            // product_Label
            // 
            this.product_Label.AutoSize = true;
            this.product_Label.Location = new System.Drawing.Point(98, 102);
            this.product_Label.Name = "product_Label";
            this.product_Label.Size = new System.Drawing.Size(57, 13);
            this.product_Label.TabIndex = 1;
            this.product_Label.Text = "Название";
            // 
            // type_textBox
            // 
            this.type_textBox.Location = new System.Drawing.Point(101, 64);
            this.type_textBox.Name = "type_textBox";
            this.type_textBox.Size = new System.Drawing.Size(107, 20);
            this.type_textBox.TabIndex = 2;
            // 
            // product_textBox
            // 
            this.product_textBox.Location = new System.Drawing.Point(101, 118);
            this.product_textBox.Name = "product_textBox";
            this.product_textBox.Size = new System.Drawing.Size(107, 20);
            this.product_textBox.TabIndex = 3;
            // 
            // addNewObject_button
            // 
            this.addNewObject_button.Location = new System.Drawing.Point(101, 157);
            this.addNewObject_button.Name = "addNewObject_button";
            this.addNewObject_button.Size = new System.Drawing.Size(107, 23);
            this.addNewObject_button.TabIndex = 4;
            this.addNewObject_button.Text = "Добавить объект";
            this.addNewObject_button.UseVisualStyleBackColor = true;
            this.addNewObject_button.Click += new System.EventHandler(this.addNewObject_button_Click);
            // 
            // AddNewObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 233);
            this.Controls.Add(this.addNewObject_button);
            this.Controls.Add(this.product_textBox);
            this.Controls.Add(this.type_textBox);
            this.Controls.Add(this.product_Label);
            this.Controls.Add(this.type_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddNewObject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый объект";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label type_Label;
        private System.Windows.Forms.Label product_Label;
        private System.Windows.Forms.TextBox type_textBox;
        private System.Windows.Forms.TextBox product_textBox;
        private System.Windows.Forms.Button addNewObject_button;
    }
}