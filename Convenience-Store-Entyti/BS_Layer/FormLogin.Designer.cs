namespace Convenience_Store_Entyti.BS_Layer
{
    partial class FormLogin
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
            this.UserControlAcountLoginAcountLogin1 = new Convenience_Store_Entyti.UserControlGroup.UserControlAcountLogin();
            this.SuspendLayout();
            // 
            // UserControlAcountLoginAcountLogin1
            // 
            this.UserControlAcountLoginAcountLogin1.Location = new System.Drawing.Point(123, 59);
            this.UserControlAcountLoginAcountLogin1.Name = "UserControlAcountLoginAcountLogin1";
            this.UserControlAcountLoginAcountLogin1.Size = new System.Drawing.Size(1165, 564);
            this.UserControlAcountLoginAcountLogin1.TabIndex = 0;
            this.UserControlAcountLoginAcountLogin1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1392, 617);
            this.Controls.Add(this.UserControlAcountLoginAcountLogin1);
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.Text = "FormLogin";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlGroup.UserControlAcountLogin UserControlAcountLoginAcountLogin1;
    }
}