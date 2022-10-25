
namespace TGG_UI
{
    partial class ForgotPassword
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
            this.labelTitleEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.buttonSendEmail = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitleEnterCode = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.panelEnterEmail = new System.Windows.Forms.Panel();
            this.labelExtraInformation = new System.Windows.Forms.Label();
            this.buttonConfirmCode = new System.Windows.Forms.Button();
            this.panelResetPassword = new System.Windows.Forms.Panel();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPass = new System.Windows.Forms.TextBox();
            this.labelEnterNewPass = new System.Windows.Forms.Label();
            this.textBoxEnterPass = new System.Windows.Forms.TextBox();
            this.buttonConfirmNewPassword = new System.Windows.Forms.Button();
            this.panelConfirmCode = new System.Windows.Forms.Panel();
            this.buttonReturn2EnterEmail = new System.Windows.Forms.Button();
            this.panelEnterEmail.SuspendLayout();
            this.panelResetPassword.SuspendLayout();
            this.panelConfirmCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitleEmail
            // 
            this.labelTitleEmail.AutoSize = true;
            this.labelTitleEmail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleEmail.Location = new System.Drawing.Point(0, 164);
            this.labelTitleEmail.Name = "labelTitleEmail";
            this.labelTitleEmail.Size = new System.Drawing.Size(205, 22);
            this.labelTitleEmail.TabIndex = 0;
            this.labelTitleEmail.Text = "Enter Email Address:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.Color.White;
            this.textBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(4, 211);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(275, 27);
            this.textBoxEmail.TabIndex = 0;
            // 
            // buttonSendEmail
            // 
            this.buttonSendEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonSendEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSendEmail.FlatAppearance.BorderSize = 0;
            this.buttonSendEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSendEmail.ForeColor = System.Drawing.Color.White;
            this.buttonSendEmail.Location = new System.Drawing.Point(4, 255);
            this.buttonSendEmail.Name = "buttonSendEmail";
            this.buttonSendEmail.Size = new System.Drawing.Size(275, 57);
            this.buttonSendEmail.TabIndex = 2;
            this.buttonSendEmail.Text = "Send Email";
            this.buttonSendEmail.UseVisualStyleBackColor = false;
            this.buttonSendEmail.Click += new System.EventHandler(this.buttonNextEmailEntered_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Arial Black", 16.2F, System.Drawing.FontStyle.Bold);
            this.buttonCancel.ForeColor = System.Drawing.Color.White;
            this.buttonCancel.Location = new System.Drawing.Point(480, -1);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(70, 67);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "X";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTitleEnterCode
            // 
            this.labelTitleEnterCode.AutoSize = true;
            this.labelTitleEnterCode.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleEnterCode.Location = new System.Drawing.Point(0, 164);
            this.labelTitleEnterCode.Name = "labelTitleEnterCode";
            this.labelTitleEnterCode.Size = new System.Drawing.Size(203, 22);
            this.labelTitleEnterCode.TabIndex = 8;
            this.labelTitleEnterCode.Text = "Enter code recieved:";
            // 
            // textBoxCode
            // 
            this.textBoxCode.BackColor = System.Drawing.Color.White;
            this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCode.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCode.Location = new System.Drawing.Point(4, 211);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(275, 28);
            this.textBoxCode.TabIndex = 0;
            // 
            // panelEnterEmail
            // 
            this.panelEnterEmail.BackColor = System.Drawing.Color.Transparent;
            this.panelEnterEmail.Controls.Add(this.labelTitleEmail);
            this.panelEnterEmail.Controls.Add(this.textBoxEmail);
            this.panelEnterEmail.Controls.Add(this.buttonSendEmail);
            this.panelEnterEmail.Location = new System.Drawing.Point(137, 57);
            this.panelEnterEmail.Name = "panelEnterEmail";
            this.panelEnterEmail.Size = new System.Drawing.Size(305, 376);
            this.panelEnterEmail.TabIndex = 11;
            this.panelEnterEmail.TabStop = true;
            // 
            // labelExtraInformation
            // 
            this.labelExtraInformation.BackColor = System.Drawing.Color.Transparent;
            this.labelExtraInformation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExtraInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.labelExtraInformation.Location = new System.Drawing.Point(136, 455);
            this.labelExtraInformation.Name = "labelExtraInformation";
            this.labelExtraInformation.Size = new System.Drawing.Size(307, 162);
            this.labelExtraInformation.TabIndex = 14;
            // 
            // buttonConfirmCode
            // 
            this.buttonConfirmCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonConfirmCode.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConfirmCode.FlatAppearance.BorderSize = 0;
            this.buttonConfirmCode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonConfirmCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmCode.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmCode.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmCode.Location = new System.Drawing.Point(4, 255);
            this.buttonConfirmCode.Name = "buttonConfirmCode";
            this.buttonConfirmCode.Size = new System.Drawing.Size(275, 57);
            this.buttonConfirmCode.TabIndex = 1;
            this.buttonConfirmCode.Text = "Confirm Code";
            this.buttonConfirmCode.UseVisualStyleBackColor = false;
            this.buttonConfirmCode.Click += new System.EventHandler(this.buttonConfirmCode_Click);
            // 
            // panelResetPassword
            // 
            this.panelResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.panelResetPassword.Controls.Add(this.labelConfirmPassword);
            this.panelResetPassword.Controls.Add(this.textBoxConfirmPass);
            this.panelResetPassword.Controls.Add(this.labelEnterNewPass);
            this.panelResetPassword.Controls.Add(this.textBoxEnterPass);
            this.panelResetPassword.Controls.Add(this.buttonConfirmNewPassword);
            this.panelResetPassword.Hide();
            this.panelResetPassword.Location = new System.Drawing.Point(137, 57);
            this.panelResetPassword.Name = "panelResetPassword";
            this.panelResetPassword.Size = new System.Drawing.Size(305, 500);
            this.panelResetPassword.TabIndex = 13;
            this.panelResetPassword.TabStop = true;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(-2, 60);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(189, 22);
            this.labelConfirmPassword.TabIndex = 10;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // textBoxConfirmPass
            // 
            this.textBoxConfirmPass.BackColor = System.Drawing.Color.White;
            this.textBoxConfirmPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConfirmPass.Location = new System.Drawing.Point(0, 85);
            this.textBoxConfirmPass.Name = "textBoxConfirmPass";
            this.textBoxConfirmPass.PasswordChar = '◍';
            this.textBoxConfirmPass.Size = new System.Drawing.Size(275, 28);
            this.textBoxConfirmPass.TabIndex = 0;
            // 
            // labelEnterNewPass
            // 
            this.labelEnterNewPass.AutoSize = true;
            this.labelEnterNewPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnterNewPass.Location = new System.Drawing.Point(0, 0);
            this.labelEnterNewPass.Name = "labelEnterNewPass";
            this.labelEnterNewPass.Size = new System.Drawing.Size(207, 22);
            this.labelEnterNewPass.TabIndex = 8;
            this.labelEnterNewPass.Text = "Enter new password:";
            // 
            // textBoxEnterPass
            // 
            this.textBoxEnterPass.BackColor = System.Drawing.Color.White;
            this.textBoxEnterPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEnterPass.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEnterPass.Location = new System.Drawing.Point(2, 25);
            this.textBoxEnterPass.Name = "textBoxEnterPass";
            this.textBoxEnterPass.PasswordChar = '◍';
            this.textBoxEnterPass.Size = new System.Drawing.Size(275, 28);
            this.textBoxEnterPass.TabIndex = 1;
            // 
            // buttonConfirmNewPassword
            // 
            this.buttonConfirmNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonConfirmNewPassword.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonConfirmNewPassword.FlatAppearance.BorderSize = 0;
            this.buttonConfirmNewPassword.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConfirmNewPassword.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmNewPassword.ForeColor = System.Drawing.Color.White;
            this.buttonConfirmNewPassword.Location = new System.Drawing.Point(2, 156);
            this.buttonConfirmNewPassword.Name = "buttonConfirmNewPassword";
            this.buttonConfirmNewPassword.Size = new System.Drawing.Size(275, 120);
            this.buttonConfirmNewPassword.TabIndex = 2;
            this.buttonConfirmNewPassword.Text = "Confirm New Password";
            this.buttonConfirmNewPassword.UseVisualStyleBackColor = false;
            this.buttonConfirmNewPassword.Click += new System.EventHandler(this.buttonConfirmNewPassword_Click);
            // 
            // panelConfirmCode
            // 
            this.panelConfirmCode.Controls.Add(this.labelTitleEnterCode);
            this.panelConfirmCode.Controls.Add(this.textBoxCode);
            this.panelConfirmCode.Controls.Add(this.buttonConfirmCode);
            this.panelConfirmCode.Controls.Add(this.buttonReturn2EnterEmail);
            this.panelConfirmCode.Hide();
            this.panelConfirmCode.Location = new System.Drawing.Point(137, 57);
            this.panelConfirmCode.Name = "panelConfirmCode";
            this.panelConfirmCode.Size = new System.Drawing.Size(305, 395);
            this.panelConfirmCode.TabIndex = 15;
            this.panelConfirmCode.TabStop = true;
            // 
            // buttonReturn2EnterEmail
            // 
            this.buttonReturn2EnterEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(179)))), ((int)(((byte)(61)))));
            this.buttonReturn2EnterEmail.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonReturn2EnterEmail.FlatAppearance.BorderSize = 0;
            this.buttonReturn2EnterEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(160)))), ((int)(((byte)(55)))));
            this.buttonReturn2EnterEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn2EnterEmail.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn2EnterEmail.ForeColor = System.Drawing.Color.White;
            this.buttonReturn2EnterEmail.Location = new System.Drawing.Point(4, 318);
            this.buttonReturn2EnterEmail.Name = "buttonReturn2EnterEmail";
            this.buttonReturn2EnterEmail.Size = new System.Drawing.Size(273, 36);
            this.buttonReturn2EnterEmail.TabIndex = 2;
            this.buttonReturn2EnterEmail.Text = "back";
            this.buttonReturn2EnterEmail.UseVisualStyleBackColor = false;
            this.buttonReturn2EnterEmail.Click += new System.EventHandler(this.buttonReturn2EnterEmail_Click);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 626);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelExtraInformation);
            this.Controls.Add(this.panelResetPassword);
            this.Controls.Add(this.panelEnterEmail);
            this.Controls.Add(this.panelConfirmCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelEnterEmail.ResumeLayout(false);
            this.panelEnterEmail.PerformLayout();
            this.panelResetPassword.ResumeLayout(false);
            this.panelResetPassword.PerformLayout();
            this.panelConfirmCode.ResumeLayout(false);
            this.panelConfirmCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitleEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Button buttonSendEmail;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTitleEnterCode;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Panel panelEnterEmail;
        private System.Windows.Forms.Button buttonConfirmCode;
        private System.Windows.Forms.Panel panelResetPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPass;
        private System.Windows.Forms.Label labelEnterNewPass;
        private System.Windows.Forms.TextBox textBoxEnterPass;
        private System.Windows.Forms.Button buttonConfirmNewPassword;
        private System.Windows.Forms.Label labelExtraInformation;
        private System.Windows.Forms.Panel panelConfirmCode;
        private System.Windows.Forms.Button buttonReturn2EnterEmail;
    }
}