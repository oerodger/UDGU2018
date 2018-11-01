using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class SuperCar: Car
    {
        public static string Constats = "777777777";

        public SuperCar()
        { }

        public SuperCar(string model, double price, string property1)
            :base(model, price)
        {
            Property1 = property1;
        }

        public string Property1 { get; set; }

        public override string GetName()
        {
            return Property1;
        }

        /*public override string GetName2()
        {
            return "Super Car!!!!";
        }*/
    }
}
