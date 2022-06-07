﻿using System;
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
    public partial class Employee_dashboard : UserControl
    {
        private Login_page login_page;
        public Employee_dashboard()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            employee_date.Text = today.ToString("D");

            //set up panels
            this.employee_reports.Hide();
            this.employee_inventory.Hide();
            this.employee_return.Hide();
            this.employee_booking.Hide();
            this.employee_customer.Hide();
        }

        public void Get_login(Login_page login_page)
        {
            this.login_page = login_page;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            this.login_page.Show();
            this.Hide();
        }

        private void button_report_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.employee_booking.Hide();
            this.employee_return.Hide();
            this.employee_inventory.Hide();
            this.employee_reports.Show();

        }

        private void button_customer_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Show();
            this.employee_booking.Hide();
            this.employee_return.Hide();
            this.employee_inventory.Hide();
            this.employee_reports.Hide();

        }

        private void button_home_click(object sender, EventArgs e)
        {
            this.employee_home.Show();
            this.employee_customer.Hide();
            this.employee_booking.Hide();
            this.employee_return.Hide();
            this.employee_inventory.Hide();
            this.employee_reports.Hide();
        }

        private void button_booking_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.employee_booking.Show();
            this.employee_return.Hide();
            this.employee_inventory.Hide();
            this.employee_reports.Hide();
        }

        private void button_return_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.employee_booking.Hide();
            this.employee_return.Show();
            this.employee_inventory.Hide();
            this.employee_reports.Hide();
        }

        private void button_inventory_click(object sender, EventArgs e)
        {
            this.employee_home.Hide();
            this.employee_customer.Hide();
            this.employee_booking.Hide();
            this.employee_return.Hide();
            this.employee_inventory.Show();
            this.employee_reports.Hide();
        }

        private void employee_home_Load(object sender, EventArgs e)
        {

        }
    }
}
