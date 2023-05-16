namespace Convenience_Store_Entyti
{
    partial class FrmMain
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
            this.panelEvent = new System.Windows.Forms.Panel();
            this.ptbSetting = new System.Windows.Forms.PictureBox();
            this.ptbShutDown = new System.Windows.Forms.PictureBox();
            this.ptbHome = new System.Windows.Forms.PictureBox();
            this.btManuafacture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btInvoice = new System.Windows.Forms.Button();
            this.btInvoice_Detail = new System.Windows.Forms.Button();
            this.btProductManagement = new System.Windows.Forms.Button();
            this.btSupplierManagement = new System.Windows.Forms.Button();
            this.btTypeManagement = new System.Windows.Forms.Button();
            this.btAccountManagement = new System.Windows.Forms.Button();
            this.btStockManagement = new System.Windows.Forms.Button();
            this.btCustomerManagement = new System.Windows.Forms.Button();
            this.btEmployeeManagement = new System.Windows.Forms.Button();
            this.btOrder = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btEmployee_Shift = new System.Windows.Forms.Button();
            this.btEmployee_late = new System.Windows.Forms.Button();
            this.panelShowOnMainForm = new System.Windows.Forms.Panel();
            this.btnRank = new System.Windows.Forms.Button();
            this.panelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShutDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelEvent
            // 
            this.panelEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.panelEvent.Controls.Add(this.ptbSetting);
            this.panelEvent.Controls.Add(this.ptbShutDown);
            this.panelEvent.Controls.Add(this.ptbHome);
            this.panelEvent.Controls.Add(this.btManuafacture);
            this.panelEvent.Controls.Add(this.btnRank);
            this.panelEvent.Controls.Add(this.button1);
            this.panelEvent.Controls.Add(this.btInvoice);
            this.panelEvent.Controls.Add(this.btInvoice_Detail);
            this.panelEvent.Controls.Add(this.btProductManagement);
            this.panelEvent.Controls.Add(this.btSupplierManagement);
            this.panelEvent.Controls.Add(this.btTypeManagement);
            this.panelEvent.Controls.Add(this.btAccountManagement);
            this.panelEvent.Controls.Add(this.btStockManagement);
            this.panelEvent.Controls.Add(this.btCustomerManagement);
            this.panelEvent.Controls.Add(this.btEmployeeManagement);
            this.panelEvent.Controls.Add(this.btOrder);
            this.panelEvent.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEvent.Location = new System.Drawing.Point(0, 0);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(310, 1080);
            this.panelEvent.TabIndex = 2;
            // 
            // ptbSetting
            // 
            this.ptbSetting.Image = global::Convenience_Store_Entyti.Properties.Resources.setting;
            this.ptbSetting.Location = new System.Drawing.Point(12, 1032);
            this.ptbSetting.Name = "ptbSetting";
            this.ptbSetting.Size = new System.Drawing.Size(44, 27);
            this.ptbSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbSetting.TabIndex = 2;
            this.ptbSetting.TabStop = false;
            this.ptbSetting.Click += new System.EventHandler(this.ptbShutDown_Click);
            // 
            // ptbShutDown
            // 
            this.ptbShutDown.Image = global::Convenience_Store_Entyti.Properties.Resources.shutdown1;
            this.ptbShutDown.Location = new System.Drawing.Point(260, 1032);
            this.ptbShutDown.Name = "ptbShutDown";
            this.ptbShutDown.Size = new System.Drawing.Size(44, 27);
            this.ptbShutDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbShutDown.TabIndex = 2;
            this.ptbShutDown.TabStop = false;
            this.ptbShutDown.Click += new System.EventHandler(this.ptbShutDown_Click);
            // 
            // ptbHome
            // 
            this.ptbHome.Image = global::Convenience_Store_Entyti.Properties.Resources.homeStore;
            this.ptbHome.Location = new System.Drawing.Point(12, 12);
            this.ptbHome.Name = "ptbHome";
            this.ptbHome.Size = new System.Drawing.Size(156, 112);
            this.ptbHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHome.TabIndex = 2;
            this.ptbHome.TabStop = false;
            // 
            // btManuafacture
            // 
            this.btManuafacture.FlatAppearance.BorderSize = 0;
            this.btManuafacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btManuafacture.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManuafacture.ForeColor = System.Drawing.Color.White;
            this.btManuafacture.Image = global::Convenience_Store_Entyti.Properties.Resources.manuafacture;
            this.btManuafacture.Location = new System.Drawing.Point(-1, 503);
            this.btManuafacture.Name = "btManuafacture";
            this.btManuafacture.Size = new System.Drawing.Size(245, 44);
            this.btManuafacture.TabIndex = 0;
            this.btManuafacture.Text = "Manuafacture";
            this.btManuafacture.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btManuafacture.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btManuafacture.UseVisualStyleBackColor = true;
            this.btManuafacture.Click += new System.EventHandler(this.btManuafacture_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Convenience_Store_Entyti.Properties.Resources.Invoice;
            this.button1.Location = new System.Drawing.Point(12, 668);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Analysis ";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btInvoice
            // 
            this.btInvoice.FlatAppearance.BorderSize = 0;
            this.btInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInvoice.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInvoice.ForeColor = System.Drawing.Color.White;
            this.btInvoice.Image = global::Convenience_Store_Entyti.Properties.Resources.Invoice;
            this.btInvoice.Location = new System.Drawing.Point(12, 603);
            this.btInvoice.Name = "btInvoice";
            this.btInvoice.Size = new System.Drawing.Size(200, 44);
            this.btInvoice.TabIndex = 0;
            this.btInvoice.Text = "Invoice";
            this.btInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInvoice.UseVisualStyleBackColor = true;
            this.btInvoice.Click += new System.EventHandler(this.btInvoice_Click);
            // 
            // btInvoice_Detail
            // 
            this.btInvoice_Detail.FlatAppearance.BorderSize = 0;
            this.btInvoice_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInvoice_Detail.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInvoice_Detail.ForeColor = System.Drawing.Color.White;
            this.btInvoice_Detail.Image = global::Convenience_Store_Entyti.Properties.Resources.invoice_detail;
            this.btInvoice_Detail.Location = new System.Drawing.Point(-1, 553);
            this.btInvoice_Detail.Name = "btInvoice_Detail";
            this.btInvoice_Detail.Size = new System.Drawing.Size(257, 44);
            this.btInvoice_Detail.TabIndex = 0;
            this.btInvoice_Detail.Text = "Invoice Detail";
            this.btInvoice_Detail.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btInvoice_Detail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btInvoice_Detail.UseVisualStyleBackColor = true;
            this.btInvoice_Detail.Click += new System.EventHandler(this.btInvoice_Detail_Click);
            // 
            // btProductManagement
            // 
            this.btProductManagement.FlatAppearance.BorderSize = 0;
            this.btProductManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProductManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProductManagement.ForeColor = System.Drawing.Color.White;
            this.btProductManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.product;
            this.btProductManagement.Location = new System.Drawing.Point(-1, 453);
            this.btProductManagement.Name = "btProductManagement";
            this.btProductManagement.Size = new System.Drawing.Size(200, 44);
            this.btProductManagement.TabIndex = 0;
            this.btProductManagement.Text = "Product";
            this.btProductManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btProductManagement.UseVisualStyleBackColor = true;
            this.btProductManagement.Click += new System.EventHandler(this.btProductManagement_Click);
            // 
            // btSupplierManagement
            // 
            this.btSupplierManagement.FlatAppearance.BorderSize = 0;
            this.btSupplierManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupplierManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupplierManagement.ForeColor = System.Drawing.Color.White;
            this.btSupplierManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.supplier;
            this.btSupplierManagement.Location = new System.Drawing.Point(-1, 403);
            this.btSupplierManagement.Name = "btSupplierManagement";
            this.btSupplierManagement.Size = new System.Drawing.Size(200, 44);
            this.btSupplierManagement.TabIndex = 0;
            this.btSupplierManagement.Text = "Supplier";
            this.btSupplierManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSupplierManagement.UseVisualStyleBackColor = true;
            this.btSupplierManagement.Click += new System.EventHandler(this.btSupplierManagement_Click);
            // 
            // btTypeManagement
            // 
            this.btTypeManagement.FlatAppearance.BorderSize = 0;
            this.btTypeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTypeManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTypeManagement.ForeColor = System.Drawing.Color.White;
            this.btTypeManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.types;
            this.btTypeManagement.Location = new System.Drawing.Point(-1, 353);
            this.btTypeManagement.Name = "btTypeManagement";
            this.btTypeManagement.Size = new System.Drawing.Size(200, 44);
            this.btTypeManagement.TabIndex = 0;
            this.btTypeManagement.Text = "Type";
            this.btTypeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btTypeManagement.UseVisualStyleBackColor = true;
            this.btTypeManagement.Click += new System.EventHandler(this.btTypeManagement_Click);
            // 
            // btAccountManagement
            // 
            this.btAccountManagement.FlatAppearance.BorderSize = 0;
            this.btAccountManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAccountManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAccountManagement.ForeColor = System.Drawing.Color.White;
            this.btAccountManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.account;
            this.btAccountManagement.Location = new System.Drawing.Point(32, 811);
            this.btAccountManagement.Name = "btAccountManagement";
            this.btAccountManagement.Size = new System.Drawing.Size(200, 44);
            this.btAccountManagement.TabIndex = 0;
            this.btAccountManagement.Text = "Account";
            this.btAccountManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAccountManagement.UseVisualStyleBackColor = true;
            this.btAccountManagement.Click += new System.EventHandler(this.btAccountManagement_Click);
            // 
            // btStockManagement
            // 
            this.btStockManagement.FlatAppearance.BorderSize = 0;
            this.btStockManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStockManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStockManagement.ForeColor = System.Drawing.Color.White;
            this.btStockManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.stock;
            this.btStockManagement.Location = new System.Drawing.Point(0, 303);
            this.btStockManagement.Name = "btStockManagement";
            this.btStockManagement.Size = new System.Drawing.Size(200, 44);
            this.btStockManagement.TabIndex = 0;
            this.btStockManagement.Text = "Stock";
            this.btStockManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btStockManagement.UseVisualStyleBackColor = true;
            this.btStockManagement.Click += new System.EventHandler(this.btStockManagement_Click);
            // 
            // btCustomerManagement
            // 
            this.btCustomerManagement.FlatAppearance.BorderSize = 0;
            this.btCustomerManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCustomerManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCustomerManagement.ForeColor = System.Drawing.Color.White;
            this.btCustomerManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.customer;
            this.btCustomerManagement.Location = new System.Drawing.Point(-1, 253);
            this.btCustomerManagement.Name = "btCustomerManagement";
            this.btCustomerManagement.Size = new System.Drawing.Size(200, 44);
            this.btCustomerManagement.TabIndex = 0;
            this.btCustomerManagement.Text = "Customer";
            this.btCustomerManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btCustomerManagement.UseVisualStyleBackColor = true;
            this.btCustomerManagement.Click += new System.EventHandler(this.btCustomerManagement_Click);
            // 
            // btEmployeeManagement
            // 
            this.btEmployeeManagement.FlatAppearance.BorderSize = 0;
            this.btEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployeeManagement.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btEmployeeManagement.Image = global::Convenience_Store_Entyti.Properties.Resources.employee1;
            this.btEmployeeManagement.Location = new System.Drawing.Point(0, 203);
            this.btEmployeeManagement.Name = "btEmployeeManagement";
            this.btEmployeeManagement.Size = new System.Drawing.Size(200, 44);
            this.btEmployeeManagement.TabIndex = 0;
            this.btEmployeeManagement.Text = "Employee";
            this.btEmployeeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmployeeManagement.UseVisualStyleBackColor = true;
            this.btEmployeeManagement.Click += new System.EventHandler(this.btEmployeeManagement_Click);
            // 
            // btOrder
            // 
            this.btOrder.FlatAppearance.BorderSize = 0;
            this.btOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrder.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrder.ForeColor = System.Drawing.Color.White;
            this.btOrder.Image = global::Convenience_Store_Entyti.Properties.Resources.order;
            this.btOrder.Location = new System.Drawing.Point(12, 153);
            this.btOrder.Name = "btOrder";
            this.btOrder.Size = new System.Drawing.Size(200, 44);
            this.btOrder.TabIndex = 0;
            this.btOrder.Text = "Order";
            this.btOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btOrder.UseVisualStyleBackColor = true;
            this.btOrder.Click += new System.EventHandler(this.btOrder_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
            this.panelTop.Controls.Add(this.btEmployee_Shift);
            this.panelTop.Controls.Add(this.btEmployee_late);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(310, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1610, 71);
            this.panelTop.TabIndex = 3;
            // 
            // btEmployee_Shift
            // 
            this.btEmployee_Shift.FlatAppearance.BorderSize = 0;
            this.btEmployee_Shift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployee_Shift.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee_Shift.ForeColor = System.Drawing.Color.White;
            this.btEmployee_Shift.Image = global::Convenience_Store_Entyti.Properties.Resources.employee1;
            this.btEmployee_Shift.Location = new System.Drawing.Point(349, 12);
            this.btEmployee_Shift.Name = "btEmployee_Shift";
            this.btEmployee_Shift.Size = new System.Drawing.Size(346, 44);
            this.btEmployee_Shift.TabIndex = 0;
            this.btEmployee_Shift.Text = "Employee  Shift";
            this.btEmployee_Shift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmployee_Shift.UseVisualStyleBackColor = true;
            this.btEmployee_Shift.Visible = false;
            this.btEmployee_Shift.Click += new System.EventHandler(this.btEmployee_Shift_Click);
            // 
            // btEmployee_late
            // 
            this.btEmployee_late.FlatAppearance.BorderSize = 0;
            this.btEmployee_late.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmployee_late.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmployee_late.ForeColor = System.Drawing.Color.White;
            this.btEmployee_late.Image = global::Convenience_Store_Entyti.Properties.Resources.employee1;
            this.btEmployee_late.Location = new System.Drawing.Point(24, 12);
            this.btEmployee_late.Name = "btEmployee_late";
            this.btEmployee_late.Size = new System.Drawing.Size(406, 44);
            this.btEmployee_late.TabIndex = 0;
            this.btEmployee_late.Text = "Employee Late";
            this.btEmployee_late.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmployee_late.UseVisualStyleBackColor = true;
            this.btEmployee_late.Visible = false;
            this.btEmployee_late.Click += new System.EventHandler(this.btEmployee_late_Click);
            // 
            // panelShowOnMainForm
            // 
            this.panelShowOnMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelShowOnMainForm.Location = new System.Drawing.Point(310, 71);
            this.panelShowOnMainForm.Name = "panelShowOnMainForm";
            this.panelShowOnMainForm.Size = new System.Drawing.Size(1610, 1009);
            this.panelShowOnMainForm.TabIndex = 4;
            // 
            // btnRank
            // 
            this.btnRank.FlatAppearance.BorderSize = 0;
            this.btnRank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRank.Font = new System.Drawing.Font("Dubai", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRank.ForeColor = System.Drawing.Color.White;
            this.btnRank.Image = global::Convenience_Store_Entyti.Properties.Resources.Invoice;
            this.btnRank.Location = new System.Drawing.Point(21, 737);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(200, 44);
            this.btnRank.TabIndex = 0;
            this.btnRank.Text = "Ranks";
            this.btnRank.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panelShowOnMainForm);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelEvent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.Text = "Managerment ConvinienceStore";
            this.panelEvent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbShutDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHome)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOrder;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelShowOnMainForm;
        private System.Windows.Forms.PictureBox ptbHome;
        private System.Windows.Forms.PictureBox ptbShutDown;
        private System.Windows.Forms.PictureBox ptbSetting;
        private System.Windows.Forms.Button btTypeManagement;
        private System.Windows.Forms.Button btAccountManagement;
        private System.Windows.Forms.Button btStockManagement;
        private System.Windows.Forms.Button btCustomerManagement;
        private System.Windows.Forms.Button btEmployeeManagement;
        private System.Windows.Forms.Button btManuafacture;
        private System.Windows.Forms.Button btInvoice_Detail;
        private System.Windows.Forms.Button btProductManagement;
        private System.Windows.Forms.Button btSupplierManagement;
        private System.Windows.Forms.Button btInvoice;
        private System.Windows.Forms.Button btEmployee_Shift;
        private System.Windows.Forms.Button btEmployee_late;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRank;
    }
}

