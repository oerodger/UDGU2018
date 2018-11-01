using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Russian
{
    [Ingridient]
    public class Meat : Ingridient
    {
        public override string Name => "Мясо";

        public override double KKal => 200;
    }
}
