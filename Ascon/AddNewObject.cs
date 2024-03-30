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
    public partial class AddNewObject : Form
    {
        public AddNewObject()
        {
            InitializeComponent();
        }

        private void addNewObject_button_Click(object sender, EventArgs e)
        {
            if (type_textBox.Text == string.Empty || product_textBox.Text == string.Empty)
            {
                
                MessageBox.Show("Заполните все поля");
            }
            else
            {
                DB.openConnection();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"SELECT product FROM Objects WHERE Product = '{product_textBox.Text}'", DB.con);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    SqlCommand insertCommand = new SqlCommand($"INSERT INTO Objects (type, product) VALUES ('{type_textBox.Text}', '{product_textBox.Text}');", DB.con);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Объект добавлен!");
                    type_textBox.Text = string.Empty;
                    product_textBox.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Объект с таким названием уже существует");
                }
            }
        }
    }
}
