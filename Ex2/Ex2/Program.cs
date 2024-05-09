using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Exerc._2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Outlook objOutLook = createAccount();

            objOutLook.sendEmail("Oi");

            MailAddress mailAddress = new MailAddress("Sesas@gmail.com");
            Email email = new Email(mailAddress, "Oi");
            objOutLook.receiveEmail(email);
        }

        static Outlook createAccount()
        {
            Console.WriteLine("Insira seu nome: /n");
            string name = Console.ReadLine()!;

            Console.WriteLine("Insira o endereço de email que deseja usar: /n");
            string addressEmailStr = Console.ReadLine()!;

            if (IsValidEmailFormat(addressEmailStr))
            {
                MailAddress addressEmail = new MailAddress(addressEmailStr);
                Outlook objEmail = new Outlook(addressEmail, name);

                return objEmail;
            }
            else
            {
                Console.WriteLine("Favor tente novamente (aperte qualquer tecla para continuar");
                Console.ReadKey();
            }

            return createAccount();
        }

        static bool IsValidEmailFormat(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}

