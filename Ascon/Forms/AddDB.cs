using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Ascon
{
    public partial class AddDB : Form
    {
        public AddDB()
        {
            InitializeComponent();
        }

        private void AddDB_button_Click(object sender, EventArgs e)
        {
            if (DBName_textBox.Text != string.Empty)
            {
                DB.openConnection();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand selectdb = new SqlCommand($"Select name from Sys.Databases where name = '{DBName_textBox.Text}'", DB.con);
                adapter.SelectCommand = selectdb;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    DB.openConnection();
                    SqlCommand addDB = new SqlCommand($"CREATE DATABASE {DBName_textBox.Text};", DB.con);
                    addDB.ExecuteNonQuery();
                    if (DB.conString.Contains("Initial Catalog"))
                    {
                        DB.conString = DB.conString.Substring(0, DB.conString.IndexOf("Initial Catalog"));
                        DB.conString = DB.conString + $"Initial Catalog = {DBName_textBox.Text};";
                    }
                    else
                    {
                        DB.conString = DB.conString + $"Initial Catalog = {DBName_textBox.Text};";
                    }
                    DB.ConnectToDatabase();
                    DB.openConnection();
                    SqlCommand createTables = new SqlCommand($"CREATE TABLE Objects(\r\n    [id] INT NOT NULL IDENTITY(0, 1) PRIMARY KEY,\r\n    [type] NVARCHAR(255) NOT NULL,\r\n    [product] NVARCHAR(255) NOT NULL\r\n);\r\n\r\nCREATE TABLE Links(\r\n    [parentId] INT NOT NULL FOREIGN KEY REFERENCES Objects(id),\r\n    [childId] INT NOT NULL FOREIGN KEY REFERENCES Objects(id),\r\n);\r\n\r\nCREATE TABLE Attributes(\r\n    [objectId] INT NOT NULL FOREIGN KEY REFERENCES Objects(id),\r\n    [name] NVARCHAR(255) NOT NULL,\r\n    [value] NVARCHAR(255) NOT NULL,\r\n    CONSTRAINT PK_Attributes PRIMARY KEY ([objectId], [name])\r\n);", DB.con);
                    createTables.ExecuteNonQuery();
                    Main main = new Main();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("База данных с таким названием уже существует");
                }
            }
            else
            {
                MessageBox.Show("Выберите путь сохранения и введите название базы данных");
            }
        }

        private void AddDB_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
