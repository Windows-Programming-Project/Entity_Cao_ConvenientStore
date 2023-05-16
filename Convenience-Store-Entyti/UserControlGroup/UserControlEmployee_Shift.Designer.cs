namespace Convenience_Store_Entyti.UserControlGroup
{
    partial class UserControlEmployee_Shift
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
            this.dgvEmpShift = new System.Windows.Forms.DataGridView();
            this.btnCalculateSalaryEmp = new System.Windows.Forms.Button();
            this.tbMonth = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpShift)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmpShift
            // 
            this.dgvEmpShift.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmpShift.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEmpShift.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpShift.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvEmpShift.Location = new System.Drawing.Point(0, 0);
            this.dgvEmpShift.Name = "dgvEmpShift";
            this.dgvEmpShift.RowHeadersWidth = 51;
            this.dgvEmpShift.RowTemplate.Height = 24;
            this.dgvEmpShift.Size = new System.Drawing.Size(1085, 713);
            this.dgvEmpShift.TabIndex = 43;
            this.dgvEmpShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpShift_CellContentClick);
            // 
            // btnCalculateSalaryEmp
            // 
            this.btnCalculateSalaryEmp.Location = new System.Drawing.Point(1247, 38);
            this.btnCalculateSalaryEmp.Name = "btnCalculateSalaryEmp";
            this.btnCalculateSalaryEmp.Size = new System.Drawing.Size(193, 66);
            this.btnCalculateSalaryEmp.TabIndex = 44;
            this.btnCalculateSalaryEmp.Text = "Calculate TotalSalary";
            this.btnCalculateSalaryEmp.UseVisualStyleBackColor = true;
            this.btnCalculateSalaryEmp.Click += new System.EventHandler(this.btnCalculateSalaryEmp_Click);
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(1247, 147);
            this.tbMonth.Multiline = true;
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(231, 75);
            this.tbMonth.TabIndex = 45;
            // 
            // UserControlEmployee_Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.btnCalculateSalaryEmp);
            this.Controls.Add(this.dgvEmpShift);
            this.Name = "UserControlEmployee_Shift";
            this.Size = new System.Drawing.Size(1494, 713);
            this.Load += new System.EventHandler(this.UserControlEmployee_Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpShift;
        private System.Windows.Forms.Button btnCalculateSalaryEmp;
        private System.Windows.Forms.TextBox tbMonth;
    }
}
