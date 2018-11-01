using CookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Russian
{
    [Ingridient]
    public class Garlic : Ingridient
    {
        public override string Name => "Чеснок";

        public override double KKal => 5;
    }
}
