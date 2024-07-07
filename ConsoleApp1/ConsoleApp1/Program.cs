using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CategoryService.CategoryList();

            while (true)
            {
                Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
                Console.WriteLine("1) Yeni kategori ekle");
                Console.WriteLine("2) Kategori listesini göster");

                string secim1 = Console.ReadLine();
                try
                {
                    int secim2 = int.Parse(secim1);

                    switch (secim2)
                    {
                        case 1:
                            CategoryService.AddCategory();
                            break;
                        case 2:
                            CategoryService.DisplayCategories();
                            break;
                        default:
                            Console.WriteLine("Geçersiz seçenek! Lütfen tekrar deneyin.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Hata: Lütfen geçerli bir tam sayı değeri girin.");
                }
            }
        }
    }
}
