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
    public partial class Attributes : Form
    {
        public string objectID;
        public string product;
        public Attributes()
        {
            InitializeComponent();
        }

        private void Attributes_Load(object sender, EventArgs e)
        {
            objectProduct_label.Text = product;
            showAttributes();
        }

        private void showAttributes()
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand($"SELECT name as 'Название', value as 'Значение' FROM Attributes WHERE objectid = {objectID}", DB.con);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            attributes_dataGrid.DataSource = table;
        }

        private void addAttribute_button_Click(object sender, EventArgs e)
        {
            if (name_textBox.Text == string.Empty || value_textBox.Text == string.Empty)
            {
                
                MessageBox.Show("Введите все поля");
            }
            else
            {
                DB.openConnection();
                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand($"SELECT * FROM Attributes WHERE objectid = '{objectID}' AND name = '{name_textBox.Text}' AND value = '{value_textBox.Text}'", DB.con);
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if (table.Rows.Count == 0)
                {
                    SqlCommand insertAttribute = new SqlCommand($"INSERT INTO Attributes (objectid, name, value) VALUES ('{objectID}', '{name_textBox.Text}', '{value_textBox.Text}')", DB.con);
                    insertAttribute.ExecuteNonQuery();
                    MessageBox.Show("Атрибут добавлен!");
                    showAttributes();
                    this.Size = new Size(424, 340);
                    name_textBox.Text = "";
                    value_textBox.Text = "";
                    this.CenterToScreen();
                }
                else
                {
                    MessageBox.Show("Данный атрибут уже существует");
                }
            }
        }

        private void deleteAttribute_button_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            SqlCommand deleteAttributes = new SqlCommand($"DELETE FROM Attributes WHERE objectID = '{objectID}' AND name = '{attributes_dataGrid.SelectedRows[0].Cells[0].Value.ToString()}' AND value = '{attributes_dataGrid.SelectedRows[0].Cells[1].Value.ToString()}'", DB.con);
            deleteAttributes.ExecuteNonQuery();
            MessageBox.Show("Атрибут удален!");
            showAttributes();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            this.Size = new Size(424, 436);
            this.CenterToScreen();
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            this.Size = new Size(424, 340);
            name_textBox.Text = "";
            value_textBox.Text = "";
            this.CenterToScreen();
        }
    }
}
