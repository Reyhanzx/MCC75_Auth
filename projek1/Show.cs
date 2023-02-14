using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projek1
{
    public class Show : Program
    {
        public Show() 
        {
            Console.WriteLine("==SHOW USER==");
        }
        public Show(List<User> BUsers) 
        {
            bool key = true;
            do
            {
                Console.Clear();

                Console.WriteLine("==SHOW USER==");
                

                    int i = 0;
                foreach (User n in BUsers)
                {
                    i++;
                        Console.WriteLine("====================");
                        Console.WriteLine("ID          : "  + (i));
                        Console.WriteLine("Name        : " + n.FirstName + " " + n.LastName);
                        Console.WriteLine("Username    : " + n.Username);
                        Console.WriteLine("Password    : " + n.Password);
                        Console.WriteLine("====================");
                    
                }
            
                Console.WriteLine("\nMenu");
                string[] menuEdit = { "Edit User", "Delete User", "Back" };
                for (i = 0; i < menuEdit.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menuEdit[i]}");
                }

                Console.Write("Input : ");
                int pilihEdit = Convert.ToInt16(Console.ReadLine());
                User SUsers = new User();

                switch (pilihEdit)
                {
                    case 1:
                        Console.Write("\nID yang ingin diubah: ");
                         


                        
                            if (SUsers.id != null)
                            {
                                Console.Write("First Name : ");
                                string ubahFirst = Console.ReadLine();
                                SUsers.FirstName = ubahFirst;

                                Console.Write("Last Name : ");
                                string ubahLast = Console.ReadLine();
                                SUsers.LastName = ubahLast;

                                SUsers.Username = SUsers.FirstName[..2] + SUsers.LastName[..2];

                                Console.Write("Password : ");
                                string ubahPass = Console.ReadLine();
                                SUsers.Password = ubahPass;
                                break;
                            }
                        
                        Console.Write("\nUser sudah berhasil diedit");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Write("\nID yang ingin dihapus: ");
                        int hapusId = Convert.ToInt32(Console.ReadLine());

                        
                            if (SUsers.id != null)
                            {
                                SUsers.id = hapusId - hapusId;
                                SUsers.FirstName    = "";
                                SUsers.LastName    = "";
                                SUsers.Username = "";
                                SUsers.Password = "";
                                break;
                            }
                        
                        Console.Write("\nUser sudah berhasil dihapus");
                        Console.ReadKey();
                        break;
                    case 3:
                        key = false;
                        break;
                    default:
                        Console.Write("\nTidak ada pilihan");
                        Console.ReadKey();
                        break;
                }
            } while (key);
        }
        
    }
}
