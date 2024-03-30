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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Xml.Linq;
using System.IO;

namespace Ascon
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            refreshTreeView();
        }

        private void refreshTreeView()
        {
            Objects_treeView.Nodes.Clear();

            DataTable table = Query($"SELECT parentid FROM Links WHERE parentid NOT IN (SELECT childid FROM Links) GROUP BY parentid");

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataTable dt = Query($"SELECT product FROM objects WHERE id = '{table.Rows[i]["parentid"]}'");

                for (int j = 0; j < dt.Rows.Count; j++)
                {
                    TreeNode tn = new TreeNode(dt.Rows[j]["product"].ToString());
                        tn.Name = "object";

                    Objects_treeView.Nodes.Add(tn);
                    Objects_treeView.Nodes[i].Nodes.Add("fake");

                    //Objects_treeView.Nodes.Add(new TreeNode(dt.Rows[j]["product"].ToString()));
                    //Objects_treeView.Nodes[i].Nodes.Add("fake");
                }
            }
        }

        private void Objects_treeView_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.Nodes.Clear();

            TreeNode parentNode = e.Node;

            DataTable table = Query($"SELECT id FROM Objects where product = '{e.Node.Text}'"); // Выбираем id у открываемого объекта
            string parentid = table.Rows[0][0].ToString();

            DataTable dt = Query($"SELECT childid FROM Links WHERE parentid = '{parentid}'"); // Смотрим список дочерних id у открываемого объекта
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataTable childObjects_dt = Query($"SELECT product FROM objects WHERE id = '{dt.Rows[i][0]}'"); // Выбираем название дочерних объектов

                for (int j = 0; j < childObjects_dt.Rows.Count; j++)
                {

                    TreeNode tn = new TreeNode(childObjects_dt.Rows[j][0].ToString());
                    tn.Name = "childObject";
                    parentNode.Nodes.Add(tn);

                    DataTable childAvailability = Query($"SELECT childid FROM Links WHERE parentid = '{dt.Rows[i][0]}'"); // Смотрим есть ли у добавленного объекта дочерние объекты

                    if (childAvailability.Rows.Count != 0)
                    {
                        TreeNode newParentNode = parentNode.Nodes[i];
                        newParentNode.Name = "childObject";
                        TreeNode tn1 = new TreeNode("fake");
                        newParentNode.Nodes.Add(tn1);
                    }
                }
            }
        }

        private DataTable Query(string queryString)
        {
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(queryString, DB.con);
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public string objectProduct;

        private void Objects_treeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Objects_treeView.SelectedNode = e.Node;
                e.Node.ContextMenuStrip = treeView_CMS;
                objectProduct = e.Node.Text;
            }
        }

        private void addObject_MenuButton_Click(object sender, EventArgs e)
        {
            DataTable table = Query($"SELECT id FROM Objects where product = '{objectProduct}'");

            AddObject addObject = new AddObject();
            addObject.objectID = table.Rows[0][0].ToString();
            addObject.ShowDialog();
            refreshTreeView();
        }

        private void showObjects_button_Click(object sender, EventArgs e)
        {
            if (showObjects_button.Text == "Показать полный список объектов")
            {
                showObjects_button.Text = "Скрыть полный список объектов";

                DataTable table = Query($"SELECT type as 'Тип', product as 'Обозначение' FROM Objects");
                Objects_dataGrid.DataSource = table;

                chooseObject_label.Visible = true;
                Objects_dataGrid.Visible = true;
                addObject_button.Visible = true;
                showAttributes_button.Visible = true;
                deleteObject_button.Visible = true;

                this.Size = new Size(858, 549);
                this.CenterToScreen();

                newNode_button.Enabled = false;
            }
            else
            {
                showObjects_button.Text = "Показать полный список объектов";

                chooseObject_label.Visible = false;
                Objects_dataGrid.Visible = false;
                addObject_button.Visible = false;
                showAttributes_button.Visible = false;
                deleteObject_button.Visible = false;

                this.Size = new Size(456, 549);
                this.CenterToScreen();

                newNode_button.Enabled = true;
            }
        }

        private void addObject_button_Click(object sender, EventArgs e)
        {
            AddNewObject addNewObject = new AddNewObject();
            addNewObject.ShowDialog();
            refreshTreeView();
        }

        private void showAttributes_button_Click(object sender, EventArgs e)
        {
            if (Objects_dataGrid.SelectedRows.Count == 1)
            {
                DataTable table = Query($"SELECT id FROM Objects where product = '{Objects_dataGrid.SelectedRows[0].Cells[1].Value}'");
                string objectID = table.Rows[0][0].ToString();
                Attributes attributes = new Attributes();
                attributes.product = Objects_dataGrid.SelectedRows[0].Cells[1].Value.ToString();
                attributes.objectID = objectID;
                attributes.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выделите только один объект!");
            }
        }

        private void deleteObject_MenuButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить ветку '{objectProduct}'?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                deleteObjects(objectProduct);
                MessageBox.Show("Ветка удалена!");
            }

            refreshTreeView();
        }

        //private void deleteObjects(int ObjectID)
        //{
        //    DB.openConnection();
        //    using (SqlCommand command1 = new SqlCommand($"SELECT childid FROM Links WHERE parentid = '{ObjectID}'", DB.con))
        //    {
        //        using (SqlDataReader reader = command1.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int childId = reader.GetInt32(0);
        //                deleteObjects(childId);
        //            }
        //        }
        //    }

        //    SqlCommand command = new SqlCommand($"DELETE FROM Links WHERE parentid = '{ObjectID}' OR childid = '{ObjectID}'", DB.con);
        //    command.ExecuteNonQuery();
        //}

        private void deleteObjects(string objectProduct)
        {
            DB.openConnection();
            DataTable table = Query($"SELECT id FROM Objects where product = '{objectProduct}'");
            int objectID = Convert.ToInt32(table.Rows[0][0].ToString());
            DataTable isParent_dt = Query($"SELECT * FROM Links where parentid = '{objectID}'");
            if (isParent_dt.Rows.Count != 0)
            {
                DataTable forDelete_dt = newDeleteObjects(objectID, isParent_dt);
                for (int i = 0; i < forDelete_dt.Rows.Count; i++)
                {
                    SqlCommand deleteLink = new SqlCommand($"DELETE FROM Links WHERE parentid = '{forDelete_dt.Rows[i][0]}' AND childid = '{forDelete_dt.Rows[i][1]}'", DB.con);
                    deleteLink.ExecuteNonQuery();
                }
            }
            else
            {
                SqlCommand deleteLink = new SqlCommand($"DELETE FROM Links WHERE childid = '{objectID}' OR parentid = '{objectID}'", DB.con);
                deleteLink.ExecuteNonQuery();
            }
        }

        private DataTable newDeleteObjects(int objectID, DataTable table)
        {
            DB.openConnection();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataTable isParent_dt = Query($"SELECT * FROM Links where parentid = '{table.Rows[i][1].ToString()}'");

                if (isParent_dt.Rows.Count != 0)
                {
                    table.Merge(isParent_dt);
                    newDeleteObjects(Convert.ToInt32(table.Rows[i][1].ToString()), isParent_dt);
                }
                else
                {
                    table.Merge(isParent_dt);
                }
            }
            return table;
        }

        private void deleteObject_button_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Вы действительно хотите удалить выбранные объекты?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DB.openConnection();

                for (int i = 0; i < Objects_dataGrid.SelectedRows.Count; i++)
                {
                    DataTable table = Query($"SELECT id FROM Objects where product = '{Objects_dataGrid.SelectedRows[i].Cells[1].Value}'");
                    string objectID = table.Rows[0][0].ToString();
                    SqlCommand deleteAttributes = new SqlCommand($"DELETE FROM Attributes WHERE objectID = '{objectID}'", DB.con);
                    deleteAttributes.ExecuteNonQuery();
                    deleteObjects(Objects_dataGrid.SelectedRows[i].Cells[1].Value.ToString());
                    SqlCommand deleteObject = new SqlCommand($"DELETE FROM Objects WHERE id = '{objectID}'", DB.con);
                    deleteObject.ExecuteNonQuery();
                }
                MessageBox.Show("Объекты удалены!");
                DataTable objectsList = Query($"SELECT type as 'Тип', product as 'Обозначение' FROM Objects");
                Objects_dataGrid.DataSource = objectsList;
                refreshTreeView();
            }
        }

        private void newNode_button_Click(object sender, EventArgs e)
        {
            parentObject_comboBox.Items.Clear();

            DataTable table = Query("SELECT product as 'Обозначение' FROM Objects WHERE id NOT IN (SELECT parentid FROM Links) AND id NOT IN (SELECT childid FROM Links)");
            
            for (int i = 0; i < table.Rows.Count; i++)
            {
                parentObject_comboBox.Items.Add(table.Rows[i][0].ToString());
            }

            parentObject_label.Visible = true;
            parentObject_comboBox.Visible = true;
            childObject_label.Visible = true;
            childObject_comboBox.Visible = true;
            addNode_button.Visible = true;
            cancel_Button.Visible = true;

            this.Size = new Size(773, 549);
            this.CenterToScreen();

            showObjects_button.Enabled = false;
        }

        private void parentObject_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            childObject_comboBox.SelectedIndex = -1;
            childObject_comboBox.Items.Clear();

            if (parentObject_comboBox.Text != "")
            {
                DataTable parentID = Query($"SELECT id FROM Objects WHERE product = '{parentObject_comboBox.Text}'");
                DataTable table = Query($"SELECT product as 'Обозначение' FROM Objects WHERE id NOT IN (SELECT parentid FROM Links) AND id NOT IN (SELECT childid FROM Links) AND id <> {parentID.Rows[0][0]}");

                for (int i = 0; i < table.Rows.Count; i++)
                {
                    childObject_comboBox.Items.Add(table.Rows[i][0].ToString());
                }
            }
        }

        private void addNode_button_Click(object sender, EventArgs e)
        {
            if (parentObject_comboBox.Text == string.Empty || childObject_comboBox.Text == string.Empty)
            {
                MessageBox.Show("Выберите объекты из списка");
            }
            else
            {
                DB.openConnection();

                DataTable parentID = Query($"SELECT id FROM Objects WHERE product = '{parentObject_comboBox.Text}'");
                DataTable childID = Query($"SELECT id FROM Objects WHERE product = '{childObject_comboBox.Text}'");
                SqlCommand command = new SqlCommand($"INSERT INTO Links (parentid, childid) VALUES ({parentID.Rows[0][0]}, {childID.Rows[0][0]})", DB.con);
                command.ExecuteNonQuery();
                MessageBox.Show("Ветка добавлена!");
                refreshTreeView();

                parentObject_label.Visible = false;
                parentObject_comboBox.Visible = false;
                childObject_label.Visible = false;
                childObject_comboBox.Visible = false;
                addNode_button.Visible = false;
                cancel_Button.Visible = false;

                this.Size = new Size(456, 549);
                this.CenterToScreen();

                showObjects_button.Enabled = true;
            }
        }

        private void Objects_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            DataTable table = Query($"SELECT id FROM Objects WHERE product = '{e.Node.Text}'");
            DataTable Attributes_dt = Query($"SELECT name, value from Attributes WHERE objectid = '{table.Rows[0][0]}'");

            attributes_textBox.Text = $"Атрибуты объекта {e.Node.Text}:";

            for (int i = 0; i < Attributes_dt.Rows.Count; i++)
            {
                attributes_textBox.Text += $"\r\n{Attributes_dt.Rows[i][0]} - {Attributes_dt.Rows[i][1]}";
            }
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            parentObject_label.Visible = false;
            parentObject_comboBox.Visible = false;
            childObject_label.Visible = false;
            childObject_comboBox.Visible = false;
            addNode_button.Visible = false;
            cancel_Button.Visible = false;

            this.Size = new Size(456, 549);
            this.CenterToScreen();

            showObjects_button.Enabled = true;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void XML_button_Click(object sender, EventArgs e)
        {
            var rootElement = new XElement("root", CreateXmlElement(Objects_treeView.Nodes));
            var document = new XDocument(rootElement);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XML-File | *.xml";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                document.Save(Path.GetFullPath(sfd.FileName));
                MessageBox.Show("Файл сохранен!");
            }
        }

        private static List<XElement> CreateXmlElement(TreeNodeCollection treeViewNodes)
        {
            var elements = new List<XElement>();
            foreach (TreeNode treeViewNode in treeViewNodes)
            {
                if (treeViewNode.Text != "fake")
                {
                    var element = new XElement(treeViewNode.Name);
                    element.SetAttributeValue("product", treeViewNode.Text);
                    element.Add(CreateXmlElement(treeViewNode.Nodes));
                    elements.Add(element);
                }
            }
            return elements;
        }
    }
}
