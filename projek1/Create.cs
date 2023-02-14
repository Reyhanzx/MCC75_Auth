using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projek1
{
    public class Create 
    {
     

        public Create(List<User> BUsers)
        {

            User SUsers = new User();
            if (SUsers.id == 0)
            {

                SUsers.id = 1;

                Console.Write("First Name : ");
                string IFirstName = Console.ReadLine();

                Console.Write("Last Name : ");
                string ILastName = Console.ReadLine();

                string Username = IFirstName[..2] + ILastName[..2];


                SUsers.FirstName = IFirstName;
                SUsers.LastName = ILastName;
                SUsers.Username = Username;

                

                bool check = true;
                do
                {
                    Console.Write("Password : ");
                    string checkPass = Console.ReadLine();
                    if (checkPass.Length >= 8)
                    {
                        if (checkPass.Any(char.IsUpper))
                        {
                            if (checkPass.Any(char.IsLower))
                            {
                                if (checkPass.Any(char.IsNumber))
                                {
                                    SUsers.Password = checkPass;
                                    check = false;
                                    BUsers.Add(SUsers);
                                    break;
                                }
                            }
                        }
                    }
                    Console.WriteLine("\nPassword must have at least 8 characters\r\n with at least one Capital letter, at least one lower case letter and at least one number.\n");
                } while (check);
                
            }

        }
    }
}
