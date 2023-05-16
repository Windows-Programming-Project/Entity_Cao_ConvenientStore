namespace Convenience_Store_Entyti.UserControlGroup
{
    partial class UserControlRanks
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
            this.dgvRank = new System.Windows.Forms.DataGridView();
            this.tbRankName = new System.Windows.Forms.TextBox();
            this.lbRankName = new System.Windows.Forms.Label();
            this.btAddRank = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDeleteRank = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrDiscount = new System.Windows.Forms.TextBox();
            this.lbrDiscount = new System.Windows.Forms.Label();
            this.btReloadRank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRank
            // 
            this.dgvRank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRank.Location = new System.Drawing.Point(81, 123);
            this.dgvRank.Name = "dgvRank";
            this.dgvRank.RowHeadersWidth = 51;
            this.dgvRank.RowTemplate.Height = 24;
            this.dgvRank.Size = new System.Drawing.Size(625, 342);
            this.dgvRank.TabIndex = 0;
            this.dgvRank.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRank_CellContentClick);
            // 
            // tbRankName
            // 
            this.tbRankName.Location = new System.Drawing.Point(815, 85);
            this.tbRankName.Multiline = true;
            this.tbRankName.Name = "tbRankName";
            this.tbRankName.Size = new System.Drawing.Size(172, 35);
            this.tbRankName.TabIndex = 1;
            // 
            // lbRankName
            // 
            this.lbRankName.AutoSize = true;
            this.lbRankName.Location = new System.Drawing.Point(943, 104);
            this.lbRankName.Name = "lbRankName";
            this.lbRankName.Size = new System.Drawing.Size(79, 16);
            this.lbRankName.TabIndex = 2;
            this.lbRankName.Text = "Rank Name";
            // 
            // btAddRank
            // 
            this.btAddRank.Location = new System.Drawing.Point(1095, 85);
            this.btAddRank.Name = "btAddRank";
            this.btAddRank.Size = new System.Drawing.Size(75, 23);
            this.btAddRank.TabIndex = 3;
            this.btAddRank.Text = "Add Rank";
            this.btAddRank.UseVisualStyleBackColor = true;
            this.btAddRank.Click += new System.EventHandler(this.btAddRank_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(1095, 123);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update Rank";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDeleteRank
            // 
            this.btDeleteRank.Location = new System.Drawing.Point(1095, 163);
            this.btDeleteRank.Name = "btDeleteRank";
            this.btDeleteRank.Size = new System.Drawing.Size(75, 23);
            this.btDeleteRank.TabIndex = 4;
            this.btDeleteRank.Text = "Delete";
            this.btDeleteRank.UseVisualStyleBackColor = true;
            this.btDeleteRank.Click += new System.EventHandler(this.btDeleteRank_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Rank";
            // 
            // tbrDiscount
            // 
            this.tbrDiscount.Location = new System.Drawing.Point(815, 151);
            this.tbrDiscount.Multiline = true;
            this.tbrDiscount.Name = "tbrDiscount";
            this.tbrDiscount.Size = new System.Drawing.Size(172, 35);
            this.tbrDiscount.TabIndex = 1;
            // 
            // lbrDiscount
            // 
            this.lbrDiscount.AutoSize = true;
            this.lbrDiscount.Location = new System.Drawing.Point(943, 170);
            this.lbrDiscount.Name = "lbrDiscount";
            this.lbrDiscount.Size = new System.Drawing.Size(59, 16);
            this.lbrDiscount.TabIndex = 2;
            this.lbrDiscount.Text = "Discount";
            // 
            // btReloadRank
            // 
            this.btReloadRank.Location = new System.Drawing.Point(1095, 204);
            this.btReloadRank.Name = "btReloadRank";
            this.btReloadRank.Size = new System.Drawing.Size(75, 23);
            this.btReloadRank.TabIndex = 4;
            this.btReloadRank.Text = "ReLoad";
            this.btReloadRank.UseVisualStyleBackColor = true;
            this.btReloadRank.Click += new System.EventHandler(this.btReloadRank_Click);
            // 
            // UserControlRanks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btReloadRank);
            this.Controls.Add(this.btDeleteRank);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAddRank);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbrDiscount);
            this.Controls.Add(this.lbRankName);
            this.Controls.Add(this.tbrDiscount);
            this.Controls.Add(this.tbRankName);
            this.Controls.Add(this.dgvRank);
            this.Name = "UserControlRanks";
            this.Size = new System.Drawing.Size(1465, 497);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRank;
        private System.Windows.Forms.TextBox tbRankName;
        private System.Windows.Forms.Label lbRankName;
        private System.Windows.Forms.Button btAddRank;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDeleteRank;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbrDiscount;
        private System.Windows.Forms.Label lbrDiscount;
        private System.Windows.Forms.Button btReloadRank;
    }
}
