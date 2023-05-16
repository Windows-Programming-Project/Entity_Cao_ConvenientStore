namespace Convenience_Store_Entyti.DanhMuc
{
    partial class FrmEmployee
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
            this.dgvEMPLOYEE = new System.Windows.Forms.DataGridView();
            this.btnDeleteEMP = new System.Windows.Forms.Button();
            this.btnExitEMP = new System.Windows.Forms.Button();
            this.btnChangedEMP = new System.Windows.Forms.Button();
            this.btnReloadEMP = new System.Windows.Forms.Button();
            this.btnAddEMP = new System.Windows.Forms.Button();
            this.lbGenderEMP = new System.Windows.Forms.Label();
            this.lbSalaryEMP = new System.Windows.Forms.Label();
            this.lbPositionEMP = new System.Windows.Forms.Label();
            this.lbDateofBirthEMP = new System.Windows.Forms.Label();
            this.lbAddressEMP = new System.Windows.Forms.Label();
            this.lbNameEMP = new System.Windows.Forms.Label();
            this.lbPhoneEMP = new System.Windows.Forms.Label();
            this.lbEmpID = new System.Windows.Forms.Label();
            this.txtGenderEMP = new System.Windows.Forms.TextBox();
            this.txtSalaryEMP = new System.Windows.Forms.TextBox();
            this.txtPositionEMP = new System.Windows.Forms.TextBox();
            this.txtDateOfBirthEMP = new System.Windows.Forms.TextBox();
            this.txtAddressEMP = new System.Windows.Forms.TextBox();
            this.txtNameEMP = new System.Windows.Forms.TextBox();
            this.txtPhoneEMP = new System.Windows.Forms.TextBox();
            this.txtIDEmp = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPasswordAccountEmp = new System.Windows.Forms.TextBox();
            this.lbUserNameAccount = new System.Windows.Forms.Label();
            this.txtUserNameEmp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEMPLOYEE
            // 
            this.dgvEMPLOYEE.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMPLOYEE.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEMPLOYEE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMPLOYEE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvEMPLOYEE.Location = new System.Drawing.Point(0, 373);
            this.dgvEMPLOYEE.Name = "dgvEMPLOYEE";
            this.dgvEMPLOYEE.RowHeadersWidth = 51;
            this.dgvEMPLOYEE.RowTemplate.Height = 24;
            this.dgvEMPLOYEE.Size = new System.Drawing.Size(1432, 281);
            this.dgvEMPLOYEE.TabIndex = 25;
            this.dgvEMPLOYEE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEMPLOYEE_CellContentClick);
            // 
            // btnDeleteEMP
            // 
            this.btnDeleteEMP.Location = new System.Drawing.Point(804, 140);
            this.btnDeleteEMP.Name = "btnDeleteEMP";
            this.btnDeleteEMP.Size = new System.Drawing.Size(128, 45);
            this.btnDeleteEMP.TabIndex = 24;
            this.btnDeleteEMP.Text = "Delete";
            this.btnDeleteEMP.UseVisualStyleBackColor = true;
            this.btnDeleteEMP.Click += new System.EventHandler(this.btnDeleteEMP_Click);
            // 
            // btnExitEMP
            // 
            this.btnExitEMP.Location = new System.Drawing.Point(1106, 77);
            this.btnExitEMP.Name = "btnExitEMP";
            this.btnExitEMP.Size = new System.Drawing.Size(128, 45);
            this.btnExitEMP.TabIndex = 23;
            this.btnExitEMP.Text = "Exit";
            this.btnExitEMP.UseVisualStyleBackColor = true;
            this.btnExitEMP.Click += new System.EventHandler(this.btnExitEMP_Click);
            // 
            // btnChangedEMP
            // 
            this.btnChangedEMP.Location = new System.Drawing.Point(804, 77);
            this.btnChangedEMP.Name = "btnChangedEMP";
            this.btnChangedEMP.Size = new System.Drawing.Size(128, 45);
            this.btnChangedEMP.TabIndex = 22;
            this.btnChangedEMP.Text = "Changed";
            this.btnChangedEMP.UseVisualStyleBackColor = true;
            this.btnChangedEMP.Click += new System.EventHandler(this.btnChangedEMP_Click);
            // 
            // btnReloadEMP
            // 
            this.btnReloadEMP.Location = new System.Drawing.Point(1106, 13);
            this.btnReloadEMP.Name = "btnReloadEMP";
            this.btnReloadEMP.Size = new System.Drawing.Size(128, 45);
            this.btnReloadEMP.TabIndex = 21;
            this.btnReloadEMP.Text = "Reload";
            this.btnReloadEMP.UseVisualStyleBackColor = true;
            this.btnReloadEMP.Click += new System.EventHandler(this.btnReloadEMP_Click);
            // 
            // btnAddEMP
            // 
            this.btnAddEMP.Location = new System.Drawing.Point(804, 13);
            this.btnAddEMP.Name = "btnAddEMP";
            this.btnAddEMP.Size = new System.Drawing.Size(128, 45);
            this.btnAddEMP.TabIndex = 20;
            this.btnAddEMP.Text = "Add";
            this.btnAddEMP.UseVisualStyleBackColor = true;
            this.btnAddEMP.Click += new System.EventHandler(this.btnAddEMP_Click);
            // 
            // lbGenderEMP
            // 
            this.lbGenderEMP.AutoSize = true;
            this.lbGenderEMP.Location = new System.Drawing.Point(53, 237);
            this.lbGenderEMP.Name = "lbGenderEMP";
            this.lbGenderEMP.Size = new System.Drawing.Size(52, 16);
            this.lbGenderEMP.TabIndex = 18;
            this.lbGenderEMP.Text = "Gender";
            // 
            // lbSalaryEMP
            // 
            this.lbSalaryEMP.AutoSize = true;
            this.lbSalaryEMP.Location = new System.Drawing.Point(355, 237);
            this.lbSalaryEMP.Name = "lbSalaryEMP";
            this.lbSalaryEMP.Size = new System.Drawing.Size(46, 16);
            this.lbSalaryEMP.TabIndex = 17;
            this.lbSalaryEMP.Text = "Salary";
            // 
            // lbPositionEMP
            // 
            this.lbPositionEMP.AutoSize = true;
            this.lbPositionEMP.Location = new System.Drawing.Point(355, 169);
            this.lbPositionEMP.Name = "lbPositionEMP";
            this.lbPositionEMP.Size = new System.Drawing.Size(55, 16);
            this.lbPositionEMP.TabIndex = 16;
            this.lbPositionEMP.Text = "Position";
            // 
            // lbDateofBirthEMP
            // 
            this.lbDateofBirthEMP.AutoSize = true;
            this.lbDateofBirthEMP.Location = new System.Drawing.Point(53, 169);
            this.lbDateofBirthEMP.Name = "lbDateofBirthEMP";
            this.lbDateofBirthEMP.Size = new System.Drawing.Size(79, 16);
            this.lbDateofBirthEMP.TabIndex = 19;
            this.lbDateofBirthEMP.Text = "Date of Birth";
            // 
            // lbAddressEMP
            // 
            this.lbAddressEMP.AutoSize = true;
            this.lbAddressEMP.Location = new System.Drawing.Point(355, 106);
            this.lbAddressEMP.Name = "lbAddressEMP";
            this.lbAddressEMP.Size = new System.Drawing.Size(58, 16);
            this.lbAddressEMP.TabIndex = 15;
            this.lbAddressEMP.Text = "Address";
            // 
            // lbNameEMP
            // 
            this.lbNameEMP.AutoSize = true;
            this.lbNameEMP.Location = new System.Drawing.Point(53, 106);
            this.lbNameEMP.Name = "lbNameEMP";
            this.lbNameEMP.Size = new System.Drawing.Size(44, 16);
            this.lbNameEMP.TabIndex = 14;
            this.lbNameEMP.Text = "Name";
            // 
            // lbPhoneEMP
            // 
            this.lbPhoneEMP.AutoSize = true;
            this.lbPhoneEMP.Location = new System.Drawing.Point(355, 42);
            this.lbPhoneEMP.Name = "lbPhoneEMP";
            this.lbPhoneEMP.Size = new System.Drawing.Size(46, 16);
            this.lbPhoneEMP.TabIndex = 13;
            this.lbPhoneEMP.Text = "Phone";
            // 
            // lbEmpID
            // 
            this.lbEmpID.AutoSize = true;
            this.lbEmpID.Location = new System.Drawing.Point(53, 42);
            this.lbEmpID.Name = "lbEmpID";
            this.lbEmpID.Size = new System.Drawing.Size(20, 16);
            this.lbEmpID.TabIndex = 12;
            this.lbEmpID.Text = "ID";
            // 
            // txtGenderEMP
            // 
            this.txtGenderEMP.Location = new System.Drawing.Point(36, 208);
            this.txtGenderEMP.Multiline = true;
            this.txtGenderEMP.Name = "txtGenderEMP";
            this.txtGenderEMP.Size = new System.Drawing.Size(267, 45);
            this.txtGenderEMP.TabIndex = 10;
            // 
            // txtSalaryEMP
            // 
            this.txtSalaryEMP.Location = new System.Drawing.Point(338, 208);
            this.txtSalaryEMP.Multiline = true;
            this.txtSalaryEMP.Name = "txtSalaryEMP";
            this.txtSalaryEMP.Size = new System.Drawing.Size(267, 45);
            this.txtSalaryEMP.TabIndex = 9;
            // 
            // txtPositionEMP
            // 
            this.txtPositionEMP.Location = new System.Drawing.Point(338, 140);
            this.txtPositionEMP.Multiline = true;
            this.txtPositionEMP.Name = "txtPositionEMP";
            this.txtPositionEMP.Size = new System.Drawing.Size(267, 45);
            this.txtPositionEMP.TabIndex = 8;
            // 
            // txtDateOfBirthEMP
            // 
            this.txtDateOfBirthEMP.Location = new System.Drawing.Point(36, 140);
            this.txtDateOfBirthEMP.Multiline = true;
            this.txtDateOfBirthEMP.Name = "txtDateOfBirthEMP";
            this.txtDateOfBirthEMP.Size = new System.Drawing.Size(267, 45);
            this.txtDateOfBirthEMP.TabIndex = 7;
            // 
            // txtAddressEMP
            // 
            this.txtAddressEMP.Location = new System.Drawing.Point(338, 77);
            this.txtAddressEMP.Multiline = true;
            this.txtAddressEMP.Name = "txtAddressEMP";
            this.txtAddressEMP.Size = new System.Drawing.Size(267, 45);
            this.txtAddressEMP.TabIndex = 6;
            // 
            // txtNameEMP
            // 
            this.txtNameEMP.Location = new System.Drawing.Point(36, 77);
            this.txtNameEMP.Multiline = true;
            this.txtNameEMP.Name = "txtNameEMP";
            this.txtNameEMP.Size = new System.Drawing.Size(267, 45);
            this.txtNameEMP.TabIndex = 5;
            // 
            // txtPhoneEMP
            // 
            this.txtPhoneEMP.Location = new System.Drawing.Point(338, 13);
            this.txtPhoneEMP.Multiline = true;
            this.txtPhoneEMP.Name = "txtPhoneEMP";
            this.txtPhoneEMP.Size = new System.Drawing.Size(267, 45);
            this.txtPhoneEMP.TabIndex = 11;
            // 
            // txtIDEmp
            // 
            this.txtIDEmp.Location = new System.Drawing.Point(36, 13);
            this.txtIDEmp.Multiline = true;
            this.txtIDEmp.Name = "txtIDEmp";
            this.txtIDEmp.Size = new System.Drawing.Size(267, 45);
            this.txtIDEmp.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(750, 334);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 39;
            this.lbPassword.Text = "Password";
            // 
            // txtPasswordAccountEmp
            // 
            this.txtPasswordAccountEmp.Location = new System.Drawing.Point(733, 305);
            this.txtPasswordAccountEmp.Multiline = true;
            this.txtPasswordAccountEmp.Name = "txtPasswordAccountEmp";
            this.txtPasswordAccountEmp.Size = new System.Drawing.Size(267, 45);
            this.txtPasswordAccountEmp.TabIndex = 38;
            // 
            // lbUserNameAccount
            // 
            this.lbUserNameAccount.AutoSize = true;
            this.lbUserNameAccount.Location = new System.Drawing.Point(450, 334);
            this.lbUserNameAccount.Name = "lbUserNameAccount";
            this.lbUserNameAccount.Size = new System.Drawing.Size(121, 16);
            this.lbUserNameAccount.TabIndex = 37;
            this.lbUserNameAccount.Text = "Username Account";
            // 
            // txtUserNameEmp
            // 
            this.txtUserNameEmp.Location = new System.Drawing.Point(433, 305);
            this.txtUserNameEmp.Multiline = true;
            this.txtUserNameEmp.Name = "txtUserNameEmp";
            this.txtUserNameEmp.Size = new System.Drawing.Size(267, 45);
            this.txtUserNameEmp.TabIndex = 36;
            // 
            // FrmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1432, 654);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.txtPasswordAccountEmp);
            this.Controls.Add(this.lbUserNameAccount);
            this.Controls.Add(this.txtUserNameEmp);
            this.Controls.Add(this.dgvEMPLOYEE);
            this.Controls.Add(this.btnDeleteEMP);
            this.Controls.Add(this.btnExitEMP);
            this.Controls.Add(this.btnChangedEMP);
            this.Controls.Add(this.btnReloadEMP);
            this.Controls.Add(this.btnAddEMP);
            this.Controls.Add(this.lbGenderEMP);
            this.Controls.Add(this.lbSalaryEMP);
            this.Controls.Add(this.lbPositionEMP);
            this.Controls.Add(this.lbDateofBirthEMP);
            this.Controls.Add(this.lbAddressEMP);
            this.Controls.Add(this.lbNameEMP);
            this.Controls.Add(this.lbPhoneEMP);
            this.Controls.Add(this.lbEmpID);
            this.Controls.Add(this.txtGenderEMP);
            this.Controls.Add(this.txtSalaryEMP);
            this.Controls.Add(this.txtPositionEMP);
            this.Controls.Add(this.txtDateOfBirthEMP);
            this.Controls.Add(this.txtAddressEMP);
            this.Controls.Add(this.txtNameEMP);
            this.Controls.Add(this.txtPhoneEMP);
            this.Controls.Add(this.txtIDEmp);
            this.Name = "FrmEmployee";
            this.Text = "FrmEmployee";
            this.Load += new System.EventHandler(this.FrmEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMPLOYEE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEMPLOYEE;
        private System.Windows.Forms.Button btnDeleteEMP;
        private System.Windows.Forms.Button btnExitEMP;
        private System.Windows.Forms.Button btnChangedEMP;
        private System.Windows.Forms.Button btnReloadEMP;
        private System.Windows.Forms.Button btnAddEMP;
        private System.Windows.Forms.Label lbGenderEMP;
        private System.Windows.Forms.Label lbSalaryEMP;
        private System.Windows.Forms.Label lbPositionEMP;
        private System.Windows.Forms.Label lbDateofBirthEMP;
        private System.Windows.Forms.Label lbAddressEMP;
        private System.Windows.Forms.Label lbNameEMP;
        private System.Windows.Forms.Label lbPhoneEMP;
        private System.Windows.Forms.Label lbEmpID;
        private System.Windows.Forms.TextBox txtGenderEMP;
        private System.Windows.Forms.TextBox txtSalaryEMP;
        private System.Windows.Forms.TextBox txtPositionEMP;
        private System.Windows.Forms.TextBox txtDateOfBirthEMP;
        private System.Windows.Forms.TextBox txtAddressEMP;
        private System.Windows.Forms.TextBox txtNameEMP;
        private System.Windows.Forms.TextBox txtPhoneEMP;
        private System.Windows.Forms.TextBox txtIDEmp;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPasswordAccountEmp;
        private System.Windows.Forms.Label lbUserNameAccount;
        private System.Windows.Forms.TextBox txtUserNameEmp;
    }
}