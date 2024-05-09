using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;


namespace Exerc._2
{
    class Outlook
    {
        private string _nome;

        private MailAddress _address;

        private string _domain;

        private List<Email> _inbox;

        public Outlook(MailAddress address, string nome)
        {
            _nome = nome;
            _address = address;
            _domain = address.ToString().Split('@')[1];
            _inbox = new List<Email>();
        }


        public Email sendEmail(string message)
        {
            if (isMailServerResponding() && isDomainActive())
            {
                Email addressee = new Email(_address, message);
                receiveEmail(addressee);
                return addressee;
            }
            return null;
        }

        public void receiveEmail(Email message)
        {
            _inbox.Add(message);
        }

        private bool isDomainActive()
        {
            try
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(_domain);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private bool isMailServerResponding()
        {
            try
            {
                using (var client = new SmtpClient(_domain))
                {
                    client.Port = 25;
                    client.Timeout = 5000;
                    client.Send(new MailMessage());
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}




