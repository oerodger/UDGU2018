using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Japan
{
    [Recipe]
    public class Sushi : Recipe
    {
        public override string Name => "Суши с лососем";       

        public override string Text => "Как мы делаем суши";

        public override List<Ingridient> Ingridients => 
            new List<Ingridient> { new Rise(), new Salmon() };
    }
}
