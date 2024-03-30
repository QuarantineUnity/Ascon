using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ascon
{
    public partial class AddObject : Form
    {
        public string objectID;
        public AddObject()
        {
            InitializeComponent();
        }

        private void AddObject_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT type as 'Тип', product as 'Обозначение' FROM Objects WHERE id NOT IN (SELECT parentid FROM Links) AND id NOT IN (SELECT childid FROM Links)", DB.con);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            Objects_GridView.DataSource = table;
        }

        private void Objects_GridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DB.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand($"SELECT id FROM Objects WHERE Product = '{Objects_GridView.CurrentRow.Cells[1].Value.ToString()}'", DB.con);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            string newObjectID = table.Rows[0][0].ToString();

            SqlCommand insertCMD = new SqlCommand($"INSERT INTO Links (parentid, childid) VALUES ({objectID}, {newObjectID});", DB.con);
            insertCMD.ExecuteNonQuery();
            MessageBox.Show("Объект вставлен!");
            this.Close();
        }

        private void addObject_Button_Click(object sender, EventArgs e)
        {
            DB.openConnection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            for (int i = Objects_GridView.SelectedRows.Count - 1; i > -1; i--)
            {
                SqlCommand command = new SqlCommand($"SELECT id FROM Objects WHERE Product = '{Objects_GridView.SelectedRows[i].Cells[1].Value.ToString()}'", DB.con);
                adapter.SelectCommand = command;
                adapter.Fill(table);
            }

            for (int i = 0; i < table.Rows.Count; i++)
            {
                SqlCommand insertCMD = new SqlCommand($"INSERT INTO Links (parentid, childid) VALUES ({objectID}, {table.Rows[i][0]});", DB.con);
                insertCMD.ExecuteNonQuery();
            }

            if (table.Rows.Count > 1) { MessageBox.Show("Объекты вставлены!");}
            else { MessageBox.Show("Объект вставлен!"); }
            this.Close();
        }
    }
}
