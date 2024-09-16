using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDPrincipleExample
{
    public class Membership
    {
        public void CreateAccount(string email, string password)
        {
            //read from database 
            new DbUtility().read("");
            //password encryption
            new EncryptionUtility().Encrypt(password);
            //registration
            new EmailSender().SendRegistrationEmail(email);
        }
    }
}
