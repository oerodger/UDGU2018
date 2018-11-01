using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.Models
{
    public abstract class Recipe
    {
        public abstract string Name { get; }

        public abstract List<Ingridient> Ingridients { get; }

        public abstract string Text { get; }

        public override string ToString()
        {
            return !string.IsNullOrEmpty(Name) ? Name : base.ToString();
        }
    }
}
