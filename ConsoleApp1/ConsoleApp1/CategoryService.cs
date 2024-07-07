using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public static class CategoryService
    {
        public static List<Categories> categoryList = new List<Categories>();  
        public static void CategoryList()
        {
            Categories horror = new Categories();
            horror.Id = 1;
            horror.Name = "Korku";

            Categories comedy = new Categories();
            comedy.Id = 2;
            comedy.Name = "Komedi";

            categoryList.Add(horror);
            categoryList.Add(comedy);

        }
        public static void AddCategory()
        {
            var newItem = new Categories();
            
            bool isValidName = true;
            while (isValidName==true)
            {
                Console.WriteLine("isim giriniz");
                newItem.Name = Console.ReadLine();

                if (int.TryParse(newItem.Name, out _))
                {
                    Console.WriteLine("Hata: İsim olarak string bir değer giriniz.");                   
                }
                else
                {
                    newItem.Name = newItem.Name;                   
                    isValidName = false;
                }
            }

            bool isValidId = true;

            while (isValidId == true)
            {
                Console.WriteLine("Id giriniz:");
                if (int.TryParse(Console.ReadLine(), out int inputId))
                {
                    if (categoryList.FirstOrDefault(x => x.Id == inputId) != null)
                    {
                        Console.WriteLine("Eklemek istediğiniz Id mevcut! Lütfen başka bir Id giriniz.");
                    }
                    else
                    {
                        newItem.Id = inputId;                       
                        isValidId = false;
                    }                   
                }
                else
                {
                    Console.WriteLine("Hata: Lütfen geçerli bir tamsayı değeri girin.");
                }
            }
            categoryList.Add(newItem);
        }
        public static void  DisplayCategories()
        {
            foreach (var item in categoryList)
            {
                Console.Write(item.Id+"");
                Console.WriteLine(item.Name);
            }
        }
    }
}
