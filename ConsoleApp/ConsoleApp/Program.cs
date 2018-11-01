using AttributeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var assembly = 
                Assembly.LoadFile(
                    @"D:\удгу\ConsoleApp\ClassLibrary\bin\Debug\ClassLibrary.dll");           
            var userType = assembly.GetType("ClassLibrary.UserGroup");
            /*var userGroup = Activator.CreateInstance(userType);
            var property = userType.GetProperty("Name");
            if (property != null)
            {
                property.SetValue(userGroup, "Группа 1");
            }
            Console.WriteLine(property.GetValue(userGroup));*/
            foreach (var type in assembly.GetTypes())
            {
                var myAttr = type.GetCustomAttribute<MyAttribute>();
                if (myAttr != null)
                {
                    Console.WriteLine(type.Name);
                }
            }

            /*var userGroup = new UserGroup { Name = "Group1" };
            Console.WriteLine(userGroup.Name);*/
            /*var list = new List<User>();

            var userManager = new UserManager();
            var carManager = new SuperCarManager();
            
            long a;
            //UserHelper.SetParam(ref a);
            UserHelper.GetParam(out a);
            Console.WriteLine(a);*/
            /*var user = new User
            {
                FIO = "Иванов Иван Иванович"
            };
            var userStruct = new UserStruct
            {
                FIO = "Петров Петр Петрович"
            };

            var user2 = user;
            var userStruct2 = userStruct;

            user.FIO = "Иванов Иван Иванович 2";
            userStruct.FIO = "Петров Петр Петрович 2";

            Console.WriteLine($"user: {user.FIO}");
            Console.WriteLine($"user2: {user2.FIO}");

            Console.WriteLine($"userStruct: {userStruct.FIO}");
            Console.WriteLine($"userStruct2: {userStruct2.FIO}");
            */
            /*
            //if
            if (args.Length > 0)
            {
                Console.WriteLine("true");
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("false");
            }
            else
            {

            }

            //switch
            switch (args.Length)
            {
                case 0:
                    Console.WriteLine(0);
                    break;
                case 1:
                    Console.WriteLine(1);
                    break;
                default:
                    Console.WriteLine("else");
                    break;
            }

            //for
            for (var i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[0]);
            }

            //foreach
            foreach (var val in args)
            {
                Console.WriteLine(val);
            }

            //while
            var i = 0;
            while (i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }

            //do
            do
            {
                
            }
            while ()

            //тернарные операции
            var res = args.Length > 0 ? true : false;

            if (args != null)
            {
                var l = args.Length;
            }

            var r = args?.Length;

            if (args != null)
            {
                var l = args[0];
            }

            var r2 = args?[0];

            //строки
            var s = "строка";
            var cs = s + "777";

            var stringBuilder = new StringBuilder();
            stringBuilder.Append("yyyyy");
            Console.WriteLine(stringBuilder.ToString());

            Console.WriteLine(
                string.Format(
                  "Массив длинной: {0}. Тип коллекции: {1}",
                  args.Length,
                  args.GetType()));

            var d = $"Массив длинной: {args.Length}. Тип коллекции: {args.GetType()}";

            s = s.Remove(0, 2);*/
            /*var super = new SuperCar { Model = "fffff" };
            Console.WriteLine(super.GetName2());

            var user = new User();
            user.GetFIO();*/

            /*var car = new Car();
            car.Price = 12;
            car.Model = "Лада";

            var car2 = new Car
            {
                Model = "Москвич",
                Price = 13,
                Creator = new User
                {
                    FIO = "Иванов Иван Иванович"
                }
            };

            var car3 = new Car("Нива", 67);*/

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            //Console.WriteLine("Hello World!");
            Console.ReadKey();

        }
    }
}
