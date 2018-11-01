using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Japan
{
    [Ingridient]
    public class Salmon : Ingridient
    {
        public override string Name => "Лосось";

        public override double KKal => 100;
    }
}
