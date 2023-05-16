namespace Convenience_Store_Entyti.UserControlGroup
{
    partial class UserControlAcountLogin
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUserLogin = new System.Windows.Forms.TextBox();
            this.lbPassLogin = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbUserLogin = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdBEmployeeFull = new System.Windows.Forms.RadioButton();
            this.rdBEmpPart = new System.Windows.Forms.RadioButton();
            this.rdBManager = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(633, 373);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(170, 65);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login Acount";
            // 
            // tbUserLogin
            // 
            this.tbUserLogin.Location = new System.Drawing.Point(240, 122);
            this.tbUserLogin.Multiline = true;
            this.tbUserLogin.Name = "tbUserLogin";
            this.tbUserLogin.Size = new System.Drawing.Size(563, 52);
            this.tbUserLogin.TabIndex = 2;
            this.tbUserLogin.TextChanged += new System.EventHandler(this.tbUserLogin_TextChanged);
            // 
            // lbPassLogin
            // 
            this.lbPassLogin.AutoSize = true;
            this.lbPassLogin.Location = new System.Drawing.Point(256, 255);
            this.lbPassLogin.Name = "lbPassLogin";
            this.lbPassLogin.Size = new System.Drawing.Size(70, 16);
            this.lbPassLogin.TabIndex = 1;
            this.lbPassLogin.Text = "Pass word";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(240, 219);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(563, 52);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lbUserLogin
            // 
            this.lbUserLogin.AutoSize = true;
            this.lbUserLogin.Location = new System.Drawing.Point(256, 158);
            this.lbUserLogin.Name = "lbUserLogin";
            this.lbUserLogin.Size = new System.Drawing.Size(73, 16);
            this.lbUserLogin.TabIndex = 1;
            this.lbUserLogin.Text = "User name";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(823, 373);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(170, 65);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // rdBEmployeeFull
            // 
            this.rdBEmployeeFull.AutoSize = true;
            this.rdBEmployeeFull.Location = new System.Drawing.Point(173, 347);
            this.rdBEmployeeFull.Name = "rdBEmployeeFull";
            this.rdBEmployeeFull.Size = new System.Drawing.Size(111, 20);
            this.rdBEmployeeFull.TabIndex = 3;
            this.rdBEmployeeFull.TabStop = true;
            this.rdBEmployeeFull.Text = "Emp FullTime";
            this.rdBEmployeeFull.UseVisualStyleBackColor = true;
            // 
            // rdBEmpPart
            // 
            this.rdBEmpPart.AutoSize = true;
            this.rdBEmpPart.Location = new System.Drawing.Point(173, 373);
            this.rdBEmpPart.Name = "rdBEmpPart";
            this.rdBEmpPart.Size = new System.Drawing.Size(114, 20);
            this.rdBEmpPart.TabIndex = 4;
            this.rdBEmpPart.TabStop = true;
            this.rdBEmpPart.Text = "Emp PartTime";
            this.rdBEmpPart.UseVisualStyleBackColor = true;
            // 
            // rdBManager
            // 
            this.rdBManager.AutoSize = true;
            this.rdBManager.Location = new System.Drawing.Point(173, 399);
            this.rdBManager.Name = "rdBManager";
            this.rdBManager.Size = new System.Drawing.Size(82, 20);
            this.rdBManager.TabIndex = 4;
            this.rdBManager.TabStop = true;
            this.rdBManager.Text = "Manager";
            this.rdBManager.UseVisualStyleBackColor = true;
            // 
            // UserControlAcountLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rdBManager);
            this.Controls.Add(this.rdBEmpPart);
            this.Controls.Add(this.rdBEmployeeFull);
            this.Controls.Add(this.lbUserLogin);
            this.Controls.Add(this.lbPassLogin);
            this.Controls.Add(this.tbUserLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Name = "UserControlAcountLogin";
            this.Size = new System.Drawing.Size(1076, 534);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUserLogin;
        private System.Windows.Forms.Label lbPassLogin;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbUserLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdBEmployeeFull;
        private System.Windows.Forms.RadioButton rdBEmpPart;
        private System.Windows.Forms.RadioButton rdBManager;
    }
}
