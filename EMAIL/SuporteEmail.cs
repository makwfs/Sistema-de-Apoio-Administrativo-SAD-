using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMysql.EMAIL
{
    class SuporteEmail:ServerEmail
    {
        public SuporteEmail()
        {
            senderMail = "suportesistemasad@gmail.com";
            password = "S1st3m4S4d()";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeSmtpClient();
        }


    }
}
