namespace Ascon
{
    partial class Attributes
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
            this.attributes_dataGrid = new System.Windows.Forms.DataGridView();
            this.name_Label = new System.Windows.Forms.Label();
            this.value_Label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.value_textBox = new System.Windows.Forms.TextBox();
            this.addAttribute_button = new System.Windows.Forms.Button();
            this.objectProduct_label = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            this.deleteAttribute_button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.attributes_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // attributes_dataGrid
            // 
            this.attributes_dataGrid.AllowUserToAddRows = false;
            this.attributes_dataGrid.AllowUserToDeleteRows = false;
            this.attributes_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.attributes_dataGrid.Location = new System.Drawing.Point(12, 32);
            this.attributes_dataGrid.Name = "attributes_dataGrid";
            this.attributes_dataGrid.ReadOnly = true;
            this.attributes_dataGrid.RowHeadersVisible = false;
            this.attributes_dataGrid.Size = new System.Drawing.Size(230, 253);
            this.attributes_dataGrid.TabIndex = 0;
            // 
            // name_Label
            // 
            this.name_Label.AutoSize = true;
            this.name_Label.Location = new System.Drawing.Point(31, 313);
            this.name_Label.Name = "name_Label";
            this.name_Label.Size = new System.Drawing.Size(105, 13);
            this.name_Label.TabIndex = 1;
            this.name_Label.Text = "Название атрибута";
            // 
            // value_Label
            // 
            this.value_Label.AutoSize = true;
            this.value_Label.Location = new System.Drawing.Point(81, 339);
            this.value_Label.Name = "value_Label";
            this.value_Label.Size = new System.Drawing.Size(55, 13);
            this.value_Label.TabIndex = 2;
            this.value_Label.Text = "Значение";
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(142, 310);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(100, 20);
            this.name_textBox.TabIndex = 3;
            // 
            // value_textBox
            // 
            this.value_textBox.Location = new System.Drawing.Point(142, 336);
            this.value_textBox.Name = "value_textBox";
            this.value_textBox.Size = new System.Drawing.Size(100, 20);
            this.value_textBox.TabIndex = 4;
            // 
            // addAttribute_button
            // 
            this.addAttribute_button.Location = new System.Drawing.Point(167, 362);
            this.addAttribute_button.Name = "addAttribute_button";
            this.addAttribute_button.Size = new System.Drawing.Size(75, 23);
            this.addAttribute_button.TabIndex = 5;
            this.addAttribute_button.Text = "Добавить";
            this.addAttribute_button.UseVisualStyleBackColor = true;
            this.addAttribute_button.Click += new System.EventHandler(this.addAttribute_button_Click);
            // 
            // objectProduct_label
            // 
            this.objectProduct_label.AutoSize = true;
            this.objectProduct_label.Location = new System.Drawing.Point(9, 10);
            this.objectProduct_label.Name = "objectProduct_label";
            this.objectProduct_label.Size = new System.Drawing.Size(35, 13);
            this.objectProduct_label.TabIndex = 6;
            this.objectProduct_label.Text = "label1";
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(248, 32);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(147, 23);
            this.Add_button.TabIndex = 7;
            this.Add_button.Text = "Добавить новый атрибут";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // deleteAttribute_button
            // 
            this.deleteAttribute_button.Location = new System.Drawing.Point(248, 61);
            this.deleteAttribute_button.Name = "deleteAttribute_button";
            this.deleteAttribute_button.Size = new System.Drawing.Size(147, 23);
            this.deleteAttribute_button.TabIndex = 8;
            this.deleteAttribute_button.Text = "Удалить атрибут";
            this.deleteAttribute_button.UseVisualStyleBackColor = true;
            this.deleteAttribute_button.Click += new System.EventHandler(this.deleteAttribute_button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(86, 362);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.cancel_Button.TabIndex = 9;
            this.cancel_Button.Text = "Отмена";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // Attributes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 301);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.deleteAttribute_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.objectProduct_label);
            this.Controls.Add(this.addAttribute_button);
            this.Controls.Add(this.value_textBox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.value_Label);
            this.Controls.Add(this.name_Label);
            this.Controls.Add(this.attributes_dataGrid);
            this.MaximizeBox = false;
            this.Name = "Attributes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Атрибуты";
            this.Load += new System.EventHandler(this.Attributes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attributes_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView attributes_dataGrid;
        private System.Windows.Forms.Label name_Label;
        private System.Windows.Forms.Label value_Label;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox value_textBox;
        private System.Windows.Forms.Button addAttribute_button;
        private System.Windows.Forms.Label objectProduct_label;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Button deleteAttribute_button;
        private System.Windows.Forms.Button cancel_Button;
    }
}