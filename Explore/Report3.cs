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
    public partial class Report3 : UserControl
    {
        private SQL sql;
        public Report3()
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
        {
            dataGridView1.Rows.Clear();

            try
            {
                sql.Query("select * from( " +
                    "select sum(Change_Branch_Fee) as fee_income" +
                    "from Customer, Rental_Transaction, Type" +
                     "where Customer.CID = Rental_Transaction.CID  and Total_Price is not null and Membership = 'n' and Type.Type_ID = Rental_Transaction.Type_Requested" +
                     "and Pickup_Branch_ID != Return_Branch_ID  and End_Date like '2022%' ) as temp" +
                     "(select sum(Change_Branch_Fee) as fee_income_lost" +
                     "from Customer, Rental_Transaction, Type" +
                     "where Customer.CID = Rental_Transaction.CID  and Total_Price is not null and Membership = 'y' and Type.Type_ID = Rental_Transaction.Type_Requested" +
                     "and Pickup_Branch_ID != Return_Branch_ID and  End_Date like '2022%' ) temp1 ");

                while (this.sql.Reader().Read())
                {
                    dataGridView1.Rows.Add(
                        this.sql.Reader()["fee_income"].ToString(),
                        this.sql.Reader()["fee_income_lost"].ToString());
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
