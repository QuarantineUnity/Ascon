using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascon
{
    public partial class Authentication : Form
    {
        public string conString;
        public Authentication()
        {
            InitializeComponent();
        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            Authentication_comboBox.SelectedIndex = 0;
            ConnectionStatus_label.Text = string.Empty;
            this.ActiveControl = UserID_textBox;
        }

        private void CheckConnection(string conString)
        {
            DisabeForm();
            DB.conString = conString;
            ConnectionStatus_label.Text = string.Empty;

            try
            {
                DB.ConnectToDatabase();
                DB.openConnection();

                if (DB.con.State == ConnectionState.Open)
                {
                    DataTable table = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    SqlCommand selectdb = new SqlCommand("SELECT name FROM sys.databases;", DB.con);
                    adapter.SelectCommand = selectdb;
                    adapter.Fill(table);

                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        InitialCatalog_comboBox.Items.Add(table.Rows[i]["name"]);
                    }

                    ConnectionStatus_label.Text = "Подключено!";
                    ConnectionStatus_label.ForeColor = Color.Green;
                    DB.con.Close();
                    EnableForm();
                }
            }
            catch
            {
                ConnectionStatus_label.Text = "Не подключено!";
                ConnectionStatus_label.ForeColor = Color.Red;
                EnableForm();
                InitialCatalog_comboBox.Items.Clear();
            }
        }

        private void CheckConnection_button_Click(object sender, EventArgs e)
        {
            conString = "";

            if (Authentication_comboBox.SelectedIndex == 0 && Server_comboBox.Text != string.Empty)
            {
                conString = $"Server={Server_comboBox.Text};Trusted_Connection=True;";
                CheckConnection(conString);
            }
            else if (Authentication_comboBox.SelectedIndex == 1 && UserID_textBox.Text != string.Empty && Server_comboBox.Text != string.Empty)
            {
                conString = $"Server={Server_comboBox.Text};User Id={UserID_textBox.Text};Password={Password_textBox.Text};";
                CheckConnection(conString);
            }
            else
            {
                MessageBox.Show("Введите все поля!");
            }
        }

        private void Authentication_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectionStatus_label.Text = string.Empty;
            InitialCatalog_comboBox.Items.Clear();
            if (Authentication_comboBox.SelectedIndex == 0)
            {
                UserID_label.Visible = false;
                UserID_textBox.Visible = false;
                Password_label.Visible = false;
                Password_textBox.Visible = false;
                ConnectionStatus_label.Location = new Point(328, 48);
                CheckConnection_button.Location = new Point(328, 67);
                InitialCatalog_label.Location = new Point(80, 99);
                InitialCatalog_comboBox.Location = new Point(156, 96);
                OpenProgram_button.Location = new Point(201, 122);
            }
            else if (Authentication_comboBox.SelectedIndex == 1)
            {
                UserID_label.Visible = true;
                UserID_textBox.Visible = true;
                Password_label.Visible = true;
                Password_textBox.Visible = true;
                ConnectionStatus_label.Location = new Point(328, 101);
                CheckConnection_button.Location = new Point(328, 120);
                InitialCatalog_label.Location = new Point(80, 153);
                InitialCatalog_comboBox.Location = new Point(156, 150);
                OpenProgram_button.Location = new Point(201, 177);
            }
        }

        private void DisabeForm()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = false;
            }
            this.Enabled = false;
            EnableControl();
        }

        private void EnableForm()
        {
            foreach (Control control in this.Controls)
            {
                control.Enabled = true;
            }
            this.Enabled = true;
            EnableControl();
        }

        private void EnableControl()
        {
            if (ConnectionStatus_label.Text == "Подключено!")
            {
                InitialCatalog_comboBox.Enabled = true;
                InitialCatalog_label.Enabled = true;
            }
            else
            {
                InitialCatalog_comboBox.Enabled = false;
                InitialCatalog_label.Enabled = false;
            }

            if (InitialCatalog_comboBox.Text != string.Empty)
            {
                OpenProgram_button.Enabled = true;
            }
            else
            {
                OpenProgram_button.Enabled = false;
            }
        }

        private void UserID_textBox_TextChanged(object sender, EventArgs e)
        {
            InitialCatalog_comboBox.Items.Clear();
            ConnectionStatus_label.Text = string.Empty;
            EnableControl();
        }

        private void InitialCatalog_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableControl();
            if (DB.conString.Contains("Initial Catalog"))
            {
                DB.conString = DB.conString.Substring(0, DB.conString.IndexOf("Initial Catalog"));
                DB.conString = DB.conString + $"Initial Catalog = {InitialCatalog_comboBox.Text};";
            }
            else
            {
                DB.conString = DB.conString + $"Initial Catalog = {InitialCatalog_comboBox.Text};";
            }
        }

        private void OpenProgram_button_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            DB.ConnectToDatabase();
            DB.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand selecttable_attributes = new SqlCommand($"SELECT table_name FROM INFORMATION_SCHEMA.TABLES where table_name = 'Attributes' or table_name = 'Objects' or table_name = 'Links';", DB.con);
            adapter.SelectCommand = selecttable_attributes;
            adapter.Fill(table);
            if (table.Rows.Count < 3)
            {
                DialogResult result = MessageBox.Show("В базе данных не хватает нужных таблиц. Добавить?", "Подтверждение", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    if (DB.conString.Contains("Initial Catalog"))
                    {
                        DB.conString = DB.conString.Substring(0, DB.conString.IndexOf("Initial Catalog"));
                        DB.conString = DB.conString + $"Initial Catalog = {InitialCatalog_comboBox.Text};";
                    }
                    else
                    {
                        DB.conString = DB.conString + $"Initial Catalog = {InitialCatalog_comboBox.Text};";
                    }
                    DB.ConnectToDatabase();
                    DB.openConnection();
                    SqlCommand addTables = new SqlCommand($"IF NOT EXISTS (SELECT table_name FROM INFORMATION_SCHEMA.TABLES where table_name = 'Objects') begin\r\nCREATE TABLE Objects(\r\n    [id] INT NOT NULL IDENTITY(0, 1) PRIMARY KEY,\r\n    [type] NVARCHAR(255) NOT NULL,\r\n    [product] NVARCHAR(255) NOT NULL\r\n);\r\nend\r\nIF NOT EXISTS (SELECT table_name FROM INFORMATION_SCHEMA.TABLES where table_name = 'Links') begin\r\nCREATE TABLE Links(\r\n    [parentId] INT NOT NULL FOREIGN KEY REFERENCES Objects(id),\r\n    [childId] INT NOT NULL FOREIGN KEY REFERENCES Objects(id),\r\n);\r\nend\r\nIF NOT EXISTS (SELECT table_name FROM INFORMATION_SCHEMA.TABLES where table_name = 'Attributes') begin\r\nCREATE TABLE Attributes(\r\n    [objectId] INT NOT NULL FOREIGN KEY REFERENCES Objects(id),\r\n    [name] NVARCHAR(255) NOT NULL,\r\n    [value] NVARCHAR(255) NOT NULL,\r\n    CONSTRAINT PK_Attributes PRIMARY KEY ([objectId], [name])\r\n);\r\nend", DB.con);
                    addTables.ExecuteNonQuery();
                    MessageBox.Show("Таблицы успешно добавлены!");
                    main.Show();
                    this.Hide();
                }
                else
                {
                    DialogResult result_db = MessageBox.Show("Для работы с программой необходима база данных с нужными таблицами. Создать базу данных?", "Подтверждение", MessageBoxButtons.YesNo);

                    if (result_db == DialogResult.Yes)
                    {
                        AddDB addDB = new AddDB();
                        addDB.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                if (DB.conString.Contains("Initial Catalog"))
                {
                    DB.conString = DB.conString.Substring(0, DB.conString.IndexOf("Initial Catalog"));
                    DB.conString = DB.conString + $"Initial Catalog = {InitialCatalog_comboBox.Text};";
                }
                else
                {
                    DB.conString = DB.conString + $"Initial Catalog = {InitialCatalog_comboBox.Text};";
                }
                DB.ConnectToDatabase();
                main.Show();
                this.Hide();
            }

            //string server = Server_comboBox.Text;
            //string login = UserID_textBox.Text;
            //string password = Password_textBox.Text;
            //string initialcatalog = InitialCatalog_comboBox.Text;
            //QueryConsole queryConsole = new QueryConsole();
            //queryConsole.Server_label.Text = server;
            //queryConsole.Login_label.Text = login;
            //queryConsole.Password_label.Text = password;
            //queryConsole.InitialCatalog_label.Text = initialcatalog;
            //queryConsole.conString_label.Text = conString;
            //queryConsole.Show();
            //this.Hide();
        }
    }
}
