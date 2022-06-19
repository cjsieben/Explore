﻿namespace Explore
{
    partial class Customer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.customer_driver_license = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.customer_edit = new System.Windows.Forms.Button();
            this.customer_view = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.customer_driver_license);
            this.panel5.Controls.Add(this.label3);
            this.panel5.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel5.Location = new System.Drawing.Point(23, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 45);
            this.panel5.TabIndex = 5;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.SeaShell;
            this.panel6.ForeColor = System.Drawing.Color.SeaShell;
            this.panel6.Location = new System.Drawing.Point(231, 32);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(212, 1);
            this.panel6.TabIndex = 3;
            // 
            // customer_driver_license
            // 
            this.customer_driver_license.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.customer_driver_license.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customer_driver_license.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_driver_license.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_driver_license.Location = new System.Drawing.Point(231, 8);
            this.customer_driver_license.MaxLength = 9;
            this.customer_driver_license.Name = "customer_driver_license";
            this.customer_driver_license.Size = new System.Drawing.Size(212, 22);
            this.customer_driver_license.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaShell;
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Driver\'s License Number:";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Transparent;
            this.button_add.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.button_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.ForeColor = System.Drawing.Color.SeaShell;
            this.button_add.Location = new System.Drawing.Point(221, 26);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(82, 40);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.Button_add_click);
            // 
            // customer_edit
            // 
            this.customer_edit.BackColor = System.Drawing.Color.Transparent;
            this.customer_edit.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.customer_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_edit.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_edit.Location = new System.Drawing.Point(123, 26);
            this.customer_edit.Name = "customer_edit";
            this.customer_edit.Size = new System.Drawing.Size(82, 40);
            this.customer_edit.TabIndex = 7;
            this.customer_edit.Text = "Edit";
            this.customer_edit.UseVisualStyleBackColor = false;
            this.customer_edit.Click += new System.EventHandler(this.Button_edit_click);
            // 
            // customer_view
            // 
            this.customer_view.BackColor = System.Drawing.Color.Transparent;
            this.customer_view.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.customer_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customer_view.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customer_view.ForeColor = System.Drawing.Color.SeaShell;
            this.customer_view.Location = new System.Drawing.Point(23, 26);
            this.customer_view.Name = "customer_view";
            this.customer_view.Size = new System.Drawing.Size(82, 40);
            this.customer_view.TabIndex = 8;
            this.customer_view.Text = "View";
            this.customer_view.UseVisualStyleBackColor = false;
            this.customer_view.Click += new System.EventHandler(this.Button_view_click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.customer_view);
            this.Controls.Add(this.customer_edit);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.panel5);
            this.Name = "Customer";
            this.Size = new System.Drawing.Size(790, 460);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox customer_driver_license;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button customer_edit;
        private System.Windows.Forms.Button customer_view;
    }
}
