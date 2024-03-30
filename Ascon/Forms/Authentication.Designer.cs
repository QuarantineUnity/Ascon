namespace Ascon
{
    partial class Authentication
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.OpenProgram_button = new System.Windows.Forms.Button();
            this.Authentication_comboBox = new System.Windows.Forms.ComboBox();
            this.Authentication_label = new System.Windows.Forms.Label();
            this.ConnectionStatus_label = new System.Windows.Forms.Label();
            this.CheckConnection_button = new System.Windows.Forms.Button();
            this.InitialCatalog_comboBox = new System.Windows.Forms.ComboBox();
            this.Server_comboBox = new System.Windows.Forms.ComboBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.UserID_textBox = new System.Windows.Forms.TextBox();
            this.InitialCatalog_label = new System.Windows.Forms.Label();
            this.Server_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.UserID_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OpenProgram_button
            // 
            this.OpenProgram_button.Enabled = false;
            this.OpenProgram_button.Location = new System.Drawing.Point(202, 173);
            this.OpenProgram_button.Name = "OpenProgram_button";
            this.OpenProgram_button.Size = new System.Drawing.Size(121, 23);
            this.OpenProgram_button.TabIndex = 30;
            this.OpenProgram_button.Text = "Открыть программу";
            this.OpenProgram_button.UseVisualStyleBackColor = true;
            this.OpenProgram_button.Click += new System.EventHandler(this.OpenProgram_button_Click);
            // 
            // Authentication_comboBox
            // 
            this.Authentication_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Authentication_comboBox.FormattingEnabled = true;
            this.Authentication_comboBox.Items.AddRange(new object[] {
            "Windows Authentication",
            "SQL Server Authentication"});
            this.Authentication_comboBox.Location = new System.Drawing.Point(156, 38);
            this.Authentication_comboBox.Name = "Authentication_comboBox";
            this.Authentication_comboBox.Size = new System.Drawing.Size(166, 21);
            this.Authentication_comboBox.TabIndex = 29;
            this.Authentication_comboBox.SelectedIndexChanged += new System.EventHandler(this.Authentication_comboBox_SelectedIndexChanged);
            this.Authentication_comboBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // Authentication_label
            // 
            this.Authentication_label.AutoSize = true;
            this.Authentication_label.Location = new System.Drawing.Point(39, 41);
            this.Authentication_label.Name = "Authentication_label";
            this.Authentication_label.Size = new System.Drawing.Size(112, 13);
            this.Authentication_label.TabIndex = 28;
            this.Authentication_label.Text = "Вид аутентификации";
            // 
            // ConnectionStatus_label
            // 
            this.ConnectionStatus_label.AutoSize = true;
            this.ConnectionStatus_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ConnectionStatus_label.Location = new System.Drawing.Point(329, 44);
            this.ConnectionStatus_label.Name = "ConnectionStatus_label";
            this.ConnectionStatus_label.Size = new System.Drawing.Size(129, 13);
            this.ConnectionStatus_label.TabIndex = 27;
            this.ConnectionStatus_label.Text = "Статус подключения";
            // 
            // CheckConnection_button
            // 
            this.CheckConnection_button.Location = new System.Drawing.Point(329, 63);
            this.CheckConnection_button.Name = "CheckConnection_button";
            this.CheckConnection_button.Size = new System.Drawing.Size(140, 23);
            this.CheckConnection_button.TabIndex = 26;
            this.CheckConnection_button.Text = "Проверить подключение";
            this.CheckConnection_button.UseVisualStyleBackColor = true;
            this.CheckConnection_button.Click += new System.EventHandler(this.CheckConnection_button_Click);
            // 
            // InitialCatalog_comboBox
            // 
            this.InitialCatalog_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.InitialCatalog_comboBox.Enabled = false;
            this.InitialCatalog_comboBox.FormattingEnabled = true;
            this.InitialCatalog_comboBox.Location = new System.Drawing.Point(157, 146);
            this.InitialCatalog_comboBox.Name = "InitialCatalog_comboBox";
            this.InitialCatalog_comboBox.Size = new System.Drawing.Size(166, 21);
            this.InitialCatalog_comboBox.TabIndex = 25;
            this.InitialCatalog_comboBox.SelectedIndexChanged += new System.EventHandler(this.InitialCatalog_comboBox_SelectedIndexChanged);
            // 
            // Server_comboBox
            // 
            this.Server_comboBox.FormattingEnabled = true;
            this.Server_comboBox.Items.AddRange(new object[] {
            "localhost"});
            this.Server_comboBox.Location = new System.Drawing.Point(157, 65);
            this.Server_comboBox.Name = "Server_comboBox";
            this.Server_comboBox.Size = new System.Drawing.Size(166, 21);
            this.Server_comboBox.TabIndex = 24;
            this.Server_comboBox.SelectedIndexChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            this.Server_comboBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(157, 118);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(166, 20);
            this.Password_textBox.TabIndex = 23;
            // 
            // UserID_textBox
            // 
            this.UserID_textBox.Location = new System.Drawing.Point(157, 92);
            this.UserID_textBox.Name = "UserID_textBox";
            this.UserID_textBox.Size = new System.Drawing.Size(166, 20);
            this.UserID_textBox.TabIndex = 22;
            this.UserID_textBox.TextChanged += new System.EventHandler(this.UserID_textBox_TextChanged);
            // 
            // InitialCatalog_label
            // 
            this.InitialCatalog_label.AutoSize = true;
            this.InitialCatalog_label.Enabled = false;
            this.InitialCatalog_label.Location = new System.Drawing.Point(78, 149);
            this.InitialCatalog_label.Name = "InitialCatalog_label";
            this.InitialCatalog_label.Size = new System.Drawing.Size(72, 13);
            this.InitialCatalog_label.TabIndex = 21;
            this.InitialCatalog_label.Text = "База данных";
            // 
            // Server_label
            // 
            this.Server_label.AutoSize = true;
            this.Server_label.Location = new System.Drawing.Point(106, 68);
            this.Server_label.Name = "Server_label";
            this.Server_label.Size = new System.Drawing.Size(44, 13);
            this.Server_label.TabIndex = 20;
            this.Server_label.Text = "Сервер";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(105, 121);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(45, 13);
            this.Password_label.TabIndex = 19;
            this.Password_label.Text = "Пароль";
            // 
            // UserID_label
            // 
            this.UserID_label.AutoSize = true;
            this.UserID_label.Location = new System.Drawing.Point(58, 95);
            this.UserID_label.Name = "UserID_label";
            this.UserID_label.Size = new System.Drawing.Size(92, 13);
            this.UserID_label.TabIndex = 18;
            this.UserID_label.Text = "ID пользователя";
            // 
            // Authentication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 238);
            this.Controls.Add(this.OpenProgram_button);
            this.Controls.Add(this.Authentication_comboBox);
            this.Controls.Add(this.Authentication_label);
            this.Controls.Add(this.ConnectionStatus_label);
            this.Controls.Add(this.CheckConnection_button);
            this.Controls.Add(this.InitialCatalog_comboBox);
            this.Controls.Add(this.Server_comboBox);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.UserID_textBox);
            this.Controls.Add(this.InitialCatalog_label);
            this.Controls.Add(this.Server_label);
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.UserID_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Authentication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение к базе данных";
            this.Load += new System.EventHandler(this.Authentication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenProgram_button;
        private System.Windows.Forms.ComboBox Authentication_comboBox;
        private System.Windows.Forms.Label Authentication_label;
        private System.Windows.Forms.Label ConnectionStatus_label;
        private System.Windows.Forms.Button CheckConnection_button;
        private System.Windows.Forms.ComboBox InitialCatalog_comboBox;
        private System.Windows.Forms.ComboBox Server_comboBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox UserID_textBox;
        private System.Windows.Forms.Label InitialCatalog_label;
        private System.Windows.Forms.Label Server_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Label UserID_label;
    }
}

