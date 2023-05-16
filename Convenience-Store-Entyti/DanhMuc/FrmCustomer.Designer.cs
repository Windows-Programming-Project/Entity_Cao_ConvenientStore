namespace Convenience_Store_Entyti.DanhMuc
{
    partial class FrmCustomer
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
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.lbPhoneCTM = new System.Windows.Forms.Label();
            this.lbTotalPayCTM = new System.Windows.Forms.Label();
            this.lbNameCTM = new System.Windows.Forms.Label();
            this.lbCTMID = new System.Windows.Forms.Label();
            this.txtPhoneCTM = new System.Windows.Forms.TextBox();
            this.txtTotalPayCTM = new System.Windows.Forms.TextBox();
            this.txtNameCTM = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtIDCTM = new System.Windows.Forms.TextBox();
            this.btnDeleteCTM = new System.Windows.Forms.Button();
            this.btnExitCTM = new System.Windows.Forms.Button();
            this.btnChangedCTM = new System.Windows.Forms.Button();
            this.btnReloadCTM = new System.Windows.Forms.Button();
            this.btnAddCTM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomer.Location = new System.Drawing.Point(0, 448);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(1579, 281);
            this.dgvCustomer.TabIndex = 16;
            this.dgvCustomer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellContentClick);
            // 
            // lbPhoneCTM
            // 
            this.lbPhoneCTM.AutoSize = true;
            this.lbPhoneCTM.Location = new System.Drawing.Point(39, 238);
            this.lbPhoneCTM.Name = "lbPhoneCTM";
            this.lbPhoneCTM.Size = new System.Drawing.Size(97, 16);
            this.lbPhoneCTM.TabIndex = 6;
            this.lbPhoneCTM.Text = "Phone Number";
            // 
            // lbTotalPayCTM
            // 
            this.lbTotalPayCTM.AutoSize = true;
            this.lbTotalPayCTM.Location = new System.Drawing.Point(39, 170);
            this.lbTotalPayCTM.Name = "lbTotalPayCTM";
            this.lbTotalPayCTM.Size = new System.Drawing.Size(65, 16);
            this.lbTotalPayCTM.TabIndex = 7;
            this.lbTotalPayCTM.Text = "Total Pay";
            // 
            // lbNameCTM
            // 
            this.lbNameCTM.AutoSize = true;
            this.lbNameCTM.Location = new System.Drawing.Point(39, 107);
            this.lbNameCTM.Name = "lbNameCTM";
            this.lbNameCTM.Size = new System.Drawing.Size(44, 16);
            this.lbNameCTM.TabIndex = 8;
            this.lbNameCTM.Text = "Name";
            // 
            // lbCTMID
            // 
            this.lbCTMID.AutoSize = true;
            this.lbCTMID.Location = new System.Drawing.Point(39, 43);
            this.lbCTMID.Name = "lbCTMID";
            this.lbCTMID.Size = new System.Drawing.Size(20, 16);
            this.lbCTMID.TabIndex = 9;
            this.lbCTMID.Text = "ID";
            // 
            // txtPhoneCTM
            // 
            this.txtPhoneCTM.Location = new System.Drawing.Point(22, 209);
            this.txtPhoneCTM.Multiline = true;
            this.txtPhoneCTM.Name = "txtPhoneCTM";
            this.txtPhoneCTM.Size = new System.Drawing.Size(267, 45);
            this.txtPhoneCTM.TabIndex = 2;
            // 
            // txtTotalPayCTM
            // 
            this.txtTotalPayCTM.Location = new System.Drawing.Point(22, 141);
            this.txtTotalPayCTM.Multiline = true;
            this.txtTotalPayCTM.Name = "txtTotalPayCTM";
            this.txtTotalPayCTM.Size = new System.Drawing.Size(267, 45);
            this.txtTotalPayCTM.TabIndex = 3;
            // 
            // txtNameCTM
            // 
            this.txtNameCTM.Location = new System.Drawing.Point(22, 78);
            this.txtNameCTM.Multiline = true;
            this.txtNameCTM.Name = "txtNameCTM";
            this.txtNameCTM.Size = new System.Drawing.Size(267, 45);
            this.txtNameCTM.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbPhoneCTM);
            this.panel1.Controls.Add(this.lbTotalPayCTM);
            this.panel1.Controls.Add(this.lbNameCTM);
            this.panel1.Controls.Add(this.lbCTMID);
            this.panel1.Controls.Add(this.txtPhoneCTM);
            this.panel1.Controls.Add(this.txtTotalPayCTM);
            this.panel1.Controls.Add(this.txtNameCTM);
            this.panel1.Controls.Add(this.txtIDCTM);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 349);
            this.panel1.TabIndex = 15;
            // 
            // txtIDCTM
            // 
            this.txtIDCTM.Location = new System.Drawing.Point(22, 14);
            this.txtIDCTM.Multiline = true;
            this.txtIDCTM.Name = "txtIDCTM";
            this.txtIDCTM.Size = new System.Drawing.Size(267, 45);
            this.txtIDCTM.TabIndex = 5;
            // 
            // btnDeleteCTM
            // 
            this.btnDeleteCTM.Location = new System.Drawing.Point(1000, 166);
            this.btnDeleteCTM.Name = "btnDeleteCTM";
            this.btnDeleteCTM.Size = new System.Drawing.Size(128, 45);
            this.btnDeleteCTM.TabIndex = 10;
            this.btnDeleteCTM.Text = "Delete";
            this.btnDeleteCTM.UseVisualStyleBackColor = true;
            this.btnDeleteCTM.Click += new System.EventHandler(this.btnDeleteCTM_Click);
            // 
            // btnExitCTM
            // 
            this.btnExitCTM.Location = new System.Drawing.Point(1302, 103);
            this.btnExitCTM.Name = "btnExitCTM";
            this.btnExitCTM.Size = new System.Drawing.Size(128, 45);
            this.btnExitCTM.TabIndex = 11;
            this.btnExitCTM.Text = "Exit";
            this.btnExitCTM.UseVisualStyleBackColor = true;
            this.btnExitCTM.Click += new System.EventHandler(this.btnExitCTM_Click);
            // 
            // btnChangedCTM
            // 
            this.btnChangedCTM.Location = new System.Drawing.Point(1000, 103);
            this.btnChangedCTM.Name = "btnChangedCTM";
            this.btnChangedCTM.Size = new System.Drawing.Size(128, 45);
            this.btnChangedCTM.TabIndex = 12;
            this.btnChangedCTM.Text = "Changed";
            this.btnChangedCTM.UseVisualStyleBackColor = true;
            this.btnChangedCTM.Click += new System.EventHandler(this.btnChangedCTM_Click);
            // 
            // btnReloadCTM
            // 
            this.btnReloadCTM.Location = new System.Drawing.Point(1302, 39);
            this.btnReloadCTM.Name = "btnReloadCTM";
            this.btnReloadCTM.Size = new System.Drawing.Size(128, 45);
            this.btnReloadCTM.TabIndex = 13;
            this.btnReloadCTM.Text = "Reload";
            this.btnReloadCTM.UseVisualStyleBackColor = true;
            this.btnReloadCTM.Click += new System.EventHandler(this.btnReloadCTM_Click);
            // 
            // btnAddCTM
            // 
            this.btnAddCTM.Location = new System.Drawing.Point(1000, 39);
            this.btnAddCTM.Name = "btnAddCTM";
            this.btnAddCTM.Size = new System.Drawing.Size(128, 45);
            this.btnAddCTM.TabIndex = 14;
            this.btnAddCTM.Text = "Add";
            this.btnAddCTM.UseVisualStyleBackColor = true;
            this.btnAddCTM.Click += new System.EventHandler(this.btnAddCTM_Click);
            // 
            // FrmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 729);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDeleteCTM);
            this.Controls.Add(this.btnExitCTM);
            this.Controls.Add(this.btnChangedCTM);
            this.Controls.Add(this.btnReloadCTM);
            this.Controls.Add(this.btnAddCTM);
            this.Name = "FrmCustomer";
            this.Text = "FrmCustomer";
            this.Load += new System.EventHandler(this.FrmCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Label lbPhoneCTM;
        private System.Windows.Forms.Label lbTotalPayCTM;
        private System.Windows.Forms.Label lbNameCTM;
        private System.Windows.Forms.Label lbCTMID;
        private System.Windows.Forms.TextBox txtPhoneCTM;
        private System.Windows.Forms.TextBox txtTotalPayCTM;
        private System.Windows.Forms.TextBox txtNameCTM;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtIDCTM;
        private System.Windows.Forms.Button btnDeleteCTM;
        private System.Windows.Forms.Button btnExitCTM;
        private System.Windows.Forms.Button btnChangedCTM;
        private System.Windows.Forms.Button btnReloadCTM;
        private System.Windows.Forms.Button btnAddCTM;
    }
}