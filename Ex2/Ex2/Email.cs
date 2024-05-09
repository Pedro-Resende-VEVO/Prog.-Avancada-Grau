using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Exerc._2
{
    class Email
    {
        private string _message;

        private MailAddress _address;

        public Email(MailAddress address, string message)
        {
            _address = address;
            _message = message;
        }

        public string toString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine(_address.ToString() + ": \n" + _message);
            return stringBuilder.ToString();
        }
    }
}
