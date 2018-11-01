using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Russian
{
    [Recipe]
    public class Holod : Recipe
    {
        public override string Name => "Холодец";

        public override List<Ingridient> Ingridients 
            => new List<Ingridient> { new Meat() };

        public override string Text => "Как делается холодец";
    }
}
