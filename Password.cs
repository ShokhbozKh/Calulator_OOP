using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculyator
{
    internal class Password
    {
        public void PasswordCheak()
        {
            string password = "";
            do
            {
                Console.Write("Enter Password: ");
                password = Console.ReadLine();

            } while (password!="12345");
        }



    }
}
