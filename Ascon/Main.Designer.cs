namespace Ascon
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.Objects_treeView = new System.Windows.Forms.TreeView();
            this.treeView_CMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addObject_MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteObject_MenuButton = new System.Windows.Forms.ToolStripMenuItem();
            this.showObjects_button = new System.Windows.Forms.Button();
            this.Objects_dataGrid = new System.Windows.Forms.DataGridView();
            this.addObject_button = new System.Windows.Forms.Button();
            this.showAttributes_button = new System.Windows.Forms.Button();
            this.attributes_textBox = new System.Windows.Forms.TextBox();
            this.deleteObject_button = new System.Windows.Forms.Button();
            this.newNode_button = new System.Windows.Forms.Button();
            this.chooseObject_label = new System.Windows.Forms.Label();
            this.parentObject_label = new System.Windows.Forms.Label();
            this.childObject_label = new System.Windows.Forms.Label();
            this.parentObject_comboBox = new System.Windows.Forms.ComboBox();
            this.childObject_comboBox = new System.Windows.Forms.ComboBox();
            this.addNode_button = new System.Windows.Forms.Button();
            this.cancel_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.XML_button = new System.Windows.Forms.Button();
            this.treeView_CMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Objects_dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Objects_treeView
            // 
            this.Objects_treeView.Location = new System.Drawing.Point(12, 41);
            this.Objects_treeView.Name = "Objects_treeView";
            this.Objects_treeView.Size = new System.Drawing.Size(416, 331);
            this.Objects_treeView.TabIndex = 0;
            this.Objects_treeView.AfterExpand += new System.Windows.Forms.TreeViewEventHandler(this.Objects_treeView_AfterExpand);
            this.Objects_treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.Objects_treeView_AfterSelect);
            this.Objects_treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.Objects_treeView_NodeMouseClick);
            // 
            // treeView_CMS
            // 
            this.treeView_CMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addObject_MenuButton,
            this.deleteObject_MenuButton});
            this.treeView_CMS.Name = "treeView_CMS";
            this.treeView_CMS.Size = new System.Drawing.Size(159, 48);
            // 
            // addObject_MenuButton
            // 
            this.addObject_MenuButton.Name = "addObject_MenuButton";
            this.addObject_MenuButton.Size = new System.Drawing.Size(158, 22);
            this.addObject_MenuButton.Text = "Добавить ветку";
            this.addObject_MenuButton.Click += new System.EventHandler(this.addObject_MenuButton_Click);
            // 
            // deleteObject_MenuButton
            // 
            this.deleteObject_MenuButton.Name = "deleteObject_MenuButton";
            this.deleteObject_MenuButton.Size = new System.Drawing.Size(158, 22);
            this.deleteObject_MenuButton.Text = "Удалить ветку";
            this.deleteObject_MenuButton.Click += new System.EventHandler(this.deleteObject_MenuButton_Click);
            // 
            // showObjects_button
            // 
            this.showObjects_button.Location = new System.Drawing.Point(12, 12);
            this.showObjects_button.Name = "showObjects_button";
            this.showObjects_button.Size = new System.Drawing.Size(202, 23);
            this.showObjects_button.TabIndex = 1;
            this.showObjects_button.Text = "Показать полный список объектов";
            this.showObjects_button.UseVisualStyleBackColor = true;
            this.showObjects_button.Click += new System.EventHandler(this.showObjects_button_Click);
            // 
            // Objects_dataGrid
            // 
            this.Objects_dataGrid.AllowUserToAddRows = false;
            this.Objects_dataGrid.AllowUserToDeleteRows = false;
            this.Objects_dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Objects_dataGrid.Location = new System.Drawing.Point(436, 41);
            this.Objects_dataGrid.Name = "Objects_dataGrid";
            this.Objects_dataGrid.ReadOnly = true;
            this.Objects_dataGrid.RowHeadersVisible = false;
            this.Objects_dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Objects_dataGrid.Size = new System.Drawing.Size(230, 447);
            this.Objects_dataGrid.TabIndex = 2;
            this.Objects_dataGrid.Visible = false;
            // 
            // addObject_button
            // 
            this.addObject_button.Location = new System.Drawing.Point(672, 41);
            this.addObject_button.Name = "addObject_button";
            this.addObject_button.Size = new System.Drawing.Size(159, 23);
            this.addObject_button.TabIndex = 3;
            this.addObject_button.Text = "Добавить новый объект";
            this.addObject_button.UseVisualStyleBackColor = true;
            this.addObject_button.Visible = false;
            this.addObject_button.Click += new System.EventHandler(this.addObject_button_Click);
            // 
            // showAttributes_button
            // 
            this.showAttributes_button.Location = new System.Drawing.Point(672, 70);
            this.showAttributes_button.Name = "showAttributes_button";
            this.showAttributes_button.Size = new System.Drawing.Size(159, 23);
            this.showAttributes_button.TabIndex = 4;
            this.showAttributes_button.Text = "Показать атрибуты объекта";
            this.showAttributes_button.UseVisualStyleBackColor = true;
            this.showAttributes_button.Visible = false;
            this.showAttributes_button.Click += new System.EventHandler(this.showAttributes_button_Click);
            // 
            // attributes_textBox
            // 
            this.attributes_textBox.BackColor = System.Drawing.SystemColors.Control;
            this.attributes_textBox.Location = new System.Drawing.Point(12, 378);
            this.attributes_textBox.Multiline = true;
            this.attributes_textBox.Name = "attributes_textBox";
            this.attributes_textBox.ReadOnly = true;
            this.attributes_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.attributes_textBox.Size = new System.Drawing.Size(416, 110);
            this.attributes_textBox.TabIndex = 5;
            // 
            // deleteObject_button
            // 
            this.deleteObject_button.Location = new System.Drawing.Point(672, 99);
            this.deleteObject_button.Name = "deleteObject_button";
            this.deleteObject_button.Size = new System.Drawing.Size(159, 23);
            this.deleteObject_button.TabIndex = 7;
            this.deleteObject_button.Text = "Удалить объект";
            this.deleteObject_button.UseVisualStyleBackColor = true;
            this.deleteObject_button.Visible = false;
            this.deleteObject_button.Click += new System.EventHandler(this.deleteObject_button_Click);
            // 
            // newNode_button
            // 
            this.newNode_button.Location = new System.Drawing.Point(220, 12);
            this.newNode_button.Name = "newNode_button";
            this.newNode_button.Size = new System.Drawing.Size(96, 23);
            this.newNode_button.TabIndex = 8;
            this.newNode_button.Text = "Добавить ветку";
            this.newNode_button.UseVisualStyleBackColor = true;
            this.newNode_button.Click += new System.EventHandler(this.newNode_button_Click);
            // 
            // chooseObject_label
            // 
            this.chooseObject_label.AutoSize = true;
            this.chooseObject_label.Location = new System.Drawing.Point(433, 22);
            this.chooseObject_label.Name = "chooseObject_label";
            this.chooseObject_label.Size = new System.Drawing.Size(96, 13);
            this.chooseObject_label.TabIndex = 9;
            this.chooseObject_label.Text = "Выберите объект";
            this.chooseObject_label.Visible = false;
            // 
            // parentObject_label
            // 
            this.parentObject_label.AutoSize = true;
            this.parentObject_label.Location = new System.Drawing.Point(433, 44);
            this.parentObject_label.Name = "parentObject_label";
            this.parentObject_label.Size = new System.Drawing.Size(118, 13);
            this.parentObject_label.TabIndex = 10;
            this.parentObject_label.Text = "Родительский объект";
            this.parentObject_label.Visible = false;
            // 
            // childObject_label
            // 
            this.childObject_label.AutoSize = true;
            this.childObject_label.Location = new System.Drawing.Point(455, 78);
            this.childObject_label.Name = "childObject_label";
            this.childObject_label.Size = new System.Drawing.Size(96, 13);
            this.childObject_label.TabIndex = 11;
            this.childObject_label.Text = "Дочерний объект";
            this.childObject_label.Visible = false;
            // 
            // parentObject_comboBox
            // 
            this.parentObject_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parentObject_comboBox.FormattingEnabled = true;
            this.parentObject_comboBox.Location = new System.Drawing.Point(557, 41);
            this.parentObject_comboBox.Name = "parentObject_comboBox";
            this.parentObject_comboBox.Size = new System.Drawing.Size(187, 21);
            this.parentObject_comboBox.TabIndex = 12;
            this.parentObject_comboBox.Visible = false;
            this.parentObject_comboBox.SelectedIndexChanged += new System.EventHandler(this.parentObject_comboBox_SelectedIndexChanged);
            // 
            // childObject_comboBox
            // 
            this.childObject_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.childObject_comboBox.FormattingEnabled = true;
            this.childObject_comboBox.Location = new System.Drawing.Point(557, 75);
            this.childObject_comboBox.Name = "childObject_comboBox";
            this.childObject_comboBox.Size = new System.Drawing.Size(187, 21);
            this.childObject_comboBox.TabIndex = 13;
            this.childObject_comboBox.Visible = false;
            // 
            // addNode_button
            // 
            this.addNode_button.Location = new System.Drawing.Point(678, 102);
            this.addNode_button.Name = "addNode_button";
            this.addNode_button.Size = new System.Drawing.Size(66, 23);
            this.addNode_button.TabIndex = 14;
            this.addNode_button.Text = "Готово";
            this.addNode_button.UseVisualStyleBackColor = true;
            this.addNode_button.Visible = false;
            this.addNode_button.Click += new System.EventHandler(this.addNode_button_Click);
            // 
            // cancel_Button
            // 
            this.cancel_Button.Location = new System.Drawing.Point(608, 102);
            this.cancel_Button.Name = "cancel_Button";
            this.cancel_Button.Size = new System.Drawing.Size(64, 23);
            this.cancel_Button.TabIndex = 15;
            this.cancel_Button.Text = "Отмена";
            this.cancel_Button.UseVisualStyleBackColor = true;
            this.cancel_Button.Visible = false;
            this.cancel_Button.Click += new System.EventHandler(this.cancel_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 491);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Нажмите правой кнопкой мыши по ветке для открытия меню";
            // 
            // XML_button
            // 
            this.XML_button.Location = new System.Drawing.Point(322, 12);
            this.XML_button.Name = "XML_button";
            this.XML_button.Size = new System.Drawing.Size(105, 23);
            this.XML_button.TabIndex = 17;
            this.XML_button.Text = "Выгрузить в XML";
            this.XML_button.UseVisualStyleBackColor = true;
            this.XML_button.Click += new System.EventHandler(this.XML_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 510);
            this.Controls.Add(this.XML_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancel_Button);
            this.Controls.Add(this.addNode_button);
            this.Controls.Add(this.childObject_comboBox);
            this.Controls.Add(this.parentObject_comboBox);
            this.Controls.Add(this.childObject_label);
            this.Controls.Add(this.parentObject_label);
            this.Controls.Add(this.chooseObject_label);
            this.Controls.Add(this.newNode_button);
            this.Controls.Add(this.deleteObject_button);
            this.Controls.Add(this.attributes_textBox);
            this.Controls.Add(this.showAttributes_button);
            this.Controls.Add(this.addObject_button);
            this.Controls.Add(this.Objects_dataGrid);
            this.Controls.Add(this.showObjects_button);
            this.Controls.Add(this.Objects_treeView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.treeView_CMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Objects_dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip treeView_CMS;
        private System.Windows.Forms.ToolStripMenuItem addObject_MenuButton;
        private System.Windows.Forms.ToolStripMenuItem deleteObject_MenuButton;
        public System.Windows.Forms.TreeView Objects_treeView;
        private System.Windows.Forms.Button showObjects_button;
        private System.Windows.Forms.DataGridView Objects_dataGrid;
        private System.Windows.Forms.Button addObject_button;
        private System.Windows.Forms.Button showAttributes_button;
        private System.Windows.Forms.TextBox attributes_textBox;
        private System.Windows.Forms.Button deleteObject_button;
        private System.Windows.Forms.Button newNode_button;
        private System.Windows.Forms.Label chooseObject_label;
        private System.Windows.Forms.Label parentObject_label;
        private System.Windows.Forms.Label childObject_label;
        private System.Windows.Forms.ComboBox parentObject_comboBox;
        private System.Windows.Forms.ComboBox childObject_comboBox;
        private System.Windows.Forms.Button addNode_button;
        private System.Windows.Forms.Button cancel_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button XML_button;
    }
}