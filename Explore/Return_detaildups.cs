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
    
    public partial class Return_detail : UserControl

    {

        private SQL sql;
        private string Return_date,total_price, late_fee, reservation_price, T_ID;
        private Employee_dashboard employee_dashboard;
        public Return_detail()
        {
            InitializeComponent();
            sql = new SQL();
            return_confirm.Enabled = false; 
        }

        public void Get_employee_dashboard(Employee_dashboard employee_dashboard)
        {
            this.employee_dashboard = employee_dashboard;
            

        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.employee_dashboard.Get_return().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            // total 

            if (T_ID in this.sqlQuery()
            
            this.sql.Query("");


           total = late_fee + reservation_price;
        }

        private void panel19_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
            // the check button 
        {
            // the textbo4 is the tid text box 
            string T_ID = textBox4.Text;
            bool check = false;

            this.sql.Query("select TID from Rrental Transactions");

            while (this.sql.Reader().Read())
            {
                if (this.sql.Reader()["TID"].ToString().Equals(textBox4.Text))
                { check = true;
                    return_confirm.Enabled = true;

                    this.sql.Close();
                  
                 }
                

                else
                {
                    MessageBox.Show("error");
                    this.textBox4.Clear();

                }


            }
        }     

        private void return_confirm_Click(object sender, EventArgs e)
        {   // gets the date from the picker and updates 
             string Return_date = dateTimePicker1.Value.ToString();
             string total_price = 
           

        }
    }
}
