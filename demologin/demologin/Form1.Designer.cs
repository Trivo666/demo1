
namespace demologin
{
    partial class Form1
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
            this.lbluser = new System.Windows.Forms.Label();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.lblpw = new System.Windows.Forms.Label();
            this.txtpw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(166, 68);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(53, 13);
            this.lbluser.TabIndex = 0;
            this.lbluser.Text = "username";
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(243, 65);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(228, 20);
            this.txtuser.TabIndex = 1;
            // 
            // lblpw
            // 
            this.lblpw.AutoSize = true;
            this.lblpw.Location = new System.Drawing.Point(166, 96);
            this.lblpw.Name = "lblpw";
            this.lblpw.Size = new System.Drawing.Size(52, 13);
            this.lblpw.TabIndex = 2;
            this.lblpw.Text = "password";
            // 
            // txtpw
            // 
            this.txtpw.Location = new System.Drawing.Point(243, 96);
            this.txtpw.Name = "txtpw";
            this.txtpw.Size = new System.Drawing.Size(228, 20);
            this.txtpw.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtpw);
            this.Controls.Add(this.lblpw);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.lbluser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.Label lblpw;
        private System.Windows.Forms.TextBox txtpw;
    }
}

