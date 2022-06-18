using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explore
{
    public partial class Report4 : UserControl
    {
        private SQL sql;
        public Report4()
        {
            InitializeComponent();
            sql = new SQL();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                sql.Query("select one.Type_Requested, total_rev_per_car_type, rev_from_returning_customers" +
                            "rom(select Type_Requested, SUM(Total_Price) as total_rev_per_car_type" +
                            "from Rental_Transaction where Total_Price is not null" +
                            "group by Type_Requested) as one," +

                           " (select Type_Requested, sum(Total_Price) as rev_from_returning_customers" +
                           "from Rental_Transaction as t" +
                             " where t.CID in (select  CID from Rental_Transaction" +
                             " where Total_Price is not null" +
                             "  group by CID" +
                               "having COUNT(cid) > 1) and Total_Price is not null" +
                               " group by Type_Requested) as two" +
                                 " where one.Type_Requested = two.Type_Requested");

                while (this.sql.Reader().Read())
                {
                    dataGridView1.Rows.Add(
                        this.sql.Reader()["Type_requested"].ToString(),
                        this.sql.Reader()["total_rev_per_car_type"].ToString(),
                        this.sql.Reader()["rev_per_returning_customer"].ToString());

                }
                this.sql.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Something Went Wrong");

            }


        }

        }
    }

