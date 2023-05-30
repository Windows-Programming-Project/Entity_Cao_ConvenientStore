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
            this.btViewShift = new Convenience_Store_Entyti.RJControl.DesignButtonControl();
            this.btEmpShiftreport = new Convenience_Store_Entyti.RJControl.DesignButtonControl();
            this.btEmpSalaryReport = new Convenience_Store_Entyti.RJControl.DesignButtonControl();
            this.btAddShift = new Convenience_Store_Entyti.RJControl.DesignButtonControl();
            this.btUpdateShift = new Convenience_Store_Entyti.RJControl.DesignButtonControl();
            this.btDeleteShift = new Convenience_Store_Entyti.RJControl.DesignButtonControl();
            this.tbShiftStart = new System.Windows.Forms.TextBox();
            this.tbShiftEnd = new System.Windows.Forms.TextBox();
            this.tbShiftID = new System.Windows.Forms.TextBox();
            this.lbShiftID = new System.Windows.Forms.Label();
            this.lbShiftStart = new System.Windows.Forms.Label();
            this.lbShiftEnd = new System.Windows.Forms.Label();
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
            this.dgvEmpShift.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpShift_CellClick);
            this.dgvEmpShift.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmpShift_CellContentClick);
            // 
            // btnCalculateSalaryEmp
            // 
            this.btnCalculateSalaryEmp.Location = new System.Drawing.Point(1496, 629);
            this.btnCalculateSalaryEmp.Name = "btnCalculateSalaryEmp";
            this.btnCalculateSalaryEmp.Size = new System.Drawing.Size(130, 49);
            this.btnCalculateSalaryEmp.TabIndex = 44;
            this.btnCalculateSalaryEmp.Text = "Calculate TotalSalary";
            this.btnCalculateSalaryEmp.UseVisualStyleBackColor = true;
            this.btnCalculateSalaryEmp.Click += new System.EventHandler(this.btnCalculateSalaryEmp_Click);
            // 
            // tbMonth
            // 
            this.tbMonth.Location = new System.Drawing.Point(1134, 561);
            this.tbMonth.Multiline = true;
            this.tbMonth.Name = "tbMonth";
            this.tbMonth.Size = new System.Drawing.Size(130, 42);
            this.tbMonth.TabIndex = 45;
            // 
            // btViewShift
            // 
            this.btViewShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btViewShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btViewShift.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btViewShift.BorderRadius = 20;
            this.btViewShift.BorderSize = 0;
            this.btViewShift.FlatAppearance.BorderSize = 0;
            this.btViewShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btViewShift.ForeColor = System.Drawing.Color.IndianRed;
            this.btViewShift.Location = new System.Drawing.Point(1424, 51);
            this.btViewShift.Name = "btViewShift";
            this.btViewShift.Size = new System.Drawing.Size(150, 40);
            this.btViewShift.TabIndex = 46;
            this.btViewShift.Text = "Shift";
            this.btViewShift.TextColor = System.Drawing.Color.IndianRed;
            this.btViewShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btViewShift.UseVisualStyleBackColor = false;
            this.btViewShift.Click += new System.EventHandler(this.btViewShift_Click);
            // 
            // btEmpShiftreport
            // 
            this.btEmpShiftreport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btEmpShiftreport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btEmpShiftreport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btEmpShiftreport.BorderRadius = 20;
            this.btEmpShiftreport.BorderSize = 0;
            this.btEmpShiftreport.FlatAppearance.BorderSize = 0;
            this.btEmpShiftreport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpShiftreport.ForeColor = System.Drawing.Color.White;
            this.btEmpShiftreport.Location = new System.Drawing.Point(1114, 638);
            this.btEmpShiftreport.Name = "btEmpShiftreport";
            this.btEmpShiftreport.Size = new System.Drawing.Size(150, 40);
            this.btEmpShiftreport.TabIndex = 46;
            this.btEmpShiftreport.Text = "Print Employee Shift";
            this.btEmpShiftreport.TextColor = System.Drawing.Color.White;
            this.btEmpShiftreport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmpShiftreport.UseVisualStyleBackColor = false;
            this.btEmpShiftreport.Click += new System.EventHandler(this.btEmpShiftreport_Click);
            // 
            // btEmpSalaryReport
            // 
            this.btEmpSalaryReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btEmpSalaryReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btEmpSalaryReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btEmpSalaryReport.BorderRadius = 20;
            this.btEmpSalaryReport.BorderSize = 0;
            this.btEmpSalaryReport.FlatAppearance.BorderSize = 0;
            this.btEmpSalaryReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEmpSalaryReport.ForeColor = System.Drawing.Color.White;
            this.btEmpSalaryReport.Location = new System.Drawing.Point(1328, 638);
            this.btEmpSalaryReport.Name = "btEmpSalaryReport";
            this.btEmpSalaryReport.Size = new System.Drawing.Size(150, 40);
            this.btEmpSalaryReport.TabIndex = 46;
            this.btEmpSalaryReport.Text = "Print Salary Employee";
            this.btEmpSalaryReport.TextColor = System.Drawing.Color.White;
            this.btEmpSalaryReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btEmpSalaryReport.UseVisualStyleBackColor = false;
            this.btEmpSalaryReport.Click += new System.EventHandler(this.btEmpSalaryReport_Click);
            // 
            // btAddShift
            // 
            this.btAddShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btAddShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btAddShift.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btAddShift.BorderRadius = 20;
            this.btAddShift.BorderSize = 0;
            this.btAddShift.FlatAppearance.BorderSize = 0;
            this.btAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddShift.ForeColor = System.Drawing.Color.IndianRed;
            this.btAddShift.Location = new System.Drawing.Point(1114, 365);
            this.btAddShift.Name = "btAddShift";
            this.btAddShift.Size = new System.Drawing.Size(150, 40);
            this.btAddShift.TabIndex = 46;
            this.btAddShift.Text = "Add Shift";
            this.btAddShift.TextColor = System.Drawing.Color.IndianRed;
            this.btAddShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAddShift.UseVisualStyleBackColor = false;
            this.btAddShift.Click += new System.EventHandler(this.btAddShift_Click);
            // 
            // btUpdateShift
            // 
            this.btUpdateShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btUpdateShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btUpdateShift.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btUpdateShift.BorderRadius = 20;
            this.btUpdateShift.BorderSize = 0;
            this.btUpdateShift.FlatAppearance.BorderSize = 0;
            this.btUpdateShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUpdateShift.ForeColor = System.Drawing.Color.IndianRed;
            this.btUpdateShift.Location = new System.Drawing.Point(1299, 365);
            this.btUpdateShift.Name = "btUpdateShift";
            this.btUpdateShift.Size = new System.Drawing.Size(150, 40);
            this.btUpdateShift.TabIndex = 46;
            this.btUpdateShift.Text = "Update Shift";
            this.btUpdateShift.TextColor = System.Drawing.Color.IndianRed;
            this.btUpdateShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btUpdateShift.UseVisualStyleBackColor = false;
            this.btUpdateShift.Click += new System.EventHandler(this.btUpdateShift_Click);
            // 
            // btDeleteShift
            // 
            this.btDeleteShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btDeleteShift.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(218)))), ((int)(((byte)(93)))));
            this.btDeleteShift.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btDeleteShift.BorderRadius = 20;
            this.btDeleteShift.BorderSize = 0;
            this.btDeleteShift.FlatAppearance.BorderSize = 0;
            this.btDeleteShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteShift.ForeColor = System.Drawing.Color.IndianRed;
            this.btDeleteShift.Location = new System.Drawing.Point(1466, 365);
            this.btDeleteShift.Name = "btDeleteShift";
            this.btDeleteShift.Size = new System.Drawing.Size(150, 40);
            this.btDeleteShift.TabIndex = 46;
            this.btDeleteShift.Text = "Delete Shift";
            this.btDeleteShift.TextColor = System.Drawing.Color.IndianRed;
            this.btDeleteShift.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btDeleteShift.UseVisualStyleBackColor = false;
            this.btDeleteShift.Click += new System.EventHandler(this.btDeleteShift_Click);
            // 
            // tbShiftStart
            // 
            this.tbShiftStart.Location = new System.Drawing.Point(1134, 126);
            this.tbShiftStart.Multiline = true;
            this.tbShiftStart.Name = "tbShiftStart";
            this.tbShiftStart.Size = new System.Drawing.Size(211, 46);
            this.tbShiftStart.TabIndex = 45;
            // 
            // tbShiftEnd
            // 
            this.tbShiftEnd.Location = new System.Drawing.Point(1135, 193);
            this.tbShiftEnd.Multiline = true;
            this.tbShiftEnd.Name = "tbShiftEnd";
            this.tbShiftEnd.Size = new System.Drawing.Size(210, 46);
            this.tbShiftEnd.TabIndex = 45;
            // 
            // tbShiftID
            // 
            this.tbShiftID.Location = new System.Drawing.Point(1134, 51);
            this.tbShiftID.Multiline = true;
            this.tbShiftID.Name = "tbShiftID";
            this.tbShiftID.Size = new System.Drawing.Size(211, 49);
            this.tbShiftID.TabIndex = 45;
            // 
            // lbShiftID
            // 
            this.lbShiftID.AutoSize = true;
            this.lbShiftID.Location = new System.Drawing.Point(1141, 84);
            this.lbShiftID.Name = "lbShiftID";
            this.lbShiftID.Size = new System.Drawing.Size(48, 16);
            this.lbShiftID.TabIndex = 47;
            this.lbShiftID.Text = "Shift ID";
            // 
            // lbShiftStart
            // 
            this.lbShiftStart.AutoSize = true;
            this.lbShiftStart.Location = new System.Drawing.Point(1141, 156);
            this.lbShiftStart.Name = "lbShiftStart";
            this.lbShiftStart.Size = new System.Drawing.Size(93, 16);
            this.lbShiftStart.TabIndex = 47;
            this.lbShiftStart.Text = "Shift StartTime";
            // 
            // lbShiftEnd
            // 
            this.lbShiftEnd.AutoSize = true;
            this.lbShiftEnd.Location = new System.Drawing.Point(1141, 223);
            this.lbShiftEnd.Name = "lbShiftEnd";
            this.lbShiftEnd.Size = new System.Drawing.Size(90, 16);
            this.lbShiftEnd.TabIndex = 47;
            this.lbShiftEnd.Text = "Shift EndTime";
            // 
            // UserControlEmployee_Shift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbShiftEnd);
            this.Controls.Add(this.lbShiftStart);
            this.Controls.Add(this.lbShiftID);
            this.Controls.Add(this.btDeleteShift);
            this.Controls.Add(this.btUpdateShift);
            this.Controls.Add(this.btAddShift);
            this.Controls.Add(this.btViewShift);
            this.Controls.Add(this.btEmpShiftreport);
            this.Controls.Add(this.btEmpSalaryReport);
            this.Controls.Add(this.tbShiftID);
            this.Controls.Add(this.tbShiftEnd);
            this.Controls.Add(this.tbShiftStart);
            this.Controls.Add(this.tbMonth);
            this.Controls.Add(this.btnCalculateSalaryEmp);
            this.Controls.Add(this.dgvEmpShift);
            this.Name = "UserControlEmployee_Shift";
            this.Size = new System.Drawing.Size(1638, 713);
            this.Load += new System.EventHandler(this.UserControlEmployee_Shift_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmpShift;
        private System.Windows.Forms.Button btnCalculateSalaryEmp;
        private System.Windows.Forms.TextBox tbMonth;
        private RJControl.DesignButtonControl btEmpSalaryReport;
        private RJControl.DesignButtonControl btEmpShiftreport;
        private RJControl.DesignButtonControl btViewShift;
        private RJControl.DesignButtonControl btAddShift;
        private RJControl.DesignButtonControl btUpdateShift;
        private RJControl.DesignButtonControl btDeleteShift;
        private System.Windows.Forms.TextBox tbShiftStart;
        private System.Windows.Forms.TextBox tbShiftEnd;
        private System.Windows.Forms.TextBox tbShiftID;
        private System.Windows.Forms.Label lbShiftID;
        private System.Windows.Forms.Label lbShiftStart;
        private System.Windows.Forms.Label lbShiftEnd;
    }
}
