using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projek1
{
    public class Login : Program
    {

        public Login(List<User> BUsersd) 
        {
            Console.Clear();

            Console.WriteLine("==LOGIN==");
            Console.Write("USERNAME : ");
            string inputUser = Console.ReadLine();

            Console.Write("PASSWORD : ");
            string inputPass = Console.ReadLine();

            bool status = false;
            foreach (User SUsers in BUsersd)
            {
                if (SUsers.Username == inputUser && SUsers.Password == inputPass)
                {
                    status = true;
                    break;
                }
            }
            

            if (status == true)
            {
                Console.Write("Login Berhasil");
                Console.ReadKey();
            }
            else
            {
                Console.Write("Login Gagal");
                Console.ReadKey();
            }
        }
        
    }
}
