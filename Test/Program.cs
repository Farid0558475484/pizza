using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Test.Models;

namespace Test
{
    class MainClass
    {
        static List<Pizza> pizzas = new List<Pizza>();

        static void Main(string[] args)
        {
            #region List
            //List<User> users = new List<User>();
            //users.Add(new User { Username = Console.ReadLine(), Password = Console.ReadLine() });
            //users.Add(new User { Username = "farid", Password = "farid" });


            //using (StreamWriter sw = new StreamWriter("/Users/xamyak/Desktop/Test/Test/Files/users.json"))
            //{
            //    sw.Write(JsonConvert.SerializeObject(users));

            //}


            //List<Product> products = new List<Product>();
            //products.Add(new Product { Name = "Marqarita" });



            //using (StreamReader sw = new StreamReader("/Users/xamyak/Desktop/Test/Test/Files/Product.json"))
            //{
            //    sw.Write(JsonConvert.SerializeObject(products));

            //}

            #endregion
            Console.WriteLine("Input : Write 1");
            Console.WriteLine("Registration : Write 0");
            int key = Convert.ToInt32(Console.ReadLine());
            if (key == 0)
            {
           // Registration:
               
                Console.WriteLine("Welcome go to register");

                List<User> users = new List<User>();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Surname: ");
                string surname = Console.ReadLine();
                Console.Write("Username: ");
                string username = Console.ReadLine();
                Console.Write("Password: ");
                string password = Console.ReadLine();

                users.Add(new User { Name = name, Surname = surname, Username = username, Password = password });

               using (StreamWriter sw = new StreamWriter("/Users/xamyak/Desktop/Test/Test/Files/users.json",true))
                {
                    sw.Write(JsonConvert.SerializeObject(users));
                   //goto Input();
                }

                Console.WriteLine("welcom");
              
            }
            else if (key == 1)
            {

                {
                Input:
                    Console.Write("Username: ");
                    string username = Console.ReadLine();

                    Console.Write("Password: ");
                    string password = Console.ReadLine();

                    List<User> users = new List<User>();

                    using (StreamReader sr = new StreamReader("/Users/xamyak/Desktop/Test/Test/Files/users.json",true))
                    {
                        users = JsonConvert.DeserializeObject<List<User>>(sr.ReadToEnd());
                    }
                    User user = users.Find(u => u.Username == username && u.Password == password);
                    if (user == null)
                    {
                        Console.WriteLine("Username ve ya parol sefdi");
                        goto Input;
                    }

                    Console.WriteLine("Welcome");
                    Console.WriteLine("1.Pizza elava et");
                    Console.WriteLine("2.Pizzala bax");
                    Console.WriteLine("3.Duzelis et Pizzalara");
                    Console.WriteLine("4.Pizzalari sil");

                    AddPizza("Marqarita");
                    AddPizza("Vegetarian");
                    AddPizza("SFungi Kon Pollo");
                    AddPizza("Speçiale");
                    AddPizza("Salyami");
                    AddPizza("Meqa Miks");
                    AddPizza("Klassiko");
                    AddPizza("Amerikana");
                    AddPizza("Sucuk");
                    AddPizza("Delyuks");

                Menu:
                    int key2 = Convert.ToInt32(Console.ReadLine());
                    if (key2 == 1)
                    {
                        AddPizza(Console.ReadLine());

                        goto Menu;
                    }
                    else if (key2 == 2)
                    {
                        GetPizza();
                        goto Menu;

                    }
                    else if (key2 == 3)
                    {
                        ChangePizza();
                        goto Menu;

                    }
                    else if (key2 == 4)
                    {
                        DeletePizza();
                        goto Menu;

                    }

                }
            }
        }
        static void AddPizza(string pizzaName)
        {
            pizzas.Add(new Pizza
            {
                Name = pizzaName
            });
        }
        private static void GetPizza()
        {
            foreach (Pizza item in pizzas)
            {
                Console.WriteLine(item.Id + " " + item.Name);

            }

        }
        private static void ChangePizza()
        {

        }
        private static void DeletePizza()
        {
            
        }
        //private static void Input()
        //{
        //    if ()
        //    {
        //        return Input;
        //    }
        }
    }

    
