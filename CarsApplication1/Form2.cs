using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\Users\Alparslan\Documents\Cars application.accdb"";Persist Security Info=True;User ID=admin";
        OleDbConnection dbConnect = new OleDbConnection();

        private void DisplayData()
        {
            string mySelect = "select * from Goods";
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
            string mySelect = "Insert into Goods(Name, DateOfManufacture, Durability, Price, MeasureQuantity)Values('"
                + textBox2.Text + "','"
                + dateTimePicker1.Text + "',"
                + textBox3.Text + ","
                + textBox4.Text + ",'"
                + textBox5.Text + "')";
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbConnect.Open();
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            dbCmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");
            dbConnect.Close();
            DisplayData();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conStr;
            string mySelect = "UPDATE Goods SET Name = '" + textBox2.Text + "' WHERE ProductCode = " + textBox1.Text;
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbConnect.Open();
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            dbCmd.ExecuteNonQuery();
            MessageBox.Show("Record Update", "Congrats");
            dbConnect.Close();

            DisplayData();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            dbConnect.ConnectionString = conStr;
            string mySelect = "DELETE FROM Goods WHERE ProductCode=" + textBox1.Text;
            OleDbCommand dbCmd = new OleDbCommand(mySelect, dbConnect);
            dbConnect.Open();
            dbCmd.CommandText = mySelect;
            dbCmd.Connection = dbConnect;
            dbCmd.ExecuteNonQuery();
            MessageBox.Show("Record Delete", "Congrats");
            dbConnect.Close();

            DisplayData();
        }
    }
}
