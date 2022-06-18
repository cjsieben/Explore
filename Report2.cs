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
    public partial class Report2 : UserControl
    {
        private SQL sql;
        public Report2()
        {
            sql = new SQL(); // Initialize the object and create the connection
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { try

            {
                sql.Query("select Pickup_Branch_ID,sum(Total_Price) as rev from Rental_Transaction where Rental_Transaction.Total_Price is not null and End_Date like'2022%' group by Pickup_Branch_ID order by rev desc");
                dataGridView1.Rows.Clear();

                while (this.sql.Reader().Read())
                {
                    this.dataGridView1.Rows.Add(
                           this.sql.Reader()["Pick_up_Branch_Id"].ToString(),
                           this.sql.Reader()["rev"].ToString());
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
