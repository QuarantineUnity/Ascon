namespace Ascon
{
    partial class AddObject
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
            this.Objects_GridView = new System.Windows.Forms.DataGridView();
            this.addObject_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Objects_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Objects_GridView
            // 
            this.Objects_GridView.AllowUserToAddRows = false;
            this.Objects_GridView.AllowUserToDeleteRows = false;
            this.Objects_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Objects_GridView.Location = new System.Drawing.Point(25, 12);
            this.Objects_GridView.Name = "Objects_GridView";
            this.Objects_GridView.ReadOnly = true;
            this.Objects_GridView.RowHeadersVisible = false;
            this.Objects_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Objects_GridView.Size = new System.Drawing.Size(230, 223);
            this.Objects_GridView.TabIndex = 0;
            this.Objects_GridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Objects_GridView_CellMouseDoubleClick);
            // 
            // addObject_Button
            // 
            this.addObject_Button.Location = new System.Drawing.Point(76, 241);
            this.addObject_Button.Name = "addObject_Button";
            this.addObject_Button.Size = new System.Drawing.Size(179, 23);
            this.addObject_Button.TabIndex = 1;
            this.addObject_Button.Text = "Вставить выделенные объекты";
            this.addObject_Button.UseVisualStyleBackColor = true;
            this.addObject_Button.Click += new System.EventHandler(this.addObject_Button_Click);
            // 
            // AddObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 276);
            this.Controls.Add(this.addObject_Button);
            this.Controls.Add(this.Objects_GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "AddObject";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление объекта в ветку";
            this.Load += new System.EventHandler(this.AddObject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Objects_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Objects_GridView;
        private System.Windows.Forms.Button addObject_Button;
    }
}