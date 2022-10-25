using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Logic;
using TGG_Model;

namespace TGG_UI
{
    public partial class ForgotPassword : Form, IForgotPassword
    {
        private EmployeeService employeeService;
        private ResetPasswordService resetPasswordService;
        private IResetPasswordController resetPasswordController;

        public string InstructionsOrErrorLabel { set => labelExtraInformation.Text = value; }
        public TGG_ResetPasswordStatus StatusPassword 
        { set 
            {
                //hide and show so user cannot tab to other panel and press other buttons
                if (value == TGG_ResetPasswordStatus.CodeConfirmed)
                {
                    panelResetPassword.Show();
                }
                else if (value == TGG_ResetPasswordStatus.EmailSent)
                {
                    panelEnterEmail.Hide();
                    panelConfirmCode.Show();
                }
                else if (value == TGG_ResetPasswordStatus.PasswordChanged)
                {
                    panelResetPassword.Hide();
                } 
            } 
        }

        public string Password => textBoxEnterPass.Text;

        public string PasswordConfirmation => textBoxConfirmPass.Text;

        public ForgotPassword(string emailAddress)
        {
            InitializeComponent();
            textBoxEmail.Text = emailAddress;
            employeeService = new EmployeeService();
            resetPasswordService = new ResetPasswordService();
        }
        private void buttonNextEmailEntered_Click(object sender, EventArgs e)
        {
            resetPasswordController.SendValidationEmail(textBoxEmail.Text);
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmCode_Click(object sender, EventArgs e)
        {
            resetPasswordController.ConfirmCode(textBoxEmail.Text, textBoxCode.Text);
        }

        private void buttonConfirmNewPassword_Click(object sender, EventArgs e)
        {
            resetPasswordController.UpdatePassword();
            panelConfirmCode.Hide();
        }

        public void SetController(IResetPasswordController controller)
        {
            resetPasswordController = controller;
        }

        private void buttonReturn2EnterEmail_Click(object sender, EventArgs e)
        {
            panelEnterEmail.Show();
            panelConfirmCode.Hide();
            labelExtraInformation.Text = string.Empty;
            textBoxCode.Text = string.Empty;
        }
    }
}
