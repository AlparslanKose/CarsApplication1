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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string conStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Alparslan\Documents\Cars application.accdb;Persist Security Info=True;User ID=admin";
        OleDbConnection dbConnect = new OleDbConnection();

        private void button1_Click(object sender, EventArgs e)
        {
            string mySelect = "SELECT Delivery.NumberOfDocument, Goods.Name, Delivery.DateOfDelivery, Delivery.DeliveryQuantity, Providers.CompanyName, Goods.Price " +
               " FROM Providers INNER JOIN (Goods INNER JOIN Delivery ON Goods.ProductCode = Delivery.ProductCode) ON Providers.SupplierCode = Delivery.SupplierCode" +
               " WHERE (((Delivery.DateOfDelivery)>#" + dateTimePicker1.Text + "# And (Delivery.DateOfDelivery)<#" + dateTimePicker2.Text + "#));";
            dbConnect.ConnectionString = conStr;
            dbConnect.ConnectionString = conStr;
            dbConnect.Open();
            OleDbDataAdapter adapt = new OleDbDataAdapter(mySelect, dbConnect);
            DataTable dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            dbConnect.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
