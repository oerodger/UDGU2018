using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var repository = new MainRepository();
            repository.Init();

            Console.WriteLine("Ингиридиенты:");
            foreach (var ining in repository.FindAllIngridients())
            {
                Console.WriteLine($"{ining.Name}({ining.KKal})");
            }

            Console.WriteLine("");

            Console.WriteLine("Рецепты:");
            foreach (var recipe in repository.FindAllRecipes())
            {
                Console.WriteLine($"{recipe.Name}({string.Join(", ", recipe.Ingridients)})");
            }

            Console.ReadKey();
        }
    }
}
