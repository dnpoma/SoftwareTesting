using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailService
{
    class SystemSupportMail: MasterMailServer
    {
        public SystemSupportMail()
        {
            senderMail = "soportemonsterespegrupo1@gmail.com";
            password = "hzekyfkzuczqnbne";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }
    }
    //senderMail = "soportemonsterespegrupo1@gmail.com";
    //password = "grupo1ASDMONSTER";
}
