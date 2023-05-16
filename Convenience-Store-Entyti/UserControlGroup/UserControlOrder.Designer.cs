namespace Convenience_Store_Entyti.DanhMuc
{
    partial class UserControlOrder
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
            this.txtIDEMP_order = new System.Windows.Forms.TextBox();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.dgvDetail_order = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tbnUpdateInvoice_order = new System.Windows.Forms.Button();
            this.lbEmpID_Order = new System.Windows.Forms.Label();
            this.txtCTMPhone_order = new System.Windows.Forms.TextBox();
            this.lbCustomerPhone_order = new System.Windows.Forms.Label();
            this.txtNameFind_product = new System.Windows.Forms.TextBox();
            this.txtProduct_order = new System.Windows.Forms.TextBox();
            this.txtAmountP_order = new System.Windows.Forms.TextBox();
            this.lbProduct_order = new System.Windows.Forms.Label();
            this.lbAmountP_order = new System.Windows.Forms.Label();
            this.btnAddProduct_order = new System.Windows.Forms.Button();
            this.btnReloadMenu_order = new System.Windows.Forms.Button();
            this.btnFind_order = new System.Windows.Forms.Button();
            this.btnAddInvoice_order = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail_order)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDEMP_order
            // 
            this.txtIDEMP_order.Location = new System.Drawing.Point(312, 14);
            this.txtIDEMP_order.Multiline = true;
            this.txtIDEMP_order.Name = "txtIDEMP_order";
            this.txtIDEMP_order.Size = new System.Drawing.Size(202, 42);
            this.txtIDEMP_order.TabIndex = 1;
            this.txtIDEMP_order.TextChanged += new System.EventHandler(this.txtIDEMP_order_TextChanged);
            // 
            // dgvMenu
            // 
            this.dgvMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMenu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(15, 165);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowHeadersWidth = 51;
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(697, 637);
            this.dgvMenu.TabIndex = 2;
            this.dgvMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMenu_CellContentClick);
            // 
            // dgvDetail_order
            // 
            this.dgvDetail_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDetail_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetail_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetail_order.Location = new System.Drawing.Point(833, 150);
            this.dgvDetail_order.Name = "dgvDetail_order";
            this.dgvDetail_order.RowHeadersWidth = 51;
            this.dgvDetail_order.RowTemplate.Height = 24;
            this.dgvDetail_order.Size = new System.Drawing.Size(866, 448);
            this.dgvDetail_order.TabIndex = 3;
            this.dgvDetail_order.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetail_order_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 51);
            this.label1.TabIndex = 4;
            this.label1.Text = "Menu";
            // 
            // tbnUpdateInvoice_order
            // 
            this.tbnUpdateInvoice_order.Location = new System.Drawing.Point(964, 14);
            this.tbnUpdateInvoice_order.Name = "tbnUpdateInvoice_order";
            this.tbnUpdateInvoice_order.Size = new System.Drawing.Size(145, 51);
            this.tbnUpdateInvoice_order.TabIndex = 0;
            this.tbnUpdateInvoice_order.Text = "Update invoice";
            this.tbnUpdateInvoice_order.UseVisualStyleBackColor = true;
            this.tbnUpdateInvoice_order.Click += new System.EventHandler(this.tbnUpdateInvoice_order_Click);
            // 
            // lbEmpID_Order
            // 
            this.lbEmpID_Order.AutoSize = true;
            this.lbEmpID_Order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpID_Order.Location = new System.Drawing.Point(406, 38);
            this.lbEmpID_Order.Name = "lbEmpID_Order";
            this.lbEmpID_Order.Size = new System.Drawing.Size(108, 18);
            this.lbEmpID_Order.TabIndex = 4;
            this.lbEmpID_Order.Text = "ID  Employee";
            // 
            // txtCTMPhone_order
            // 
            this.txtCTMPhone_order.Location = new System.Drawing.Point(583, 14);
            this.txtCTMPhone_order.Multiline = true;
            this.txtCTMPhone_order.Name = "txtCTMPhone_order";
            this.txtCTMPhone_order.Size = new System.Drawing.Size(212, 42);
            this.txtCTMPhone_order.TabIndex = 1;
            this.txtCTMPhone_order.TextChanged += new System.EventHandler(this.txtCTMPhone_order_TextChanged);
            // 
            // lbCustomerPhone_order
            // 
            this.lbCustomerPhone_order.AutoSize = true;
            this.lbCustomerPhone_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustomerPhone_order.Location = new System.Drawing.Point(650, 38);
            this.lbCustomerPhone_order.Name = "lbCustomerPhone_order";
            this.lbCustomerPhone_order.Size = new System.Drawing.Size(194, 18);
            this.lbCustomerPhone_order.TabIndex = 4;
            this.lbCustomerPhone_order.Text = "Customer PhoneNumber";
            // 
            // txtNameFind_product
            // 
            this.txtNameFind_product.Location = new System.Drawing.Point(537, 85);
            this.txtNameFind_product.Multiline = true;
            this.txtNameFind_product.Name = "txtNameFind_product";
            this.txtNameFind_product.Size = new System.Drawing.Size(175, 48);
            this.txtNameFind_product.TabIndex = 1;
            // 
            // txtProduct_order
            // 
            this.txtProduct_order.Location = new System.Drawing.Point(887, 91);
            this.txtProduct_order.Multiline = true;
            this.txtProduct_order.Name = "txtProduct_order";
            this.txtProduct_order.Size = new System.Drawing.Size(120, 34);
            this.txtProduct_order.TabIndex = 1;
            this.txtProduct_order.TextChanged += new System.EventHandler(this.txtProduct_order_TextChanged);
            // 
            // txtAmountP_order
            // 
            this.txtAmountP_order.Location = new System.Drawing.Point(1059, 91);
            this.txtAmountP_order.Multiline = true;
            this.txtAmountP_order.Name = "txtAmountP_order";
            this.txtAmountP_order.Size = new System.Drawing.Size(120, 34);
            this.txtAmountP_order.TabIndex = 1;
            this.txtAmountP_order.TextChanged += new System.EventHandler(this.txtAmountP_order_TextChanged);
            // 
            // lbProduct_order
            // 
            this.lbProduct_order.AutoSize = true;
            this.lbProduct_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct_order.Location = new System.Drawing.Point(940, 106);
            this.lbProduct_order.Name = "lbProduct_order";
            this.lbProduct_order.Size = new System.Drawing.Size(67, 18);
            this.lbProduct_order.TabIndex = 4;
            this.lbProduct_order.Text = "Product";
            // 
            // lbAmountP_order
            // 
            this.lbAmountP_order.AutoSize = true;
            this.lbAmountP_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountP_order.Location = new System.Drawing.Point(1114, 107);
            this.lbAmountP_order.Name = "lbAmountP_order";
            this.lbAmountP_order.Size = new System.Drawing.Size(65, 18);
            this.lbAmountP_order.TabIndex = 4;
            this.lbAmountP_order.Text = "Amount";
            // 
            // btnAddProduct_order
            // 
            this.btnAddProduct_order.Location = new System.Drawing.Point(1207, 93);
            this.btnAddProduct_order.Name = "btnAddProduct_order";
            this.btnAddProduct_order.Size = new System.Drawing.Size(95, 32);
            this.btnAddProduct_order.TabIndex = 0;
            this.btnAddProduct_order.Text = "Add ";
            this.btnAddProduct_order.UseVisualStyleBackColor = true;
            this.btnAddProduct_order.Click += new System.EventHandler(this.btnAddProduct_order_Click);
            // 
            // btnReloadMenu_order
            // 
            this.btnReloadMenu_order.Image = global::Convenience_Store_Entyti.Properties.Resources.Reload;
            this.btnReloadMenu_order.Location = new System.Drawing.Point(206, 85);
            this.btnReloadMenu_order.Margin = new System.Windows.Forms.Padding(0);
            this.btnReloadMenu_order.Name = "btnReloadMenu_order";
            this.btnReloadMenu_order.Size = new System.Drawing.Size(153, 48);
            this.btnReloadMenu_order.TabIndex = 0;
            this.btnReloadMenu_order.Text = "Reload";
            this.btnReloadMenu_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReloadMenu_order.UseVisualStyleBackColor = true;
            this.btnReloadMenu_order.Click += new System.EventHandler(this.btnReloadMenu_order_Click);
            // 
            // btnFind_order
            // 
            this.btnFind_order.Image = global::Convenience_Store_Entyti.Properties.Resources.Find;
            this.btnFind_order.Location = new System.Drawing.Point(383, 85);
            this.btnFind_order.Name = "btnFind_order";
            this.btnFind_order.Size = new System.Drawing.Size(148, 48);
            this.btnFind_order.TabIndex = 0;
            this.btnFind_order.Text = "Find";
            this.btnFind_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFind_order.UseVisualStyleBackColor = true;
            this.btnFind_order.Click += new System.EventHandler(this.btnFind_order_Click);
            // 
            // btnAddInvoice_order
            // 
            this.btnAddInvoice_order.Image = global::Convenience_Store_Entyti.Properties.Resources.add_order;
            this.btnAddInvoice_order.Location = new System.Drawing.Point(15, 14);
            this.btnAddInvoice_order.Name = "btnAddInvoice_order";
            this.btnAddInvoice_order.Size = new System.Drawing.Size(158, 51);
            this.btnAddInvoice_order.TabIndex = 0;
            this.btnAddInvoice_order.Text = "Add invoice";
            this.btnAddInvoice_order.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddInvoice_order.UseVisualStyleBackColor = true;
            this.btnAddInvoice_order.Click += new System.EventHandler(this.btnAddInvoice_order_Click);
            // 
            // UserControlOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(169)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.lbAmountP_order);
            this.Controls.Add(this.lbCustomerPhone_order);
            this.Controls.Add(this.lbProduct_order);
            this.Controls.Add(this.lbEmpID_Order);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetail_order);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.txtAmountP_order);
            this.Controls.Add(this.txtCTMPhone_order);
            this.Controls.Add(this.txtProduct_order);
            this.Controls.Add(this.txtNameFind_product);
            this.Controls.Add(this.txtIDEMP_order);
            this.Controls.Add(this.btnReloadMenu_order);
            this.Controls.Add(this.btnFind_order);
            this.Controls.Add(this.tbnUpdateInvoice_order);
            this.Controls.Add(this.btnAddProduct_order);
            this.Controls.Add(this.btnAddInvoice_order);
            this.Name = "UserControlOrder";
            this.Size = new System.Drawing.Size(1720, 1009);
            this.Load += new System.EventHandler(this.UserControlOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail_order)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddInvoice_order;
        private System.Windows.Forms.TextBox txtIDEMP_order;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.DataGridView dgvDetail_order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tbnUpdateInvoice_order;
        private System.Windows.Forms.Label lbEmpID_Order;
        private System.Windows.Forms.TextBox txtCTMPhone_order;
        private System.Windows.Forms.Label lbCustomerPhone_order;
        private System.Windows.Forms.TextBox txtNameFind_product;
        private System.Windows.Forms.Button btnFind_order;
        private System.Windows.Forms.TextBox txtProduct_order;
        private System.Windows.Forms.TextBox txtAmountP_order;
        private System.Windows.Forms.Label lbProduct_order;
        private System.Windows.Forms.Label lbAmountP_order;
        private System.Windows.Forms.Button btnAddProduct_order;
        private System.Windows.Forms.Button btnReloadMenu_order;
    }
}
