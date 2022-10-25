using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using TGG_Logic;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Net.Mail;
using System.Net;

namespace TGG_Logic
{
    public class ResetPasswordController : IResetPasswordController
    {
        private List<Employee> employees;
        private EmployeeService employeeService;
        private ResetPasswordService resetPasswordService;
        IForgotPassword forgotPasswordForm;

        public ResetPasswordController(IForgotPassword forgotPasswordForm)
        {
            this.forgotPasswordForm = forgotPasswordForm;
            employeeService = new EmployeeService();
            resetPasswordService = new ResetPasswordService();
            forgotPasswordForm.SetController(this);
        }

        public void ConfirmCode(string email, string validation)
        {
            if (resetPasswordService.CheckValidationByElement(new TGGValidation(email, validation)))
            {
                forgotPasswordForm.StatusPassword = TGG_ResetPasswordStatus.CodeConfirmed;
                forgotPasswordForm.InstructionsOrErrorLabel = "new password must contain a minimum of 8 characters.";
            }
            else
            {
                forgotPasswordForm.InstructionsOrErrorLabel= "Wrong verification code! Either the validation code is wrong, or the entered email address " +
                    $"({email}) is not in our database. " +
                    "If you think that this should not be the case, please contact an operator.";
            }
        }

        public void SendValidationEmail(string email)
        {
                try
                {
                    forgotPasswordForm.InstructionsOrErrorLabel = string.Empty;
                    employees = employeeService.GetEmployeesByElement(new Employee(email).ToBsonDocument().GetElement("email"));
                    CheckForValidEmail(email);
                    if (employees.Count != 0)
                    {
                        SendMail(email);
                    }
                    forgotPasswordForm.InstructionsOrErrorLabel = $"Verification mail has been sent to address: {email}\n" +
                        "If you cannot find the email, please check your spam or look for spelling mistakes in the " +
                        "entered mail address, otherwise please contact an operator.";
                    forgotPasswordForm.StatusPassword = TGG_ResetPasswordStatus.EmailSent;
                }
                catch (Exception ex)
                {
                    forgotPasswordForm.InstructionsOrErrorLabel = ex.Message + $"\n time: {DateTime.Now.ToString("hh:mm:ss")}";
                }

        }
        private void SendMail(string email)
        {
            var client = new SmtpClient("smtp.mailtrap.io", 2525)
            {
                Credentials = new NetworkCredential("aee2f8f4701483", "119bbc2e9eaa33"),
                EnableSsl = true
            };
            TGGValidation validationForUser = new TGGValidation(email);
            client.Send("Support@TGG.com", email, "Reset Password", $"Your confirmation code is: {validationForUser.ValidationCode}." +
                $"\nThis code is only valid for 10 minutes.");
            resetPasswordService.InsertValidationCode(validationForUser);
        }

        public void UpdatePassword()
        {
            try
            {
                if (CheckForValidPassword())
                {
                    employees[0].Password = forgotPasswordForm.Password;
                    resetPasswordService.UpdateEmployeePassword(employees[0]);
                    forgotPasswordForm.StatusPassword = TGG_ResetPasswordStatus.PasswordChanged;
                    forgotPasswordForm.InstructionsOrErrorLabel = "successfully changed password. You can now close this and return to the login screen.";
                }
            }
            catch(Exception ex)
            {
                forgotPasswordForm.InstructionsOrErrorLabel = ex.Message;
            }

        }
        private bool CheckForValidPassword()
        {
            if (forgotPasswordForm.Password.Length < 8)
            {
                throw new Exception("minimum password size is 8 characters");
            }
            if (forgotPasswordForm.Password != forgotPasswordForm.PasswordConfirmation)
            {
                throw new Exception("Passwords do not match!");
            }
            return true;
        }

        private void CheckForValidEmail(string email)
        {
            try
            {
                var addr = new MailAddress(email);
            }
            catch
            {
                throw new Exception("Email address is invalid!\nPlease check for spelling mistakes and make sure you hava an @ symbol.");
            }
        }
    }
}
