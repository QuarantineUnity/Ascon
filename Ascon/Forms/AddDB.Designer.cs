namespace Ascon
{
    partial class AddDB
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
            this.AddDB_button = new System.Windows.Forms.Button();
            this.DBName_textBox = new System.Windows.Forms.TextBox();
            this.DBName_label = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // AddDB_button
            // 
            this.AddDB_button.Location = new System.Drawing.Point(95, 99);
            this.AddDB_button.Name = "AddDB_button";
            this.AddDB_button.Size = new System.Drawing.Size(75, 23);
            this.AddDB_button.TabIndex = 0;
            this.AddDB_button.Text = "Создать";
            this.AddDB_button.UseVisualStyleBackColor = true;
            this.AddDB_button.Click += new System.EventHandler(this.AddDB_button_Click);
            // 
            // DBName_textBox
            // 
            this.DBName_textBox.Location = new System.Drawing.Point(41, 64);
            this.DBName_textBox.Name = "DBName_textBox";
            this.DBName_textBox.Size = new System.Drawing.Size(195, 20);
            this.DBName_textBox.TabIndex = 1;
            // 
            // DBName_label
            // 
            this.DBName_label.AutoSize = true;
            this.DBName_label.Location = new System.Drawing.Point(52, 39);
            this.DBName_label.Name = "DBName_label";
            this.DBName_label.Size = new System.Drawing.Size(169, 13);
            this.DBName_label.TabIndex = 2;
            this.DBName_label.Text = "Введите название базы данных";
            // 
            // AddDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 173);
            this.Controls.Add(this.DBName_label);
            this.Controls.Add(this.DBName_textBox);
            this.Controls.Add(this.AddDB_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddDB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новая база данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddDB_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddDB_button;
        private System.Windows.Forms.TextBox DBName_textBox;
        private System.Windows.Forms.Label DBName_label;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}