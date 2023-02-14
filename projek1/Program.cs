using System;
using System.Collections.Generic;

namespace projek1;

public class Program
{
   
    public static void Main()
    {
        List<User> BUser = new List<User>();
        bool key = true;

        do  
        {
            Menu(BUser);
        } while (key);
        
        

    }
  
    public static void Menu(List<User> BUsers)
    {
        Console.Clear();
        string[] menuTampilan = { "Create", "Show", "Login", "Exit" };
        


        Console.WriteLine("== BASIC AUTHENTICATION ==");
        for (int i = 0; i < menuTampilan.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {menuTampilan[i]} User");
        }

        Console.Write("Input : ");
        int pilihMenu = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        switch (pilihMenu)
        {
            case 1:
               Create MCreate = new Create(BUsers);
               
                break;
            case 2:
                Show Mshow= new Show(BUsers);
                break;
            case 3:
                Login MLogin= new Login(BUsers);
                break;
            case 4:
                System.Environment.Exit(0);
                break;
            default:
                Console.Write("\nTidak ada pilihan");
                break;
        }



    }

    //static void Masuk(int[] id, string[] FirstName, string[] LastName, string[] Username, string[] Password)
    //{

        

    //    for (int i = 0; i < id.Length; i++)
    //    {
    //        if (id[i] == 0)
    //        {
    //            id[i] = i + 1;

    //            Console.Write("First Name : ");
    //            FirstName[i] = Console.ReadLine();

    //            Console.Write("Last Name : ");
    //            LastName[i] = Console.ReadLine();

    //            Username[i] = FirstName[i].Substring(0, 2) + LastName[i].Substring(0, 2);

    //            bool check = true;
    //            do
    //            {
    //                Console.Write("Password : ");
    //                string checkPass = Console.ReadLine();
    //                if (checkPass.Length >= 8)
    //                {
    //                    if (checkPass.Any(char.IsUpper))
    //                    {
    //                        if (checkPass.Any(char.IsLower))
    //                        {
    //                            if (checkPass.Any(char.IsNumber))
    //                            {
    //                                Password[i] = checkPass;
    //                                check = false;
    //                                break;
    //                            }
    //                        }
    //                    }
    //                }
    //                Console.WriteLine("\nPassword must have at least 8 characters\r\n with at least one Capital letter, at least one lower case letter and at least one number.\n");
    //            } while (check);
    //            break;
    //        }
    //    }
    //    Console.Write("\nData user berhasil dibuat");
    //    Console.ReadKey();
        
    //}

    //static void Show(int[] id, string[] FirstName, string[] LastName, string[] Username, string[] Password)
    //{
    //    bool key = true;
    //    do
    //    {
    //        Console.Clear();

    //        Console.WriteLine("==SHOW USER==");
    //        for (int i = 0; i < id.Length; i++)
    //        {
    //            if (id[i] != 0)
    //            {
    //                Console.WriteLine("====================");
    //                Console.WriteLine("ID          : " + id[i]);
    //                Console.WriteLine("Name        : " + FirstName[i] + " " + LastName[i]);
    //                Console.WriteLine("Username    : " + Username[i]);
    //                Console.WriteLine("Password    : " + Password[i]);
    //                Console.WriteLine("====================");
    //            }
    //        }
    //        Console.WriteLine("\nMenu");
    //        string[] menuEdit = { "Edit User", "Delete User", "Back" };
    //        for (int i = 0; i < menuEdit.Length; i++)
    //        {
    //            Console.WriteLine($"{i + 1}. {menuEdit[i]}");
    //        }

    //        Console.Write("Input : ");
    //        int pilihEdit = Convert.ToInt16(Console.ReadLine());

    //        switch (pilihEdit)
    //        {
    //            case 1:
    //                Console.Write("\nID yang ingin diubah: ");
    //                int ubahId = Convert.ToInt32(Console.ReadLine());

    //                for (int i = 0; i < id.Length; i++)
    //                {
    //                    if (id.Length != null)
    //                    {
    //                        Console.Write("First Name : ");
    //                        string ubahFirst = Console.ReadLine();
    //                        FirstName[ubahId - 1] = ubahFirst;

    //                        Console.Write("Last Name : ");
    //                        string ubahLast = Console.ReadLine();
    //                        LastName[ubahId - 1] = ubahLast;

    //                        Username[i] = FirstName[i].Substring(0, 2) + LastName[i].Substring(0, 2);

    //                        Console.Write("Password : ");
    //                        string ubahPass = Console.ReadLine();
    //                        Password[ubahId - 1] = ubahPass;
    //                        break;
    //                    }
    //                }
    //                Console.Write("\nUser sudah berhasil diedit");
    //                Console.ReadKey();
    //                break;
    //            case 2:
    //                Console.Write("\nID yang ingin dihapus: ");
    //                int hapusId = Convert.ToInt32(Console.ReadLine());

    //                for (int i = 0; i < id.Length; i++)
    //                {
    //                    if (id.Length != null)
    //                    {
    //                        id[hapusId - 1] = hapusId - hapusId;
    //                        FirstName[hapusId - 1] = "";
    //                        LastName[hapusId - 1] = "";
    //                        Username[hapusId - 1] = "";
    //                        Password[hapusId - 1] = "";
    //                        break;
    //                    }
    //                }
    //                Console.Write("\nUser sudah berhasil dihapus");
    //                Console.ReadKey();
    //                break;
    //            case 3:
    //                key = false;
    //                break;
    //            default:
    //                Console.Write("\nTidak ada pilihan");
    //                Console.ReadKey();
    //                break;
    //        }
    //    } while (key);
        
    //}

    //static void Login(int[] id, string[] Username, string[] Password)
    //{
    //    Console.Clear();

    //    Console.WriteLine("==LOGIN==");
    //    Console.Write("USERNAME : ");
    //    string inputUser = Console.ReadLine();

    //    Console.Write("PASSWORD : ");
    //    string inputPass = Console.ReadLine();

    //    bool status = false;
    //    for (int i = 0; i < id.Length; i++)
    //    {
    //        if (Username[i] == inputUser && Password[i] == inputPass)
    //        {
    //            status = true;
    //            break;
    //        }
    //    }

    //    if (status == true)
    //    {
    //        Console.Write("Login Berhasil");
    //        Console.ReadKey();
    //    }
    //    else
    //    {
    //        Console.Write("Login Gagal");
    //        Console.ReadKey();
    //    }
       
    //}
}