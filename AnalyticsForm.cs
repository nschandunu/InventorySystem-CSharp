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

namespace SmartInventoryTracker
{
    public partial class AnalyticsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Senuka Chandunu\Documents\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        //SqlCommand cm = new SqlCommand();
        //SqlDataReader dr;
        public AnalyticsForm()
        {
            InitializeComponent();
        }

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbIMSDataSet.tbOrder' table. You can move, or remove it, as needed.
            this.tbOrderTableAdapter.Fill(this.dbIMSDataSet.tbOrder);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyticsChart.Series[0].XValueMember = "qty";
            AnalyticsChart.Series[0].YValueMembers = "qty";

            AnalyticsChart.Series[1].XValueMember = "price";
            AnalyticsChart.Series[1].YValueMembers = "price";

            AnalyticsChart.Series[2].XValueMember = "total";
            AnalyticsChart.Series[2].YValueMembers = "total";

            AnalyticsChart.DataSource = dbIMSDataSet.tbOrder;
            AnalyticsChart.DataBind();

        }
    }
}
