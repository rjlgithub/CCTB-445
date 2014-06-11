namespace DesktopApp
{
    partial class fmViewShippers
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labShippers = new System.Windows.Forms.Label();
            this.cboShippers = new System.Windows.Forms.ComboBox();
            this.btnLookupShipper = new System.Windows.Forms.Button();
            this.labShipperID = new System.Windows.Forms.Label();
            this.tboShipperID = new System.Windows.Forms.TextBox();
            this.tboCompanyName = new System.Windows.Forms.TextBox();
            this.labCompanyName = new System.Windows.Forms.Label();
            this.tboPhone = new System.Windows.Forms.TextBox();
            this.labPhone = new System.Windows.Forms.Label();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.btnDeleteShipper = new System.Windows.Forms.Button();
            this.btnClearShippersForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labShippers
            // 
            this.labShippers.AutoSize = true;
            this.labShippers.Location = new System.Drawing.Point(43, 16);
            this.labShippers.Name = "labShippers";
            this.labShippers.Size = new System.Drawing.Size(48, 13);
            this.labShippers.TabIndex = 0;
            this.labShippers.Text = "Shippers";
            // 
            // cboShippers
            // 
            this.cboShippers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShippers.FormattingEnabled = true;
            this.cboShippers.Location = new System.Drawing.Point(109, 12);
            this.cboShippers.Name = "cboShippers";
            this.cboShippers.Size = new System.Drawing.Size(181, 21);
            this.cboShippers.TabIndex = 1;
            // 
            // btnLookupShipper
            // 
            this.btnLookupShipper.Location = new System.Drawing.Point(296, 11);
            this.btnLookupShipper.Name = "btnLookupShipper";
            this.btnLookupShipper.Size = new System.Drawing.Size(75, 22);
            this.btnLookupShipper.TabIndex = 2;
            this.btnLookupShipper.Text = "Lookup Shipper";
            this.btnLookupShipper.UseVisualStyleBackColor = true;
            this.btnLookupShipper.Click += new System.EventHandler(this.btnLookupShipper_Click);
            // 
            // labShipperID
            // 
            this.labShipperID.AutoSize = true;
            this.labShipperID.Location = new System.Drawing.Point(37, 46);
            this.labShipperID.Name = "labShipperID";
            this.labShipperID.Size = new System.Drawing.Size(54, 13);
            this.labShipperID.TabIndex = 3;
            this.labShipperID.Text = "ShipperID";
            // 
            // tboShipperID
            // 
            this.tboShipperID.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tboShipperID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tboShipperID.Location = new System.Drawing.Point(109, 46);
            this.tboShipperID.Name = "tboShipperID";
            this.tboShipperID.Size = new System.Drawing.Size(181, 13);
            this.tboShipperID.TabIndex = 4;
            this.tboShipperID.Text = "- - - ShipperID - - -";
            // 
            // tboCompanyName
            // 
            this.tboCompanyName.Location = new System.Drawing.Point(109, 79);
            this.tboCompanyName.Name = "tboCompanyName";
            this.tboCompanyName.Size = new System.Drawing.Size(181, 20);
            this.tboCompanyName.TabIndex = 6;
            // 
            // labCompanyName
            // 
            this.labCompanyName.AutoSize = true;
            this.labCompanyName.Location = new System.Drawing.Point(9, 82);
            this.labCompanyName.Name = "labCompanyName";
            this.labCompanyName.Size = new System.Drawing.Size(82, 13);
            this.labCompanyName.TabIndex = 5;
            this.labCompanyName.Text = "Company Name";
            // 
            // tboPhone
            // 
            this.tboPhone.Location = new System.Drawing.Point(109, 116);
            this.tboPhone.Name = "tboPhone";
            this.tboPhone.Size = new System.Drawing.Size(181, 20);
            this.tboPhone.TabIndex = 8;
            // 
            // labPhone
            // 
            this.labPhone.AutoSize = true;
            this.labPhone.Location = new System.Drawing.Point(53, 119);
            this.labPhone.Name = "labPhone";
            this.labPhone.Size = new System.Drawing.Size(38, 13);
            this.labPhone.TabIndex = 7;
            this.labPhone.Text = "Phone";
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.Location = new System.Drawing.Point(16, 172);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(75, 23);
            this.btnAddShipper.TabIndex = 9;
            this.btnAddShipper.Text = "Add";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.Location = new System.Drawing.Point(109, 172);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateShipper.TabIndex = 10;
            this.btnUpdateShipper.Text = "Update";
            this.btnUpdateShipper.UseVisualStyleBackColor = true;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // btnDeleteShipper
            // 
            this.btnDeleteShipper.Location = new System.Drawing.Point(206, 172);
            this.btnDeleteShipper.Name = "btnDeleteShipper";
            this.btnDeleteShipper.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteShipper.TabIndex = 11;
            this.btnDeleteShipper.Text = "Delete";
            this.btnDeleteShipper.UseVisualStyleBackColor = true;
            this.btnDeleteShipper.Click += new System.EventHandler(this.btnDeleteShipper_Click);
            // 
            // btnClearShippersForm
            // 
            this.btnClearShippersForm.Location = new System.Drawing.Point(296, 172);
            this.btnClearShippersForm.Name = "btnClearShippersForm";
            this.btnClearShippersForm.Size = new System.Drawing.Size(75, 23);
            this.btnClearShippersForm.TabIndex = 12;
            this.btnClearShippersForm.Text = "Clear";
            this.btnClearShippersForm.UseVisualStyleBackColor = true;
            this.btnClearShippersForm.Click += new System.EventHandler(this.btnClearShippersForm_Click);
            // 
            // fmViewShippers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 261);
            this.Controls.Add(this.btnClearShippersForm);
            this.Controls.Add(this.btnDeleteShipper);
            this.Controls.Add(this.btnUpdateShipper);
            this.Controls.Add(this.btnAddShipper);
            this.Controls.Add(this.tboPhone);
            this.Controls.Add(this.labPhone);
            this.Controls.Add(this.tboCompanyName);
            this.Controls.Add(this.labCompanyName);
            this.Controls.Add(this.tboShipperID);
            this.Controls.Add(this.labShipperID);
            this.Controls.Add(this.btnLookupShipper);
            this.Controls.Add(this.cboShippers);
            this.Controls.Add(this.labShippers);
            this.Name = "fmViewShippers";
            this.Text = "View/Edit Shippers";
            this.Load += new System.EventHandler(this.fmViewShippers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labShippers;
        private System.Windows.Forms.ComboBox cboShippers;
        private System.Windows.Forms.Button btnLookupShipper;
        private System.Windows.Forms.Label labShipperID;
        private System.Windows.Forms.TextBox tboShipperID;
        private System.Windows.Forms.TextBox tboCompanyName;
        private System.Windows.Forms.Label labCompanyName;
        private System.Windows.Forms.TextBox tboPhone;
        private System.Windows.Forms.Label labPhone;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.Button btnDeleteShipper;
        private System.Windows.Forms.Button btnClearShippersForm;
    }
}