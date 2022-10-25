using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGG_DAL;
using TGG_Model;
using MongoDB.Bson;
using MongoDB.Driver;

namespace TGG_Logic
{
    public class ResetPasswordService
    {
        private ResetPasswordDAO resetPasswordDAO;
        private EmployeeDAO employeeDAO;
        private TGGEncryption encryptionService;

        public ResetPasswordService()
        {
            resetPasswordDAO = new ResetPasswordDAO();
            encryptionService = new TGGEncryption();
            employeeDAO = new EmployeeDAO();
        }
        public void InsertValidationCode(TGGValidation validationUser)
        {
            validationUser.ValidationCode = encryptionService.HashWithSalt(validationUser.ValidationCode);
            resetPasswordDAO.AddValidationCodes(validationUser);
        }
        public bool CheckValidationByElement(TGGValidation validation)
        {
            validation.ValidationCode = encryptionService.HashWithSalt(validation.ValidationCode);
            BsonDocument validationCodeInput = validation.ToBsonDocument();
            return resetPasswordDAO.CheckValidationByElement(validationCodeInput.GetElement("email"), validationCodeInput.GetElement("validationCode"));
        }
        public void UpdateEmployeePassword(Employee employeeToUpdate)
        {
            BsonDocument filterElement = employeeToUpdate.ToBsonDocument();
            string password = employeeToUpdate.Password;
            string password2 = employeeToUpdate.Password;
            employeeToUpdate.Password = encryptionService.HashWithSalt(employeeToUpdate.Password);
            BsonDocument requiredUpdateElement = employeeToUpdate.ToBsonDocument();
            employeeDAO.UpdateEmployeePassword(filterElement.GetElement("email"), requiredUpdateElement.GetElement("password"));
        }
    }
}
