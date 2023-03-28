using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Alparslan\Documents\Cars application.accdb"";Persist Security Info=True;User ID=admin";
        OleDbConnection dbConnect = new OleDbConnection();
        private void Models_Load(object sender, EventArgs e)
        {
            label1.Text = "VersionID";
            label2.Text = "Version";
            label3.Text = "Find";
            button1.Text = "Insert";
            button2.Text = "Update";
            button3.Text = "Delete";
            button4.Text = "Query";
            ExportCombo();
            DisplayData();
            comboBox1.SelectedIndex = 0;
        }
        private void ExportCombo()
        {
            dbConnect.ConnectionString = conStr;
            string mySelect = "select * from Versions";
            dbConnect.Open();
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            OleDbDataReader reader = dbCmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["Version"]).ToString();
            }
            dbConnect.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conStr;

            string mySelect = "select * from Versions where Version='" + comboBox1.Text
            + "'";
            dbConnect.Open();
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            OleDbDataReader reader = dbCmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = (reader["VersionID"]).ToString();
                textBox2.Text = (reader["Version"]).ToString();
            }
            dbConnect.Close();
        }
        private void DisplayData()
        {
            string mySelect = "select * from Versions";
            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, dbConnect);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dbConnect.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conStr;
            string mySelect = "Insert into Versions(Version)Values('" + textBox2.Text +
            "')";
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbConnect.Open();
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            dbCmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            dbConnect.Close();
            DisplayData();
            comboBox1.Items.Clear();
            ExportCombo();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conStr;
            string mySelect = "UPDATE Versions SET Version = '" + textBox2.Text + "' WHERE VersionID = " + textBox1.Text;
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbConnect.Open();
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            dbCmd.ExecuteNonQuery();
            MessageBox.Show("Record Update", "Congrats");
            dbConnect.Close();
            comboBox1.Items.Clear();
            ExportCombo();

            DisplayData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conStr;
            string mySelect = "DELETE FROM Versions WHERE VersionID=" + textBox1.Text;
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbConnect.Open();
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            dbCmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete", "Congrats");
            dbConnect.Close();
            comboBox1.Items.Clear();
            ExportCombo();
            DisplayData();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.Name, column.ValueType);
            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataRow dr = dt.NewRow();
                foreach (DataGridViewTextBoxColumn column in dataGridView1.Columns)
                {
                    if (row.Cells[column.Name].Value != null)
                    {
                        dr[column.Name] = row.Cells[column.Name].Value.ToString();

                        MessageBox.Show("Yes1!!!");

                    }
                }
                dt.Rows.Add(dr);
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            string filePath = saveFileDialog1.FileName;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
            }
            DataTableToTextFile(dt, filePath);
        }
        private void DataTableToTextFile(DataTable dt, string outputFilePath)
        {
            int[] maxLengths = new int[dt.Columns.Count];
            for (int i = 0; i < dt.Columns.Count; i++)
            {

                maxLengths[i] = dt.Columns[i].ColumnName.Length;
                foreach (DataRow row in dt.Rows)
                {
                    if (!row.IsNull(i))

                    {

                        int length = row[i].ToString().Length;

                        if (length > maxLengths[i])
                        {

                            maxLengths[i] = length;
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(outputFilePath, false))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    sw.Write(dt.Columns[i].ColumnName.PadRight(maxLengths[i] + 2));
                }
                sw.WriteLine();
                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        if (!row.IsNull(i))

                        {

                            sw.Write(row[i].ToString().PadRight(maxLengths[i] + 2));
                        }
                        else
                        {

                            sw.Write(new string(' ', maxLengths[i] + 2));
                        }
                    }

                    sw.WriteLine();

                }
                sw.Close();
            }
        }
        private void dataGridView1_RowHeaderMouseClick(object sender,
        DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        private void Form1_Load(object sender, EventArgs e) { }

    }
}