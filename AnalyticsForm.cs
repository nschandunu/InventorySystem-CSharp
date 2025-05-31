﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LiveCharts;
using LiveCharts.Wpf;

namespace SmartInventoryTracker
{
    public partial class AnalyticsForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Senuka Chandunu\Documents\dbIMS.mdf"";Integrated Security=True;Connect Timeout=30");
        //SqlCommand cm = new SqlCommand();
        //SqlDataReader dr;
        public AnalyticsForm()
        {
            InitializeComponent();
        }



        private async void button2_Click(object sender, EventArgs e)
        {
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            SeriesCollection series = new SeriesCollection();

            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\dbIMS.mdf;Integrated Security=True;Connect Timeout=30";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Year, Total FROM Revenue";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    await conn.OpenAsync();

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        if (!reader.HasRows)
                        {
                            MessageBox.Show("No data found in the Revenue table.");
                            return;
                        }

                        while (await reader.ReadAsync())
                        {
                            string year = reader["Year"].ToString();
                            int total = reader["Total"] != DBNull.Value ? Convert.ToInt32(reader["Total"]) : 0;

                            series.Add(new PieSeries
                            {
                                Title = year,
                                Values = new ChartValues<int> { total },
                                DataLabels = true,
                                LabelPoint = labelPoint,
                            });
                        }
                    }
                }

                pieChart1.Series = series;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading chart: " + ex.Message);
            }
        }



        //Func<ChartPoint, string> lablePoint = charpoint => string.Format("{0} ({1:P})", charpoint.Y, charpoint.Participation);

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Func<ChartPoint, string> lablePoint = charpoint => string.Format("{0} ({1:P})", charpoint.Y, charpoint.Participation);
        //    SeriesCollection series = new SeriesCollection();

        //    string connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\dbIMS.mdf;Integrated Security=True;Connect Timeout=30";
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = "SELECT Year, Total FROM Revenue";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        conn.Open();

        //        SqlDataReader reader = cmd.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            string year = reader["Year"].ToString();
        //            int total = Convert.ToInt32(reader["Total"]);

        //            series.Add(new PieSeries
        //            {
        //                Title = year,
        //                Values = new ChartValues<int> { total },
        //                DataLabels = true,
        //                LabelPoint = lablePoint,
        //            });
        //        }


        //        //SeriesCollection series = new SeriesCollection();
        //        //foreach (var obj in yrsData.Revenue)
        //        //    series.Add(new PieSeries() { Title = obj.Year.ToString(), Values = new ChartValues<int> { obj.Total }, DataLabels = true, LabelPoint = lablePoint });
        //        //pieChart1.Series = series;
        //    }
        //    pieChart1.Series = series;
        //}

        private void AnalyticsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbIMSDataSet.tbOrder' table. You can move, or remove it, as needed.
            this.tbOrderTableAdapter.Fill(this.dbIMSDataSet.tbOrder);
            pieChart1.LegendLocation = LegendLocation.Bottom;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalyticsChart.Series[0].XValueMember = "orderid";
            AnalyticsChart.Series[0].YValueMembers = "orderid";

            AnalyticsChart.Series[1].XValueMember = "cid";
            AnalyticsChart.Series[1].YValueMembers = "cid";

            AnalyticsChart.Series[2].XValueMember = "qty";
            AnalyticsChart.Series[2].YValueMembers = "qty";

            AnalyticsChart.DataSource = dbIMSDataSet.tbOrder;
            AnalyticsChart.DataBind();

        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
